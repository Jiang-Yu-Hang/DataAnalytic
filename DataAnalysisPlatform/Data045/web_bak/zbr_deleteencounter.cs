/*
               File: ZBR_DeleteEncounter
        Description: 删除就诊信息所有相关信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:31.50
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
   public class zbr_deleteencounter : GXProcedure
   {
      public zbr_deleteencounter( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_deleteencounter( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iBR_EncounterID )
      {
         this.AV8iBR_EncounterID = aP0_iBR_EncounterID;
         initialize();
         executePrivate();
      }

      public void executeSubmit( long aP0_iBR_EncounterID )
      {
         zbr_deleteencounter objzbr_deleteencounter;
         objzbr_deleteencounter = new zbr_deleteencounter();
         objzbr_deleteencounter.AV8iBR_EncounterID = aP0_iBR_EncounterID;
         objzbr_deleteencounter.context.SetSubmitInitialConfig(context);
         objzbr_deleteencounter.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_deleteencounter);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_deleteencounter)stateInfo).executePrivate();
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
         /* Using cursor P002B2 */
         pr_default.execute(0, new Object[] {AV8iBR_EncounterID});
         pr_default.close(0);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
         /* End optimized DELETE. */
         /* Using cursor P002B3 */
         pr_default.execute(1, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A327BR_SchemeID = P002B3_A327BR_SchemeID[0];
            n327BR_SchemeID = P002B3_n327BR_SchemeID[0];
            A19BR_EncounterID = P002B3_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B3_n19BR_EncounterID[0];
            A332BR_Scheme_MedicationID = P002B3_A332BR_Scheme_MedicationID[0];
            A19BR_EncounterID = P002B3_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B3_n19BR_EncounterID[0];
            /* Using cursor P002B4 */
            pr_default.execute(2, new Object[] {A332BR_Scheme_MedicationID});
            pr_default.close(2);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme_Medication") ;
            pr_default.readNext(1);
         }
         pr_default.close(1);
         /* Optimized DELETE. */
         /* Using cursor P002B5 */
         pr_default.execute(3, new Object[] {AV8iBR_EncounterID});
         pr_default.close(3);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
         /* End optimized DELETE. */
         /* Using cursor P002B6 */
         pr_default.execute(4, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A139BR_ProcedureID = P002B6_A139BR_ProcedureID[0];
            A19BR_EncounterID = P002B6_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B6_n19BR_EncounterID[0];
            A323BR_Procedure_RadioID = P002B6_A323BR_Procedure_RadioID[0];
            A19BR_EncounterID = P002B6_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B6_n19BR_EncounterID[0];
            /* Using cursor P002B7 */
            pr_default.execute(5, new Object[] {A323BR_Procedure_RadioID});
            pr_default.close(5);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Radio") ;
            pr_default.readNext(4);
         }
         pr_default.close(4);
         /* Using cursor P002B8 */
         pr_default.execute(6, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(6) != 101) )
         {
            A139BR_ProcedureID = P002B8_A139BR_ProcedureID[0];
            A19BR_EncounterID = P002B8_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B8_n19BR_EncounterID[0];
            A320BR_Procedure_SurgeryID = P002B8_A320BR_Procedure_SurgeryID[0];
            A19BR_EncounterID = P002B8_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B8_n19BR_EncounterID[0];
            /* Using cursor P002B9 */
            pr_default.execute(7, new Object[] {A320BR_Procedure_SurgeryID});
            pr_default.close(7);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
            pr_default.readNext(6);
         }
         pr_default.close(6);
         /* Optimized DELETE. */
         /* Using cursor P002B10 */
         pr_default.execute(8, new Object[] {AV8iBR_EncounterID});
         pr_default.close(8);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Comorbidity") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B11 */
         pr_default.execute(9, new Object[] {AV8iBR_EncounterID});
         pr_default.close(9);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B12 */
         pr_default.execute(10, new Object[] {AV8iBR_EncounterID});
         pr_default.close(10);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B13 */
         pr_default.execute(11, new Object[] {AV8iBR_EncounterID});
         pr_default.close(11);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Diagnosis") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B14 */
         pr_default.execute(12, new Object[] {AV8iBR_EncounterID});
         pr_default.close(12);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
         /* End optimized DELETE. */
         /* Using cursor P002B15 */
         pr_default.execute(13, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(13) != 101) )
         {
            A119BR_MedicationID = P002B15_A119BR_MedicationID[0];
            n119BR_MedicationID = P002B15_n119BR_MedicationID[0];
            A19BR_EncounterID = P002B15_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B15_n19BR_EncounterID[0];
            /* Using cursor P002B16 */
            pr_default.execute(14, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            while ( (pr_default.getStatus(14) != 101) )
            {
               A296BR_Medication_SchemeID = P002B16_A296BR_Medication_SchemeID[0];
               new zbr_deletemedication_scheme(context ).execute(  A296BR_Medication_SchemeID) ;
               pr_default.readNext(14);
            }
            pr_default.close(14);
            /* Using cursor P002B17 */
            pr_default.execute(15, new Object[] {n119BR_MedicationID, A119BR_MedicationID});
            pr_default.close(15);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Medication") ;
            pr_default.readNext(13);
         }
         pr_default.close(13);
         /* Optimized DELETE. */
         /* Using cursor P002B18 */
         pr_default.execute(16, new Object[] {AV8iBR_EncounterID});
         pr_default.close(16);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
         /* End optimized DELETE. */
         /* Optimized DELETE. */
         /* Using cursor P002B19 */
         pr_default.execute(17, new Object[] {AV8iBR_EncounterID});
         pr_default.close(17);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
         /* End optimized DELETE. */
         /* Using cursor P002B20 */
         pr_default.execute(18, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(18) != 101) )
         {
            A225BR_MedicalImagingID = P002B20_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = P002B20_n225BR_MedicalImagingID[0];
            A19BR_EncounterID = P002B20_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B20_n19BR_EncounterID[0];
            /* Optimized DELETE. */
            /* Using cursor P002B21 */
            pr_default.execute(19, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            pr_default.close(19);
            dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging_Diag") ;
            /* End optimized DELETE. */
            /* Using cursor P002B22 */
            pr_default.execute(20, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            pr_default.close(20);
            dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
            pr_default.readNext(18);
         }
         pr_default.close(18);
         /* Using cursor P002B23 */
         pr_default.execute(21, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(21) != 101) )
         {
            A226BR_PathologyID = P002B23_A226BR_PathologyID[0];
            n226BR_PathologyID = P002B23_n226BR_PathologyID[0];
            A19BR_EncounterID = P002B23_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B23_n19BR_EncounterID[0];
            /* Optimized DELETE. */
            /* Using cursor P002B24 */
            pr_default.execute(22, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(22);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Specimen") ;
            /* End optimized DELETE. */
            /* Optimized DELETE. */
            /* Using cursor P002B25 */
            pr_default.execute(23, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(23);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Diag") ;
            /* End optimized DELETE. */
            /* Optimized DELETE. */
            /* Using cursor P002B26 */
            pr_default.execute(24, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(24);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
            /* End optimized DELETE. */
            /* Using cursor P002B27 */
            pr_default.execute(25, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            pr_default.close(25);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
            pr_default.readNext(21);
         }
         pr_default.close(21);
         /* Optimized DELETE. */
         /* Using cursor P002B28 */
         pr_default.execute(26, new Object[] {AV8iBR_EncounterID});
         pr_default.close(26);
         dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter_RefuseReason") ;
         /* End optimized DELETE. */
         /* Using cursor P002B29 */
         pr_default.execute(27, new Object[] {AV8iBR_EncounterID});
         while ( (pr_default.getStatus(27) != 101) )
         {
            A19BR_EncounterID = P002B29_A19BR_EncounterID[0];
            n19BR_EncounterID = P002B29_n19BR_EncounterID[0];
            /* Using cursor P002B30 */
            pr_default.execute(28, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            pr_default.close(28);
            dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
            new zutil_recordlog(context ).execute(  StringUtil.Str( (decimal)(AV8iBR_EncounterID), 18, 0),  "就诊信息",  "Delete",  1) ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(27);
         this.cleanup();
      }

      public override void cleanup( )
      {
         context.CommitDataStores("zbr_deleteencounter",pr_default);
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
         P002B3_A327BR_SchemeID = new long[1] ;
         P002B3_n327BR_SchemeID = new bool[] {false} ;
         P002B3_A19BR_EncounterID = new long[1] ;
         P002B3_n19BR_EncounterID = new bool[] {false} ;
         P002B3_A332BR_Scheme_MedicationID = new long[1] ;
         P002B6_A139BR_ProcedureID = new long[1] ;
         P002B6_A19BR_EncounterID = new long[1] ;
         P002B6_n19BR_EncounterID = new bool[] {false} ;
         P002B6_A323BR_Procedure_RadioID = new long[1] ;
         P002B8_A139BR_ProcedureID = new long[1] ;
         P002B8_A19BR_EncounterID = new long[1] ;
         P002B8_n19BR_EncounterID = new bool[] {false} ;
         P002B8_A320BR_Procedure_SurgeryID = new long[1] ;
         P002B15_A119BR_MedicationID = new long[1] ;
         P002B15_n119BR_MedicationID = new bool[] {false} ;
         P002B15_A19BR_EncounterID = new long[1] ;
         P002B15_n19BR_EncounterID = new bool[] {false} ;
         P002B16_A119BR_MedicationID = new long[1] ;
         P002B16_n119BR_MedicationID = new bool[] {false} ;
         P002B16_A296BR_Medication_SchemeID = new long[1] ;
         P002B20_A225BR_MedicalImagingID = new long[1] ;
         P002B20_n225BR_MedicalImagingID = new bool[] {false} ;
         P002B20_A19BR_EncounterID = new long[1] ;
         P002B20_n19BR_EncounterID = new bool[] {false} ;
         P002B23_A226BR_PathologyID = new long[1] ;
         P002B23_n226BR_PathologyID = new bool[] {false} ;
         P002B23_A19BR_EncounterID = new long[1] ;
         P002B23_n19BR_EncounterID = new bool[] {false} ;
         P002B29_A19BR_EncounterID = new long[1] ;
         P002B29_n19BR_EncounterID = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_deleteencounter__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P002B3_A327BR_SchemeID, P002B3_n327BR_SchemeID, P002B3_A19BR_EncounterID, P002B3_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P002B6_A139BR_ProcedureID, P002B6_A19BR_EncounterID, P002B6_n19BR_EncounterID, P002B6_A323BR_Procedure_RadioID
               }
               , new Object[] {
               }
               , new Object[] {
               P002B8_A139BR_ProcedureID, P002B8_A19BR_EncounterID, P002B8_n19BR_EncounterID, P002B8_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P002B15_A119BR_MedicationID, P002B15_A19BR_EncounterID
               }
               , new Object[] {
               P002B16_A119BR_MedicationID, P002B16_n119BR_MedicationID, P002B16_A296BR_Medication_SchemeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P002B20_A225BR_MedicalImagingID, P002B20_A19BR_EncounterID, P002B20_n19BR_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P002B23_A226BR_PathologyID, P002B23_A19BR_EncounterID, P002B23_n19BR_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               P002B29_A19BR_EncounterID
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8iBR_EncounterID ;
      private long A327BR_SchemeID ;
      private long A19BR_EncounterID ;
      private long A332BR_Scheme_MedicationID ;
      private long A139BR_ProcedureID ;
      private long A323BR_Procedure_RadioID ;
      private long A320BR_Procedure_SurgeryID ;
      private long A119BR_MedicationID ;
      private long A296BR_Medication_SchemeID ;
      private long A225BR_MedicalImagingID ;
      private long A226BR_PathologyID ;
      private String scmdbuf ;
      private bool n327BR_SchemeID ;
      private bool n19BR_EncounterID ;
      private bool n119BR_MedicationID ;
      private bool n225BR_MedicalImagingID ;
      private bool n226BR_PathologyID ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002B3_A327BR_SchemeID ;
      private bool[] P002B3_n327BR_SchemeID ;
      private long[] P002B3_A19BR_EncounterID ;
      private bool[] P002B3_n19BR_EncounterID ;
      private long[] P002B3_A332BR_Scheme_MedicationID ;
      private long[] P002B6_A139BR_ProcedureID ;
      private long[] P002B6_A19BR_EncounterID ;
      private bool[] P002B6_n19BR_EncounterID ;
      private long[] P002B6_A323BR_Procedure_RadioID ;
      private long[] P002B8_A139BR_ProcedureID ;
      private long[] P002B8_A19BR_EncounterID ;
      private bool[] P002B8_n19BR_EncounterID ;
      private long[] P002B8_A320BR_Procedure_SurgeryID ;
      private long[] P002B15_A119BR_MedicationID ;
      private bool[] P002B15_n119BR_MedicationID ;
      private long[] P002B15_A19BR_EncounterID ;
      private bool[] P002B15_n19BR_EncounterID ;
      private long[] P002B16_A119BR_MedicationID ;
      private bool[] P002B16_n119BR_MedicationID ;
      private long[] P002B16_A296BR_Medication_SchemeID ;
      private long[] P002B20_A225BR_MedicalImagingID ;
      private bool[] P002B20_n225BR_MedicalImagingID ;
      private long[] P002B20_A19BR_EncounterID ;
      private bool[] P002B20_n19BR_EncounterID ;
      private long[] P002B23_A226BR_PathologyID ;
      private bool[] P002B23_n226BR_PathologyID ;
      private long[] P002B23_A19BR_EncounterID ;
      private bool[] P002B23_n19BR_EncounterID ;
      private long[] P002B29_A19BR_EncounterID ;
      private bool[] P002B29_n19BR_EncounterID ;
   }

   public class zbr_deleteencounter__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new UpdateCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new UpdateCursor(def[25])
         ,new UpdateCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new UpdateCursor(def[28])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002B2 ;
          prmP002B2 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B3 ;
          prmP002B3 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B4 ;
          prmP002B4 = new Object[] {
          new Object[] {"@BR_Scheme_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B5 ;
          prmP002B5 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B6 ;
          prmP002B6 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B7 ;
          prmP002B7 = new Object[] {
          new Object[] {"@BR_Procedure_RadioID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B8 ;
          prmP002B8 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B9 ;
          prmP002B9 = new Object[] {
          new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B10 ;
          prmP002B10 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B11 ;
          prmP002B11 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B12 ;
          prmP002B12 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B13 ;
          prmP002B13 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B14 ;
          prmP002B14 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B15 ;
          prmP002B15 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B16 ;
          prmP002B16 = new Object[] {
          new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B17 ;
          prmP002B17 = new Object[] {
          new Object[] {"@BR_MedicationID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B18 ;
          prmP002B18 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B19 ;
          prmP002B19 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B20 ;
          prmP002B20 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B21 ;
          prmP002B21 = new Object[] {
          new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B22 ;
          prmP002B22 = new Object[] {
          new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B23 ;
          prmP002B23 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B24 ;
          prmP002B24 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B25 ;
          prmP002B25 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B26 ;
          prmP002B26 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B27 ;
          prmP002B27 = new Object[] {
          new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B28 ;
          prmP002B28 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B29 ;
          prmP002B29 = new Object[] {
          new Object[] {"@AV8iBR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002B30 ;
          prmP002B30 = new Object[] {
          new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002B2", "DELETE FROM [BR_Behavior]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B2)
             ,new CursorDef("P002B3", "SELECT T1.[BR_SchemeID], T2.[BR_EncounterID], T1.[BR_Scheme_MedicationID] FROM ([BR_Scheme_Medication] T1 WITH (UPDLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID]) WHERE T2.[BR_EncounterID] = @AV8iBR_EncounterID ORDER BY T1.[BR_Scheme_MedicationID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B3,1,0,true,false )
             ,new CursorDef("P002B4", "DELETE FROM [BR_Scheme_Medication]  WHERE [BR_Scheme_MedicationID] = @BR_Scheme_MedicationID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B4)
             ,new CursorDef("P002B5", "DELETE FROM [BR_Scheme]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B5)
             ,new CursorDef("P002B6", "SELECT T1.[BR_ProcedureID], T2.[BR_EncounterID], T1.[BR_Procedure_RadioID] FROM ([BR_Procedure_Radio] T1 WITH (UPDLOCK) INNER JOIN [BR_Procedure] T2 WITH (NOLOCK) ON T2.[BR_ProcedureID] = T1.[BR_ProcedureID]) WHERE T2.[BR_EncounterID] = @AV8iBR_EncounterID ORDER BY T1.[BR_Procedure_RadioID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B6,1,0,true,false )
             ,new CursorDef("P002B7", "DELETE FROM [BR_Procedure_Radio]  WHERE [BR_Procedure_RadioID] = @BR_Procedure_RadioID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B7)
             ,new CursorDef("P002B8", "SELECT T1.[BR_ProcedureID], T2.[BR_EncounterID], T1.[BR_Procedure_SurgeryID] FROM ([BR_Procedure_Surgery] T1 WITH (UPDLOCK) INNER JOIN [BR_Procedure] T2 WITH (NOLOCK) ON T2.[BR_ProcedureID] = T1.[BR_ProcedureID]) WHERE T2.[BR_EncounterID] = @AV8iBR_EncounterID ORDER BY T1.[BR_Procedure_SurgeryID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B8,1,0,true,false )
             ,new CursorDef("P002B9", "DELETE FROM [BR_Procedure_Surgery]  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B9)
             ,new CursorDef("P002B10", "DELETE FROM [BR_Comorbidity]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B10)
             ,new CursorDef("P002B11", "DELETE FROM [BR_Death]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B11)
             ,new CursorDef("P002B12", "DELETE FROM [BR_Demographics]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B12)
             ,new CursorDef("P002B13", "DELETE FROM [BR_Diagnosis]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B13)
             ,new CursorDef("P002B14", "DELETE FROM [BR_Lab]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B14)
             ,new CursorDef("P002B15", "SELECT [BR_MedicationID], [BR_EncounterID] FROM [BR_Medication] WITH (UPDLOCK) WHERE [BR_EncounterID] = @AV8iBR_EncounterID ORDER BY [BR_EncounterID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B15,1,0,true,false )
             ,new CursorDef("P002B16", "SELECT [BR_MedicationID], [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_MedicationID] = @BR_MedicationID ORDER BY [BR_MedicationID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B16,100,0,true,false )
             ,new CursorDef("P002B17", "DELETE FROM [BR_Medication]  WHERE [BR_MedicationID] = @BR_MedicationID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B17)
             ,new CursorDef("P002B18", "DELETE FROM [BR_Procedure]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B18)
             ,new CursorDef("P002B19", "DELETE FROM [BR_Vital]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B19)
             ,new CursorDef("P002B20", "SELECT [BR_MedicalImagingID], [BR_EncounterID] FROM [BR_MedicalImaging] WITH (UPDLOCK) WHERE [BR_EncounterID] = @AV8iBR_EncounterID ORDER BY [BR_EncounterID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B20,1,0,true,false )
             ,new CursorDef("P002B21", "DELETE FROM [BR_MedicalImaging_Diag]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B21)
             ,new CursorDef("P002B22", "DELETE FROM [BR_MedicalImaging]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B22)
             ,new CursorDef("P002B23", "SELECT [BR_PathologyID], [BR_EncounterID] FROM [BR_Pathology] WITH (UPDLOCK) WHERE [BR_EncounterID] = @AV8iBR_EncounterID ORDER BY [BR_EncounterID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B23,1,0,true,false )
             ,new CursorDef("P002B24", "DELETE FROM [BR_Pathology_Specimen]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B24)
             ,new CursorDef("P002B25", "DELETE FROM [BR_Pathology_Diag]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B25)
             ,new CursorDef("P002B26", "DELETE FROM [BR_Pathology_Other]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B26)
             ,new CursorDef("P002B27", "DELETE FROM [BR_Pathology]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B27)
             ,new CursorDef("P002B28", "DELETE FROM [BR_Encounter_RefuseReason]  WHERE [BR_EncounterID] = @AV8iBR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B28)
             ,new CursorDef("P002B29", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (UPDLOCK) WHERE [BR_EncounterID] = @AV8iBR_EncounterID ORDER BY [BR_EncounterID] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002B29,1,0,true,true )
             ,new CursorDef("P002B30", "DELETE FROM [BR_Encounter]  WHERE [BR_EncounterID] = @BR_EncounterID", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002B30)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                return;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((long[]) buf[3])[0] = rslt.getLong(3) ;
                return;
             case 13 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
             case 14 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                return;
             case 18 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 21 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                return;
             case 27 :
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 14 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 15 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 16 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 19 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 20 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 21 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 22 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 23 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 24 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 25 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.Decimal );
                }
                else
                {
                   stmt.SetParameter(1, (long)parms[1]);
                }
                return;
             case 26 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (long)parms[0]);
                return;
             case 28 :
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
