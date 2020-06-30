/*
               File: ZBR_DeleteProcedureSurgery
        Description: 删除诊疗处理下的手术信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.61
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
   public class zbr_deleteproceduresurgery : GXProcedure
   {
      public zbr_deleteproceduresurgery( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deleteproceduresurgery( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         zbr_deleteproceduresurgery objzbr_deleteproceduresurgery;
         objzbr_deleteproceduresurgery = new zbr_deleteproceduresurgery();
         objzbr_deleteproceduresurgery.context.SetSubmitInitialConfig(context);
         objzbr_deleteproceduresurgery.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deleteproceduresurgery);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deleteproceduresurgery)stateInfo).executePrivate();
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
         /* Using cursor P003J2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A320BR_Procedure_SurgeryID = P003J2_A320BR_Procedure_SurgeryID[0];
            /* Using cursor P003J3 */
            pr_default.execute(1, new Object[] {A320BR_Procedure_SurgeryID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deleteproceduresurgery",pr_default);
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
         P003J2_A320BR_Procedure_SurgeryID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deleteproceduresurgery__default(),
            new Object[][] {
                new Object[] {
               P003J2_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long A320BR_Procedure_SurgeryID ;
      private String scmdbuf ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P003J2_A320BR_Procedure_SurgeryID ;
   }

   public class zbr_deleteproceduresurgery__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP003J2 ;
          prmP003J2 = new Object[] {
          } ;
          Object[] prmP003J3 ;
          prmP003J3 = new Object[] {
          new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003J2", "SELECT [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (UPDLOCK) ORDER BY [BR_Procedure_SurgeryID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003J2,100,0,true,false )
             ,new CursorDef("P003J3", "DELETE FROM [BR_Procedure_Surgery]  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP003J3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
