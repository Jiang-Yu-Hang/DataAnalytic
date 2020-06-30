/*
               File: ZSU_DeleteUserAllInfo
        Description: 删除该用户的所有相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:46.5
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zsu_deleteuserallinfo : GXProcedure
   {
      public zsu_deleteuserallinfo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zsu_deleteuserallinfo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_iSecUserId )
      {
         this.AV8iSecUserId = aP0_iSecUserId;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_iSecUserId )
      {
         zsu_deleteuserallinfo objzsu_deleteuserallinfo;
         objzsu_deleteuserallinfo = new zsu_deleteuserallinfo();
         objzsu_deleteuserallinfo.AV8iSecUserId = aP0_iSecUserId;
         objzsu_deleteuserallinfo.context.SetSubmitInitialConfig(context);
         objzsu_deleteuserallinfo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzsu_deleteuserallinfo);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zsu_deleteuserallinfo)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         if ( AV8iSecUserId == 1 )
         {
            GX_msglist.addItem("超级管理员不可删除");
         }
         else
         {
            /* Optimized DELETE. */
            /* Using cursor P00262 */
            pr_default.execute(0, new Object[] {AV8iSecUserId});
            pr_default.close(0);
            dsDefault.SmartCacheProvider.SetUpdated("JC_ProviderSecUser") ;
            /* End optimized DELETE. */
            /* Optimized DELETE. */
            /* Using cursor P00263 */
            pr_default.execute(1, new Object[] {AV8iSecUserId});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
            /* End optimized DELETE. */
            /* Using cursor P00264 */
            pr_default.execute(2, new Object[] {AV8iSecUserId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A6SecUserId = P00264_A6SecUserId[0];
               A14SecUserName = P00264_A14SecUserName[0];
               AV9tSecUserName = A14SecUserName;
               /* Using cursor P00265 */
               pr_default.execute(3, new Object[] {A6SecUserId});
               pr_default.close(3);
               dsDefault.SmartCacheProvider.SetUpdated("SecUser") ;
               new zutil_recordlog(context ).execute(  AV9tSecUserName,  "用户信息",  "Delete",  1) ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zsu_deleteuserallinfo",pr_default);
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00264_A6SecUserId = new short[1] ;
         P00264_A14SecUserName = new String[] {""} ;
         A14SecUserName = "";
         AV9tSecUserName = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zsu_deleteuserallinfo__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P00264_A6SecUserId, P00264_A14SecUserName
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8iSecUserId ;
      private short A6SecUserId ;
      private String scmdbuf ;
      private String A14SecUserName ;
      private String AV9tSecUserName ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00264_A6SecUserId ;
      private String[] P00264_A14SecUserName ;
   }

   public class zsu_deleteuserallinfo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00262 ;
          prmP00262 = new Object[] {
          new Object[] {"@AV8iSecUserId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00263 ;
          prmP00263 = new Object[] {
          new Object[] {"@AV8iSecUserId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00264 ;
          prmP00264 = new Object[] {
          new Object[] {"@AV8iSecUserId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00265 ;
          prmP00265 = new Object[] {
          new Object[] {"@SecUserId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00262", "DELETE FROM [JC_ProviderSecUser]  WHERE [SecUserId] = @AV8iSecUserId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00262)
             ,new CursorDef("P00263", "DELETE FROM [SecUserRole]  WHERE [SecUserId] = @AV8iSecUserId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00263)
             ,new CursorDef("P00264", "SELECT TOP 1 [SecUserId], [SecUserName] FROM [SecUser] WITH (UPDLOCK) WHERE [SecUserId] = @AV8iSecUserId ORDER BY [SecUserId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00264,1,0,true,true )
             ,new CursorDef("P00265", "DELETE FROM [SecUser]  WHERE [SecUserId] = @SecUserId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00265)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
