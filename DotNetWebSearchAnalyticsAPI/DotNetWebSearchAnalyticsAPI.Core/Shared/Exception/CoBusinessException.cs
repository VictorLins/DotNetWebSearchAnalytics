namespace DotNetWebSearchAnalyticsAPI.Core.Shared
{
    internal class CoBusinessException : Exception
    {
        #region [ Constructors ]

        public CoBusinessException(string prMessage)
           : base(prMessage) { }

        #endregion


        public override string ToString()
        {
            return this.Message;
        }
    }
}