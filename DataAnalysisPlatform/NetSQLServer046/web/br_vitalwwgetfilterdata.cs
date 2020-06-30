/*
               File: BR_VitalWWGetFilterData
        Description: BR_Vital WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:12.59
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
   public class br_vitalwwgetfilterdata : GXProcedure
   {
      public br_vitalwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vitalwwgetfilterdata( IGxContext context )
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
         br_vitalwwgetfilterdata objbr_vitalwwgetfilterdata;
         objbr_vitalwwgetfilterdata = new br_vitalwwgetfilterdata();
         objbr_vitalwwgetfilterdata.AV37DDOName = aP0_DDOName;
         objbr_vitalwwgetfilterdata.AV35SearchTxt = aP1_SearchTxt;
         objbr_vitalwwgetfilterdata.AV36SearchTxtTo = aP2_SearchTxtTo;
         objbr_vitalwwgetfilterdata.AV41OptionsJson = "" ;
         objbr_vitalwwgetfilterdata.AV44OptionsDescJson = "" ;
         objbr_vitalwwgetfilterdata.AV46OptionIndexesJson = "" ;
         objbr_vitalwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_vitalwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_vitalwwgetfilterdata);
         aP3_OptionsJson=this.AV41OptionsJson;
         aP4_OptionsDescJson=this.AV44OptionsDescJson;
         aP5_OptionIndexesJson=this.AV46OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_vitalwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Vital", out  GXt_boolean1) ;
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
         if ( StringUtil.StrCmp(AV48Session.Get("BR_VitalWWGridState"), "") == 0 )
         {
            AV50GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_VitalWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV50GridState.FromXml(AV48Session.Get("BR_VitalWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV55GXV1 = 1;
         while ( AV55GXV1 <= AV50GridState.gxTpr_Filtervalues.Count )
         {
            AV51GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV50GridState.gxTpr_Filtervalues.Item(AV55GXV1));
            if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITALID") == 0 )
            {
               AV11TFBR_VitalID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_VitalID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV15TFBR_Information_PatientNo = AV51GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV16TFBR_Information_PatientNo_Sel = AV51GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_VITALID") == 0 )
            {
               AV17TFBR_Vital_VitalID = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, "."));
               AV18TFBR_Vital_VitalID_To = (long)(NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_MEASUREDATE") == 0 )
            {
               AV19TFBR_Vital_MeasureDate = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Value, 0);
               AV20TFBR_Vital_MeasureDate_To = context.localUtil.CToD( AV51GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_TEMPERATURE") == 0 )
            {
               AV21TFBR_Vital_Temperature = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV22TFBR_Vital_Temperature_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_PULSE") == 0 )
            {
               AV23TFBR_Vital_Pulse = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV24TFBR_Vital_Pulse_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_RESPIRATION") == 0 )
            {
               AV25TFBR_Vital_Respiration = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV26TFBR_Vital_Respiration_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_SYSTOLIC") == 0 )
            {
               AV27TFBR_Vital_Systolic = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV28TFBR_Vital_Systolic_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_DIASTOLIC") == 0 )
            {
               AV29TFBR_Vital_Diastolic = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV30TFBR_Vital_Diastolic_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_HEIGHT") == 0 )
            {
               AV31TFBR_Vital_Height = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV32TFBR_Vital_Height_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV51GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_WEIGHT") == 0 )
            {
               AV33TFBR_Vital_Weight = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Value, ".");
               AV34TFBR_Vital_Weight_To = NumberUtil.Val( AV51GridStateFilterValue.gxTpr_Valueto, ".");
            }
            AV55GXV1 = (int)(AV55GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV15TFBR_Information_PatientNo = AV35SearchTxt;
         AV16TFBR_Information_PatientNo_Sel = "";
         AV57BR_VitalWWDS_1_Tfbr_vitalid = AV11TFBR_VitalID;
         AV58BR_VitalWWDS_2_Tfbr_vitalid_to = AV12TFBR_VitalID_To;
         AV59BR_VitalWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV60BR_VitalWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV61BR_VitalWWDS_5_Tfbr_information_patientno = AV15TFBR_Information_PatientNo;
         AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel = AV16TFBR_Information_PatientNo_Sel;
         AV63BR_VitalWWDS_7_Tfbr_vital_vitalid = AV17TFBR_Vital_VitalID;
         AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to = AV18TFBR_Vital_VitalID_To;
         AV65BR_VitalWWDS_9_Tfbr_vital_measuredate = AV19TFBR_Vital_MeasureDate;
         AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to = AV20TFBR_Vital_MeasureDate_To;
         AV67BR_VitalWWDS_11_Tfbr_vital_temperature = AV21TFBR_Vital_Temperature;
         AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to = AV22TFBR_Vital_Temperature_To;
         AV69BR_VitalWWDS_13_Tfbr_vital_pulse = AV23TFBR_Vital_Pulse;
         AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to = AV24TFBR_Vital_Pulse_To;
         AV71BR_VitalWWDS_15_Tfbr_vital_respiration = AV25TFBR_Vital_Respiration;
         AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to = AV26TFBR_Vital_Respiration_To;
         AV73BR_VitalWWDS_17_Tfbr_vital_systolic = AV27TFBR_Vital_Systolic;
         AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to = AV28TFBR_Vital_Systolic_To;
         AV75BR_VitalWWDS_19_Tfbr_vital_diastolic = AV29TFBR_Vital_Diastolic;
         AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to = AV30TFBR_Vital_Diastolic_To;
         AV77BR_VitalWWDS_21_Tfbr_vital_height = AV31TFBR_Vital_Height;
         AV78BR_VitalWWDS_22_Tfbr_vital_height_to = AV32TFBR_Vital_Height_To;
         AV79BR_VitalWWDS_23_Tfbr_vital_weight = AV33TFBR_Vital_Weight;
         AV80BR_VitalWWDS_24_Tfbr_vital_weight_to = AV34TFBR_Vital_Weight_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV57BR_VitalWWDS_1_Tfbr_vitalid ,
                                              AV58BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                              AV59BR_VitalWWDS_3_Tfbr_encounterid ,
                                              AV60BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                              AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                              AV61BR_VitalWWDS_5_Tfbr_information_patientno ,
                                              AV63BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                              AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                              AV65BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                              AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                              AV67BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                              AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                              AV69BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                              AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                              AV71BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                              AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                              AV73BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                              AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                              AV75BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                              AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                              AV77BR_VitalWWDS_21_Tfbr_vital_height ,
                                              AV78BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                              AV79BR_VitalWWDS_23_Tfbr_vital_weight ,
                                              AV80BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                              A150BR_VitalID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A151BR_Vital_VitalID ,
                                              A152BR_Vital_MeasureDate ,
                                              A153BR_Vital_Temperature ,
                                              A154BR_Vital_Pulse ,
                                              A155BR_Vital_Respiration ,
                                              A156BR_Vital_Systolic ,
                                              A157BR_Vital_Diastolic ,
                                              A158BR_Vital_Height ,
                                              A159BR_Vital_Weight } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN,
                                              TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV61BR_VitalWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV61BR_VitalWWDS_5_Tfbr_information_patientno), "%", "");
         /* Using cursor P002Q2 */
         pr_default.execute(0, new Object[] {AV57BR_VitalWWDS_1_Tfbr_vitalid, AV58BR_VitalWWDS_2_Tfbr_vitalid_to, AV59BR_VitalWWDS_3_Tfbr_encounterid, AV60BR_VitalWWDS_4_Tfbr_encounterid_to, lV61BR_VitalWWDS_5_Tfbr_information_patientno, AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel, AV63BR_VitalWWDS_7_Tfbr_vital_vitalid, AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to, AV65BR_VitalWWDS_9_Tfbr_vital_measuredate, AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to, AV67BR_VitalWWDS_11_Tfbr_vital_temperature, AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to, AV69BR_VitalWWDS_13_Tfbr_vital_pulse, AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to, AV71BR_VitalWWDS_15_Tfbr_vital_respiration, AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to, AV73BR_VitalWWDS_17_Tfbr_vital_systolic, AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to, AV75BR_VitalWWDS_19_Tfbr_vital_diastolic, AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to, AV77BR_VitalWWDS_21_Tfbr_vital_height, AV78BR_VitalWWDS_22_Tfbr_vital_height_to, AV79BR_VitalWWDS_23_Tfbr_vital_weight, AV80BR_VitalWWDS_24_Tfbr_vital_weight_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2Q2 = false;
            A85BR_Information_ID = P002Q2_A85BR_Information_ID[0];
            n85BR_Information_ID = P002Q2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002Q2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002Q2_n36BR_Information_PatientNo[0];
            A159BR_Vital_Weight = P002Q2_A159BR_Vital_Weight[0];
            n159BR_Vital_Weight = P002Q2_n159BR_Vital_Weight[0];
            A158BR_Vital_Height = P002Q2_A158BR_Vital_Height[0];
            n158BR_Vital_Height = P002Q2_n158BR_Vital_Height[0];
            A157BR_Vital_Diastolic = P002Q2_A157BR_Vital_Diastolic[0];
            n157BR_Vital_Diastolic = P002Q2_n157BR_Vital_Diastolic[0];
            A156BR_Vital_Systolic = P002Q2_A156BR_Vital_Systolic[0];
            n156BR_Vital_Systolic = P002Q2_n156BR_Vital_Systolic[0];
            A155BR_Vital_Respiration = P002Q2_A155BR_Vital_Respiration[0];
            n155BR_Vital_Respiration = P002Q2_n155BR_Vital_Respiration[0];
            A154BR_Vital_Pulse = P002Q2_A154BR_Vital_Pulse[0];
            n154BR_Vital_Pulse = P002Q2_n154BR_Vital_Pulse[0];
            A153BR_Vital_Temperature = P002Q2_A153BR_Vital_Temperature[0];
            n153BR_Vital_Temperature = P002Q2_n153BR_Vital_Temperature[0];
            A152BR_Vital_MeasureDate = P002Q2_A152BR_Vital_MeasureDate[0];
            n152BR_Vital_MeasureDate = P002Q2_n152BR_Vital_MeasureDate[0];
            A151BR_Vital_VitalID = P002Q2_A151BR_Vital_VitalID[0];
            n151BR_Vital_VitalID = P002Q2_n151BR_Vital_VitalID[0];
            A19BR_EncounterID = P002Q2_A19BR_EncounterID[0];
            A150BR_VitalID = P002Q2_A150BR_VitalID[0];
            A85BR_Information_ID = P002Q2_A85BR_Information_ID[0];
            n85BR_Information_ID = P002Q2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P002Q2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P002Q2_n36BR_Information_PatientNo[0];
            AV47count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002Q2_A36BR_Information_PatientNo[0], A36BR_Information_PatientNo) == 0 ) )
            {
               BRK2Q2 = false;
               A85BR_Information_ID = P002Q2_A85BR_Information_ID[0];
               n85BR_Information_ID = P002Q2_n85BR_Information_ID[0];
               A19BR_EncounterID = P002Q2_A19BR_EncounterID[0];
               A150BR_VitalID = P002Q2_A150BR_VitalID[0];
               A85BR_Information_ID = P002Q2_A85BR_Information_ID[0];
               n85BR_Information_ID = P002Q2_n85BR_Information_ID[0];
               AV47count = (long)(AV47count+1);
               BRK2Q2 = true;
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
            if ( ! BRK2Q2 )
            {
               BRK2Q2 = true;
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
         AV15TFBR_Information_PatientNo = "";
         AV16TFBR_Information_PatientNo_Sel = "";
         AV19TFBR_Vital_MeasureDate = DateTime.MinValue;
         AV20TFBR_Vital_MeasureDate_To = DateTime.MinValue;
         AV61BR_VitalWWDS_5_Tfbr_information_patientno = "";
         AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel = "";
         AV65BR_VitalWWDS_9_Tfbr_vital_measuredate = DateTime.MinValue;
         AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to = DateTime.MinValue;
         scmdbuf = "";
         lV61BR_VitalWWDS_5_Tfbr_information_patientno = "";
         A36BR_Information_PatientNo = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         P002Q2_A85BR_Information_ID = new long[1] ;
         P002Q2_n85BR_Information_ID = new bool[] {false} ;
         P002Q2_A36BR_Information_PatientNo = new String[] {""} ;
         P002Q2_n36BR_Information_PatientNo = new bool[] {false} ;
         P002Q2_A159BR_Vital_Weight = new decimal[1] ;
         P002Q2_n159BR_Vital_Weight = new bool[] {false} ;
         P002Q2_A158BR_Vital_Height = new decimal[1] ;
         P002Q2_n158BR_Vital_Height = new bool[] {false} ;
         P002Q2_A157BR_Vital_Diastolic = new decimal[1] ;
         P002Q2_n157BR_Vital_Diastolic = new bool[] {false} ;
         P002Q2_A156BR_Vital_Systolic = new decimal[1] ;
         P002Q2_n156BR_Vital_Systolic = new bool[] {false} ;
         P002Q2_A155BR_Vital_Respiration = new decimal[1] ;
         P002Q2_n155BR_Vital_Respiration = new bool[] {false} ;
         P002Q2_A154BR_Vital_Pulse = new decimal[1] ;
         P002Q2_n154BR_Vital_Pulse = new bool[] {false} ;
         P002Q2_A153BR_Vital_Temperature = new decimal[1] ;
         P002Q2_n153BR_Vital_Temperature = new bool[] {false} ;
         P002Q2_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         P002Q2_n152BR_Vital_MeasureDate = new bool[] {false} ;
         P002Q2_A151BR_Vital_VitalID = new long[1] ;
         P002Q2_n151BR_Vital_VitalID = new bool[] {false} ;
         P002Q2_A19BR_EncounterID = new long[1] ;
         P002Q2_A150BR_VitalID = new long[1] ;
         AV39Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vitalwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002Q2_A85BR_Information_ID, P002Q2_n85BR_Information_ID, P002Q2_A36BR_Information_PatientNo, P002Q2_n36BR_Information_PatientNo, P002Q2_A159BR_Vital_Weight, P002Q2_n159BR_Vital_Weight, P002Q2_A158BR_Vital_Height, P002Q2_n158BR_Vital_Height, P002Q2_A157BR_Vital_Diastolic, P002Q2_n157BR_Vital_Diastolic,
               P002Q2_A156BR_Vital_Systolic, P002Q2_n156BR_Vital_Systolic, P002Q2_A155BR_Vital_Respiration, P002Q2_n155BR_Vital_Respiration, P002Q2_A154BR_Vital_Pulse, P002Q2_n154BR_Vital_Pulse, P002Q2_A153BR_Vital_Temperature, P002Q2_n153BR_Vital_Temperature, P002Q2_A152BR_Vital_MeasureDate, P002Q2_n152BR_Vital_MeasureDate,
               P002Q2_A151BR_Vital_VitalID, P002Q2_n151BR_Vital_VitalID, P002Q2_A19BR_EncounterID, P002Q2_A150BR_VitalID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV55GXV1 ;
      private long AV11TFBR_VitalID ;
      private long AV12TFBR_VitalID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV17TFBR_Vital_VitalID ;
      private long AV18TFBR_Vital_VitalID_To ;
      private long AV57BR_VitalWWDS_1_Tfbr_vitalid ;
      private long AV58BR_VitalWWDS_2_Tfbr_vitalid_to ;
      private long AV59BR_VitalWWDS_3_Tfbr_encounterid ;
      private long AV60BR_VitalWWDS_4_Tfbr_encounterid_to ;
      private long AV63BR_VitalWWDS_7_Tfbr_vital_vitalid ;
      private long AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to ;
      private long A150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long A151BR_Vital_VitalID ;
      private long A85BR_Information_ID ;
      private long AV47count ;
      private decimal AV21TFBR_Vital_Temperature ;
      private decimal AV22TFBR_Vital_Temperature_To ;
      private decimal AV23TFBR_Vital_Pulse ;
      private decimal AV24TFBR_Vital_Pulse_To ;
      private decimal AV25TFBR_Vital_Respiration ;
      private decimal AV26TFBR_Vital_Respiration_To ;
      private decimal AV27TFBR_Vital_Systolic ;
      private decimal AV28TFBR_Vital_Systolic_To ;
      private decimal AV29TFBR_Vital_Diastolic ;
      private decimal AV30TFBR_Vital_Diastolic_To ;
      private decimal AV31TFBR_Vital_Height ;
      private decimal AV32TFBR_Vital_Height_To ;
      private decimal AV33TFBR_Vital_Weight ;
      private decimal AV34TFBR_Vital_Weight_To ;
      private decimal AV67BR_VitalWWDS_11_Tfbr_vital_temperature ;
      private decimal AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to ;
      private decimal AV69BR_VitalWWDS_13_Tfbr_vital_pulse ;
      private decimal AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to ;
      private decimal AV71BR_VitalWWDS_15_Tfbr_vital_respiration ;
      private decimal AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to ;
      private decimal AV73BR_VitalWWDS_17_Tfbr_vital_systolic ;
      private decimal AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to ;
      private decimal AV75BR_VitalWWDS_19_Tfbr_vital_diastolic ;
      private decimal AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to ;
      private decimal AV77BR_VitalWWDS_21_Tfbr_vital_height ;
      private decimal AV78BR_VitalWWDS_22_Tfbr_vital_height_to ;
      private decimal AV79BR_VitalWWDS_23_Tfbr_vital_weight ;
      private decimal AV80BR_VitalWWDS_24_Tfbr_vital_weight_to ;
      private decimal A153BR_Vital_Temperature ;
      private decimal A154BR_Vital_Pulse ;
      private decimal A155BR_Vital_Respiration ;
      private decimal A156BR_Vital_Systolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal A158BR_Vital_Height ;
      private decimal A159BR_Vital_Weight ;
      private String scmdbuf ;
      private DateTime AV19TFBR_Vital_MeasureDate ;
      private DateTime AV20TFBR_Vital_MeasureDate_To ;
      private DateTime AV65BR_VitalWWDS_9_Tfbr_vital_measuredate ;
      private DateTime AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2Q2 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n159BR_Vital_Weight ;
      private bool n158BR_Vital_Height ;
      private bool n157BR_Vital_Diastolic ;
      private bool n156BR_Vital_Systolic ;
      private bool n155BR_Vital_Respiration ;
      private bool n154BR_Vital_Pulse ;
      private bool n153BR_Vital_Temperature ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n151BR_Vital_VitalID ;
      private String AV46OptionIndexesJson ;
      private String AV41OptionsJson ;
      private String AV44OptionsDescJson ;
      private String AV37DDOName ;
      private String AV35SearchTxt ;
      private String AV36SearchTxtTo ;
      private String AV15TFBR_Information_PatientNo ;
      private String AV16TFBR_Information_PatientNo_Sel ;
      private String AV61BR_VitalWWDS_5_Tfbr_information_patientno ;
      private String AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel ;
      private String lV61BR_VitalWWDS_5_Tfbr_information_patientno ;
      private String A36BR_Information_PatientNo ;
      private String AV39Option ;
      private IGxSession AV48Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P002Q2_A85BR_Information_ID ;
      private bool[] P002Q2_n85BR_Information_ID ;
      private String[] P002Q2_A36BR_Information_PatientNo ;
      private bool[] P002Q2_n36BR_Information_PatientNo ;
      private decimal[] P002Q2_A159BR_Vital_Weight ;
      private bool[] P002Q2_n159BR_Vital_Weight ;
      private decimal[] P002Q2_A158BR_Vital_Height ;
      private bool[] P002Q2_n158BR_Vital_Height ;
      private decimal[] P002Q2_A157BR_Vital_Diastolic ;
      private bool[] P002Q2_n157BR_Vital_Diastolic ;
      private decimal[] P002Q2_A156BR_Vital_Systolic ;
      private bool[] P002Q2_n156BR_Vital_Systolic ;
      private decimal[] P002Q2_A155BR_Vital_Respiration ;
      private bool[] P002Q2_n155BR_Vital_Respiration ;
      private decimal[] P002Q2_A154BR_Vital_Pulse ;
      private bool[] P002Q2_n154BR_Vital_Pulse ;
      private decimal[] P002Q2_A153BR_Vital_Temperature ;
      private bool[] P002Q2_n153BR_Vital_Temperature ;
      private DateTime[] P002Q2_A152BR_Vital_MeasureDate ;
      private bool[] P002Q2_n152BR_Vital_MeasureDate ;
      private long[] P002Q2_A151BR_Vital_VitalID ;
      private bool[] P002Q2_n151BR_Vital_VitalID ;
      private long[] P002Q2_A19BR_EncounterID ;
      private long[] P002Q2_A150BR_VitalID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV40Options ;
      private GxSimpleCollection<String> AV43OptionsDesc ;
      private GxSimpleCollection<String> AV45OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV50GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV51GridStateFilterValue ;
   }

   public class br_vitalwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002Q2( IGxContext context ,
                                             long AV57BR_VitalWWDS_1_Tfbr_vitalid ,
                                             long AV58BR_VitalWWDS_2_Tfbr_vitalid_to ,
                                             long AV59BR_VitalWWDS_3_Tfbr_encounterid ,
                                             long AV60BR_VitalWWDS_4_Tfbr_encounterid_to ,
                                             String AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV61BR_VitalWWDS_5_Tfbr_information_patientno ,
                                             long AV63BR_VitalWWDS_7_Tfbr_vital_vitalid ,
                                             long AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to ,
                                             DateTime AV65BR_VitalWWDS_9_Tfbr_vital_measuredate ,
                                             DateTime AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to ,
                                             decimal AV67BR_VitalWWDS_11_Tfbr_vital_temperature ,
                                             decimal AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to ,
                                             decimal AV69BR_VitalWWDS_13_Tfbr_vital_pulse ,
                                             decimal AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to ,
                                             decimal AV71BR_VitalWWDS_15_Tfbr_vital_respiration ,
                                             decimal AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to ,
                                             decimal AV73BR_VitalWWDS_17_Tfbr_vital_systolic ,
                                             decimal AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to ,
                                             decimal AV75BR_VitalWWDS_19_Tfbr_vital_diastolic ,
                                             decimal AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to ,
                                             decimal AV77BR_VitalWWDS_21_Tfbr_vital_height ,
                                             decimal AV78BR_VitalWWDS_22_Tfbr_vital_height_to ,
                                             decimal AV79BR_VitalWWDS_23_Tfbr_vital_weight ,
                                             decimal AV80BR_VitalWWDS_24_Tfbr_vital_weight_to ,
                                             long A150BR_VitalID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A151BR_Vital_VitalID ,
                                             DateTime A152BR_Vital_MeasureDate ,
                                             decimal A153BR_Vital_Temperature ,
                                             decimal A154BR_Vital_Pulse ,
                                             decimal A155BR_Vital_Respiration ,
                                             decimal A156BR_Vital_Systolic ,
                                             decimal A157BR_Vital_Diastolic ,
                                             decimal A158BR_Vital_Height ,
                                             decimal A159BR_Vital_Weight )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [24] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T3.[BR_Information_PatientNo], T1.[BR_Vital_Weight], T1.[BR_Vital_Height], T1.[BR_Vital_Diastolic], T1.[BR_Vital_Systolic], T1.[BR_Vital_Respiration], T1.[BR_Vital_Pulse], T1.[BR_Vital_Temperature], T1.[BR_Vital_MeasureDate], T1.[BR_Vital_VitalID], T1.[BR_EncounterID], T1.[BR_VitalID] FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV57BR_VitalWWDS_1_Tfbr_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] >= @AV57BR_VitalWWDS_1_Tfbr_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] >= @AV57BR_VitalWWDS_1_Tfbr_vitalid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV58BR_VitalWWDS_2_Tfbr_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_VitalID] <= @AV58BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_VitalID] <= @AV58BR_VitalWWDS_2_Tfbr_vitalid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV59BR_VitalWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV59BR_VitalWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV59BR_VitalWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV60BR_VitalWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV60BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV60BR_VitalWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_VitalWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV61BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV61BR_VitalWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (0==AV63BR_VitalWWDS_7_Tfbr_vital_vitalid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] >= @AV63BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] >= @AV63BR_VitalWWDS_7_Tfbr_vital_vitalid)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (0==AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_VitalID] <= @AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_VitalID] <= @AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV65BR_VitalWWDS_9_Tfbr_vital_measuredate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] >= @AV65BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] >= @AV65BR_VitalWWDS_9_Tfbr_vital_measuredate)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_MeasureDate] <= @AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_MeasureDate] <= @AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV67BR_VitalWWDS_11_Tfbr_vital_temperature) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] >= @AV67BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] >= @AV67BR_VitalWWDS_11_Tfbr_vital_temperature)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Temperature] <= @AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Temperature] <= @AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV69BR_VitalWWDS_13_Tfbr_vital_pulse) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] >= @AV69BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] >= @AV69BR_VitalWWDS_13_Tfbr_vital_pulse)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Pulse] <= @AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Pulse] <= @AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV71BR_VitalWWDS_15_Tfbr_vital_respiration) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] >= @AV71BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] >= @AV71BR_VitalWWDS_15_Tfbr_vital_respiration)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Respiration] <= @AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Respiration] <= @AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to)";
            }
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV73BR_VitalWWDS_17_Tfbr_vital_systolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] >= @AV73BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] >= @AV73BR_VitalWWDS_17_Tfbr_vital_systolic)";
            }
         }
         else
         {
            GXv_int2[16] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Systolic] <= @AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Systolic] <= @AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to)";
            }
         }
         else
         {
            GXv_int2[17] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV75BR_VitalWWDS_19_Tfbr_vital_diastolic) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] >= @AV75BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] >= @AV75BR_VitalWWDS_19_Tfbr_vital_diastolic)";
            }
         }
         else
         {
            GXv_int2[18] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Diastolic] <= @AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Diastolic] <= @AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to)";
            }
         }
         else
         {
            GXv_int2[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV77BR_VitalWWDS_21_Tfbr_vital_height) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] >= @AV77BR_VitalWWDS_21_Tfbr_vital_height)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] >= @AV77BR_VitalWWDS_21_Tfbr_vital_height)";
            }
         }
         else
         {
            GXv_int2[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV78BR_VitalWWDS_22_Tfbr_vital_height_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Height] <= @AV78BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Height] <= @AV78BR_VitalWWDS_22_Tfbr_vital_height_to)";
            }
         }
         else
         {
            GXv_int2[21] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV79BR_VitalWWDS_23_Tfbr_vital_weight) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] >= @AV79BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] >= @AV79BR_VitalWWDS_23_Tfbr_vital_weight)";
            }
         }
         else
         {
            GXv_int2[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV80BR_VitalWWDS_24_Tfbr_vital_weight_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Vital_Weight] <= @AV80BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Vital_Weight] <= @AV80BR_VitalWWDS_24_Tfbr_vital_weight_to)";
            }
         }
         else
         {
            GXv_int2[23] = 1;
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
                     return conditional_P002Q2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (decimal)dynConstraints[16] , (decimal)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (decimal)dynConstraints[20] , (decimal)dynConstraints[21] , (decimal)dynConstraints[22] , (decimal)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (long)dynConstraints[27] , (DateTime)dynConstraints[28] , (decimal)dynConstraints[29] , (decimal)dynConstraints[30] , (decimal)dynConstraints[31] , (decimal)dynConstraints[32] , (decimal)dynConstraints[33] , (decimal)dynConstraints[34] , (decimal)dynConstraints[35] );
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
          Object[] prmP002Q2 ;
          prmP002Q2 = new Object[] {
          new Object[] {"@AV57BR_VitalWWDS_1_Tfbr_vitalid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_VitalWWDS_2_Tfbr_vitalid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV59BR_VitalWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_VitalWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV61BR_VitalWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV62BR_VitalWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV63BR_VitalWWDS_7_Tfbr_vital_vitalid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV64BR_VitalWWDS_8_Tfbr_vital_vitalid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV65BR_VitalWWDS_9_Tfbr_vital_measuredate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV66BR_VitalWWDS_10_Tfbr_vital_measuredate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV67BR_VitalWWDS_11_Tfbr_vital_temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV68BR_VitalWWDS_12_Tfbr_vital_temperature_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV69BR_VitalWWDS_13_Tfbr_vital_pulse",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV70BR_VitalWWDS_14_Tfbr_vital_pulse_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV71BR_VitalWWDS_15_Tfbr_vital_respiration",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV72BR_VitalWWDS_16_Tfbr_vital_respiration_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV73BR_VitalWWDS_17_Tfbr_vital_systolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV74BR_VitalWWDS_18_Tfbr_vital_systolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV75BR_VitalWWDS_19_Tfbr_vital_diastolic",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV76BR_VitalWWDS_20_Tfbr_vital_diastolic_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV77BR_VitalWWDS_21_Tfbr_vital_height",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV78BR_VitalWWDS_22_Tfbr_vital_height_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV79BR_VitalWWDS_23_Tfbr_vital_weight",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV80BR_VitalWWDS_24_Tfbr_vital_weight_to",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002Q2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002Q2,100,0,true,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((decimal[]) buf[16])[0] = rslt.getDecimal(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((long[]) buf[20])[0] = rslt.getLong(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
                   stmt.SetParameter(sIdx, (long)parms[24]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[25]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[26]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[27]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[47]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_vitalwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_vitalwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_vitalwwgetfilterdata") )
          {
             return  ;
          }
          br_vitalwwgetfilterdata worker = new br_vitalwwgetfilterdata(context) ;
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
