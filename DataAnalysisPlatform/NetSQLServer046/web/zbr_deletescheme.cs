/*
               File: ZBR_DeleteScheme
        Description: 删除化疗方案
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:13.97
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
   public class zbr_deletescheme : GXProcedure
   {
      public zbr_deletescheme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deletescheme( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_EncounterID ,
                           long aP1_iBR_SchemeID )
      {
         this.AV8iBR_EncounterID = aP0_iBR_EncounterID;
         this.AV9iBR_SchemeID = aP1_iBR_SchemeID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_EncounterID ,
                                 long aP1_iBR_SchemeID )
      {
         zbr_deletescheme objzbr_deletescheme;
         objzbr_deletescheme = new zbr_deletescheme();
         objzbr_deletescheme.AV8iBR_EncounterID = aP0_iBR_EncounterID;
         objzbr_deletescheme.AV9iBR_SchemeID = aP1_iBR_SchemeID;
         objzbr_deletescheme.context.SetSubmitInitialConfig(context);
         objzbr_deletescheme.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deletescheme);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deletescheme)stateInfo).executePrivate();
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
         /* Using cursor P00332 */
         pr_default.execute(0, new Object[] {AV9iBR_SchemeID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P00333 */
         pr_default.execute(1, new Object[] {AV9iBR_SchemeID});
         pr_default.close(1);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
         /* End optimized DELETE. */
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV8iBR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(AV9iBR_SchemeID), 18, 0)),  "化疗方案",  "Delete",  1) ;
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deletescheme",pr_default);
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deletescheme__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8iBR_EncounterID ;
      private long AV9iBR_SchemeID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
   }

   public class zbr_deletescheme__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00332 ;
          prmP00332 = new Object[] {
          new Object[] {"@AV9iBR_SchemeID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP00333 ;
          prmP00333 = new Object[] {
          new Object[] {"@AV9iBR_SchemeID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00332", "DELETE FROM [BR_Scheme_Medication]  WHERE [BR_SchemeID] = @AV9iBR_SchemeID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00332)
             ,new CursorDef("P00333", "DELETE FROM [BR_Scheme]  WHERE [BR_SchemeID] = @AV9iBR_SchemeID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00333)
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 1 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
