/*
               File: BR_Scheme_MedicationWWGetFilterData
        Description: BR_Scheme_Medication WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:15.44
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
   public class br_scheme_medicationwwgetfilterdata : GXProcedure
   {
      public br_scheme_medicationwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_medicationwwgetfilterdata( IGxContext context )
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
         this.AV27DDOName = aP0_DDOName;
         this.AV25SearchTxt = aP1_SearchTxt;
         this.AV26SearchTxtTo = aP2_SearchTxtTo;
         this.AV31OptionsJson = "" ;
         this.AV34OptionsDescJson = "" ;
         this.AV36OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV27DDOName = aP0_DDOName;
         this.AV25SearchTxt = aP1_SearchTxt;
         this.AV26SearchTxtTo = aP2_SearchTxtTo;
         this.AV31OptionsJson = "" ;
         this.AV34OptionsDescJson = "" ;
         this.AV36OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
         return AV36OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_scheme_medicationwwgetfilterdata objbr_scheme_medicationwwgetfilterdata;
         objbr_scheme_medicationwwgetfilterdata = new br_scheme_medicationwwgetfilterdata();
         objbr_scheme_medicationwwgetfilterdata.AV27DDOName = aP0_DDOName;
         objbr_scheme_medicationwwgetfilterdata.AV25SearchTxt = aP1_SearchTxt;
         objbr_scheme_medicationwwgetfilterdata.AV26SearchTxtTo = aP2_SearchTxtTo;
         objbr_scheme_medicationwwgetfilterdata.AV31OptionsJson = "" ;
         objbr_scheme_medicationwwgetfilterdata.AV34OptionsDescJson = "" ;
         objbr_scheme_medicationwwgetfilterdata.AV36OptionIndexesJson = "" ;
         objbr_scheme_medicationwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_scheme_medicationwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_scheme_medicationwwgetfilterdata);
         aP3_OptionsJson=this.AV31OptionsJson;
         aP4_OptionsDescJson=this.AV34OptionsDescJson;
         aP5_OptionIndexesJson=this.AV36OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_scheme_medicationwwgetfilterdata)stateInfo).executePrivate();
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
         AV30Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV35OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme_Medication", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV27DDOName), "DDO_BR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV27DDOName), "DDO_BR_MEDICATION_RXNAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXNAMEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV27DDOName), "DDO_BR_MEDICATION_RXUNIT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXUNITOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV31OptionsJson = AV30Options.ToJSonString(false);
         AV34OptionsDescJson = AV33OptionsDesc.ToJSonString(false);
         AV36OptionIndexesJson = AV35OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV38Session.Get("BR_Scheme_MedicationWWGridState"), "") == 0 )
         {
            AV40GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Scheme_MedicationWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV40GridState.FromXml(AV38Session.Get("BR_Scheme_MedicationWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV45GXV1 = 1;
         while ( AV45GXV1 <= AV40GridState.gxTpr_Filtervalues.Count )
         {
            AV41GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV40GridState.gxTpr_Filtervalues.Item(AV45GXV1));
            if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_MEDICATIONID") == 0 )
            {
               AV11TFBR_Scheme_MedicationID = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Scheme_MedicationID_To = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_SCHEMEID") == 0 )
            {
               AV13TFBR_SchemeID = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_SchemeID_To = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATIONID") == 0 )
            {
               AV15TFBR_MedicationID = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, "."));
               AV16TFBR_MedicationID_To = (long)(NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV17TFBR_Scheme_Chem_Regimens = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV18TFBR_Scheme_Chem_Regimens_Sel = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV19TFBR_Medication_RXName = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV20TFBR_Medication_RXName_Sel = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDOSE") == 0 )
            {
               AV21TFBR_Medication_RXDose = NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Value, ".");
               AV22TFBR_Medication_RXDose_To = NumberUtil.Val( AV41GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT") == 0 )
            {
               AV23TFBR_Medication_RXUnit = AV41GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV41GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT_SEL") == 0 )
            {
               AV24TFBR_Medication_RXUnit_Sel = AV41GridStateFilterValue.gxTpr_Value;
            }
            AV45GXV1 = (int)(AV45GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' Routine */
         AV17TFBR_Scheme_Chem_Regimens = AV25SearchTxt;
         AV18TFBR_Scheme_Chem_Regimens_Sel = "";
         AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV11TFBR_Scheme_MedicationID;
         AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV12TFBR_Scheme_MedicationID_To;
         AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV13TFBR_SchemeID;
         AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV14TFBR_SchemeID_To;
         AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV15TFBR_MedicationID;
         AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV16TFBR_MedicationID_To;
         AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV17TFBR_Scheme_Chem_Regimens;
         AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV18TFBR_Scheme_Chem_Regimens_Sel;
         AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV19TFBR_Medication_RXName;
         AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV20TFBR_Medication_RXName_Sel;
         AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV21TFBR_Medication_RXDose;
         AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV22TFBR_Medication_RXDose_To;
         AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV23TFBR_Medication_RXUnit;
         AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV24TFBR_Medication_RXUnit_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                              AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                              AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                              AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                              AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                              AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                              AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                              AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                              AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                              AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                              AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                              AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                              AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                              AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                              A332BR_Scheme_MedicationID ,
                                              A327BR_SchemeID ,
                                              A119BR_MedicationID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens), "%", "");
         lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname), "%", "");
         lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit), "%", "");
         /* Using cursor P00322 */
         pr_default.execute(0, new Object[] {AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid, AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to, AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid, AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to, AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid, AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to, lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens, AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel, lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname, AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel, AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose, AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to, lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit, AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK322 = false;
            A327BR_SchemeID = P00322_A327BR_SchemeID[0];
            n327BR_SchemeID = P00322_n327BR_SchemeID[0];
            A125BR_Medication_RXUnit = P00322_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00322_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00322_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00322_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00322_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00322_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00322_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00322_n328BR_Scheme_Chem_Regimens[0];
            A119BR_MedicationID = P00322_A119BR_MedicationID[0];
            n119BR_MedicationID = P00322_n119BR_MedicationID[0];
            A332BR_Scheme_MedicationID = P00322_A332BR_Scheme_MedicationID[0];
            A328BR_Scheme_Chem_Regimens = P00322_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00322_n328BR_Scheme_Chem_Regimens[0];
            A125BR_Medication_RXUnit = P00322_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00322_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00322_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00322_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00322_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00322_n121BR_Medication_RXName[0];
            AV37count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P00322_A327BR_SchemeID[0] == A327BR_SchemeID ) )
            {
               BRK322 = false;
               A332BR_Scheme_MedicationID = P00322_A332BR_Scheme_MedicationID[0];
               AV37count = (long)(AV37count+1);
               BRK322 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) )
            {
               AV29Option = A328BR_Scheme_Chem_Regimens;
               AV28InsertIndex = 1;
               while ( ( AV28InsertIndex <= AV30Options.Count ) && ( StringUtil.StrCmp(((String)AV30Options.Item(AV28InsertIndex)), AV29Option) < 0 ) )
               {
                  AV28InsertIndex = (int)(AV28InsertIndex+1);
               }
               AV30Options.Add(AV29Option, AV28InsertIndex);
               AV35OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV37count), "Z,ZZZ,ZZZ,ZZ9")), AV28InsertIndex);
            }
            if ( AV30Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK322 )
            {
               BRK322 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICATION_RXNAMEOPTIONS' Routine */
         AV19TFBR_Medication_RXName = AV25SearchTxt;
         AV20TFBR_Medication_RXName_Sel = "";
         AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV11TFBR_Scheme_MedicationID;
         AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV12TFBR_Scheme_MedicationID_To;
         AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV13TFBR_SchemeID;
         AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV14TFBR_SchemeID_To;
         AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV15TFBR_MedicationID;
         AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV16TFBR_MedicationID_To;
         AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV17TFBR_Scheme_Chem_Regimens;
         AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV18TFBR_Scheme_Chem_Regimens_Sel;
         AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV19TFBR_Medication_RXName;
         AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV20TFBR_Medication_RXName_Sel;
         AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV21TFBR_Medication_RXDose;
         AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV22TFBR_Medication_RXDose_To;
         AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV23TFBR_Medication_RXUnit;
         AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV24TFBR_Medication_RXUnit_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                              AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                              AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                              AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                              AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                              AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                              AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                              AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                              AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                              AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                              AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                              AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                              AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                              AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                              A332BR_Scheme_MedicationID ,
                                              A327BR_SchemeID ,
                                              A119BR_MedicationID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens), "%", "");
         lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname), "%", "");
         lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit), "%", "");
         /* Using cursor P00323 */
         pr_default.execute(1, new Object[] {AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid, AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to, AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid, AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to, AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid, AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to, lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens, AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel, lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname, AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel, AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose, AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to, lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit, AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK324 = false;
            A121BR_Medication_RXName = P00323_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00323_n121BR_Medication_RXName[0];
            A125BR_Medication_RXUnit = P00323_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00323_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00323_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00323_n124BR_Medication_RXDose[0];
            A328BR_Scheme_Chem_Regimens = P00323_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00323_n328BR_Scheme_Chem_Regimens[0];
            A119BR_MedicationID = P00323_A119BR_MedicationID[0];
            n119BR_MedicationID = P00323_n119BR_MedicationID[0];
            A327BR_SchemeID = P00323_A327BR_SchemeID[0];
            n327BR_SchemeID = P00323_n327BR_SchemeID[0];
            A332BR_Scheme_MedicationID = P00323_A332BR_Scheme_MedicationID[0];
            A121BR_Medication_RXName = P00323_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00323_n121BR_Medication_RXName[0];
            A125BR_Medication_RXUnit = P00323_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00323_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00323_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00323_n124BR_Medication_RXDose[0];
            A328BR_Scheme_Chem_Regimens = P00323_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00323_n328BR_Scheme_Chem_Regimens[0];
            AV37count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00323_A121BR_Medication_RXName[0], A121BR_Medication_RXName) == 0 ) )
            {
               BRK324 = false;
               A119BR_MedicationID = P00323_A119BR_MedicationID[0];
               n119BR_MedicationID = P00323_n119BR_MedicationID[0];
               A332BR_Scheme_MedicationID = P00323_A332BR_Scheme_MedicationID[0];
               AV37count = (long)(AV37count+1);
               BRK324 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) )
            {
               AV29Option = A121BR_Medication_RXName;
               AV30Options.Add(AV29Option, 0);
               AV35OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV37count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV30Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK324 )
            {
               BRK324 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_MEDICATION_RXUNITOPTIONS' Routine */
         AV23TFBR_Medication_RXUnit = AV25SearchTxt;
         AV24TFBR_Medication_RXUnit_Sel = "";
         AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid = AV11TFBR_Scheme_MedicationID;
         AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to = AV12TFBR_Scheme_MedicationID_To;
         AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid = AV13TFBR_SchemeID;
         AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to = AV14TFBR_SchemeID_To;
         AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid = AV15TFBR_MedicationID;
         AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to = AV16TFBR_MedicationID_To;
         AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = AV17TFBR_Scheme_Chem_Regimens;
         AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = AV18TFBR_Scheme_Chem_Regimens_Sel;
         AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = AV19TFBR_Medication_RXName;
         AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = AV20TFBR_Medication_RXName_Sel;
         AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose = AV21TFBR_Medication_RXDose;
         AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to = AV22TFBR_Medication_RXDose_To;
         AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = AV23TFBR_Medication_RXUnit;
         AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = AV24TFBR_Medication_RXUnit_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                              AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                              AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                              AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                              AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                              AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                              AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                              AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                              AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                              AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                              AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                              AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                              AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                              AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                              A332BR_Scheme_MedicationID ,
                                              A327BR_SchemeID ,
                                              A119BR_MedicationID ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = StringUtil.Concat( StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens), "%", "");
         lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname), "%", "");
         lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit), "%", "");
         /* Using cursor P00324 */
         pr_default.execute(2, new Object[] {AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid, AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to, AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid, AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to, AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid, AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to, lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens, AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel, lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname, AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel, AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose, AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to, lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit, AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK326 = false;
            A125BR_Medication_RXUnit = P00324_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00324_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00324_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00324_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00324_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00324_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00324_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00324_n328BR_Scheme_Chem_Regimens[0];
            A119BR_MedicationID = P00324_A119BR_MedicationID[0];
            n119BR_MedicationID = P00324_n119BR_MedicationID[0];
            A327BR_SchemeID = P00324_A327BR_SchemeID[0];
            n327BR_SchemeID = P00324_n327BR_SchemeID[0];
            A332BR_Scheme_MedicationID = P00324_A332BR_Scheme_MedicationID[0];
            A125BR_Medication_RXUnit = P00324_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00324_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00324_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00324_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00324_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00324_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00324_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00324_n328BR_Scheme_Chem_Regimens[0];
            AV37count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P00324_A125BR_Medication_RXUnit[0], A125BR_Medication_RXUnit) == 0 ) )
            {
               BRK326 = false;
               A119BR_MedicationID = P00324_A119BR_MedicationID[0];
               n119BR_MedicationID = P00324_n119BR_MedicationID[0];
               A332BR_Scheme_MedicationID = P00324_A332BR_Scheme_MedicationID[0];
               AV37count = (long)(AV37count+1);
               BRK326 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) )
            {
               AV29Option = A125BR_Medication_RXUnit;
               AV30Options.Add(AV29Option, 0);
               AV35OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV37count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV30Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK326 )
            {
               BRK326 = true;
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
         AV30Options = new GxSimpleCollection<String>();
         AV33OptionsDesc = new GxSimpleCollection<String>();
         AV35OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV38Session = context.GetSession();
         AV40GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV41GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV17TFBR_Scheme_Chem_Regimens = "";
         AV18TFBR_Scheme_Chem_Regimens_Sel = "";
         AV19TFBR_Medication_RXName = "";
         AV20TFBR_Medication_RXName_Sel = "";
         AV23TFBR_Medication_RXUnit = "";
         AV24TFBR_Medication_RXUnit_Sel = "";
         AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = "";
         AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel = "";
         AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = "";
         AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel = "";
         AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = "";
         AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel = "";
         scmdbuf = "";
         lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens = "";
         lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname = "";
         lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit = "";
         A328BR_Scheme_Chem_Regimens = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         P00322_A327BR_SchemeID = new long[1] ;
         P00322_n327BR_SchemeID = new bool[] {false} ;
         P00322_A125BR_Medication_RXUnit = new String[] {""} ;
         P00322_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00322_A124BR_Medication_RXDose = new decimal[1] ;
         P00322_n124BR_Medication_RXDose = new bool[] {false} ;
         P00322_A121BR_Medication_RXName = new String[] {""} ;
         P00322_n121BR_Medication_RXName = new bool[] {false} ;
         P00322_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00322_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00322_A119BR_MedicationID = new long[1] ;
         P00322_n119BR_MedicationID = new bool[] {false} ;
         P00322_A332BR_Scheme_MedicationID = new long[1] ;
         AV29Option = "";
         P00323_A121BR_Medication_RXName = new String[] {""} ;
         P00323_n121BR_Medication_RXName = new bool[] {false} ;
         P00323_A125BR_Medication_RXUnit = new String[] {""} ;
         P00323_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00323_A124BR_Medication_RXDose = new decimal[1] ;
         P00323_n124BR_Medication_RXDose = new bool[] {false} ;
         P00323_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00323_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00323_A119BR_MedicationID = new long[1] ;
         P00323_n119BR_MedicationID = new bool[] {false} ;
         P00323_A327BR_SchemeID = new long[1] ;
         P00323_n327BR_SchemeID = new bool[] {false} ;
         P00323_A332BR_Scheme_MedicationID = new long[1] ;
         P00324_A125BR_Medication_RXUnit = new String[] {""} ;
         P00324_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00324_A124BR_Medication_RXDose = new decimal[1] ;
         P00324_n124BR_Medication_RXDose = new bool[] {false} ;
         P00324_A121BR_Medication_RXName = new String[] {""} ;
         P00324_n121BR_Medication_RXName = new bool[] {false} ;
         P00324_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00324_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00324_A119BR_MedicationID = new long[1] ;
         P00324_n119BR_MedicationID = new bool[] {false} ;
         P00324_A327BR_SchemeID = new long[1] ;
         P00324_n327BR_SchemeID = new bool[] {false} ;
         P00324_A332BR_Scheme_MedicationID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_medicationwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00322_A327BR_SchemeID, P00322_n327BR_SchemeID, P00322_A125BR_Medication_RXUnit, P00322_n125BR_Medication_RXUnit, P00322_A124BR_Medication_RXDose, P00322_n124BR_Medication_RXDose, P00322_A121BR_Medication_RXName, P00322_n121BR_Medication_RXName, P00322_A328BR_Scheme_Chem_Regimens, P00322_n328BR_Scheme_Chem_Regimens,
               P00322_A119BR_MedicationID, P00322_n119BR_MedicationID, P00322_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               P00323_A121BR_Medication_RXName, P00323_n121BR_Medication_RXName, P00323_A125BR_Medication_RXUnit, P00323_n125BR_Medication_RXUnit, P00323_A124BR_Medication_RXDose, P00323_n124BR_Medication_RXDose, P00323_A328BR_Scheme_Chem_Regimens, P00323_n328BR_Scheme_Chem_Regimens, P00323_A119BR_MedicationID, P00323_n119BR_MedicationID,
               P00323_A327BR_SchemeID, P00323_n327BR_SchemeID, P00323_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               P00324_A125BR_Medication_RXUnit, P00324_n125BR_Medication_RXUnit, P00324_A124BR_Medication_RXDose, P00324_n124BR_Medication_RXDose, P00324_A121BR_Medication_RXName, P00324_n121BR_Medication_RXName, P00324_A328BR_Scheme_Chem_Regimens, P00324_n328BR_Scheme_Chem_Regimens, P00324_A119BR_MedicationID, P00324_n119BR_MedicationID,
               P00324_A327BR_SchemeID, P00324_n327BR_SchemeID, P00324_A332BR_Scheme_MedicationID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV45GXV1 ;
      private int AV28InsertIndex ;
      private long AV11TFBR_Scheme_MedicationID ;
      private long AV12TFBR_Scheme_MedicationID_To ;
      private long AV13TFBR_SchemeID ;
      private long AV14TFBR_SchemeID_To ;
      private long AV15TFBR_MedicationID ;
      private long AV16TFBR_MedicationID_To ;
      private long AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ;
      private long AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ;
      private long AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ;
      private long AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ;
      private long AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ;
      private long AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ;
      private long A332BR_Scheme_MedicationID ;
      private long A327BR_SchemeID ;
      private long A119BR_MedicationID ;
      private long AV37count ;
      private decimal AV21TFBR_Medication_RXDose ;
      private decimal AV22TFBR_Medication_RXDose_To ;
      private decimal AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ;
      private decimal AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ;
      private decimal A124BR_Medication_RXDose ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK322 ;
      private bool n327BR_SchemeID ;
      private bool n125BR_Medication_RXUnit ;
      private bool n124BR_Medication_RXDose ;
      private bool n121BR_Medication_RXName ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n119BR_MedicationID ;
      private bool BRK324 ;
      private bool BRK326 ;
      private String AV36OptionIndexesJson ;
      private String AV31OptionsJson ;
      private String AV34OptionsDescJson ;
      private String AV27DDOName ;
      private String AV25SearchTxt ;
      private String AV26SearchTxtTo ;
      private String AV17TFBR_Scheme_Chem_Regimens ;
      private String AV18TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV19TFBR_Medication_RXName ;
      private String AV20TFBR_Medication_RXName_Sel ;
      private String AV23TFBR_Medication_RXUnit ;
      private String AV24TFBR_Medication_RXUnit_Sel ;
      private String AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ;
      private String AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ;
      private String AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ;
      private String AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ;
      private String AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ;
      private String AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ;
      private String lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ;
      private String lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ;
      private String lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV29Option ;
      private IGxSession AV38Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00322_A327BR_SchemeID ;
      private bool[] P00322_n327BR_SchemeID ;
      private String[] P00322_A125BR_Medication_RXUnit ;
      private bool[] P00322_n125BR_Medication_RXUnit ;
      private decimal[] P00322_A124BR_Medication_RXDose ;
      private bool[] P00322_n124BR_Medication_RXDose ;
      private String[] P00322_A121BR_Medication_RXName ;
      private bool[] P00322_n121BR_Medication_RXName ;
      private String[] P00322_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00322_n328BR_Scheme_Chem_Regimens ;
      private long[] P00322_A119BR_MedicationID ;
      private bool[] P00322_n119BR_MedicationID ;
      private long[] P00322_A332BR_Scheme_MedicationID ;
      private String[] P00323_A121BR_Medication_RXName ;
      private bool[] P00323_n121BR_Medication_RXName ;
      private String[] P00323_A125BR_Medication_RXUnit ;
      private bool[] P00323_n125BR_Medication_RXUnit ;
      private decimal[] P00323_A124BR_Medication_RXDose ;
      private bool[] P00323_n124BR_Medication_RXDose ;
      private String[] P00323_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00323_n328BR_Scheme_Chem_Regimens ;
      private long[] P00323_A119BR_MedicationID ;
      private bool[] P00323_n119BR_MedicationID ;
      private long[] P00323_A327BR_SchemeID ;
      private bool[] P00323_n327BR_SchemeID ;
      private long[] P00323_A332BR_Scheme_MedicationID ;
      private String[] P00324_A125BR_Medication_RXUnit ;
      private bool[] P00324_n125BR_Medication_RXUnit ;
      private decimal[] P00324_A124BR_Medication_RXDose ;
      private bool[] P00324_n124BR_Medication_RXDose ;
      private String[] P00324_A121BR_Medication_RXName ;
      private bool[] P00324_n121BR_Medication_RXName ;
      private String[] P00324_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00324_n328BR_Scheme_Chem_Regimens ;
      private long[] P00324_A119BR_MedicationID ;
      private bool[] P00324_n119BR_MedicationID ;
      private long[] P00324_A327BR_SchemeID ;
      private bool[] P00324_n327BR_SchemeID ;
      private long[] P00324_A332BR_Scheme_MedicationID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV30Options ;
      private GxSimpleCollection<String> AV33OptionsDesc ;
      private GxSimpleCollection<String> AV35OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV40GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV41GridStateFilterValue ;
   }

   public class br_scheme_medicationwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00322( IGxContext context ,
                                             long AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                             long AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                             long AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                             long AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                             long AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                             long AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                             String AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                             String AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                             String AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                             String AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                             decimal AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                             decimal AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                             String AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                             String AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                             long A332BR_Scheme_MedicationID ,
                                             long A327BR_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [14] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[BR_SchemeID], T3.[BR_Medication_RXUnit], T3.[BR_Medication_RXDose], T3.[BR_Medication_RXName], T2.[BR_Scheme_Chem_Regimens], T1.[BR_MedicationID], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Scheme] T2 WITH (NOLOCK) ON T2.[BR_SchemeID] = T1.[BR_SchemeID]) LEFT JOIN [BR_Medication] T3 WITH (NOLOCK) ON T3.[BR_MedicationID] = T1.[BR_MedicationID])";
         if ( ! (0==AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! (0==AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! (0==AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_SchemeID]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00323( IGxContext context ,
                                             long AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                             long AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                             long AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                             long AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                             long AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                             long AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                             String AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                             String AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                             String AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                             String AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                             decimal AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                             decimal AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                             String AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                             String AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                             long A332BR_Scheme_MedicationID ,
                                             long A327BR_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [14] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Medication_RXName], T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T3.[BR_Scheme_Chem_Regimens], T1.[BR_MedicationID], T1.[BR_SchemeID], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         if ( ! (0==AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (0==AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (0==AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T2.[BR_Medication_RXName]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P00324( IGxContext context ,
                                             long AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid ,
                                             long AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to ,
                                             long AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid ,
                                             long AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to ,
                                             long AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid ,
                                             long AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to ,
                                             String AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel ,
                                             String AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens ,
                                             String AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel ,
                                             String AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname ,
                                             decimal AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose ,
                                             decimal AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to ,
                                             String AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel ,
                                             String AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit ,
                                             long A332BR_Scheme_MedicationID ,
                                             long A327BR_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [14] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T2.[BR_Medication_RXName], T3.[BR_Scheme_Chem_Regimens], T1.[BR_MedicationID], T1.[BR_SchemeID], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         if ( ! (0==AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] >= @AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Scheme_MedicationID] <= @AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] >= @AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_SchemeID] <= @AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! (0==AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] >= @AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! (0==AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_MedicationID] <= @AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] like @lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Scheme_Chem_Regimens] = @AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] like @lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXName] = @AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] >= @AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXDose] <= @AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] like @lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T2.[BR_Medication_RXUnit] = @AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel)";
            }
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY T2.[BR_Medication_RXUnit]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00322(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (long)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (decimal)dynConstraints[19] , (String)dynConstraints[20] );
               case 1 :
                     return conditional_P00323(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (long)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (decimal)dynConstraints[19] , (String)dynConstraints[20] );
               case 2 :
                     return conditional_P00324(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (long)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (decimal)dynConstraints[19] , (String)dynConstraints[20] );
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
          Object[] prmP00322 ;
          prmP00322 = new Object[] {
          new Object[] {"@AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP00323 ;
          prmP00323 = new Object[] {
          new Object[] {"@AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP00324 ;
          prmP00324 = new Object[] {
          new Object[] {"@AV47BR_Scheme_MedicationWWDS_1_Tfbr_scheme_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_Scheme_MedicationWWDS_2_Tfbr_scheme_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV49BR_Scheme_MedicationWWDS_3_Tfbr_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Scheme_MedicationWWDS_4_Tfbr_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Scheme_MedicationWWDS_5_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Scheme_MedicationWWDS_6_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV53BR_Scheme_MedicationWWDS_7_Tfbr_scheme_chem_regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_Scheme_MedicationWWDS_8_Tfbr_scheme_chem_regimens_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV55BR_Scheme_MedicationWWDS_9_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Scheme_MedicationWWDS_10_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Scheme_MedicationWWDS_11_Tfbr_medication_rxdose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Scheme_MedicationWWDS_12_Tfbr_medication_rxdose_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Scheme_MedicationWWDS_13_Tfbr_medication_rxunit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Scheme_MedicationWWDS_14_Tfbr_medication_rxunit_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00322", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00322,100,0,true,false )
             ,new CursorDef("P00323", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00323,100,0,true,false )
             ,new CursorDef("P00324", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00324,100,0,true,false )
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
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                return;
             case 2 :
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
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_scheme_medicationwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_scheme_medicationwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_scheme_medicationwwgetfilterdata") )
          {
             return  ;
          }
          br_scheme_medicationwwgetfilterdata worker = new br_scheme_medicationwwgetfilterdata(context) ;
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
