/*
               File: ZBR_DeleteProcedureRadio
        Description: 删除诊疗处理下的放疗信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:19.27
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
   public class zbr_deleteprocedureradio : GXProcedure
   {
      public zbr_deleteprocedureradio( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deleteprocedureradio( IGxContext context )
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
         zbr_deleteprocedureradio objzbr_deleteprocedureradio;
         objzbr_deleteprocedureradio = new zbr_deleteprocedureradio();
         objzbr_deleteprocedureradio.context.SetSubmitInitialConfig(context);
         objzbr_deleteprocedureradio.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deleteprocedureradio);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deleteprocedureradio)stateInfo).executePrivate();
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
         /* Using cursor P003I2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A323BR_Procedure_RadioID = P003I2_A323BR_Procedure_RadioID[0];
            /* Using cursor P003I3 */
            pr_default.execute(1, new Object[] {A323BR_Procedure_RadioID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deleteprocedureradio",pr_default);
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
         P003I2_A323BR_Procedure_RadioID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deleteprocedureradio__default(),
            new Object[][] {
                new Object[] {
               P003I2_A323BR_Procedure_RadioID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long A323BR_Procedure_RadioID ;
      private String scmdbuf ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P003I2_A323BR_Procedure_RadioID ;
   }

   public class zbr_deleteprocedureradio__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP003I2 ;
          prmP003I2 = new Object[] {
          } ;
          Object[] prmP003I3 ;
          prmP003I3 = new Object[] {
          new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003I2", "SELECT [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (UPDLOCK) ORDER BY [BR_Procedure_RadioID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003I2,100,0,true,false )
             ,new CursorDef("P003I3", "DELETE FROM [BR_Procedure_Radio]  WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP003I3)
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
