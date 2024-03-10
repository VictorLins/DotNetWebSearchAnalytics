namespace DotNetWebSearchAnalyticsAPI.Core.Shared
{
    internal class CoSystemException : Exception
    {
        #region [ Constructors ]

        public CoSystemException(string prMessage)
           : base(prMessage) { }

        #endregion


        public override string ToString()
        {
            return this.Message;
        }
    }
}