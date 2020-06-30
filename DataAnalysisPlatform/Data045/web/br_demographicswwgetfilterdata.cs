/*
               File: BR_DemographicsWWGetFilterData
        Description: BR_Demographics WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:53.62
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
   public class br_demographicswwgetfilterdata : GXProcedure
   {
      public br_demographicswwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_demographicswwgetfilterdata( IGxContext context )
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
         this.AV41DDOName = aP0_DDOName;
         this.AV39SearchTxt = aP1_SearchTxt;
         this.AV40SearchTxtTo = aP2_SearchTxtTo;
         this.AV45OptionsJson = "" ;
         this.AV48OptionsDescJson = "" ;
         this.AV50OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV45OptionsJson;
         aP4_OptionsDescJson=this.AV48OptionsDescJson;
         aP5_OptionIndexesJson=this.AV50OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV41DDOName = aP0_DDOName;
         this.AV39SearchTxt = aP1_SearchTxt;
         this.AV40SearchTxtTo = aP2_SearchTxtTo;
         this.AV45OptionsJson = "" ;
         this.AV48OptionsDescJson = "" ;
         this.AV50OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV45OptionsJson;
         aP4_OptionsDescJson=this.AV48OptionsDescJson;
         aP5_OptionIndexesJson=this.AV50OptionIndexesJson;
         return AV50OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_demographicswwgetfilterdata objbr_demographicswwgetfilterdata;
         objbr_demographicswwgetfilterdata = new br_demographicswwgetfilterdata();
         objbr_demographicswwgetfilterdata.AV41DDOName = aP0_DDOName;
         objbr_demographicswwgetfilterdata.AV39SearchTxt = aP1_SearchTxt;
         objbr_demographicswwgetfilterdata.AV40SearchTxtTo = aP2_SearchTxtTo;
         objbr_demographicswwgetfilterdata.AV45OptionsJson = "" ;
         objbr_demographicswwgetfilterdata.AV48OptionsDescJson = "" ;
         objbr_demographicswwgetfilterdata.AV50OptionIndexesJson = "" ;
         objbr_demographicswwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_demographicswwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_demographicswwgetfilterdata);
         aP3_OptionsJson=this.AV45OptionsJson;
         aP4_OptionsDescJson=this.AV48OptionsDescJson;
         aP5_OptionIndexesJson=this.AV50OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_demographicswwgetfilterdata)stateInfo).executePrivate();
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
         AV44Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV47OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV49OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Demographics", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_INFORMATION_PATIENTNO") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_INFORMATION_PATIENTNOOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_SEXOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_MARRITALSTATUSOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_ETHNICOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_EDUCATION") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_EDUCATIONOPTIONS' */
               S161 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_OCCUPATION") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_OCCUPATIONOPTIONS' */
               S171 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_INSURANCE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_INSURANCEOPTIONS' */
               S181 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_PROVINCE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_PROVINCEOPTIONS' */
               S191 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV41DDOName), "DDO_BR_DEMOGRAPHICS_CITY") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_DEMOGRAPHICS_CITYOPTIONS' */
               S201 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV45OptionsJson = AV44Options.ToJSonString(false);
         AV48OptionsDescJson = AV47OptionsDesc.ToJSonString(false);
         AV50OptionIndexesJson = AV49OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV52Session.Get("BR_DemographicsWWGridState"), "") == 0 )
         {
            AV54GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_DemographicsWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV54GridState.FromXml(AV52Session.Get("BR_DemographicsWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV72GXV1 = 1;
         while ( AV72GXV1 <= AV54GridState.gxTpr_Filtervalues.Count )
         {
            AV55GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV54GridState.gxTpr_Filtervalues.Item(AV72GXV1));
            if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_ID") == 0 )
            {
               AV11TFBR_Demographics_ID = (long)(NumberUtil.Val( AV55GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Demographics_ID_To = (long)(NumberUtil.Val( AV55GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV55GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV55GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV17TFBR_Information_PatientNo = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV18TFBR_Information_PatientNo_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_BIRTHDATE") == 0 )
            {
               AV19TFBR_Demographics_BirthDate = context.localUtil.CToD( AV55GridStateFilterValue.gxTpr_Value, 0);
               AV20TFBR_Demographics_BirthDate_To = context.localUtil.CToD( AV55GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV57TFBR_Demographics_Sex = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_SEX_SEL") == 0 )
            {
               AV66TFBR_Demographics_Sex_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_MARRITALSTATUS") == 0 )
            {
               AV25TFBR_Demographics_MarritalStatus = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_MARRITALSTATUS_SEL") == 0 )
            {
               AV26TFBR_Demographics_MarritalStatus_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV60TFBR_Demographics_Ethnic = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_ETHNIC_SEL") == 0 )
            {
               AV67TFBR_Demographics_Ethnic_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_EDUCATION") == 0 )
            {
               AV62TFBR_Demographics_Education = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_EDUCATION_SEL") == 0 )
            {
               AV68TFBR_Demographics_Education_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_OCCUPATION") == 0 )
            {
               AV31TFBR_Demographics_Occupation = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_OCCUPATION_SEL") == 0 )
            {
               AV32TFBR_Demographics_Occupation_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_INSURANCE") == 0 )
            {
               AV64TFBR_Demographics_Insurance = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_INSURANCE_SEL") == 0 )
            {
               AV69TFBR_Demographics_Insurance_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_PROVINCE") == 0 )
            {
               AV35TFBR_Demographics_Province = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_PROVINCE_SEL") == 0 )
            {
               AV36TFBR_Demographics_Province_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_CITY") == 0 )
            {
               AV37TFBR_Demographics_City = AV55GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV55GridStateFilterValue.gxTpr_Name, "TFBR_DEMOGRAPHICS_CITY_SEL") == 0 )
            {
               AV38TFBR_Demographics_City_Sel = AV55GridStateFilterValue.gxTpr_Value;
            }
            AV72GXV1 = (int)(AV72GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV17TFBR_Information_PatientNo = AV39SearchTxt;
         AV18TFBR_Information_PatientNo_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N2 */
         pr_default.execute(0, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK1N2 = false;
            A85BR_Information_ID = P001N2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N2_n36BR_Information_PatientNo[0];
            A60BR_Demographics_City = P001N2_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N2_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N2_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N2_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N2_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N2_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N2_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N2_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N2_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N2_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N2_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N2_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N2_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N2_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N2_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N2_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N2_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N2_n53BR_Demographics_BirthDate[0];
            A19BR_EncounterID = P001N2_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N2_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N2_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N2_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N2_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N2_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001N2_A36BR_Information_PatientNo[0], A36BR_Information_PatientNo) == 0 ) )
            {
               BRK1N2 = false;
               A85BR_Information_ID = P001N2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001N2_n85BR_Information_ID[0];
               A19BR_EncounterID = P001N2_A19BR_EncounterID[0];
               A61BR_Demographics_ID = P001N2_A61BR_Demographics_ID[0];
               A85BR_Information_ID = P001N2_A85BR_Information_ID[0];
               n85BR_Information_ID = P001N2_n85BR_Information_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A36BR_Information_PatientNo)) )
            {
               AV43Option = A36BR_Information_PatientNo;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N2 )
            {
               BRK1N2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_DEMOGRAPHICS_SEXOPTIONS' Routine */
         AV57TFBR_Demographics_Sex = AV39SearchTxt;
         AV66TFBR_Demographics_Sex_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N3 */
         pr_default.execute(1, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK1N4 = false;
            A85BR_Information_ID = P001N3_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N3_n85BR_Information_ID[0];
            A54BR_Demographics_Sex = P001N3_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N3_n54BR_Demographics_Sex[0];
            A60BR_Demographics_City = P001N3_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N3_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N3_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N3_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N3_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N3_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N3_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N3_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N3_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N3_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N3_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N3_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N3_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N3_n63BR_Demographics_MarritalStatus[0];
            A53BR_Demographics_BirthDate = P001N3_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N3_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N3_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N3_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N3_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N3_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N3_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N3_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N3_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P001N3_A54BR_Demographics_Sex[0], A54BR_Demographics_Sex) == 0 ) )
            {
               BRK1N4 = false;
               A61BR_Demographics_ID = P001N3_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) )
            {
               AV43Option = A54BR_Demographics_Sex;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N4 )
            {
               BRK1N4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_DEMOGRAPHICS_MARRITALSTATUSOPTIONS' Routine */
         AV25TFBR_Demographics_MarritalStatus = AV39SearchTxt;
         AV26TFBR_Demographics_MarritalStatus_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N4 */
         pr_default.execute(2, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK1N6 = false;
            A85BR_Information_ID = P001N4_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N4_n85BR_Information_ID[0];
            A63BR_Demographics_MarritalStatus = P001N4_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N4_n63BR_Demographics_MarritalStatus[0];
            A60BR_Demographics_City = P001N4_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N4_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N4_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N4_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N4_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N4_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N4_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N4_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N4_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N4_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N4_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N4_n55BR_Demographics_Ethnic[0];
            A54BR_Demographics_Sex = P001N4_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N4_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N4_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N4_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N4_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N4_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N4_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N4_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N4_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N4_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N4_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P001N4_A63BR_Demographics_MarritalStatus[0], A63BR_Demographics_MarritalStatus) == 0 ) )
            {
               BRK1N6 = false;
               A61BR_Demographics_ID = P001N4_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A63BR_Demographics_MarritalStatus)) )
            {
               AV43Option = A63BR_Demographics_MarritalStatus;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N6 )
            {
               BRK1N6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_DEMOGRAPHICS_ETHNICOPTIONS' Routine */
         AV60TFBR_Demographics_Ethnic = AV39SearchTxt;
         AV67TFBR_Demographics_Ethnic_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N5 */
         pr_default.execute(3, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK1N8 = false;
            A85BR_Information_ID = P001N5_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N5_n85BR_Information_ID[0];
            A55BR_Demographics_Ethnic = P001N5_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N5_n55BR_Demographics_Ethnic[0];
            A60BR_Demographics_City = P001N5_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N5_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N5_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N5_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N5_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N5_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N5_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N5_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N5_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N5_n56BR_Demographics_Education[0];
            A63BR_Demographics_MarritalStatus = P001N5_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N5_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N5_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N5_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N5_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N5_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N5_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N5_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N5_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N5_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N5_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N5_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N5_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P001N5_A55BR_Demographics_Ethnic[0], A55BR_Demographics_Ethnic) == 0 ) )
            {
               BRK1N8 = false;
               A61BR_Demographics_ID = P001N5_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A55BR_Demographics_Ethnic)) )
            {
               AV43Option = A55BR_Demographics_Ethnic;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N8 )
            {
               BRK1N8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
      }

      protected void S161( )
      {
         /* 'LOADBR_DEMOGRAPHICS_EDUCATIONOPTIONS' Routine */
         AV62TFBR_Demographics_Education = AV39SearchTxt;
         AV68TFBR_Demographics_Education_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N6 */
         pr_default.execute(4, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK1N10 = false;
            A85BR_Information_ID = P001N6_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N6_n85BR_Information_ID[0];
            A56BR_Demographics_Education = P001N6_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N6_n56BR_Demographics_Education[0];
            A60BR_Demographics_City = P001N6_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N6_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N6_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N6_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N6_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N6_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N6_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N6_n57BR_Demographics_Occupation[0];
            A55BR_Demographics_Ethnic = P001N6_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N6_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N6_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N6_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N6_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N6_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N6_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N6_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N6_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N6_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N6_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N6_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N6_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(P001N6_A56BR_Demographics_Education[0], A56BR_Demographics_Education) == 0 ) )
            {
               BRK1N10 = false;
               A61BR_Demographics_ID = P001N6_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N10 = true;
               pr_default.readNext(4);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A56BR_Demographics_Education)) )
            {
               AV43Option = A56BR_Demographics_Education;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N10 )
            {
               BRK1N10 = true;
               pr_default.readNext(4);
            }
         }
         pr_default.close(4);
      }

      protected void S171( )
      {
         /* 'LOADBR_DEMOGRAPHICS_OCCUPATIONOPTIONS' Routine */
         AV31TFBR_Demographics_Occupation = AV39SearchTxt;
         AV32TFBR_Demographics_Occupation_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(5, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N7 */
         pr_default.execute(5, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(5) != 101) )
         {
            BRK1N12 = false;
            A85BR_Information_ID = P001N7_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N7_n85BR_Information_ID[0];
            A57BR_Demographics_Occupation = P001N7_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N7_n57BR_Demographics_Occupation[0];
            A60BR_Demographics_City = P001N7_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N7_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N7_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N7_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N7_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N7_n58BR_Demographics_Insurance[0];
            A56BR_Demographics_Education = P001N7_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N7_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N7_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N7_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N7_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N7_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N7_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N7_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N7_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N7_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N7_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N7_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N7_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N7_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N7_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N7_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(5) != 101) && ( StringUtil.StrCmp(P001N7_A57BR_Demographics_Occupation[0], A57BR_Demographics_Occupation) == 0 ) )
            {
               BRK1N12 = false;
               A61BR_Demographics_ID = P001N7_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N12 = true;
               pr_default.readNext(5);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A57BR_Demographics_Occupation)) )
            {
               AV43Option = A57BR_Demographics_Occupation;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N12 )
            {
               BRK1N12 = true;
               pr_default.readNext(5);
            }
         }
         pr_default.close(5);
      }

      protected void S181( )
      {
         /* 'LOADBR_DEMOGRAPHICS_INSURANCEOPTIONS' Routine */
         AV64TFBR_Demographics_Insurance = AV39SearchTxt;
         AV69TFBR_Demographics_Insurance_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(6, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N8 */
         pr_default.execute(6, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(6) != 101) )
         {
            BRK1N14 = false;
            A85BR_Information_ID = P001N8_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N8_n85BR_Information_ID[0];
            A58BR_Demographics_Insurance = P001N8_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N8_n58BR_Demographics_Insurance[0];
            A60BR_Demographics_City = P001N8_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N8_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N8_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N8_n59BR_Demographics_Province[0];
            A57BR_Demographics_Occupation = P001N8_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N8_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N8_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N8_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N8_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N8_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N8_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N8_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N8_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N8_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N8_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N8_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N8_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N8_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N8_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N8_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N8_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N8_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N8_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(6) != 101) && ( StringUtil.StrCmp(P001N8_A58BR_Demographics_Insurance[0], A58BR_Demographics_Insurance) == 0 ) )
            {
               BRK1N14 = false;
               A61BR_Demographics_ID = P001N8_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N14 = true;
               pr_default.readNext(6);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A58BR_Demographics_Insurance)) )
            {
               AV43Option = A58BR_Demographics_Insurance;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N14 )
            {
               BRK1N14 = true;
               pr_default.readNext(6);
            }
         }
         pr_default.close(6);
      }

      protected void S191( )
      {
         /* 'LOADBR_DEMOGRAPHICS_PROVINCEOPTIONS' Routine */
         AV35TFBR_Demographics_Province = AV39SearchTxt;
         AV36TFBR_Demographics_Province_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(7, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N9 */
         pr_default.execute(7, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(7) != 101) )
         {
            BRK1N16 = false;
            A85BR_Information_ID = P001N9_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N9_n85BR_Information_ID[0];
            A59BR_Demographics_Province = P001N9_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N9_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = P001N9_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N9_n60BR_Demographics_City[0];
            A58BR_Demographics_Insurance = P001N9_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N9_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N9_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N9_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N9_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N9_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N9_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N9_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N9_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N9_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N9_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N9_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N9_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N9_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N9_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N9_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N9_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N9_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N9_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N9_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N9_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N9_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(7) != 101) && ( StringUtil.StrCmp(P001N9_A59BR_Demographics_Province[0], A59BR_Demographics_Province) == 0 ) )
            {
               BRK1N16 = false;
               A61BR_Demographics_ID = P001N9_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N16 = true;
               pr_default.readNext(7);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A59BR_Demographics_Province)) )
            {
               AV43Option = A59BR_Demographics_Province;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N16 )
            {
               BRK1N16 = true;
               pr_default.readNext(7);
            }
         }
         pr_default.close(7);
      }

      protected void S201( )
      {
         /* 'LOADBR_DEMOGRAPHICS_CITYOPTIONS' Routine */
         AV37TFBR_Demographics_City = AV39SearchTxt;
         AV38TFBR_Demographics_City_Sel = "";
         AV74BR_DemographicsWWDS_1_Tfbr_demographics_id = AV11TFBR_Demographics_ID;
         AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to = AV12TFBR_Demographics_ID_To;
         AV76BR_DemographicsWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = AV17TFBR_Information_PatientNo;
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = AV18TFBR_Information_PatientNo_Sel;
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = AV19TFBR_Demographics_BirthDate;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = AV20TFBR_Demographics_BirthDate_To;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = AV57TFBR_Demographics_Sex;
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = AV66TFBR_Demographics_Sex_Sel;
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = AV25TFBR_Demographics_MarritalStatus;
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = AV26TFBR_Demographics_MarritalStatus_Sel;
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = AV60TFBR_Demographics_Ethnic;
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = AV67TFBR_Demographics_Ethnic_Sel;
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = AV62TFBR_Demographics_Education;
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = AV68TFBR_Demographics_Education_Sel;
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = AV31TFBR_Demographics_Occupation;
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = AV32TFBR_Demographics_Occupation_Sel;
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = AV64TFBR_Demographics_Insurance;
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = AV69TFBR_Demographics_Insurance_Sel;
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = AV35TFBR_Demographics_Province;
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = AV36TFBR_Demographics_Province_Sel;
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = AV37TFBR_Demographics_City;
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = AV38TFBR_Demographics_City_Sel;
         pr_default.dynParam(8, new Object[]{ new Object[]{
                                              AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              A61BR_Demographics_ID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A53BR_Demographics_BirthDate ,
                                              A54BR_Demographics_Sex ,
                                              A63BR_Demographics_MarritalStatus ,
                                              A55BR_Demographics_Ethnic ,
                                              A56BR_Demographics_Education ,
                                              A57BR_Demographics_Occupation ,
                                              A58BR_Demographics_Insurance ,
                                              A59BR_Demographics_Province ,
                                              A60BR_Demographics_City } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno), "%", "");
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex), "%", "");
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = StringUtil.Concat( StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus), "%", "");
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic), "%", "");
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = StringUtil.Concat( StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education), "%", "");
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = StringUtil.Concat( StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation), "%", "");
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = StringUtil.Concat( StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance), "%", "");
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = StringUtil.Concat( StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province), "%", "");
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = StringUtil.Concat( StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city), "%", "");
         /* Using cursor P001N10 */
         pr_default.execute(8, new Object[] {AV74BR_DemographicsWWDS_1_Tfbr_demographics_id, AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to, AV76BR_DemographicsWWDS_3_Tfbr_encounterid, AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to, lV78BR_DemographicsWWDS_5_Tfbr_information_patientno, AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel, AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate, AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to, lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex, AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel, lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus, AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel, lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic, AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel, lV88BR_DemographicsWWDS_15_Tfbr_demographics_education, AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel, lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation, AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel, lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance, AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel, lV94BR_DemographicsWWDS_21_Tfbr_demographics_province, AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel, lV96BR_DemographicsWWDS_23_Tfbr_demographics_city, AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel});
         while ( (pr_default.getStatus(8) != 101) )
         {
            BRK1N18 = false;
            A85BR_Information_ID = P001N10_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N10_n85BR_Information_ID[0];
            A60BR_Demographics_City = P001N10_A60BR_Demographics_City[0];
            n60BR_Demographics_City = P001N10_n60BR_Demographics_City[0];
            A59BR_Demographics_Province = P001N10_A59BR_Demographics_Province[0];
            n59BR_Demographics_Province = P001N10_n59BR_Demographics_Province[0];
            A58BR_Demographics_Insurance = P001N10_A58BR_Demographics_Insurance[0];
            n58BR_Demographics_Insurance = P001N10_n58BR_Demographics_Insurance[0];
            A57BR_Demographics_Occupation = P001N10_A57BR_Demographics_Occupation[0];
            n57BR_Demographics_Occupation = P001N10_n57BR_Demographics_Occupation[0];
            A56BR_Demographics_Education = P001N10_A56BR_Demographics_Education[0];
            n56BR_Demographics_Education = P001N10_n56BR_Demographics_Education[0];
            A55BR_Demographics_Ethnic = P001N10_A55BR_Demographics_Ethnic[0];
            n55BR_Demographics_Ethnic = P001N10_n55BR_Demographics_Ethnic[0];
            A63BR_Demographics_MarritalStatus = P001N10_A63BR_Demographics_MarritalStatus[0];
            n63BR_Demographics_MarritalStatus = P001N10_n63BR_Demographics_MarritalStatus[0];
            A54BR_Demographics_Sex = P001N10_A54BR_Demographics_Sex[0];
            n54BR_Demographics_Sex = P001N10_n54BR_Demographics_Sex[0];
            A53BR_Demographics_BirthDate = P001N10_A53BR_Demographics_BirthDate[0];
            n53BR_Demographics_BirthDate = P001N10_n53BR_Demographics_BirthDate[0];
            A36BR_Information_PatientNo = P001N10_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N10_n36BR_Information_PatientNo[0];
            A19BR_EncounterID = P001N10_A19BR_EncounterID[0];
            A61BR_Demographics_ID = P001N10_A61BR_Demographics_ID[0];
            A85BR_Information_ID = P001N10_A85BR_Information_ID[0];
            n85BR_Information_ID = P001N10_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = P001N10_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = P001N10_n36BR_Information_PatientNo[0];
            AV51count = 0;
            while ( (pr_default.getStatus(8) != 101) && ( StringUtil.StrCmp(P001N10_A60BR_Demographics_City[0], A60BR_Demographics_City) == 0 ) )
            {
               BRK1N18 = false;
               A61BR_Demographics_ID = P001N10_A61BR_Demographics_ID[0];
               AV51count = (long)(AV51count+1);
               BRK1N18 = true;
               pr_default.readNext(8);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A60BR_Demographics_City)) )
            {
               AV43Option = A60BR_Demographics_City;
               AV44Options.Add(AV43Option, 0);
               AV49OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV51count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV44Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1N18 )
            {
               BRK1N18 = true;
               pr_default.readNext(8);
            }
         }
         pr_default.close(8);
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
         AV44Options = new GxSimpleCollection<String>();
         AV47OptionsDesc = new GxSimpleCollection<String>();
         AV49OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV52Session = context.GetSession();
         AV54GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV55GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV17TFBR_Information_PatientNo = "";
         AV18TFBR_Information_PatientNo_Sel = "";
         AV19TFBR_Demographics_BirthDate = DateTime.MinValue;
         AV20TFBR_Demographics_BirthDate_To = DateTime.MinValue;
         AV57TFBR_Demographics_Sex = "";
         AV66TFBR_Demographics_Sex_Sel = "";
         AV25TFBR_Demographics_MarritalStatus = "";
         AV26TFBR_Demographics_MarritalStatus_Sel = "";
         AV60TFBR_Demographics_Ethnic = "";
         AV67TFBR_Demographics_Ethnic_Sel = "";
         AV62TFBR_Demographics_Education = "";
         AV68TFBR_Demographics_Education_Sel = "";
         AV31TFBR_Demographics_Occupation = "";
         AV32TFBR_Demographics_Occupation_Sel = "";
         AV64TFBR_Demographics_Insurance = "";
         AV69TFBR_Demographics_Insurance_Sel = "";
         AV35TFBR_Demographics_Province = "";
         AV36TFBR_Demographics_Province_Sel = "";
         AV37TFBR_Demographics_City = "";
         AV38TFBR_Demographics_City_Sel = "";
         AV78BR_DemographicsWWDS_5_Tfbr_information_patientno = "";
         AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel = "";
         AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate = DateTime.MinValue;
         AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to = DateTime.MinValue;
         AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = "";
         AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel = "";
         AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = "";
         AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel = "";
         AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = "";
         AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel = "";
         AV88BR_DemographicsWWDS_15_Tfbr_demographics_education = "";
         AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel = "";
         AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = "";
         AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel = "";
         AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = "";
         AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel = "";
         AV94BR_DemographicsWWDS_21_Tfbr_demographics_province = "";
         AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel = "";
         AV96BR_DemographicsWWDS_23_Tfbr_demographics_city = "";
         AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel = "";
         scmdbuf = "";
         lV78BR_DemographicsWWDS_5_Tfbr_information_patientno = "";
         lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex = "";
         lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus = "";
         lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic = "";
         lV88BR_DemographicsWWDS_15_Tfbr_demographics_education = "";
         lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation = "";
         lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance = "";
         lV94BR_DemographicsWWDS_21_Tfbr_demographics_province = "";
         lV96BR_DemographicsWWDS_23_Tfbr_demographics_city = "";
         A36BR_Information_PatientNo = "";
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         A54BR_Demographics_Sex = "";
         A63BR_Demographics_MarritalStatus = "";
         A55BR_Demographics_Ethnic = "";
         A56BR_Demographics_Education = "";
         A57BR_Demographics_Occupation = "";
         A58BR_Demographics_Insurance = "";
         A59BR_Demographics_Province = "";
         A60BR_Demographics_City = "";
         P001N2_A85BR_Information_ID = new long[1] ;
         P001N2_n85BR_Information_ID = new bool[] {false} ;
         P001N2_A36BR_Information_PatientNo = new String[] {""} ;
         P001N2_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N2_A60BR_Demographics_City = new String[] {""} ;
         P001N2_n60BR_Demographics_City = new bool[] {false} ;
         P001N2_A59BR_Demographics_Province = new String[] {""} ;
         P001N2_n59BR_Demographics_Province = new bool[] {false} ;
         P001N2_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N2_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N2_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N2_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N2_A56BR_Demographics_Education = new String[] {""} ;
         P001N2_n56BR_Demographics_Education = new bool[] {false} ;
         P001N2_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N2_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N2_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N2_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N2_A54BR_Demographics_Sex = new String[] {""} ;
         P001N2_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N2_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N2_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N2_A19BR_EncounterID = new long[1] ;
         P001N2_A61BR_Demographics_ID = new long[1] ;
         AV43Option = "";
         P001N3_A85BR_Information_ID = new long[1] ;
         P001N3_n85BR_Information_ID = new bool[] {false} ;
         P001N3_A54BR_Demographics_Sex = new String[] {""} ;
         P001N3_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N3_A60BR_Demographics_City = new String[] {""} ;
         P001N3_n60BR_Demographics_City = new bool[] {false} ;
         P001N3_A59BR_Demographics_Province = new String[] {""} ;
         P001N3_n59BR_Demographics_Province = new bool[] {false} ;
         P001N3_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N3_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N3_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N3_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N3_A56BR_Demographics_Education = new String[] {""} ;
         P001N3_n56BR_Demographics_Education = new bool[] {false} ;
         P001N3_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N3_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N3_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N3_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N3_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N3_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N3_A36BR_Information_PatientNo = new String[] {""} ;
         P001N3_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N3_A19BR_EncounterID = new long[1] ;
         P001N3_A61BR_Demographics_ID = new long[1] ;
         P001N4_A85BR_Information_ID = new long[1] ;
         P001N4_n85BR_Information_ID = new bool[] {false} ;
         P001N4_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N4_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N4_A60BR_Demographics_City = new String[] {""} ;
         P001N4_n60BR_Demographics_City = new bool[] {false} ;
         P001N4_A59BR_Demographics_Province = new String[] {""} ;
         P001N4_n59BR_Demographics_Province = new bool[] {false} ;
         P001N4_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N4_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N4_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N4_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N4_A56BR_Demographics_Education = new String[] {""} ;
         P001N4_n56BR_Demographics_Education = new bool[] {false} ;
         P001N4_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N4_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N4_A54BR_Demographics_Sex = new String[] {""} ;
         P001N4_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N4_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N4_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N4_A36BR_Information_PatientNo = new String[] {""} ;
         P001N4_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N4_A19BR_EncounterID = new long[1] ;
         P001N4_A61BR_Demographics_ID = new long[1] ;
         P001N5_A85BR_Information_ID = new long[1] ;
         P001N5_n85BR_Information_ID = new bool[] {false} ;
         P001N5_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N5_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N5_A60BR_Demographics_City = new String[] {""} ;
         P001N5_n60BR_Demographics_City = new bool[] {false} ;
         P001N5_A59BR_Demographics_Province = new String[] {""} ;
         P001N5_n59BR_Demographics_Province = new bool[] {false} ;
         P001N5_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N5_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N5_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N5_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N5_A56BR_Demographics_Education = new String[] {""} ;
         P001N5_n56BR_Demographics_Education = new bool[] {false} ;
         P001N5_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N5_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N5_A54BR_Demographics_Sex = new String[] {""} ;
         P001N5_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N5_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N5_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N5_A36BR_Information_PatientNo = new String[] {""} ;
         P001N5_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N5_A19BR_EncounterID = new long[1] ;
         P001N5_A61BR_Demographics_ID = new long[1] ;
         P001N6_A85BR_Information_ID = new long[1] ;
         P001N6_n85BR_Information_ID = new bool[] {false} ;
         P001N6_A56BR_Demographics_Education = new String[] {""} ;
         P001N6_n56BR_Demographics_Education = new bool[] {false} ;
         P001N6_A60BR_Demographics_City = new String[] {""} ;
         P001N6_n60BR_Demographics_City = new bool[] {false} ;
         P001N6_A59BR_Demographics_Province = new String[] {""} ;
         P001N6_n59BR_Demographics_Province = new bool[] {false} ;
         P001N6_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N6_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N6_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N6_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N6_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N6_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N6_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N6_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N6_A54BR_Demographics_Sex = new String[] {""} ;
         P001N6_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N6_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N6_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N6_A36BR_Information_PatientNo = new String[] {""} ;
         P001N6_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N6_A19BR_EncounterID = new long[1] ;
         P001N6_A61BR_Demographics_ID = new long[1] ;
         P001N7_A85BR_Information_ID = new long[1] ;
         P001N7_n85BR_Information_ID = new bool[] {false} ;
         P001N7_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N7_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N7_A60BR_Demographics_City = new String[] {""} ;
         P001N7_n60BR_Demographics_City = new bool[] {false} ;
         P001N7_A59BR_Demographics_Province = new String[] {""} ;
         P001N7_n59BR_Demographics_Province = new bool[] {false} ;
         P001N7_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N7_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N7_A56BR_Demographics_Education = new String[] {""} ;
         P001N7_n56BR_Demographics_Education = new bool[] {false} ;
         P001N7_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N7_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N7_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N7_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N7_A54BR_Demographics_Sex = new String[] {""} ;
         P001N7_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N7_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N7_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N7_A36BR_Information_PatientNo = new String[] {""} ;
         P001N7_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N7_A19BR_EncounterID = new long[1] ;
         P001N7_A61BR_Demographics_ID = new long[1] ;
         P001N8_A85BR_Information_ID = new long[1] ;
         P001N8_n85BR_Information_ID = new bool[] {false} ;
         P001N8_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N8_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N8_A60BR_Demographics_City = new String[] {""} ;
         P001N8_n60BR_Demographics_City = new bool[] {false} ;
         P001N8_A59BR_Demographics_Province = new String[] {""} ;
         P001N8_n59BR_Demographics_Province = new bool[] {false} ;
         P001N8_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N8_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N8_A56BR_Demographics_Education = new String[] {""} ;
         P001N8_n56BR_Demographics_Education = new bool[] {false} ;
         P001N8_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N8_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N8_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N8_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N8_A54BR_Demographics_Sex = new String[] {""} ;
         P001N8_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N8_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N8_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N8_A36BR_Information_PatientNo = new String[] {""} ;
         P001N8_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N8_A19BR_EncounterID = new long[1] ;
         P001N8_A61BR_Demographics_ID = new long[1] ;
         P001N9_A85BR_Information_ID = new long[1] ;
         P001N9_n85BR_Information_ID = new bool[] {false} ;
         P001N9_A59BR_Demographics_Province = new String[] {""} ;
         P001N9_n59BR_Demographics_Province = new bool[] {false} ;
         P001N9_A60BR_Demographics_City = new String[] {""} ;
         P001N9_n60BR_Demographics_City = new bool[] {false} ;
         P001N9_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N9_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N9_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N9_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N9_A56BR_Demographics_Education = new String[] {""} ;
         P001N9_n56BR_Demographics_Education = new bool[] {false} ;
         P001N9_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N9_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N9_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N9_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N9_A54BR_Demographics_Sex = new String[] {""} ;
         P001N9_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N9_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N9_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N9_A36BR_Information_PatientNo = new String[] {""} ;
         P001N9_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N9_A19BR_EncounterID = new long[1] ;
         P001N9_A61BR_Demographics_ID = new long[1] ;
         P001N10_A85BR_Information_ID = new long[1] ;
         P001N10_n85BR_Information_ID = new bool[] {false} ;
         P001N10_A60BR_Demographics_City = new String[] {""} ;
         P001N10_n60BR_Demographics_City = new bool[] {false} ;
         P001N10_A59BR_Demographics_Province = new String[] {""} ;
         P001N10_n59BR_Demographics_Province = new bool[] {false} ;
         P001N10_A58BR_Demographics_Insurance = new String[] {""} ;
         P001N10_n58BR_Demographics_Insurance = new bool[] {false} ;
         P001N10_A57BR_Demographics_Occupation = new String[] {""} ;
         P001N10_n57BR_Demographics_Occupation = new bool[] {false} ;
         P001N10_A56BR_Demographics_Education = new String[] {""} ;
         P001N10_n56BR_Demographics_Education = new bool[] {false} ;
         P001N10_A55BR_Demographics_Ethnic = new String[] {""} ;
         P001N10_n55BR_Demographics_Ethnic = new bool[] {false} ;
         P001N10_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         P001N10_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         P001N10_A54BR_Demographics_Sex = new String[] {""} ;
         P001N10_n54BR_Demographics_Sex = new bool[] {false} ;
         P001N10_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P001N10_n53BR_Demographics_BirthDate = new bool[] {false} ;
         P001N10_A36BR_Information_PatientNo = new String[] {""} ;
         P001N10_n36BR_Information_PatientNo = new bool[] {false} ;
         P001N10_A19BR_EncounterID = new long[1] ;
         P001N10_A61BR_Demographics_ID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographicswwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P001N2_A85BR_Information_ID, P001N2_n85BR_Information_ID, P001N2_A36BR_Information_PatientNo, P001N2_n36BR_Information_PatientNo, P001N2_A60BR_Demographics_City, P001N2_n60BR_Demographics_City, P001N2_A59BR_Demographics_Province, P001N2_n59BR_Demographics_Province, P001N2_A58BR_Demographics_Insurance, P001N2_n58BR_Demographics_Insurance,
               P001N2_A57BR_Demographics_Occupation, P001N2_n57BR_Demographics_Occupation, P001N2_A56BR_Demographics_Education, P001N2_n56BR_Demographics_Education, P001N2_A55BR_Demographics_Ethnic, P001N2_n55BR_Demographics_Ethnic, P001N2_A63BR_Demographics_MarritalStatus, P001N2_n63BR_Demographics_MarritalStatus, P001N2_A54BR_Demographics_Sex, P001N2_n54BR_Demographics_Sex,
               P001N2_A53BR_Demographics_BirthDate, P001N2_n53BR_Demographics_BirthDate, P001N2_A19BR_EncounterID, P001N2_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N3_A85BR_Information_ID, P001N3_n85BR_Information_ID, P001N3_A54BR_Demographics_Sex, P001N3_n54BR_Demographics_Sex, P001N3_A60BR_Demographics_City, P001N3_n60BR_Demographics_City, P001N3_A59BR_Demographics_Province, P001N3_n59BR_Demographics_Province, P001N3_A58BR_Demographics_Insurance, P001N3_n58BR_Demographics_Insurance,
               P001N3_A57BR_Demographics_Occupation, P001N3_n57BR_Demographics_Occupation, P001N3_A56BR_Demographics_Education, P001N3_n56BR_Demographics_Education, P001N3_A55BR_Demographics_Ethnic, P001N3_n55BR_Demographics_Ethnic, P001N3_A63BR_Demographics_MarritalStatus, P001N3_n63BR_Demographics_MarritalStatus, P001N3_A53BR_Demographics_BirthDate, P001N3_n53BR_Demographics_BirthDate,
               P001N3_A36BR_Information_PatientNo, P001N3_n36BR_Information_PatientNo, P001N3_A19BR_EncounterID, P001N3_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N4_A85BR_Information_ID, P001N4_n85BR_Information_ID, P001N4_A63BR_Demographics_MarritalStatus, P001N4_n63BR_Demographics_MarritalStatus, P001N4_A60BR_Demographics_City, P001N4_n60BR_Demographics_City, P001N4_A59BR_Demographics_Province, P001N4_n59BR_Demographics_Province, P001N4_A58BR_Demographics_Insurance, P001N4_n58BR_Demographics_Insurance,
               P001N4_A57BR_Demographics_Occupation, P001N4_n57BR_Demographics_Occupation, P001N4_A56BR_Demographics_Education, P001N4_n56BR_Demographics_Education, P001N4_A55BR_Demographics_Ethnic, P001N4_n55BR_Demographics_Ethnic, P001N4_A54BR_Demographics_Sex, P001N4_n54BR_Demographics_Sex, P001N4_A53BR_Demographics_BirthDate, P001N4_n53BR_Demographics_BirthDate,
               P001N4_A36BR_Information_PatientNo, P001N4_n36BR_Information_PatientNo, P001N4_A19BR_EncounterID, P001N4_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N5_A85BR_Information_ID, P001N5_n85BR_Information_ID, P001N5_A55BR_Demographics_Ethnic, P001N5_n55BR_Demographics_Ethnic, P001N5_A60BR_Demographics_City, P001N5_n60BR_Demographics_City, P001N5_A59BR_Demographics_Province, P001N5_n59BR_Demographics_Province, P001N5_A58BR_Demographics_Insurance, P001N5_n58BR_Demographics_Insurance,
               P001N5_A57BR_Demographics_Occupation, P001N5_n57BR_Demographics_Occupation, P001N5_A56BR_Demographics_Education, P001N5_n56BR_Demographics_Education, P001N5_A63BR_Demographics_MarritalStatus, P001N5_n63BR_Demographics_MarritalStatus, P001N5_A54BR_Demographics_Sex, P001N5_n54BR_Demographics_Sex, P001N5_A53BR_Demographics_BirthDate, P001N5_n53BR_Demographics_BirthDate,
               P001N5_A36BR_Information_PatientNo, P001N5_n36BR_Information_PatientNo, P001N5_A19BR_EncounterID, P001N5_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N6_A85BR_Information_ID, P001N6_n85BR_Information_ID, P001N6_A56BR_Demographics_Education, P001N6_n56BR_Demographics_Education, P001N6_A60BR_Demographics_City, P001N6_n60BR_Demographics_City, P001N6_A59BR_Demographics_Province, P001N6_n59BR_Demographics_Province, P001N6_A58BR_Demographics_Insurance, P001N6_n58BR_Demographics_Insurance,
               P001N6_A57BR_Demographics_Occupation, P001N6_n57BR_Demographics_Occupation, P001N6_A55BR_Demographics_Ethnic, P001N6_n55BR_Demographics_Ethnic, P001N6_A63BR_Demographics_MarritalStatus, P001N6_n63BR_Demographics_MarritalStatus, P001N6_A54BR_Demographics_Sex, P001N6_n54BR_Demographics_Sex, P001N6_A53BR_Demographics_BirthDate, P001N6_n53BR_Demographics_BirthDate,
               P001N6_A36BR_Information_PatientNo, P001N6_n36BR_Information_PatientNo, P001N6_A19BR_EncounterID, P001N6_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N7_A85BR_Information_ID, P001N7_n85BR_Information_ID, P001N7_A57BR_Demographics_Occupation, P001N7_n57BR_Demographics_Occupation, P001N7_A60BR_Demographics_City, P001N7_n60BR_Demographics_City, P001N7_A59BR_Demographics_Province, P001N7_n59BR_Demographics_Province, P001N7_A58BR_Demographics_Insurance, P001N7_n58BR_Demographics_Insurance,
               P001N7_A56BR_Demographics_Education, P001N7_n56BR_Demographics_Education, P001N7_A55BR_Demographics_Ethnic, P001N7_n55BR_Demographics_Ethnic, P001N7_A63BR_Demographics_MarritalStatus, P001N7_n63BR_Demographics_MarritalStatus, P001N7_A54BR_Demographics_Sex, P001N7_n54BR_Demographics_Sex, P001N7_A53BR_Demographics_BirthDate, P001N7_n53BR_Demographics_BirthDate,
               P001N7_A36BR_Information_PatientNo, P001N7_n36BR_Information_PatientNo, P001N7_A19BR_EncounterID, P001N7_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N8_A85BR_Information_ID, P001N8_n85BR_Information_ID, P001N8_A58BR_Demographics_Insurance, P001N8_n58BR_Demographics_Insurance, P001N8_A60BR_Demographics_City, P001N8_n60BR_Demographics_City, P001N8_A59BR_Demographics_Province, P001N8_n59BR_Demographics_Province, P001N8_A57BR_Demographics_Occupation, P001N8_n57BR_Demographics_Occupation,
               P001N8_A56BR_Demographics_Education, P001N8_n56BR_Demographics_Education, P001N8_A55BR_Demographics_Ethnic, P001N8_n55BR_Demographics_Ethnic, P001N8_A63BR_Demographics_MarritalStatus, P001N8_n63BR_Demographics_MarritalStatus, P001N8_A54BR_Demographics_Sex, P001N8_n54BR_Demographics_Sex, P001N8_A53BR_Demographics_BirthDate, P001N8_n53BR_Demographics_BirthDate,
               P001N8_A36BR_Information_PatientNo, P001N8_n36BR_Information_PatientNo, P001N8_A19BR_EncounterID, P001N8_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N9_A85BR_Information_ID, P001N9_n85BR_Information_ID, P001N9_A59BR_Demographics_Province, P001N9_n59BR_Demographics_Province, P001N9_A60BR_Demographics_City, P001N9_n60BR_Demographics_City, P001N9_A58BR_Demographics_Insurance, P001N9_n58BR_Demographics_Insurance, P001N9_A57BR_Demographics_Occupation, P001N9_n57BR_Demographics_Occupation,
               P001N9_A56BR_Demographics_Education, P001N9_n56BR_Demographics_Education, P001N9_A55BR_Demographics_Ethnic, P001N9_n55BR_Demographics_Ethnic, P001N9_A63BR_Demographics_MarritalStatus, P001N9_n63BR_Demographics_MarritalStatus, P001N9_A54BR_Demographics_Sex, P001N9_n54BR_Demographics_Sex, P001N9_A53BR_Demographics_BirthDate, P001N9_n53BR_Demographics_BirthDate,
               P001N9_A36BR_Information_PatientNo, P001N9_n36BR_Information_PatientNo, P001N9_A19BR_EncounterID, P001N9_A61BR_Demographics_ID
               }
               , new Object[] {
               P001N10_A85BR_Information_ID, P001N10_n85BR_Information_ID, P001N10_A60BR_Demographics_City, P001N10_n60BR_Demographics_City, P001N10_A59BR_Demographics_Province, P001N10_n59BR_Demographics_Province, P001N10_A58BR_Demographics_Insurance, P001N10_n58BR_Demographics_Insurance, P001N10_A57BR_Demographics_Occupation, P001N10_n57BR_Demographics_Occupation,
               P001N10_A56BR_Demographics_Education, P001N10_n56BR_Demographics_Education, P001N10_A55BR_Demographics_Ethnic, P001N10_n55BR_Demographics_Ethnic, P001N10_A63BR_Demographics_MarritalStatus, P001N10_n63BR_Demographics_MarritalStatus, P001N10_A54BR_Demographics_Sex, P001N10_n54BR_Demographics_Sex, P001N10_A53BR_Demographics_BirthDate, P001N10_n53BR_Demographics_BirthDate,
               P001N10_A36BR_Information_PatientNo, P001N10_n36BR_Information_PatientNo, P001N10_A19BR_EncounterID, P001N10_A61BR_Demographics_ID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV72GXV1 ;
      private long AV11TFBR_Demographics_ID ;
      private long AV12TFBR_Demographics_ID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ;
      private long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ;
      private long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ;
      private long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ;
      private long A61BR_Demographics_ID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV51count ;
      private String scmdbuf ;
      private DateTime AV19TFBR_Demographics_BirthDate ;
      private DateTime AV20TFBR_Demographics_BirthDate_To ;
      private DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ;
      private DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ;
      private DateTime A53BR_Demographics_BirthDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK1N2 ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool n60BR_Demographics_City ;
      private bool n59BR_Demographics_Province ;
      private bool n58BR_Demographics_Insurance ;
      private bool n57BR_Demographics_Occupation ;
      private bool n56BR_Demographics_Education ;
      private bool n55BR_Demographics_Ethnic ;
      private bool n63BR_Demographics_MarritalStatus ;
      private bool n54BR_Demographics_Sex ;
      private bool n53BR_Demographics_BirthDate ;
      private bool BRK1N4 ;
      private bool BRK1N6 ;
      private bool BRK1N8 ;
      private bool BRK1N10 ;
      private bool BRK1N12 ;
      private bool BRK1N14 ;
      private bool BRK1N16 ;
      private bool BRK1N18 ;
      private String AV50OptionIndexesJson ;
      private String AV45OptionsJson ;
      private String AV48OptionsDescJson ;
      private String AV41DDOName ;
      private String AV39SearchTxt ;
      private String AV40SearchTxtTo ;
      private String AV17TFBR_Information_PatientNo ;
      private String AV18TFBR_Information_PatientNo_Sel ;
      private String AV57TFBR_Demographics_Sex ;
      private String AV66TFBR_Demographics_Sex_Sel ;
      private String AV25TFBR_Demographics_MarritalStatus ;
      private String AV26TFBR_Demographics_MarritalStatus_Sel ;
      private String AV60TFBR_Demographics_Ethnic ;
      private String AV67TFBR_Demographics_Ethnic_Sel ;
      private String AV62TFBR_Demographics_Education ;
      private String AV68TFBR_Demographics_Education_Sel ;
      private String AV31TFBR_Demographics_Occupation ;
      private String AV32TFBR_Demographics_Occupation_Sel ;
      private String AV64TFBR_Demographics_Insurance ;
      private String AV69TFBR_Demographics_Insurance_Sel ;
      private String AV35TFBR_Demographics_Province ;
      private String AV36TFBR_Demographics_Province_Sel ;
      private String AV37TFBR_Demographics_City ;
      private String AV38TFBR_Demographics_City_Sel ;
      private String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ;
      private String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ;
      private String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ;
      private String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ;
      private String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ;
      private String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ;
      private String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ;
      private String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ;
      private String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ;
      private String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ;
      private String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ;
      private String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ;
      private String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ;
      private String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ;
      private String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ;
      private String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ;
      private String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ;
      private String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ;
      private String lV78BR_DemographicsWWDS_5_Tfbr_information_patientno ;
      private String lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ;
      private String lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ;
      private String lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ;
      private String lV88BR_DemographicsWWDS_15_Tfbr_demographics_education ;
      private String lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ;
      private String lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ;
      private String lV94BR_DemographicsWWDS_21_Tfbr_demographics_province ;
      private String lV96BR_DemographicsWWDS_23_Tfbr_demographics_city ;
      private String A36BR_Information_PatientNo ;
      private String A54BR_Demographics_Sex ;
      private String A63BR_Demographics_MarritalStatus ;
      private String A55BR_Demographics_Ethnic ;
      private String A56BR_Demographics_Education ;
      private String A57BR_Demographics_Occupation ;
      private String A58BR_Demographics_Insurance ;
      private String A59BR_Demographics_Province ;
      private String A60BR_Demographics_City ;
      private String AV43Option ;
      private IGxSession AV52Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P001N2_A85BR_Information_ID ;
      private bool[] P001N2_n85BR_Information_ID ;
      private String[] P001N2_A36BR_Information_PatientNo ;
      private bool[] P001N2_n36BR_Information_PatientNo ;
      private String[] P001N2_A60BR_Demographics_City ;
      private bool[] P001N2_n60BR_Demographics_City ;
      private String[] P001N2_A59BR_Demographics_Province ;
      private bool[] P001N2_n59BR_Demographics_Province ;
      private String[] P001N2_A58BR_Demographics_Insurance ;
      private bool[] P001N2_n58BR_Demographics_Insurance ;
      private String[] P001N2_A57BR_Demographics_Occupation ;
      private bool[] P001N2_n57BR_Demographics_Occupation ;
      private String[] P001N2_A56BR_Demographics_Education ;
      private bool[] P001N2_n56BR_Demographics_Education ;
      private String[] P001N2_A55BR_Demographics_Ethnic ;
      private bool[] P001N2_n55BR_Demographics_Ethnic ;
      private String[] P001N2_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N2_n63BR_Demographics_MarritalStatus ;
      private String[] P001N2_A54BR_Demographics_Sex ;
      private bool[] P001N2_n54BR_Demographics_Sex ;
      private DateTime[] P001N2_A53BR_Demographics_BirthDate ;
      private bool[] P001N2_n53BR_Demographics_BirthDate ;
      private long[] P001N2_A19BR_EncounterID ;
      private long[] P001N2_A61BR_Demographics_ID ;
      private long[] P001N3_A85BR_Information_ID ;
      private bool[] P001N3_n85BR_Information_ID ;
      private String[] P001N3_A54BR_Demographics_Sex ;
      private bool[] P001N3_n54BR_Demographics_Sex ;
      private String[] P001N3_A60BR_Demographics_City ;
      private bool[] P001N3_n60BR_Demographics_City ;
      private String[] P001N3_A59BR_Demographics_Province ;
      private bool[] P001N3_n59BR_Demographics_Province ;
      private String[] P001N3_A58BR_Demographics_Insurance ;
      private bool[] P001N3_n58BR_Demographics_Insurance ;
      private String[] P001N3_A57BR_Demographics_Occupation ;
      private bool[] P001N3_n57BR_Demographics_Occupation ;
      private String[] P001N3_A56BR_Demographics_Education ;
      private bool[] P001N3_n56BR_Demographics_Education ;
      private String[] P001N3_A55BR_Demographics_Ethnic ;
      private bool[] P001N3_n55BR_Demographics_Ethnic ;
      private String[] P001N3_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N3_n63BR_Demographics_MarritalStatus ;
      private DateTime[] P001N3_A53BR_Demographics_BirthDate ;
      private bool[] P001N3_n53BR_Demographics_BirthDate ;
      private String[] P001N3_A36BR_Information_PatientNo ;
      private bool[] P001N3_n36BR_Information_PatientNo ;
      private long[] P001N3_A19BR_EncounterID ;
      private long[] P001N3_A61BR_Demographics_ID ;
      private long[] P001N4_A85BR_Information_ID ;
      private bool[] P001N4_n85BR_Information_ID ;
      private String[] P001N4_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N4_n63BR_Demographics_MarritalStatus ;
      private String[] P001N4_A60BR_Demographics_City ;
      private bool[] P001N4_n60BR_Demographics_City ;
      private String[] P001N4_A59BR_Demographics_Province ;
      private bool[] P001N4_n59BR_Demographics_Province ;
      private String[] P001N4_A58BR_Demographics_Insurance ;
      private bool[] P001N4_n58BR_Demographics_Insurance ;
      private String[] P001N4_A57BR_Demographics_Occupation ;
      private bool[] P001N4_n57BR_Demographics_Occupation ;
      private String[] P001N4_A56BR_Demographics_Education ;
      private bool[] P001N4_n56BR_Demographics_Education ;
      private String[] P001N4_A55BR_Demographics_Ethnic ;
      private bool[] P001N4_n55BR_Demographics_Ethnic ;
      private String[] P001N4_A54BR_Demographics_Sex ;
      private bool[] P001N4_n54BR_Demographics_Sex ;
      private DateTime[] P001N4_A53BR_Demographics_BirthDate ;
      private bool[] P001N4_n53BR_Demographics_BirthDate ;
      private String[] P001N4_A36BR_Information_PatientNo ;
      private bool[] P001N4_n36BR_Information_PatientNo ;
      private long[] P001N4_A19BR_EncounterID ;
      private long[] P001N4_A61BR_Demographics_ID ;
      private long[] P001N5_A85BR_Information_ID ;
      private bool[] P001N5_n85BR_Information_ID ;
      private String[] P001N5_A55BR_Demographics_Ethnic ;
      private bool[] P001N5_n55BR_Demographics_Ethnic ;
      private String[] P001N5_A60BR_Demographics_City ;
      private bool[] P001N5_n60BR_Demographics_City ;
      private String[] P001N5_A59BR_Demographics_Province ;
      private bool[] P001N5_n59BR_Demographics_Province ;
      private String[] P001N5_A58BR_Demographics_Insurance ;
      private bool[] P001N5_n58BR_Demographics_Insurance ;
      private String[] P001N5_A57BR_Demographics_Occupation ;
      private bool[] P001N5_n57BR_Demographics_Occupation ;
      private String[] P001N5_A56BR_Demographics_Education ;
      private bool[] P001N5_n56BR_Demographics_Education ;
      private String[] P001N5_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N5_n63BR_Demographics_MarritalStatus ;
      private String[] P001N5_A54BR_Demographics_Sex ;
      private bool[] P001N5_n54BR_Demographics_Sex ;
      private DateTime[] P001N5_A53BR_Demographics_BirthDate ;
      private bool[] P001N5_n53BR_Demographics_BirthDate ;
      private String[] P001N5_A36BR_Information_PatientNo ;
      private bool[] P001N5_n36BR_Information_PatientNo ;
      private long[] P001N5_A19BR_EncounterID ;
      private long[] P001N5_A61BR_Demographics_ID ;
      private long[] P001N6_A85BR_Information_ID ;
      private bool[] P001N6_n85BR_Information_ID ;
      private String[] P001N6_A56BR_Demographics_Education ;
      private bool[] P001N6_n56BR_Demographics_Education ;
      private String[] P001N6_A60BR_Demographics_City ;
      private bool[] P001N6_n60BR_Demographics_City ;
      private String[] P001N6_A59BR_Demographics_Province ;
      private bool[] P001N6_n59BR_Demographics_Province ;
      private String[] P001N6_A58BR_Demographics_Insurance ;
      private bool[] P001N6_n58BR_Demographics_Insurance ;
      private String[] P001N6_A57BR_Demographics_Occupation ;
      private bool[] P001N6_n57BR_Demographics_Occupation ;
      private String[] P001N6_A55BR_Demographics_Ethnic ;
      private bool[] P001N6_n55BR_Demographics_Ethnic ;
      private String[] P001N6_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N6_n63BR_Demographics_MarritalStatus ;
      private String[] P001N6_A54BR_Demographics_Sex ;
      private bool[] P001N6_n54BR_Demographics_Sex ;
      private DateTime[] P001N6_A53BR_Demographics_BirthDate ;
      private bool[] P001N6_n53BR_Demographics_BirthDate ;
      private String[] P001N6_A36BR_Information_PatientNo ;
      private bool[] P001N6_n36BR_Information_PatientNo ;
      private long[] P001N6_A19BR_EncounterID ;
      private long[] P001N6_A61BR_Demographics_ID ;
      private long[] P001N7_A85BR_Information_ID ;
      private bool[] P001N7_n85BR_Information_ID ;
      private String[] P001N7_A57BR_Demographics_Occupation ;
      private bool[] P001N7_n57BR_Demographics_Occupation ;
      private String[] P001N7_A60BR_Demographics_City ;
      private bool[] P001N7_n60BR_Demographics_City ;
      private String[] P001N7_A59BR_Demographics_Province ;
      private bool[] P001N7_n59BR_Demographics_Province ;
      private String[] P001N7_A58BR_Demographics_Insurance ;
      private bool[] P001N7_n58BR_Demographics_Insurance ;
      private String[] P001N7_A56BR_Demographics_Education ;
      private bool[] P001N7_n56BR_Demographics_Education ;
      private String[] P001N7_A55BR_Demographics_Ethnic ;
      private bool[] P001N7_n55BR_Demographics_Ethnic ;
      private String[] P001N7_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N7_n63BR_Demographics_MarritalStatus ;
      private String[] P001N7_A54BR_Demographics_Sex ;
      private bool[] P001N7_n54BR_Demographics_Sex ;
      private DateTime[] P001N7_A53BR_Demographics_BirthDate ;
      private bool[] P001N7_n53BR_Demographics_BirthDate ;
      private String[] P001N7_A36BR_Information_PatientNo ;
      private bool[] P001N7_n36BR_Information_PatientNo ;
      private long[] P001N7_A19BR_EncounterID ;
      private long[] P001N7_A61BR_Demographics_ID ;
      private long[] P001N8_A85BR_Information_ID ;
      private bool[] P001N8_n85BR_Information_ID ;
      private String[] P001N8_A58BR_Demographics_Insurance ;
      private bool[] P001N8_n58BR_Demographics_Insurance ;
      private String[] P001N8_A60BR_Demographics_City ;
      private bool[] P001N8_n60BR_Demographics_City ;
      private String[] P001N8_A59BR_Demographics_Province ;
      private bool[] P001N8_n59BR_Demographics_Province ;
      private String[] P001N8_A57BR_Demographics_Occupation ;
      private bool[] P001N8_n57BR_Demographics_Occupation ;
      private String[] P001N8_A56BR_Demographics_Education ;
      private bool[] P001N8_n56BR_Demographics_Education ;
      private String[] P001N8_A55BR_Demographics_Ethnic ;
      private bool[] P001N8_n55BR_Demographics_Ethnic ;
      private String[] P001N8_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N8_n63BR_Demographics_MarritalStatus ;
      private String[] P001N8_A54BR_Demographics_Sex ;
      private bool[] P001N8_n54BR_Demographics_Sex ;
      private DateTime[] P001N8_A53BR_Demographics_BirthDate ;
      private bool[] P001N8_n53BR_Demographics_BirthDate ;
      private String[] P001N8_A36BR_Information_PatientNo ;
      private bool[] P001N8_n36BR_Information_PatientNo ;
      private long[] P001N8_A19BR_EncounterID ;
      private long[] P001N8_A61BR_Demographics_ID ;
      private long[] P001N9_A85BR_Information_ID ;
      private bool[] P001N9_n85BR_Information_ID ;
      private String[] P001N9_A59BR_Demographics_Province ;
      private bool[] P001N9_n59BR_Demographics_Province ;
      private String[] P001N9_A60BR_Demographics_City ;
      private bool[] P001N9_n60BR_Demographics_City ;
      private String[] P001N9_A58BR_Demographics_Insurance ;
      private bool[] P001N9_n58BR_Demographics_Insurance ;
      private String[] P001N9_A57BR_Demographics_Occupation ;
      private bool[] P001N9_n57BR_Demographics_Occupation ;
      private String[] P001N9_A56BR_Demographics_Education ;
      private bool[] P001N9_n56BR_Demographics_Education ;
      private String[] P001N9_A55BR_Demographics_Ethnic ;
      private bool[] P001N9_n55BR_Demographics_Ethnic ;
      private String[] P001N9_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N9_n63BR_Demographics_MarritalStatus ;
      private String[] P001N9_A54BR_Demographics_Sex ;
      private bool[] P001N9_n54BR_Demographics_Sex ;
      private DateTime[] P001N9_A53BR_Demographics_BirthDate ;
      private bool[] P001N9_n53BR_Demographics_BirthDate ;
      private String[] P001N9_A36BR_Information_PatientNo ;
      private bool[] P001N9_n36BR_Information_PatientNo ;
      private long[] P001N9_A19BR_EncounterID ;
      private long[] P001N9_A61BR_Demographics_ID ;
      private long[] P001N10_A85BR_Information_ID ;
      private bool[] P001N10_n85BR_Information_ID ;
      private String[] P001N10_A60BR_Demographics_City ;
      private bool[] P001N10_n60BR_Demographics_City ;
      private String[] P001N10_A59BR_Demographics_Province ;
      private bool[] P001N10_n59BR_Demographics_Province ;
      private String[] P001N10_A58BR_Demographics_Insurance ;
      private bool[] P001N10_n58BR_Demographics_Insurance ;
      private String[] P001N10_A57BR_Demographics_Occupation ;
      private bool[] P001N10_n57BR_Demographics_Occupation ;
      private String[] P001N10_A56BR_Demographics_Education ;
      private bool[] P001N10_n56BR_Demographics_Education ;
      private String[] P001N10_A55BR_Demographics_Ethnic ;
      private bool[] P001N10_n55BR_Demographics_Ethnic ;
      private String[] P001N10_A63BR_Demographics_MarritalStatus ;
      private bool[] P001N10_n63BR_Demographics_MarritalStatus ;
      private String[] P001N10_A54BR_Demographics_Sex ;
      private bool[] P001N10_n54BR_Demographics_Sex ;
      private DateTime[] P001N10_A53BR_Demographics_BirthDate ;
      private bool[] P001N10_n53BR_Demographics_BirthDate ;
      private String[] P001N10_A36BR_Information_PatientNo ;
      private bool[] P001N10_n36BR_Information_PatientNo ;
      private long[] P001N10_A19BR_EncounterID ;
      private long[] P001N10_A61BR_Demographics_ID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV44Options ;
      private GxSimpleCollection<String> AV47OptionsDesc ;
      private GxSimpleCollection<String> AV49OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV54GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV55GridStateFilterValue ;
   }

   public class br_demographicswwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001N2( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [24] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T3.[BR_Information_PatientNo], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int2[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int2[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int2[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int2[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int2[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int2[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int2[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
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

      protected Object[] conditional_P001N3( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [24] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Sex], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int4[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int4[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int4[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int4[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int4[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int4[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int4[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int4[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int4[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Sex]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P001N4( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [24] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int6[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int6[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int6[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int6[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int6[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int6[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int6[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int6[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int6[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int6[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_MarritalStatus]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P001N5( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [24] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int8[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int8[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int8[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int8[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int8[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int8[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int8[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int8[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int8[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int8[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int8[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int8[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Ethnic]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      protected Object[] conditional_P001N6( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [24] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Education], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int10[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int10[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int10[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int10[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int10[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int10[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int10[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int10[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int10[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int10[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int10[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int10[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int10[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int10[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int10[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int10[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int10[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int10[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int10[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int10[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int10[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int10[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int10[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int10[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Education]";
         GXv_Object11[0] = scmdbuf;
         GXv_Object11[1] = GXv_int10;
         return GXv_Object11 ;
      }

      protected Object[] conditional_P001N7( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int12 ;
         GXv_int12 = new short [24] ;
         Object[] GXv_Object13 ;
         GXv_Object13 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int12[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int12[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int12[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int12[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int12[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int12[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int12[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int12[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int12[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int12[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int12[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int12[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int12[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int12[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int12[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int12[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int12[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int12[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int12[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int12[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int12[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int12[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int12[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int12[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Occupation]";
         GXv_Object13[0] = scmdbuf;
         GXv_Object13[1] = GXv_int12;
         return GXv_Object13 ;
      }

      protected Object[] conditional_P001N8( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int14 ;
         GXv_int14 = new short [24] ;
         Object[] GXv_Object15 ;
         GXv_Object15 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int14[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int14[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int14[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int14[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int14[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int14[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int14[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int14[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int14[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int14[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int14[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int14[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int14[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int14[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int14[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int14[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int14[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int14[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int14[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int14[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int14[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int14[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int14[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int14[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Insurance]";
         GXv_Object15[0] = scmdbuf;
         GXv_Object15[1] = GXv_int14;
         return GXv_Object15 ;
      }

      protected Object[] conditional_P001N9( IGxContext context ,
                                             long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                             long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                             long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                             long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                             String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                             DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                             DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                             String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                             String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                             String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                             String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                             String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                             String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                             String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                             String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                             String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                             String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                             String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                             String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                             String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                             String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                             String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                             String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                             long A61BR_Demographics_ID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A53BR_Demographics_BirthDate ,
                                             String A54BR_Demographics_Sex ,
                                             String A63BR_Demographics_MarritalStatus ,
                                             String A55BR_Demographics_Ethnic ,
                                             String A56BR_Demographics_Education ,
                                             String A57BR_Demographics_Occupation ,
                                             String A58BR_Demographics_Insurance ,
                                             String A59BR_Demographics_Province ,
                                             String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int16 ;
         GXv_int16 = new short [24] ;
         Object[] GXv_Object17 ;
         GXv_Object17 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_Province], T1.[BR_Demographics_City], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int16[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int16[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int16[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int16[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int16[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int16[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int16[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int16[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int16[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int16[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int16[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int16[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int16[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int16[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int16[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int16[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int16[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int16[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int16[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int16[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int16[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int16[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int16[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int16[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_Province]";
         GXv_Object17[0] = scmdbuf;
         GXv_Object17[1] = GXv_int16;
         return GXv_Object17 ;
      }

      protected Object[] conditional_P001N10( IGxContext context ,
                                              long AV74BR_DemographicsWWDS_1_Tfbr_demographics_id ,
                                              long AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to ,
                                              long AV76BR_DemographicsWWDS_3_Tfbr_encounterid ,
                                              long AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to ,
                                              String AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel ,
                                              String AV78BR_DemographicsWWDS_5_Tfbr_information_patientno ,
                                              DateTime AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate ,
                                              DateTime AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to ,
                                              String AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel ,
                                              String AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex ,
                                              String AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel ,
                                              String AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus ,
                                              String AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel ,
                                              String AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic ,
                                              String AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel ,
                                              String AV88BR_DemographicsWWDS_15_Tfbr_demographics_education ,
                                              String AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel ,
                                              String AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation ,
                                              String AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel ,
                                              String AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance ,
                                              String AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel ,
                                              String AV94BR_DemographicsWWDS_21_Tfbr_demographics_province ,
                                              String AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel ,
                                              String AV96BR_DemographicsWWDS_23_Tfbr_demographics_city ,
                                              long A61BR_Demographics_ID ,
                                              long A19BR_EncounterID ,
                                              String A36BR_Information_PatientNo ,
                                              DateTime A53BR_Demographics_BirthDate ,
                                              String A54BR_Demographics_Sex ,
                                              String A63BR_Demographics_MarritalStatus ,
                                              String A55BR_Demographics_Ethnic ,
                                              String A56BR_Demographics_Education ,
                                              String A57BR_Demographics_Occupation ,
                                              String A58BR_Demographics_Insurance ,
                                              String A59BR_Demographics_Province ,
                                              String A60BR_Demographics_City )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int18 ;
         GXv_int18 = new short [24] ;
         Object[] GXv_Object19 ;
         GXv_Object19 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Information_ID], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID] FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV74BR_DemographicsWWDS_1_Tfbr_demographics_id) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] >= @AV74BR_DemographicsWWDS_1_Tfbr_demographics_id)";
            }
         }
         else
         {
            GXv_int18[0] = 1;
         }
         if ( ! (0==AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_ID] <= @AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to)";
            }
         }
         else
         {
            GXv_int18[1] = 1;
         }
         if ( ! (0==AV76BR_DemographicsWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV76BR_DemographicsWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int18[2] = 1;
         }
         if ( ! (0==AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int18[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV78BR_DemographicsWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV78BR_DemographicsWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int18[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int18[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] >= @AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate)";
            }
         }
         else
         {
            GXv_int18[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_BirthDate] <= @AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to)";
            }
         }
         else
         {
            GXv_int18[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] like @lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex)";
            }
         }
         else
         {
            GXv_int18[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Sex] = @AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel)";
            }
         }
         else
         {
            GXv_int18[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] like @lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus)";
            }
         }
         else
         {
            GXv_int18[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_MarritalStatus] = @AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel)";
            }
         }
         else
         {
            GXv_int18[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] like @lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic)";
            }
         }
         else
         {
            GXv_int18[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Ethnic] = @AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel)";
            }
         }
         else
         {
            GXv_int18[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_DemographicsWWDS_15_Tfbr_demographics_education)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] like @lV88BR_DemographicsWWDS_15_Tfbr_demographics_education)";
            }
         }
         else
         {
            GXv_int18[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Education] = @AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel)";
            }
         }
         else
         {
            GXv_int18[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] like @lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation)";
            }
         }
         else
         {
            GXv_int18[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Occupation] = @AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel)";
            }
         }
         else
         {
            GXv_int18[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] like @lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance)";
            }
         }
         else
         {
            GXv_int18[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Insurance] = @AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel)";
            }
         }
         else
         {
            GXv_int18[19] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV94BR_DemographicsWWDS_21_Tfbr_demographics_province)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] like @lV94BR_DemographicsWWDS_21_Tfbr_demographics_province)";
            }
         }
         else
         {
            GXv_int18[20] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_Province] = @AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel)";
            }
         }
         else
         {
            GXv_int18[21] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV96BR_DemographicsWWDS_23_Tfbr_demographics_city)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] like @lV96BR_DemographicsWWDS_23_Tfbr_demographics_city)";
            }
         }
         else
         {
            GXv_int18[22] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Demographics_City] = @AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel)";
            }
         }
         else
         {
            GXv_int18[23] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_Demographics_City]";
         GXv_Object19[0] = scmdbuf;
         GXv_Object19[1] = GXv_int18;
         return GXv_Object19 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001N2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 1 :
                     return conditional_P001N3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 2 :
                     return conditional_P001N4(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 3 :
                     return conditional_P001N5(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 4 :
                     return conditional_P001N6(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 5 :
                     return conditional_P001N7(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 6 :
                     return conditional_P001N8(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 7 :
                     return conditional_P001N9(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
               case 8 :
                     return conditional_P001N10(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (DateTime)dynConstraints[6] , (DateTime)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (long)dynConstraints[24] , (long)dynConstraints[25] , (String)dynConstraints[26] , (DateTime)dynConstraints[27] , (String)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (String)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (String)dynConstraints[34] , (String)dynConstraints[35] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001N2 ;
          prmP001N2 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N3 ;
          prmP001N3 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N4 ;
          prmP001N4 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N5 ;
          prmP001N5 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N6 ;
          prmP001N6 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N7 ;
          prmP001N7 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N8 ;
          prmP001N8 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N9 ;
          prmP001N9 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP001N10 ;
          prmP001N10 = new Object[] {
          new Object[] {"@AV74BR_DemographicsWWDS_1_Tfbr_demographics_id",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV75BR_DemographicsWWDS_2_Tfbr_demographics_id_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76BR_DemographicsWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV77BR_DemographicsWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV78BR_DemographicsWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV79BR_DemographicsWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV80BR_DemographicsWWDS_7_Tfbr_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV81BR_DemographicsWWDS_8_Tfbr_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV82BR_DemographicsWWDS_9_Tfbr_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV83BR_DemographicsWWDS_10_Tfbr_demographics_sex_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV84BR_DemographicsWWDS_11_Tfbr_demographics_marritalstatus",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_DemographicsWWDS_12_Tfbr_demographics_marritalstatus_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV86BR_DemographicsWWDS_13_Tfbr_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV87BR_DemographicsWWDS_14_Tfbr_demographics_ethnic_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV88BR_DemographicsWWDS_15_Tfbr_demographics_education",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_DemographicsWWDS_16_Tfbr_demographics_education_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV90BR_DemographicsWWDS_17_Tfbr_demographics_occupation",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV91BR_DemographicsWWDS_18_Tfbr_demographics_occupation_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV92BR_DemographicsWWDS_19_Tfbr_demographics_insurance",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV93BR_DemographicsWWDS_20_Tfbr_demographics_insurance_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV94BR_DemographicsWWDS_21_Tfbr_demographics_province",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV95BR_DemographicsWWDS_22_Tfbr_demographics_province_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV96BR_DemographicsWWDS_23_Tfbr_demographics_city",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV97BR_DemographicsWWDS_24_Tfbr_demographics_city_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N2,100,0,true,false )
             ,new CursorDef("P001N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N3,100,0,true,false )
             ,new CursorDef("P001N4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N4,100,0,true,false )
             ,new CursorDef("P001N5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N5,100,0,true,false )
             ,new CursorDef("P001N6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N6,100,0,true,false )
             ,new CursorDef("P001N7", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N7,100,0,true,false )
             ,new CursorDef("P001N8", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N8,100,0,true,false )
             ,new CursorDef("P001N9", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N9,100,0,true,false )
             ,new CursorDef("P001N10", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001N10,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((DateTime[]) buf[20])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 3 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 4 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 5 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 7 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
                return;
             case 8 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 2 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 3 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 4 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 5 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 6 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 7 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
             case 8 :
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
                   stmt.SetParameter(sIdx, (DateTime)parms[30]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[37]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[40]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_demographicswwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_demographicswwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_demographicswwgetfilterdata") )
          {
             return  ;
          }
          br_demographicswwgetfilterdata worker = new br_demographicswwgetfilterdata(context) ;
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
