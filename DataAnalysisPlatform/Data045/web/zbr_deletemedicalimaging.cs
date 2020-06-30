/*
               File: ZBR_DeleteMedicalImaging
        Description: 删除影像学的所有信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:3.22
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
   public class zbr_deletemedicalimaging : GXProcedure
   {
      public zbr_deletemedicalimaging( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deletemedicalimaging( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_MedicalImagingID )
      {
         this.AV8iBR_MedicalImagingID = aP0_iBR_MedicalImagingID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_MedicalImagingID )
      {
         zbr_deletemedicalimaging objzbr_deletemedicalimaging;
         objzbr_deletemedicalimaging = new zbr_deletemedicalimaging();
         objzbr_deletemedicalimaging.AV8iBR_MedicalImagingID = aP0_iBR_MedicalImagingID;
         objzbr_deletemedicalimaging.context.SetSubmitInitialConfig(context);
         objzbr_deletemedicalimaging.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deletemedicalimaging);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deletemedicalimaging)stateInfo).executePrivate();
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
         /* Using cursor P002U2 */
         pr_default.execute(0, new Object[] {AV8iBR_MedicalImagingID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A225BR_MedicalImagingID = P002U2_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = P002U2_n225BR_MedicalImagingID[0];
            /* Optimized DELETE. */
            /* Using cursor P002U3 */
            pr_default.execute(1, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            pr_default.close(1);
            dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging_Diag") ;
            /* End optimized DELETE. */
            AV9tBR_MedicalImagingID = A225BR_MedicalImagingID;
            /* Using cursor P002U4 */
            pr_default.execute(2, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV9tBR_MedicalImagingID), 18, 0)),  "影像学",  "Delete",  1) ;
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deletemedicalimaging",pr_default);
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
         P002U2_A225BR_MedicalImagingID = new long[1] ;
         P002U2_n225BR_MedicalImagingID = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deletemedicalimaging__default(),
            new Object[][] {
                new Object[] {
               P002U2_A225BR_MedicalImagingID
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

      private long AV8iBR_MedicalImagingID ;
      private long A225BR_MedicalImagingID ;
      private long AV9tBR_MedicalImagingID ;
      private long A19BR_EncounterID ;
      private String scmdbuf ;
      private bool n225BR_MedicalImagingID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002U2_A225BR_MedicalImagingID ;
      private bool[] P002U2_n225BR_MedicalImagingID ;
   }

   public class zbr_deletemedicalimaging__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002U2 ;
          prmP002U2 = new Object[] {
          new Object[] {"@AV8iBR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002U3 ;
          prmP002U3 = new Object[] {
          new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002U4 ;
          prmP002U4 = new Object[] {
          new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002U2", "SELECT [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (UPDLOCK) WHERE [BR_MedicalImagingID] = @AV8iBR_MedicalImagingID ORDER BY [BR_MedicalImagingID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002U2,1,0,true,true )
             ,new CursorDef("P002U3", "DELETE FROM [BR_MedicalImaging_Diag]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002U3)
             ,new CursorDef("P002U4", "DELETE FROM [BR_MedicalImaging]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002U4)
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
             case 0 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 1 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
       }
    }

 }

}
