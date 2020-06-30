/*
               File: ZSR_DeleteRoleAllInfo
        Description: 删除该角色的所有信息的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:22.40
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
   public class zsr_deleteroleallinfo : GXProcedure
   {
      public zsr_deleteroleallinfo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zsr_deleteroleallinfo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_iSecRoleId )
      {
         this.AV8iSecRoleId = aP0_iSecRoleId;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_iSecRoleId )
      {
         zsr_deleteroleallinfo objzsr_deleteroleallinfo;
         objzsr_deleteroleallinfo = new zsr_deleteroleallinfo();
         objzsr_deleteroleallinfo.AV8iSecRoleId = aP0_iSecRoleId;
         objzsr_deleteroleallinfo.context.SetSubmitInitialConfig(context);
         objzsr_deleteroleallinfo.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzsr_deleteroleallinfo);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zsr_deleteroleallinfo)stateInfo).executePrivate();
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
         /* Optimized DELETE. */
         /* Using cursor P00272 */
         pr_default.execute(0, new Object[] {AV8iSecRoleId});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("SecFunctionalityRole") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P00273 */
         pr_default.execute(1, new Object[] {AV8iSecRoleId});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("SecUserRole") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P00274 */
         pr_default.execute(2, new Object[] {AV8iSecRoleId});
         pr_default.close(2);
         dsDefault.SmartCacheProvider.SetUpdated("SecRole") ;
         /* End optimized DELETE. */
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zsr_deleteroleallinfo",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zsr_deleteroleallinfo__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV8iSecRoleId ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class zsr_deleteroleallinfo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00272 ;
          prmP00272 = new Object[] {
          new Object[] {"@AV8iSecRoleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00273 ;
          prmP00273 = new Object[] {
          new Object[] {"@AV8iSecRoleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP00274 ;
          prmP00274 = new Object[] {
          new Object[] {"@AV8iSecRoleId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00272", "DELETE FROM [SecFunctionalityRole]  WHERE [SecRoleId] = @AV8iSecRoleId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00272)
             ,new CursorDef("P00273", "DELETE FROM [SecUserRole]  WHERE [SecRoleId] = @AV8iSecRoleId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00273)
             ,new CursorDef("P00274", "DELETE FROM [SecRole]  WHERE [SecRoleId] = @AV8iSecRoleId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00274)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
       }
    }

 }

}
