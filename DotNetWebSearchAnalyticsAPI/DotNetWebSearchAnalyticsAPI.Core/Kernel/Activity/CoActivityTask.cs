using DotNetWebSearchAnalyticsAPI.Core.Shared;

namespace DotNetWebSearchAnalyticsAPI.Core.Kernel
{
    public abstract class CoActivityTask : CoClass
    {
        #region [ Constructors ]

        public CoActivityTask() { }

        #endregion

        protected virtual bool PreConditional()
        {
            return _CoMessageList.HasNotError();
        }

        protected virtual bool Semantic()
        {
            return _CoMessageList.HasNotError();
        }

        protected virtual void PosConditional() { }

        public virtual bool Action()
        {
            try
            {
                if (PreConditional())
                {
                    if (Semantic())
                        PosConditional();
                }
            }
            catch (CoBusinessException lException)
            {
                _CoMessageList.AddCoMessage(CoMessage.CreateBusinessError(lException.Message, lException.Source != null ? lException.Source : ""));
            }
            catch (CoSystemException lException)
            {
                _CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : ""));
            }
            catch (Exception lException)
            {
                _CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return _CoMessageList.HasNotError();
        }
    }
}