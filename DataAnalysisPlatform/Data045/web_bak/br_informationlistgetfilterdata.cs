/*
               File: BR_InformationListGetFilterData
        Description: BR_Information List Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:41.56
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
   public class br_informationlistgetfilterdata : GXProcedure
   {
      public br_informationlistgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_informationlistgetfilterdata( IGxContext context )
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
         this.AV21DDOName = aP0_DDOName;
         this.AV19SearchTxt = aP1_SearchTxt;
         this.AV20SearchTxtTo = aP2_SearchTxtTo;
         this.AV25OptionsJson = "" ;
         this.AV28OptionsDescJson = "" ;
         this.AV30OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV21DDOName = aP0_DDOName;
         this.AV19SearchTxt = aP1_SearchTxt;
         this.AV20SearchTxtTo = aP2_SearchTxtTo;
         this.AV25OptionsJson = "" ;
         this.AV28OptionsDescJson = "" ;
         this.AV30OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
         return AV30OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_informationlistgetfilterdata objbr_informationlistgetfilterdata;
         objbr_informationlistgetfilterdata = new br_informationlistgetfilterdata();
         objbr_informationlistgetfilterdata.AV21DDOName = aP0_DDOName;
         objbr_informationlistgetfilterdata.AV19SearchTxt = aP1_SearchTxt;
         objbr_informationlistgetfilterdata.AV20SearchTxtTo = aP2_SearchTxtTo;
         objbr_informationlistgetfilterdata.AV25OptionsJson = "" ;
         objbr_informationlistgetfilterdata.AV28OptionsDescJson = "" ;
         objbr_informationlistgetfilterdata.AV30OptionIndexesJson = "" ;
         objbr_informationlistgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_informationlistgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_informationlistgetfilterdata);
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_informationlistgetfilterdata)stateInfo).executePrivate();
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
         AV24Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV27OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV29OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_VIEW_LPI_BR_INFORMATION_PATIENTNO") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_LPI_BR_INFORMATION_PATIENTNOOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_VIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_LPI_BR_DEMOGRAPHICS_SEXOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_LPI_BR_DEMOGRAPHICS_ETHNICOPTIONS' */
            S141 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV25OptionsJson = AV24Options.ToJSonString(false);
         AV28OptionsDescJson = AV27OptionsDesc.ToJSonString(false);
         AV30OptionIndexesJson = AV29OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV32Session.Get("BR_InformationListGridState"), "") == 0 )
         {
            AV34GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_InformationListGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV34GridState.FromXml(AV32Session.Get("BR_InformationListGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV46GXV1 = 1;
         while ( AV46GXV1 <= AV34GridState.gxTpr_Filtervalues.Count )
         {
            AV35GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV34GridState.gxTpr_Filtervalues.Item(AV46GXV1));
            if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV37VIEW_LPI_BR_Information_PatientNo = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE") == 0 )
            {
               AV40VIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( AV35GridStateFilterValue.gxTpr_Value, 0);
               AV38VIEW_LPI_BR_Demographics_BirthDateOperator = AV35GridStateFilterValue.gxTpr_Operator;
               AV39VIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( AV35GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV41VIEW_LPI_BR_Demographics_Ethnic = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "VIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV42VIEW_LPI_BR_Demographics_Sex = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV11TFVIEW_LPI_BR_Information_PatientNo = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV12TFVIEW_LPI_BR_Information_PatientNo_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX") == 0 )
            {
               AV13TFVIEW_LPI_BR_Demographics_Sex = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_SEX_SEL") == 0 )
            {
               AV14TFVIEW_LPI_BR_Demographics_Sex_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_BIRTHDATE") == 0 )
            {
               AV15TFVIEW_LPI_BR_Demographics_BirthDate = context.localUtil.CToD( AV35GridStateFilterValue.gxTpr_Value, 0);
               AV16TFVIEW_LPI_BR_Demographics_BirthDate_To = context.localUtil.CToD( AV35GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC") == 0 )
            {
               AV17TFVIEW_LPI_BR_Demographics_Ethnic = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFVIEW_LPI_BR_DEMOGRAPHICS_ETHNIC_SEL") == 0 )
            {
               AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            AV46GXV1 = (int)(AV46GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_LPI_BR_INFORMATION_PATIENTNOOPTIONS' Routine */
         AV11TFVIEW_LPI_BR_Information_PatientNo = AV19SearchTxt;
         AV12TFVIEW_LPI_BR_Information_PatientNo_Sel = "";
         AV48BR_InformationListDS_1_View_lpi_br_information_patientno = AV37VIEW_LPI_BR_Information_PatientNo;
         AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV40VIEW_LPI_BR_Demographics_BirthDate;
         AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV39VIEW_LPI_BR_Demographics_BirthDate_To;
         AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV41VIEW_LPI_BR_Demographics_Ethnic;
         AV52BR_InformationListDS_5_View_lpi_br_demographics_sex = AV42VIEW_LPI_BR_Demographics_Sex;
         AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV11TFVIEW_LPI_BR_Information_PatientNo;
         AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV12TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV13TFVIEW_LPI_BR_Demographics_Sex;
         AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV14TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV15TFVIEW_LPI_BR_Demographics_BirthDate;
         AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV16TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV17TFVIEW_LPI_BR_Demographics_Ethnic;
         AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A520VIEW_LPI_BR_Information_ID ,
                                              AV43oBR_Information_ID ,
                                              AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                              AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                              AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                              AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                              AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                              AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                              AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                              AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                              AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                              AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                              AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                              AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                              AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                              AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                              A519VIEW_LPI_BR_Information_PatientNo ,
                                              A523VIEW_LPI_BR_Demographics_BirthDate ,
                                              A524VIEW_LPI_BR_Demographics_Ethnic ,
                                              A522VIEW_LPI_BR_Demographics_Sex } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV48BR_InformationListDS_1_View_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno), "%", "");
         lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno), "%", "");
         lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex), "%", "");
         lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic), "%", "");
         /* Using cursor P004F2 */
         pr_default.execute(0, new Object[] {lV48BR_InformationListDS_1_View_lpi_br_information_patientno, AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate, AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to, AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic, AV52BR_InformationListDS_5_View_lpi_br_demographics_sex, lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno, AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel, lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex, AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel, AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate, AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to, lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic, AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4F2 = false;
            A519VIEW_LPI_BR_Information_PatientNo = P004F2_A519VIEW_LPI_BR_Information_PatientNo[0];
            A520VIEW_LPI_BR_Information_ID = P004F2_A520VIEW_LPI_BR_Information_ID[0];
            A522VIEW_LPI_BR_Demographics_Sex = P004F2_A522VIEW_LPI_BR_Demographics_Sex[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = P004F2_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = P004F2_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            AV31count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004F2_A519VIEW_LPI_BR_Information_PatientNo[0], A519VIEW_LPI_BR_Information_PatientNo) == 0 ) )
            {
               BRK4F2 = false;
               A520VIEW_LPI_BR_Information_ID = P004F2_A520VIEW_LPI_BR_Information_ID[0];
               if ( (AV43oBR_Information_ID.IndexOf(A520VIEW_LPI_BR_Information_ID)>0) )
               {
                  AV31count = (long)(AV31count+1);
               }
               BRK4F2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A519VIEW_LPI_BR_Information_PatientNo)) )
            {
               AV23Option = A519VIEW_LPI_BR_Information_PatientNo;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4F2 )
            {
               BRK4F2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_LPI_BR_DEMOGRAPHICS_SEXOPTIONS' Routine */
         AV13TFVIEW_LPI_BR_Demographics_Sex = AV19SearchTxt;
         AV14TFVIEW_LPI_BR_Demographics_Sex_Sel = "";
         AV48BR_InformationListDS_1_View_lpi_br_information_patientno = AV37VIEW_LPI_BR_Information_PatientNo;
         AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV40VIEW_LPI_BR_Demographics_BirthDate;
         AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV39VIEW_LPI_BR_Demographics_BirthDate_To;
         AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV41VIEW_LPI_BR_Demographics_Ethnic;
         AV52BR_InformationListDS_5_View_lpi_br_demographics_sex = AV42VIEW_LPI_BR_Demographics_Sex;
         AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV11TFVIEW_LPI_BR_Information_PatientNo;
         AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV12TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV13TFVIEW_LPI_BR_Demographics_Sex;
         AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV14TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV15TFVIEW_LPI_BR_Demographics_BirthDate;
         AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV16TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV17TFVIEW_LPI_BR_Demographics_Ethnic;
         AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A520VIEW_LPI_BR_Information_ID ,
                                              AV43oBR_Information_ID ,
                                              AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                              AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                              AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                              AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                              AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                              AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                              AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                              AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                              AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                              AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                              AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                              AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                              AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                              AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                              A519VIEW_LPI_BR_Information_PatientNo ,
                                              A523VIEW_LPI_BR_Demographics_BirthDate ,
                                              A524VIEW_LPI_BR_Demographics_Ethnic ,
                                              A522VIEW_LPI_BR_Demographics_Sex } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV48BR_InformationListDS_1_View_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno), "%", "");
         lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno), "%", "");
         lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex), "%", "");
         lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic), "%", "");
         /* Using cursor P004F3 */
         pr_default.execute(1, new Object[] {lV48BR_InformationListDS_1_View_lpi_br_information_patientno, AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate, AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to, AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic, AV52BR_InformationListDS_5_View_lpi_br_demographics_sex, lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno, AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel, lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex, AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel, AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate, AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to, lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic, AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4F4 = false;
            A522VIEW_LPI_BR_Demographics_Sex = P004F3_A522VIEW_LPI_BR_Demographics_Sex[0];
            A520VIEW_LPI_BR_Information_ID = P004F3_A520VIEW_LPI_BR_Information_ID[0];
            A524VIEW_LPI_BR_Demographics_Ethnic = P004F3_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = P004F3_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A519VIEW_LPI_BR_Information_PatientNo = P004F3_A519VIEW_LPI_BR_Information_PatientNo[0];
            AV31count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004F3_A522VIEW_LPI_BR_Demographics_Sex[0], A522VIEW_LPI_BR_Demographics_Sex) == 0 ) )
            {
               BRK4F4 = false;
               A520VIEW_LPI_BR_Information_ID = P004F3_A520VIEW_LPI_BR_Information_ID[0];
               if ( (AV43oBR_Information_ID.IndexOf(A520VIEW_LPI_BR_Information_ID)>0) )
               {
                  AV31count = (long)(AV31count+1);
               }
               BRK4F4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A522VIEW_LPI_BR_Demographics_Sex)) )
            {
               AV23Option = A522VIEW_LPI_BR_Demographics_Sex;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4F4 )
            {
               BRK4F4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADVIEW_LPI_BR_DEMOGRAPHICS_ETHNICOPTIONS' Routine */
         AV17TFVIEW_LPI_BR_Demographics_Ethnic = AV19SearchTxt;
         AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "";
         AV48BR_InformationListDS_1_View_lpi_br_information_patientno = AV37VIEW_LPI_BR_Information_PatientNo;
         AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate = AV40VIEW_LPI_BR_Demographics_BirthDate;
         AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = AV39VIEW_LPI_BR_Demographics_BirthDate_To;
         AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic = AV41VIEW_LPI_BR_Demographics_Ethnic;
         AV52BR_InformationListDS_5_View_lpi_br_demographics_sex = AV42VIEW_LPI_BR_Demographics_Sex;
         AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = AV11TFVIEW_LPI_BR_Information_PatientNo;
         AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = AV12TFVIEW_LPI_BR_Information_PatientNo_Sel;
         AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = AV13TFVIEW_LPI_BR_Demographics_Sex;
         AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = AV14TFVIEW_LPI_BR_Demographics_Sex_Sel;
         AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = AV15TFVIEW_LPI_BR_Demographics_BirthDate;
         AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = AV16TFVIEW_LPI_BR_Demographics_BirthDate_To;
         AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = AV17TFVIEW_LPI_BR_Demographics_Ethnic;
         AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              A520VIEW_LPI_BR_Information_ID ,
                                              AV43oBR_Information_ID ,
                                              AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                              AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                              AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                              AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                              AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                              AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                              AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                              AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                              AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                              AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                              AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                              AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                              AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                              AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                              A519VIEW_LPI_BR_Information_PatientNo ,
                                              A523VIEW_LPI_BR_Demographics_BirthDate ,
                                              A524VIEW_LPI_BR_Demographics_Ethnic ,
                                              A522VIEW_LPI_BR_Demographics_Sex } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV48BR_InformationListDS_1_View_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno), "%", "");
         lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno), "%", "");
         lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = StringUtil.Concat( StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex), "%", "");
         lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = StringUtil.Concat( StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic), "%", "");
         /* Using cursor P004F4 */
         pr_default.execute(2, new Object[] {lV48BR_InformationListDS_1_View_lpi_br_information_patientno, AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate, AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to, AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic, AV52BR_InformationListDS_5_View_lpi_br_demographics_sex, lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno, AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel, lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex, AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel, AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate, AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to, lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic, AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK4F6 = false;
            A524VIEW_LPI_BR_Demographics_Ethnic = P004F4_A524VIEW_LPI_BR_Demographics_Ethnic[0];
            A520VIEW_LPI_BR_Information_ID = P004F4_A520VIEW_LPI_BR_Information_ID[0];
            A522VIEW_LPI_BR_Demographics_Sex = P004F4_A522VIEW_LPI_BR_Demographics_Sex[0];
            A523VIEW_LPI_BR_Demographics_BirthDate = P004F4_A523VIEW_LPI_BR_Demographics_BirthDate[0];
            A519VIEW_LPI_BR_Information_PatientNo = P004F4_A519VIEW_LPI_BR_Information_PatientNo[0];
            AV31count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P004F4_A524VIEW_LPI_BR_Demographics_Ethnic[0], A524VIEW_LPI_BR_Demographics_Ethnic) == 0 ) )
            {
               BRK4F6 = false;
               A520VIEW_LPI_BR_Information_ID = P004F4_A520VIEW_LPI_BR_Information_ID[0];
               if ( (AV43oBR_Information_ID.IndexOf(A520VIEW_LPI_BR_Information_ID)>0) )
               {
                  AV31count = (long)(AV31count+1);
               }
               BRK4F6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A524VIEW_LPI_BR_Demographics_Ethnic)) )
            {
               AV23Option = A524VIEW_LPI_BR_Demographics_Ethnic;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4F6 )
            {
               BRK4F6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
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
         AV24Options = new GxSimpleCollection<String>();
         AV27OptionsDesc = new GxSimpleCollection<String>();
         AV29OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV32Session = context.GetSession();
         AV34GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV35GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV37VIEW_LPI_BR_Information_PatientNo = "";
         AV40VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         AV39VIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
         AV41VIEW_LPI_BR_Demographics_Ethnic = "";
         AV42VIEW_LPI_BR_Demographics_Sex = "";
         AV11TFVIEW_LPI_BR_Information_PatientNo = "";
         AV12TFVIEW_LPI_BR_Information_PatientNo_Sel = "";
         AV13TFVIEW_LPI_BR_Demographics_Sex = "";
         AV14TFVIEW_LPI_BR_Demographics_Sex_Sel = "";
         AV15TFVIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         AV16TFVIEW_LPI_BR_Demographics_BirthDate_To = DateTime.MinValue;
         AV17TFVIEW_LPI_BR_Demographics_Ethnic = "";
         AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel = "";
         AV48BR_InformationListDS_1_View_lpi_br_information_patientno = "";
         AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate = DateTime.MinValue;
         AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to = DateTime.MinValue;
         AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic = "";
         AV52BR_InformationListDS_5_View_lpi_br_demographics_sex = "";
         AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = "";
         AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel = "";
         AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = "";
         AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel = "";
         AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate = DateTime.MinValue;
         AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to = DateTime.MinValue;
         AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = "";
         AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel = "";
         scmdbuf = "";
         lV48BR_InformationListDS_1_View_lpi_br_information_patientno = "";
         lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno = "";
         lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex = "";
         lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic = "";
         AV43oBR_Information_ID = new GxSimpleCollection<long>();
         A519VIEW_LPI_BR_Information_PatientNo = "";
         A523VIEW_LPI_BR_Demographics_BirthDate = DateTime.MinValue;
         A524VIEW_LPI_BR_Demographics_Ethnic = "";
         A522VIEW_LPI_BR_Demographics_Sex = "";
         P004F2_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         P004F2_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         P004F2_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         P004F2_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         P004F2_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         AV23Option = "";
         P004F3_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         P004F3_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         P004F3_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         P004F3_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P004F3_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         P004F4_A524VIEW_LPI_BR_Demographics_Ethnic = new String[] {""} ;
         P004F4_A520VIEW_LPI_BR_Information_ID = new long[1] ;
         P004F4_A522VIEW_LPI_BR_Demographics_Sex = new String[] {""} ;
         P004F4_A523VIEW_LPI_BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         P004F4_A519VIEW_LPI_BR_Information_PatientNo = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_informationlistgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004F2_A519VIEW_LPI_BR_Information_PatientNo, P004F2_A520VIEW_LPI_BR_Information_ID, P004F2_A522VIEW_LPI_BR_Demographics_Sex, P004F2_A524VIEW_LPI_BR_Demographics_Ethnic, P004F2_A523VIEW_LPI_BR_Demographics_BirthDate
               }
               , new Object[] {
               P004F3_A522VIEW_LPI_BR_Demographics_Sex, P004F3_A520VIEW_LPI_BR_Information_ID, P004F3_A524VIEW_LPI_BR_Demographics_Ethnic, P004F3_A523VIEW_LPI_BR_Demographics_BirthDate, P004F3_A519VIEW_LPI_BR_Information_PatientNo
               }
               , new Object[] {
               P004F4_A524VIEW_LPI_BR_Demographics_Ethnic, P004F4_A520VIEW_LPI_BR_Information_ID, P004F4_A522VIEW_LPI_BR_Demographics_Sex, P004F4_A523VIEW_LPI_BR_Demographics_BirthDate, P004F4_A519VIEW_LPI_BR_Information_PatientNo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV38VIEW_LPI_BR_Demographics_BirthDateOperator ;
      private int AV46GXV1 ;
      private long A520VIEW_LPI_BR_Information_ID ;
      private long AV31count ;
      private String scmdbuf ;
      private DateTime AV40VIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime AV39VIEW_LPI_BR_Demographics_BirthDate_To ;
      private DateTime AV15TFVIEW_LPI_BR_Demographics_BirthDate ;
      private DateTime AV16TFVIEW_LPI_BR_Demographics_BirthDate_To ;
      private DateTime AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ;
      private DateTime AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ;
      private DateTime AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ;
      private DateTime AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ;
      private DateTime A523VIEW_LPI_BR_Demographics_BirthDate ;
      private bool returnInSub ;
      private bool BRK4F2 ;
      private bool BRK4F4 ;
      private bool BRK4F6 ;
      private String AV30OptionIndexesJson ;
      private String AV25OptionsJson ;
      private String AV28OptionsDescJson ;
      private String AV21DDOName ;
      private String AV19SearchTxt ;
      private String AV20SearchTxtTo ;
      private String AV37VIEW_LPI_BR_Information_PatientNo ;
      private String AV41VIEW_LPI_BR_Demographics_Ethnic ;
      private String AV42VIEW_LPI_BR_Demographics_Sex ;
      private String AV11TFVIEW_LPI_BR_Information_PatientNo ;
      private String AV12TFVIEW_LPI_BR_Information_PatientNo_Sel ;
      private String AV13TFVIEW_LPI_BR_Demographics_Sex ;
      private String AV14TFVIEW_LPI_BR_Demographics_Sex_Sel ;
      private String AV17TFVIEW_LPI_BR_Demographics_Ethnic ;
      private String AV18TFVIEW_LPI_BR_Demographics_Ethnic_Sel ;
      private String AV48BR_InformationListDS_1_View_lpi_br_information_patientno ;
      private String AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ;
      private String AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ;
      private String AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ;
      private String AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ;
      private String AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ;
      private String AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ;
      private String AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ;
      private String AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ;
      private String lV48BR_InformationListDS_1_View_lpi_br_information_patientno ;
      private String lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ;
      private String lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ;
      private String lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ;
      private String A519VIEW_LPI_BR_Information_PatientNo ;
      private String A524VIEW_LPI_BR_Demographics_Ethnic ;
      private String A522VIEW_LPI_BR_Demographics_Sex ;
      private String AV23Option ;
      private GxSimpleCollection<long> AV43oBR_Information_ID ;
      private IGxSession AV32Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004F2_A519VIEW_LPI_BR_Information_PatientNo ;
      private long[] P004F2_A520VIEW_LPI_BR_Information_ID ;
      private String[] P004F2_A522VIEW_LPI_BR_Demographics_Sex ;
      private String[] P004F2_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private DateTime[] P004F2_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] P004F3_A522VIEW_LPI_BR_Demographics_Sex ;
      private long[] P004F3_A520VIEW_LPI_BR_Information_ID ;
      private String[] P004F3_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private DateTime[] P004F3_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] P004F3_A519VIEW_LPI_BR_Information_PatientNo ;
      private String[] P004F4_A524VIEW_LPI_BR_Demographics_Ethnic ;
      private long[] P004F4_A520VIEW_LPI_BR_Information_ID ;
      private String[] P004F4_A522VIEW_LPI_BR_Demographics_Sex ;
      private DateTime[] P004F4_A523VIEW_LPI_BR_Demographics_BirthDate ;
      private String[] P004F4_A519VIEW_LPI_BR_Information_PatientNo ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV24Options ;
      private GxSimpleCollection<String> AV27OptionsDesc ;
      private GxSimpleCollection<String> AV29OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV34GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV35GridStateFilterValue ;
   }

   public class br_informationlistgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004F2( IGxContext context ,
                                             long A520VIEW_LPI_BR_Information_ID ,
                                             GxSimpleCollection<long> AV43oBR_Information_ID ,
                                             String AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                             short AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                             DateTime AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                             DateTime AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                             String AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                             String AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                             String AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                             String AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                             String AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                             String AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                             DateTime AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                             DateTime AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                             String AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                             String AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                             String A519VIEW_LPI_BR_Information_PatientNo ,
                                             DateTime A523VIEW_LPI_BR_Demographics_BirthDate ,
                                             String A524VIEW_LPI_BR_Demographics_Ethnic ,
                                             String A522VIEW_LPI_BR_Demographics_Sex )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [13] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [VIEW_LPI_BR_Information_PatientNo], [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_Ethnic], [VIEW_LPI_BR_Demographics_BirthDate] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV43oBR_Information_ID, "[VIEW_LPI_BR_Information_ID] IN (", ")") + ")";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like '%' + @lV48BR_InformationListDS_1_View_lpi_br_information_patientno + '%')";
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like @lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] = @AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] like @lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int1[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)";
         }
         else
         {
            GXv_int1[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int1[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int1[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] like @lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int1[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)";
         }
         else
         {
            GXv_int1[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [VIEW_LPI_BR_Information_PatientNo]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004F3( IGxContext context ,
                                             long A520VIEW_LPI_BR_Information_ID ,
                                             GxSimpleCollection<long> AV43oBR_Information_ID ,
                                             String AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                             short AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                             DateTime AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                             DateTime AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                             String AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                             String AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                             String AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                             String AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                             String AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                             String AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                             DateTime AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                             DateTime AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                             String AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                             String AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                             String A519VIEW_LPI_BR_Information_PatientNo ,
                                             DateTime A523VIEW_LPI_BR_Demographics_BirthDate ,
                                             String A524VIEW_LPI_BR_Demographics_Ethnic ,
                                             String A522VIEW_LPI_BR_Demographics_Sex )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [13] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Demographics_Ethnic], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Information_PatientNo] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV43oBR_Information_ID, "[VIEW_LPI_BR_Information_ID] IN (", ")") + ")";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like '%' + @lV48BR_InformationListDS_1_View_lpi_br_information_patientno + '%')";
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like @lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] = @AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] like @lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] like @lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)";
         }
         else
         {
            GXv_int3[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [VIEW_LPI_BR_Demographics_Sex]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_P004F4( IGxContext context ,
                                             long A520VIEW_LPI_BR_Information_ID ,
                                             GxSimpleCollection<long> AV43oBR_Information_ID ,
                                             String AV48BR_InformationListDS_1_View_lpi_br_information_patientno ,
                                             short AV38VIEW_LPI_BR_Demographics_BirthDateOperator ,
                                             DateTime AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate ,
                                             DateTime AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to ,
                                             String AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic ,
                                             String AV52BR_InformationListDS_5_View_lpi_br_demographics_sex ,
                                             String AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel ,
                                             String AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno ,
                                             String AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel ,
                                             String AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex ,
                                             DateTime AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate ,
                                             DateTime AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to ,
                                             String AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel ,
                                             String AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic ,
                                             String A519VIEW_LPI_BR_Information_PatientNo ,
                                             DateTime A523VIEW_LPI_BR_Demographics_BirthDate ,
                                             String A524VIEW_LPI_BR_Demographics_Ethnic ,
                                             String A522VIEW_LPI_BR_Demographics_Sex )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [13] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT [VIEW_LPI_BR_Demographics_Ethnic], [VIEW_LPI_BR_Information_ID], [VIEW_LPI_BR_Demographics_Sex], [VIEW_LPI_BR_Demographics_BirthDate], [VIEW_LPI_BR_Information_PatientNo] FROM dbo.[view_lastest_patient_info] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV43oBR_Information_ID, "[VIEW_LPI_BR_Information_ID] IN (", ")") + ")";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_InformationListDS_1_View_lpi_br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like '%' + @lV48BR_InformationListDS_1_View_lpi_br_information_patientno + '%')";
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ( AV38VIEW_LPI_BR_Demographics_BirthDateOperator == 0 ) && ( ! (DateTime.MinValue==AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV52BR_InformationListDS_5_View_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] like @lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Information_PatientNo] = @AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] like @lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Sex] = @AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] >= @AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_BirthDate] <= @AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to)";
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)) ) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] like @lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic)";
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)) )
         {
            sWhereString = sWhereString + " and ([VIEW_LPI_BR_Demographics_Ethnic] = @AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel)";
         }
         else
         {
            GXv_int5[12] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [VIEW_LPI_BR_Demographics_Ethnic]";
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P004F2(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
               case 1 :
                     return conditional_P004F3(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
               case 2 :
                     return conditional_P004F4(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] , (DateTime)dynConstraints[4] , (DateTime)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP004F2 ;
          prmP004F2 = new Object[] {
          new Object[] {"@lV48BR_InformationListDS_1_View_lpi_br_information_patientno",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_InformationListDS_5_View_lpi_br_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004F3 ;
          prmP004F3 = new Object[] {
          new Object[] {"@lV48BR_InformationListDS_1_View_lpi_br_information_patientno",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_InformationListDS_5_View_lpi_br_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004F4 ;
          prmP004F4 = new Object[] {
          new Object[] {"@lV48BR_InformationListDS_1_View_lpi_br_information_patientno",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49BR_InformationListDS_2_View_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV50BR_InformationListDS_3_View_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV51BR_InformationListDS_4_View_lpi_br_demographics_ethnic",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_InformationListDS_5_View_lpi_br_demographics_sex",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_InformationListDS_6_Tfview_lpi_br_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV54BR_InformationListDS_7_Tfview_lpi_br_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV55BR_InformationListDS_8_Tfview_lpi_br_demographics_sex",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV56BR_InformationListDS_9_Tfview_lpi_br_demographics_sex_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV57BR_InformationListDS_10_Tfview_lpi_br_demographics_birthdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV58BR_InformationListDS_11_Tfview_lpi_br_demographics_birthdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV59BR_InformationListDS_12_Tfview_lpi_br_demographics_ethnic",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60BR_InformationListDS_13_Tfview_lpi_br_demographics_ethnic_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004F2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004F2,100,0,true,false )
             ,new CursorDef("P004F3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004F3,100,0,true,false )
             ,new CursorDef("P004F4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004F4,100,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_informationlistgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_informationlistgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_informationlistgetfilterdata") )
          {
             return  ;
          }
          br_informationlistgetfilterdata worker = new br_informationlistgetfilterdata(context) ;
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
