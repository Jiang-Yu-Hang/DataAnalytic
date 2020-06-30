/*
               File: BR_ProcedureWWGetFilterData
        Description: BR_Procedure WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.6
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_procedurewwgetfilterdata : GXProcedure
   {
      public br_procedurewwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedurewwgetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV37DDOName = aP0_DDOName;
         this.AV35SearchTxt = aP1_SearchTxt;
         this.AV36SearchTxtTo = aP2_SearchTxtTo;
         this.AV41OptionsJson = "" ;
         this.AV44OptionsDescJson = "" ;
         this.AV46OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV41OptionsJson;
         aP4_OptionsDescJson=this.AV44OptionsDescJson;
         aP5_OptionIndexesJson=this.AV46OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV37DDOName = aP0_DDOName;
         this.AV35SearchTxt = aP1_SearchTxt;
         this.AV36SearchTxtTo = aP2_SearchTxtTo;
         this.AV41OptionsJson = "" ;
         this.AV44OptionsDescJson = "" ;
         this.AV46OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV41OptionsJson;
         aP4_OptionsDescJson=this.AV44OptionsDescJson;
         aP5_OptionIndexesJson=this.AV46OptionIndexesJson;
         return AV46OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_procedurewwgetfilterdata objbr_procedurewwgetfilterdata;
         objbr_procedurewwgetfilterdata = new br_procedurewwgetfilterdata();
         objbr_procedurewwgetfilterdata.AV37DDOName = aP0_DDOName;
         objbr_procedurewwgetfilterdata.AV35SearchTxt = aP1_SearchTxt;
         objbr_procedurewwgetfilterdata.AV36SearchTxtTo = aP2_SearchTxtTo;
         objbr_procedurewwgetfilterdata.AV41OptionsJson = "" ;
         objbr_procedurewwgetfilterdata.AV44OptionsDescJson = "" ;
         objbr_procedurewwgetfilterdata.AV46OptionIndexesJson = "" ;
         objbr_procedurewwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_procedurewwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_procedurewwgetfilterdata);
         aP3_OptionsJson=this.AV41OptionsJson;
         aP4_OptionsDescJson=this.AV44OptionsDescJson;
         aP5_OptionIndexesJson=this.AV46OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_procedurewwgetfilterdata)stateInfo).executePrivate();
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
         AV40Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV43OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV45OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV37DDOName), "DDO_BR_INFORMATION_PATIENTNO") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_INFORMATION_PATIENTNOOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV41OptionsJson = AV40Options.ToJSonString(false);
         AV44OptionsDescJson = AV43OptionsDesc.ToJSonString(false);
         AV46OptionIndexesJson = AV45OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV48Session.Get("BR_ProcedureWWGridState"), "") == 0 )
         {
            AV50GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_ProcedureWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV50GridState.FromXml(AV48Session.Get("BR_ProcedureWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV66GXV1 = 1;
         while ( AV66GXV1 <= AV50GridState.gxTpr_Filtervalues.Count )
         {
            AV51GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV50GridState.gxTpr_Filtervalues.Item(AV66GXV1));
            if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDUREID") == 0 )
            {
               AV53TFBR_ProcedureID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV54TFBR_ProcedureID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV11TFBR_EncounterID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_EncounterID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV13TFBR_Information_PatientNo = AV51GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV14TFBR_Information_PatientNo_Sel = AV51GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXID") == 0 )
            {
               AV15TFBR_Procedure_PXID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV16TFBR_Procedure_PXID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXSURGERY_SEL") == 0 )
            {
               AV17TFBR_Procedure_PXSurgery_SelsJson = AV51GridStateFilterValue.gxTpr_Value;
               AV18TFBR_Procedure_PXSurgery_Sels.FromJSonString(AV17TFBR_Procedure_PXSurgery_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_DATE") == 0 )
            {
               AV55TFBR_Procedure_Date = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Value, 0);
               AV56TFBR_Procedure_Date_To = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXRADIOTHERAPY_SEL") == 0 )
            {
               AV21TFBR_Procedure_PXRadiotherapy_SelsJson = AV51GridStateFilterValue.gxTpr_Value;
               AV22TFBR_Procedure_PXRadiotherapy_Sels.FromJSonString(AV21TFBR_Procedure_PXRadiotherapy_SelsJson, null);
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIODATE") == 0 )
            {
               AV59TFBR_Procedure_RadioDate = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Value, 0);
               AV60TFBR_Procedure_RadioDate_To = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIOTIME") == 0 )
            {
               AV61TFBR_Procedure_RadioTime = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV62TFBR_Procedure_RadioTime_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            AV66GXV1 = (int)(AV66GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV13TFBR_Information_PatientNo = AV35SearchTxt;
         AV14TFBR_Information_PatientNo_Sel = "";
         AV68BR_ProcedureWWDS_1_Tfbr_procedureid = AV53TFBR_ProcedureID;
         AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV54TFBR_ProcedureID_To;
         AV70BR_ProcedureWWDS_3_Tfbr_encounterid = AV11TFBR_EncounterID;
         AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV12TFBR_EncounterID_To;
         AV72BR_ProcedureWWDS_5_Tfbr_information_patientno = AV13TFBR_Information_PatientNo;
         AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV14TFBR_Information_PatientNo_Sel;
         AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV15TFBR_Procedure_PXID;
         AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV16TFBR_Procedure_PXID_To;
         AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV18TFBR_Procedure_PXSurgery_Sels;
         AV77BR_ProcedureWWDS_10_Tfbr_procedure_date = AV55TFBR_Procedure_Date;
         AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV56TFBR_Procedure_Date_To;
         AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV22TFBR_Procedure_PXRadiotherapy_Sels;
         AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV59TFBR_Procedure_RadioDate;
         AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV60TFBR_Procedure_RadioDate_To;
         AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV61TFBR_Procedure_RadioTime;
         AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV62TFBR_Procedure_RadioTime_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A141BR_Procedure_PXSurgery ,
                                              AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                              A143BR_Procedure_PXRadiotherapy ,
                                              AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                              AV68BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                              AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                              AV70BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                              AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                              AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                              AV72BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                              AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                              AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                              AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels.Count ,
                                              AV77BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                              AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                              AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels.Count ,
                                              AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                              AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                              AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                              AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                              A139BR_ProcedureID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A140BR_Procedure_PXID ,
                                              A266BR_Procedure_Date ,
                                              A268BR_Procedure_RadioDate ,
                                              A269BR_Procedure_RadioTime } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV72BR_ProcedureWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV72BR_ProcedureWWDS_5_Tfbr_information_patientno), "%", "");
         /* Using cursor P001W2 */
         pr_default.execute(0, new Object[] {AV68BR_ProcedureWWDS_1_Tfbr_procedureid, AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to, AV70BR_ProcedureWWDS_3_Tfbr_encounterid, AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to, lV72BR_ProcedureWWDS_5_Tfbr_information_patientno, AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel, AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid, AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to, AV77BR_ProcedureWWDS_10_Tfbr_procedure_date, AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to, AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate, AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to, AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime, AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK1W2 = false;
            A85BR_Information_ID = P001W2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001W2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001W2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001W2_n36BR_Information_PatientNo[0];
            A269BR_Procedure_RadioTime = P001W2_A269BR_Procedure_RadioTime[0];
            n269BR_Procedure_RadioTime = P001W2_n269BR_Procedure_RadioTime[0];
            A268BR_Procedure_RadioDate = P001W2_A268BR_Procedure_RadioDate[0];
            n268BR_Procedure_RadioDate = P001W2_n268BR_Procedure_RadioDate[0];
            A143BR_Procedure_PXRadiotherapy = P001W2_A143BR_Procedure_PXRadiotherapy[0];
            n143BR_Procedure_PXRadiotherapy = P001W2_n143BR_Procedure_PXRadiotherapy[0];
            A266BR_Procedure_Date = P001W2_A266BR_Procedure_Date[0];
            n266BR_Procedure_Date = P001W2_n266BR_Procedure_Date[0];
            A141BR_Procedure_PXSurgery = P001W2_A141BR_Procedure_PXSurgery[0];
            n141BR_Procedure_PXSurgery = P001W2_n141BR_Procedure_PXSurgery[0];
            A140BR_Procedure_PXID = P001W2_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = P001W2_n140BR_Procedure_PXID[0];
            A19BR_EncounterID = P001W2_A19BR_EncounterID[0];
            n19BR_EncounterID = P001W2_n19BR_EncounterID[0];
            A139BR_ProcedureID = P001W2_A139BR_ProcedureID[0];
            A85BR_Information_ID = P001W2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001W2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001W2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001W2_n36BR_Information_PatientNo[0];
            AV47count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001W2_A36BR_Information_PatientNo[0], A36BR_Information_PatientNo) == 0 ) )
            {
               BRK1W2 = false;
               A85BR_Information_ID = P001W2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001W2_n85BR_Information_ID[0];
               A19BR_EncounterID = P001W2_A19BR_EncounterID[0];
               n19BR_EncounterID = P001W2_n19BR_EncounterID[0];
               A139BR_ProcedureID = P001W2_A139BR_ProcedureID[0];
               A85BR_Information_ID = P001W2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001W2_n85BR_Information_ID[0];
               AV47count = (long)(AV47count+1);
               BRK1W2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A36BR_Information_PatientNo)) )
            {
               AV39Option = A36BR_Information_PatientNo;
               AV40Options.Add(AV39Option, 0);
               AV45OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV47count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV40Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1W2 )
            {
               BRK1W2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      public override void cleanup( )
      {
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
         AV40Options = new GxSimpleCollection<String>();
         AV43OptionsDesc = new GxSimpleCollection<String>();
         AV45OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV48Session = context.GetSession();
         AV50GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV51GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV13TFBR_Information_PatientNo = "";
         AV14TFBR_Information_PatientNo_Sel = "";
         AV17TFBR_Procedure_PXSurgery_SelsJson = "";
         AV18TFBR_Procedure_PXSurgery_Sels = new GxSimpleCollection<String>();
         AV55TFBR_Procedure_Date = DateTime.MinValue;
         AV56TFBR_Procedure_Date_To = DateTime.MinValue;
         AV21TFBR_Procedure_PXRadiotherapy_SelsJson = "";
         AV22TFBR_Procedure_PXRadiotherapy_Sels = new GxSimpleCollection<String>();
         AV59TFBR_Procedure_RadioDate = DateTime.MinValue;
         AV60TFBR_Procedure_RadioDate_To = DateTime.MinValue;
         AV72BR_ProcedureWWDS_5_Tfbr_information_patientno = "";
         AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = "";
         AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = new GxSimpleCollection<String>();
         AV77BR_ProcedureWWDS_10_Tfbr_procedure_date = DateTime.MinValue;
         AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to = DateTime.MinValue;
         AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = new GxSimpleCollection<String>();
         AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = DateTime.MinValue;
         AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = DateTime.MinValue;
         scmdbuf = "";
         lV72BR_ProcedureWWDS_5_Tfbr_information_patientno = "";
         A141BR_Procedure_PXSurgery = "";
         A143BR_Procedure_PXRadiotherapy = "";
         A36BR_Information_PatientNo = "";
         A266BR_Procedure_Date = DateTime.MinValue;
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         P001W2_A85BR_Information_ID = new long[1] ;
         P001W2_n85BR_Information_ID = new bool[] {false} ;
         P001W2_A36BR_Information_PatientNo = new String[] {""} ;
         P001W2_n36BR_Information_PatientNo = new bool[] {false} ;
         P001W2_A269BR_Procedure_RadioTime = new decimal[1] ;
         P001W2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         P001W2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         P001W2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         P001W2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         P001W2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         P001W2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         P001W2_n266BR_Procedure_Date = new bool[] {false} ;
         P001W2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         P001W2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         P001W2_A140BR_Procedure_PXID = new long[1] ;
         P001W2_n140BR_Procedure_PXID = new bool[] {false} ;
         P001W2_A19BR_EncounterID = new long[1] ;
         P001W2_n19BR_EncounterID = new bool[] {false} ;
         P001W2_A139BR_ProcedureID = new long[1] ;
         AV39Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedurewwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P001W2_A85BR_Information_ID, P001W2_n85BR_Information_ID, P001W2_A36BR_Information_PatientNo, P001W2_n36BR_Information_PatientNo, P001W2_A269BR_Procedure_RadioTime, P001W2_n269BR_Procedure_RadioTime, P001W2_A268BR_Procedure_RadioDate, P001W2_n268BR_Procedure_RadioDate, P001W2_A143BR_Procedure_PXRadiotherapy, P001W2_n143BR_Procedure_PXRadiotherapy,
               P001W2_A266BR_Procedure_Date, P001W2_n266BR_Procedure_Date, P001W2_A141BR_Procedure_PXSurgery, P001W2_n141BR_Procedure_PXSurgery, P001W2_A140BR_Procedure_PXID, P001W2_n140BR_Procedure_PXID, P001W2_A19BR_EncounterID, P001W2_n19BR_EncounterID, P001W2_A139BR_ProcedureID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV66GXV1 ;
      private int AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count ;
      private int AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count ;
      private long AV53TFBR_ProcedureID ;
      private long AV54TFBR_ProcedureID_To ;
      private long AV11TFBR_EncounterID ;
      private long AV12TFBR_EncounterID_To ;
      private long AV15TFBR_Procedure_PXID ;
      private long AV16TFBR_Procedure_PXID_To ;
      private long AV68BR_ProcedureWWDS_1_Tfbr_procedureid ;
      private long AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to ;
      private long AV70BR_ProcedureWWDS_3_Tfbr_encounterid ;
      private long AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to ;
      private long AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid ;
      private long AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ;
      private long A139BR_ProcedureID ;
      private long A19BR_EncounterID ;
      private long A140BR_Procedure_PXID ;
      private long A85BR_Information_ID ;
      private long AV47count ;
      private decimal AV61TFBR_Procedure_RadioTime ;
      private decimal AV62TFBR_Procedure_RadioTime_To ;
      private decimal AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ;
      private decimal AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ;
      private decimal A269BR_Procedure_RadioTime ;
      private String scmdbuf ;
      private DateTime AV55TFBR_Procedure_Date ;
      private DateTime AV56TFBR_Procedure_Date_To ;
      private DateTime AV59TFBR_Procedure_RadioDate ;
      private DateTime AV60TFBR_Procedure_RadioDate_To ;
      private DateTime AV77BR_ProcedureWWDS_10_Tfbr_procedure_date ;
      private DateTime AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to ;
      private DateTime AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ;
      private DateTime AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime A268BR_Procedure_RadioDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK1W2 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n269BR_Procedure_RadioTime ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n266BR_Procedure_Date ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool n140BR_Procedure_PXID ;
      private bool n19BR_EncounterID ;
      private String AV46OptionIndexesJson ;
      private String AV41OptionsJson ;
      private String AV44OptionsDescJson ;
      private String AV17TFBR_Procedure_PXSurgery_SelsJson ;
      private String AV21TFBR_Procedure_PXRadiotherapy_SelsJson ;
      private String AV37DDOName ;
      private String AV35SearchTxt ;
      private String AV36SearchTxtTo ;
      private String AV13TFBR_Information_PatientNo ;
      private String AV14TFBR_Information_PatientNo_Sel ;
      private String AV72BR_ProcedureWWDS_5_Tfbr_information_patientno ;
      private String AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ;
      private String lV72BR_ProcedureWWDS_5_Tfbr_information_patientno ;
      private String A141BR_Procedure_PXSurgery ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String A36BR_Information_PatientNo ;
      private String AV39Option ;
      private IGxSession AV48Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001W2_A85BR_Information_ID ;
      private bool[] P001W2_n85BR_Information_ID ;
      private String[] P001W2_A36BR_Information_PatientNo ;
      private bool[] P001W2_n36BR_Information_PatientNo ;
      private decimal[] P001W2_A269BR_Procedure_RadioTime ;
      private bool[] P001W2_n269BR_Procedure_RadioTime ;
      private DateTime[] P001W2_A268BR_Procedure_RadioDate ;
      private bool[] P001W2_n268BR_Procedure_RadioDate ;
      private String[] P001W2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] P001W2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] P001W2_A266BR_Procedure_Date ;
      private bool[] P001W2_n266BR_Procedure_Date ;
      private String[] P001W2_A141BR_Procedure_PXSurgery ;
      private bool[] P001W2_n141BR_Procedure_PXSurgery ;
      private long[] P001W2_A140BR_Procedure_PXID ;
      private bool[] P001W2_n140BR_Procedure_PXID ;
      private long[] P001W2_A19BR_EncounterID ;
      private bool[] P001W2_n19BR_EncounterID ;
      private long[] P001W2_A139BR_ProcedureID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV40Options ;
      private GxSimpleCollection<String> AV43OptionsDesc ;
      private GxSimpleCollection<String> AV45OptionIndexes ;
      private GxSimpleCollection<String> AV18TFBR_Procedure_PXSurgery_Sels ;
      private GxSimpleCollection<String> AV22TFBR_Procedure_PXRadiotherapy_Sels ;
      private GxSimpleCollection<String> AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ;
      private GxSimpleCollection<String> AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV50GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV51GridStateFilterValue ;
   }

   public class br_procedurewwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001W2( IGxContext context ,
                                             String A141BR_Procedure_PXSurgery ,
                                             GxSimpleCollection<String> AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                             String A143BR_Procedure_PXRadiotherapy ,
                                             GxSimpleCollection<String> AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                             long AV68BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                             long AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                             long AV70BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                             long AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                             String AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV72BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                             long AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                             long AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                             int AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count ,
                                             DateTime AV77BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                             DateTime AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                             int AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count ,
                                             DateTime AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                             DateTime AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                             decimal AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                             decimal AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                             long A139BR_ProcedureID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A140BR_Procedure_PXID ,
                                             DateTime A266BR_Procedure_Date ,
                                             DateTime A268BR_Procedure_RadioDate ,
                                             decimal A269BR_Procedure_RadioTime )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [14] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T3.[BR_Information_PatientNo], T1.[BR_Procedure_RadioTime], T1.[BR_Procedure_RadioDate], T1.[BR_Procedure_PXRadiotherapy], T1.[BR_Procedure_Date], T1.[BR_Procedure_PXSurgery], T1.[BR_Procedure_PXID], T1.[BR_EncounterID], T1.[BR_ProcedureID] FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV68BR_ProcedureWWDS_1_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] >= @AV68BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] >= @AV68BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] <= @AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] <= @AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV70BR_ProcedureWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV70BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV70BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_ProcedureWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV72BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV72BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (0==AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] >= @AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] >= @AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (0==AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] <= @AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] <= @AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV76BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV77BR_ProcedureWWDS_10_Tfbr_procedure_date) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] >= @AV77BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] >= @AV77BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] <= @AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] <= @AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV79BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] >= @AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] >= @AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] <= @AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] <= @AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] >= @AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] >= @AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] <= @AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] <= @AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T3.[BR_Information_PatientNo]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001W2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (int)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (long)dynConstraints[23] , (DateTime)dynConstraints[24] , (DateTime)dynConstraints[25] , (decimal)dynConstraints[26] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001W2 ;
          prmP001W2 = new Object[] {
          new Object[] {"@AV68BR_ProcedureWWDS_1_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV69BR_ProcedureWWDS_2_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV70BR_ProcedureWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV71BR_ProcedureWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV72BR_ProcedureWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV73BR_ProcedureWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV74BR_ProcedureWWDS_7_Tfbr_procedure_pxid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV75BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV77BR_ProcedureWWDS_10_Tfbr_procedure_date",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV78BR_ProcedureWWDS_11_Tfbr_procedure_date_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV80BR_ProcedureWWDS_13_Tfbr_procedure_radiodate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV82BR_ProcedureWWDS_15_Tfbr_procedure_radiotime",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV83BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001W2,100,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[27]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_procedurewwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_procedurewwgetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("br_procedurewwgetfilterdata") )
          {
             return  ;
          }
          br_procedurewwgetfilterdata worker = new br_procedurewwgetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
