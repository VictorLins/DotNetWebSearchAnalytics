using DotNetWebSearchAnalyticsAPI.Core.Shared;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace DotNetWebSearchAnalyticsAPI.Core.Kernel
{
    public abstract class CoRepository : IdentityDbContext
    {
        #region [ Constructors ]

        public CoRepository(IdentityDbContext prIdentityDbContext)
        {
            IdentityDbContext = prIdentityDbContext;
        }

        #endregion

        #region [ Properties / Fields ]

        public IdentityDbContext IdentityDbContext;
        public CoMessageList CoMessageList = new CoMessageList();

        #endregion

        // Abstract Methods
        protected abstract void Add(CoEntity prCoEntity);
        protected abstract CoEntity Find(CoEntity prCoEntity);
        protected abstract void Remove(CoEntity prCoEntity);

        // Generic
        protected int GetId(CoEntity prCoEntity)
        {
            int lEntityId = 0;

            try
            {
                // TODO Add Audit Feature

                List<PropertyInfo> lProperyInfoList = prCoEntity.GetType().GetProperties().ToList();

                PropertyInfo lPropertyInfo = lProperyInfoList.Where(x => x.GetCustomAttribute(typeof(KeyAttribute), true) != null).Select(x => x).FirstOrDefault();

                lEntityId = lPropertyInfo != null ? Convert.ToInt32(lPropertyInfo.GetValue(prCoEntity, null)) : 0;
            }
            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return lEntityId;
        }

        // Insert
        protected virtual bool BeforeInsert(CoEntity prCoEntity)
        {
            try
            {
                // TODO Add Audit Feature
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        protected virtual bool Insert(CoEntity prCoEntity, bool prFlush = true)
        {
            try
            {
                // TODO Add Audit Feature

                if (BeforeInsert(prCoEntity))
                {
                    Add(prCoEntity);

                    if (prFlush)
                    {
                        if (Flush())
                            AfterInsert(prCoEntity);
                    }
                }
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        protected bool AfterInsert(CoEntity prCoEntity)
        {
            try
            {
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        // Update
        protected virtual bool BeforeUpdate(CoEntity prCoEntity)
        {
            try
            {
                // TODO Add Audit Feature
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        protected virtual bool Update(CoEntity prCoEntity, bool prFlush = true)
        {
            try
            {
                // TODO Add Audit Feature

                CoEntity lCoEntity = Find(prCoEntity);

                if (lCoEntity == null)
                    CoMessageList.AddCoMessage(CoMessage.CreateSystemError("Entity Not Found"));
                else
                {
                    if (CoMessageList.HasNotError())
                    {
                        if (BeforeUpdate(lCoEntity))
                        {
                            IdentityDbContext.Update(lCoEntity);

                            if (prFlush)
                            {
                                if (Flush())
                                    AfterUpdate(lCoEntity);
                            }
                        }
                    }
                }
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }


            return CoMessageList.HasNotError();
        }

        protected bool AfterUpdate(CoEntity prCoEntity)
        {
            try
            {
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        // Delete
        protected virtual bool BeforeDelete(CoEntity prCoEntity)
        {
            try
            {
                // TODO Add Audit Feature
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        protected virtual bool Delete(CoEntity prCoEntity, bool prFlush = true)
        {
            try
            {
                // TODO Add Audit Feature

                if (BeforeDelete(prCoEntity))
                {
                    IdentityDbContext.Remove(prCoEntity);

                    if (prFlush)
                    {
                        if (Flush())
                            AfterDelete(prCoEntity);
                    }
                }
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }


            return CoMessageList.HasNotError();
        }

        protected bool AfterDelete(CoEntity prCoEntity)
        {
            try
            {
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }

        // Generic
        private bool Flush()
        {
            try
            {
                IdentityDbContext.SaveChanges();
            }

            catch (Exception lException)
            {
                CoMessageList.AddCoMessage(CoMessage.CreateSystemError(lException.Message, lException.Source != null ? lException.Source : "", "", "Exception Not Handled"));
            }

            return CoMessageList.HasNotError();
        }
    }
}