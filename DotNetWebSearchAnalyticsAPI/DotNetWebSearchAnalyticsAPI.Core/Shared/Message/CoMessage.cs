namespace DotNetWebSearchAnalyticsAPI.Core.Shared
{
    public class CoMessage
    {
        #region [ Constructors ]

        public CoMessage()
        {
            this.Occurrence = DateTime.Now;
            this.Scope = EnumScope.System;
        }

        public CoMessage(string prMessage, EnumType prType)
            : this()
        {
            this.Message = prMessage;
            this.Type = prType;
        }

        #endregion


        #region [ Properties / Fields ]

        public DateTime Occurrence = DateTime.Now;
        public EnumScope Scope = EnumScope.System;
        public CoMessage.EnumType Type;
        public string NameSpace = "";
        public string Source = "";
        public string Message = "";
        public string Detail = "";

        #endregion

        #region [ Enums / Constraints ]

        public enum EnumType
        {
            Information,
            Warning,
            Error
        }

        public enum EnumScope
        {
            System,
            Business
        }

        #endregion

        private static CoMessage CreateCoMessage(EnumScope prEnumScope, EnumType prEnumType, string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            CoMessage lCoMessage = new CoMessage();
            lCoMessage.Type = prEnumType;
            lCoMessage.Scope = prEnumScope;
            lCoMessage.Message = prMessage;
            lCoMessage.Source = prSource;
            lCoMessage.NameSpace = prNameSpace;
            lCoMessage.Detail = prDetail;
            return lCoMessage;
        }

        // Error
        public static CoMessage CreateSystemError(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.System, EnumType.Error, prMessage, prSource, prNameSpace, prDetail);
        }

        public static CoMessage CreateBusinessError(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.Business, EnumType.Error, prMessage, prSource, prNameSpace, prDetail);
        }

        // Information
        public static CoMessage CreateSystemInformation(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.System, EnumType.Information, prMessage, prSource, prNameSpace, prDetail);
        }

        public static CoMessage CreateBusinessInformation(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.Business, EnumType.Information, prMessage, prSource, prNameSpace, prDetail);
        }

        // Warning
        public static CoMessage CreateSystemWarning(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.System, EnumType.Warning, prMessage, prSource, prNameSpace, prDetail);
        }

        public static CoMessage CreateBusinessWarning(string prMessage = "", string prSource = "", string prNameSpace = "", string prDetail = "")
        {
            return CreateCoMessage(EnumScope.Business, EnumType.Warning, prMessage, prSource, prNameSpace, prDetail);
        }
    }
}