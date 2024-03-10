using System.Text;

namespace DotNetWebSearchAnalyticsAPI.Core.Shared
{
    public class CoMessageList : List<CoMessage>
    {
        #region [ Constructors ]

        public CoMessageList() : base() { }

        #endregion

        public void AddCoMessage(CoMessage prCoMessage)
        {
            Add(prCoMessage);
        }

        // Generic
        public bool HasError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error).Any();
        }

        public bool HasWarning()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Warning).Any();
        }

        public bool HasErrorOrWarning()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error || x.Type == CoMessage.EnumType.Warning).Any();
        }

        public bool HasNotError()
        {
            return HasError() == false;
        }

        public bool HasNotErrorOrWarning()
        {
            return HasErrorOrWarning() == false;
        }

        public void ClearError()
        {
            this.RemoveAll(x => x.Type == CoMessage.EnumType.Error);
        }

        public void ClearWarning()
        {
            this.RemoveAll(x => x.Type == CoMessage.EnumType.Warning);
        }

        public void ClearInformation()
        {
            this.RemoveAll(x => x.Type == CoMessage.EnumType.Information);
        }

        public List<CoMessage> GetError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error).ToList();
        }

        public override string ToString()
        {
            StringBuilder lStringBuilder = new StringBuilder();

            if (this.Count == 0)
                return "";

            foreach (CoMessage lCoMessageCurrent in this.Where(x => x != null && !string.IsNullOrWhiteSpace(x.Message)))
            {
                lStringBuilder.AppendLine(lCoMessageCurrent.Message);
            }

            return lStringBuilder.ToString();
        }

        // System
        public bool HasSystemError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error && x.Scope == CoMessage.EnumScope.System).Any();
        }

        public List<CoMessage> GetSystemError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error && x.Scope == CoMessage.EnumScope.System).ToList();
        }

        public List<CoMessage> GetSystemWarning()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Warning && x.Scope == CoMessage.EnumScope.System).ToList();
        }

        // Business
        public bool HasBusinessError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error && x.Scope == CoMessage.EnumScope.Business).Any();
        }

        public List<CoMessage> GetBusinessError()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Error && x.Scope == CoMessage.EnumScope.Business).ToList();
        }

        public List<CoMessage> GetBusinessWarning()
        {
            return this.Where(x => x.Type == CoMessage.EnumType.Warning && x.Scope == CoMessage.EnumScope.Business).ToList();
        }
    }
}