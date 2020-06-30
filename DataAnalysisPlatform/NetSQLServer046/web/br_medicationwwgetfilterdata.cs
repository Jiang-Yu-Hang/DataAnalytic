/*
               File: BR_MedicationWWGetFilterData
        Description: BR_Medication WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.44
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
   public class br_medicationwwgetfilterdata : GXProcedure
   {
      public br_medicationwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicationwwgetfilterdata( IGxContext context )
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
         this.AV55DDOName = aP0_DDOName;
         this.AV53SearchTxt = aP1_SearchTxt;
         this.AV54SearchTxtTo = aP2_SearchTxtTo;
         this.AV59OptionsJson = "" ;
         this.AV62OptionsDescJson = "" ;
         this.AV64OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV59OptionsJson;
         aP4_OptionsDescJson=this.AV62OptionsDescJson;
         aP5_OptionIndexesJson=this.AV64OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV55DDOName = aP0_DDOName;
         this.AV53SearchTxt = aP1_SearchTxt;
         this.AV54SearchTxtTo = aP2_SearchTxtTo;
         this.AV59OptionsJson = "" ;
         this.AV62OptionsDescJson = "" ;
         this.AV64OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV59OptionsJson;
         aP4_OptionsDescJson=this.AV62OptionsDescJson;
         aP5_OptionIndexesJson=this.AV64OptionIndexesJson;
         return AV64OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_medicationwwgetfilterdata objbr_medicationwwgetfilterdata;
         objbr_medicationwwgetfilterdata = new br_medicationwwgetfilterdata();
         objbr_medicationwwgetfilterdata.AV55DDOName = aP0_DDOName;
         objbr_medicationwwgetfilterdata.AV53SearchTxt = aP1_SearchTxt;
         objbr_medicationwwgetfilterdata.AV54SearchTxtTo = aP2_SearchTxtTo;
         objbr_medicationwwgetfilterdata.AV59OptionsJson = "" ;
         objbr_medicationwwgetfilterdata.AV62OptionsDescJson = "" ;
         objbr_medicationwwgetfilterdata.AV64OptionIndexesJson = "" ;
         objbr_medicationwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_medicationwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_medicationwwgetfilterdata);
         aP3_OptionsJson=this.AV59OptionsJson;
         aP4_OptionsDescJson=this.AV62OptionsDescJson;
         aP5_OptionIndexesJson=this.AV64OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_medicationwwgetfilterdata)stateInfo).executePrivate();
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
         AV58Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV61OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV63OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV55DDOName), "DDO_BR_MEDICATION_RXNAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXNAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV55DDOName), "DDO_BR_MEDICATION_RXCODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXCODEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV55DDOName), "DDO_BR_MEDICATION_RXQUANTITY") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXQUANTITYOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV55DDOName), "DDO_BR_MEDICATION_RXFREQUENCY") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXFREQUENCYOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV59OptionsJson = AV58Options.ToJSonString(false);
         AV62OptionsDescJson = AV61OptionsDesc.ToJSonString(false);
         AV64OptionIndexesJson = AV63OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV66Session.Get("BR_MedicationWWGridState"), "") == 0 )
         {
            AV68GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_MedicationWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV68GridState.FromXml(AV66Session.Get("BR_MedicationWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV78GXV1 = 1;
         while ( AV78GXV1 <= AV68GridState.gxTpr_Filtervalues.Count )
         {
            AV69GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV68GridState.gxTpr_Filtervalues.Item(AV78GXV1));
            if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV17TFBR_Medication_RXName = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV18TFBR_Medication_RXName_Sel = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXCODE") == 0 )
            {
               AV19TFBR_Medication_RXCode = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXCODE_SEL") == 0 )
            {
               AV20TFBR_Medication_RXCode_Sel = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXQUANTITY") == 0 )
            {
               AV29TFBR_Medication_RXQuantity = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXQUANTITY_SEL") == 0 )
            {
               AV30TFBR_Medication_RXQuantity_Sel = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDAYSSUPPLY") == 0 )
            {
               AV31TFBR_Medication_RXDaysSupply = NumberUtil.Val( AV69GridStateFilterValue.gxTpr_Value, ".");
               AV32TFBR_Medication_RXDaysSupply_To = NumberUtil.Val( AV69GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXFREQUENCY") == 0 )
            {
               AV27TFBR_Medication_RXFrequency = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXFREQUENCY_SEL") == 0 )
            {
               AV73TFBR_Medication_RXFrequency_Sel = AV69GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV69GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_ADMITSTARTDATE") == 0 )
            {
               AV39TFBR_Medication_AdmitStartDate = context.localUtil.CToD( AV69GridStateFilterValue.gxTpr_Value, 0);
               AV40TFBR_Medication_AdmitStartDate_To = context.localUtil.CToD( AV69GridStateFilterValue.gxTpr_Valueto, 0);
            }
            AV78GXV1 = (int)(AV78GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_MEDICATION_RXNAMEOPTIONS' Routine */
         AV17TFBR_Medication_RXName = AV53SearchTxt;
         AV18TFBR_Medication_RXName_Sel = "";
         AV80BR_MedicationWWDS_1_Tfbr_medication_rxname = AV17TFBR_Medication_RXName;
         AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV18TFBR_Medication_RXName_Sel;
         AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV19TFBR_Medication_RXCode;
         AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV20TFBR_Medication_RXCode_Sel;
         AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV29TFBR_Medication_RXQuantity;
         AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV30TFBR_Medication_RXQuantity_Sel;
         AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV31TFBR_Medication_RXDaysSupply;
         AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV32TFBR_Medication_RXDaysSupply_To;
         AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV27TFBR_Medication_RXFrequency;
         AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV73TFBR_Medication_RXFrequency_Sel;
         AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV39TFBR_Medication_AdmitStartDate;
         AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV40TFBR_Medication_AdmitStartDate_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                              AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                              AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                              AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                              AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                              AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                              AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                              AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                              AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                              AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                              AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                              AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                              A121BR_Medication_RXName ,
                                              A122BR_Medication_RXCode ,
                                              A127BR_Medication_RXQuantity ,
                                              A128BR_Medication_RXDaysSupply ,
                                              A126BR_Medication_RXFrequency ,
                                              A132BR_Medication_AdmitStartDate } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV80BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
         lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
         lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
         lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
         /* Using cursor P001V2 */
         pr_default.execute(0, new Object[] {lV80BR_MedicationWWDS_1_Tfbr_medication_rxname, AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK1V2 = false;
            A121BR_Medication_RXName = P001V2_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P001V2_n121BR_Medication_RXName[0];
            A132BR_Medication_AdmitStartDate = P001V2_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = P001V2_n132BR_Medication_AdmitStartDate[0];
            A126BR_Medication_RXFrequency = P001V2_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = P001V2_n126BR_Medication_RXFrequency[0];
            A128BR_Medication_RXDaysSupply = P001V2_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = P001V2_n128BR_Medication_RXDaysSupply[0];
            A127BR_Medication_RXQuantity = P001V2_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = P001V2_n127BR_Medication_RXQuantity[0];
            A122BR_Medication_RXCode = P001V2_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = P001V2_n122BR_Medication_RXCode[0];
            A119BR_MedicationID = P001V2_A119BR_MedicationID[0];
            AV65count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P001V2_A121BR_Medication_RXName[0], A121BR_Medication_RXName) == 0 ) )
            {
               BRK1V2 = false;
               A119BR_MedicationID = P001V2_A119BR_MedicationID[0];
               AV65count = (long)(AV65count+1);
               BRK1V2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) )
            {
               AV57Option = A121BR_Medication_RXName;
               AV58Options.Add(AV57Option, 0);
               AV63OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV65count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV58Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1V2 )
            {
               BRK1V2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICATION_RXCODEOPTIONS' Routine */
         AV19TFBR_Medication_RXCode = AV53SearchTxt;
         AV20TFBR_Medication_RXCode_Sel = "";
         AV80BR_MedicationWWDS_1_Tfbr_medication_rxname = AV17TFBR_Medication_RXName;
         AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV18TFBR_Medication_RXName_Sel;
         AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV19TFBR_Medication_RXCode;
         AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV20TFBR_Medication_RXCode_Sel;
         AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV29TFBR_Medication_RXQuantity;
         AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV30TFBR_Medication_RXQuantity_Sel;
         AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV31TFBR_Medication_RXDaysSupply;
         AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV32TFBR_Medication_RXDaysSupply_To;
         AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV27TFBR_Medication_RXFrequency;
         AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV73TFBR_Medication_RXFrequency_Sel;
         AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV39TFBR_Medication_AdmitStartDate;
         AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV40TFBR_Medication_AdmitStartDate_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                              AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                              AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                              AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                              AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                              AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                              AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                              AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                              AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                              AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                              AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                              AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                              A121BR_Medication_RXName ,
                                              A122BR_Medication_RXCode ,
                                              A127BR_Medication_RXQuantity ,
                                              A128BR_Medication_RXDaysSupply ,
                                              A126BR_Medication_RXFrequency ,
                                              A132BR_Medication_AdmitStartDate } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV80BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
         lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
         lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
         lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
         /* Using cursor P001V3 */
         pr_default.execute(1, new Object[] {lV80BR_MedicationWWDS_1_Tfbr_medication_rxname, AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK1V4 = false;
            A122BR_Medication_RXCode = P001V3_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = P001V3_n122BR_Medication_RXCode[0];
            A132BR_Medication_AdmitStartDate = P001V3_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = P001V3_n132BR_Medication_AdmitStartDate[0];
            A126BR_Medication_RXFrequency = P001V3_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = P001V3_n126BR_Medication_RXFrequency[0];
            A128BR_Medication_RXDaysSupply = P001V3_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = P001V3_n128BR_Medication_RXDaysSupply[0];
            A127BR_Medication_RXQuantity = P001V3_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = P001V3_n127BR_Medication_RXQuantity[0];
            A121BR_Medication_RXName = P001V3_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P001V3_n121BR_Medication_RXName[0];
            A119BR_MedicationID = P001V3_A119BR_MedicationID[0];
            AV65count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P001V3_A122BR_Medication_RXCode[0], A122BR_Medication_RXCode) == 0 ) )
            {
               BRK1V4 = false;
               A119BR_MedicationID = P001V3_A119BR_MedicationID[0];
               AV65count = (long)(AV65count+1);
               BRK1V4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A122BR_Medication_RXCode)) )
            {
               AV57Option = A122BR_Medication_RXCode;
               AV58Options.Add(AV57Option, 0);
               AV63OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV65count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV58Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1V4 )
            {
               BRK1V4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_MEDICATION_RXQUANTITYOPTIONS' Routine */
         AV29TFBR_Medication_RXQuantity = AV53SearchTxt;
         AV30TFBR_Medication_RXQuantity_Sel = "";
         AV80BR_MedicationWWDS_1_Tfbr_medication_rxname = AV17TFBR_Medication_RXName;
         AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV18TFBR_Medication_RXName_Sel;
         AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV19TFBR_Medication_RXCode;
         AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV20TFBR_Medication_RXCode_Sel;
         AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV29TFBR_Medication_RXQuantity;
         AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV30TFBR_Medication_RXQuantity_Sel;
         AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV31TFBR_Medication_RXDaysSupply;
         AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV32TFBR_Medication_RXDaysSupply_To;
         AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV27TFBR_Medication_RXFrequency;
         AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV73TFBR_Medication_RXFrequency_Sel;
         AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV39TFBR_Medication_AdmitStartDate;
         AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV40TFBR_Medication_AdmitStartDate_To;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                              AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                              AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                              AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                              AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                              AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                              AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                              AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                              AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                              AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                              AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                              AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                              A121BR_Medication_RXName ,
                                              A122BR_Medication_RXCode ,
                                              A127BR_Medication_RXQuantity ,
                                              A128BR_Medication_RXDaysSupply ,
                                              A126BR_Medication_RXFrequency ,
                                              A132BR_Medication_AdmitStartDate } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV80BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
         lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
         lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
         lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
         /* Using cursor P001V4 */
         pr_default.execute(2, new Object[] {lV80BR_MedicationWWDS_1_Tfbr_medication_rxname, AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK1V6 = false;
            A127BR_Medication_RXQuantity = P001V4_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = P001V4_n127BR_Medication_RXQuantity[0];
            A132BR_Medication_AdmitStartDate = P001V4_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = P001V4_n132BR_Medication_AdmitStartDate[0];
            A126BR_Medication_RXFrequency = P001V4_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = P001V4_n126BR_Medication_RXFrequency[0];
            A128BR_Medication_RXDaysSupply = P001V4_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = P001V4_n128BR_Medication_RXDaysSupply[0];
            A122BR_Medication_RXCode = P001V4_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = P001V4_n122BR_Medication_RXCode[0];
            A121BR_Medication_RXName = P001V4_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P001V4_n121BR_Medication_RXName[0];
            A119BR_MedicationID = P001V4_A119BR_MedicationID[0];
            AV65count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P001V4_A127BR_Medication_RXQuantity[0], A127BR_Medication_RXQuantity) == 0 ) )
            {
               BRK1V6 = false;
               A119BR_MedicationID = P001V4_A119BR_MedicationID[0];
               AV65count = (long)(AV65count+1);
               BRK1V6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A127BR_Medication_RXQuantity)) )
            {
               AV57Option = A127BR_Medication_RXQuantity;
               AV58Options.Add(AV57Option, 0);
               AV63OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV65count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV58Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1V6 )
            {
               BRK1V6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_MEDICATION_RXFREQUENCYOPTIONS' Routine */
         AV27TFBR_Medication_RXFrequency = AV53SearchTxt;
         AV73TFBR_Medication_RXFrequency_Sel = "";
         AV80BR_MedicationWWDS_1_Tfbr_medication_rxname = AV17TFBR_Medication_RXName;
         AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = AV18TFBR_Medication_RXName_Sel;
         AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = AV19TFBR_Medication_RXCode;
         AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = AV20TFBR_Medication_RXCode_Sel;
         AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = AV29TFBR_Medication_RXQuantity;
         AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = AV30TFBR_Medication_RXQuantity_Sel;
         AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply = AV31TFBR_Medication_RXDaysSupply;
         AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to = AV32TFBR_Medication_RXDaysSupply_To;
         AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = AV27TFBR_Medication_RXFrequency;
         AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = AV73TFBR_Medication_RXFrequency_Sel;
         AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = AV39TFBR_Medication_AdmitStartDate;
         AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = AV40TFBR_Medication_AdmitStartDate_To;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                              AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                              AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                              AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                              AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                              AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                              AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                              AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                              AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                              AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                              AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                              AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                              A121BR_Medication_RXName ,
                                              A122BR_Medication_RXCode ,
                                              A127BR_Medication_RXQuantity ,
                                              A128BR_Medication_RXDaysSupply ,
                                              A126BR_Medication_RXFrequency ,
                                              A132BR_Medication_AdmitStartDate } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV80BR_MedicationWWDS_1_Tfbr_medication_rxname = StringUtil.Concat( StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname), "%", "");
         lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = StringUtil.Concat( StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode), "%", "");
         lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = StringUtil.Concat( StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity), "%", "");
         lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = StringUtil.Concat( StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency), "%", "");
         /* Using cursor P001V5 */
         pr_default.execute(3, new Object[] {lV80BR_MedicationWWDS_1_Tfbr_medication_rxname, AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel, lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode, AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel, lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity, AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel, AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply, AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to, lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency, AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel, AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate, AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK1V8 = false;
            A126BR_Medication_RXFrequency = P001V5_A126BR_Medication_RXFrequency[0];
            n126BR_Medication_RXFrequency = P001V5_n126BR_Medication_RXFrequency[0];
            A132BR_Medication_AdmitStartDate = P001V5_A132BR_Medication_AdmitStartDate[0];
            n132BR_Medication_AdmitStartDate = P001V5_n132BR_Medication_AdmitStartDate[0];
            A128BR_Medication_RXDaysSupply = P001V5_A128BR_Medication_RXDaysSupply[0];
            n128BR_Medication_RXDaysSupply = P001V5_n128BR_Medication_RXDaysSupply[0];
            A127BR_Medication_RXQuantity = P001V5_A127BR_Medication_RXQuantity[0];
            n127BR_Medication_RXQuantity = P001V5_n127BR_Medication_RXQuantity[0];
            A122BR_Medication_RXCode = P001V5_A122BR_Medication_RXCode[0];
            n122BR_Medication_RXCode = P001V5_n122BR_Medication_RXCode[0];
            A121BR_Medication_RXName = P001V5_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P001V5_n121BR_Medication_RXName[0];
            A119BR_MedicationID = P001V5_A119BR_MedicationID[0];
            AV65count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P001V5_A126BR_Medication_RXFrequency[0], A126BR_Medication_RXFrequency) == 0 ) )
            {
               BRK1V8 = false;
               A119BR_MedicationID = P001V5_A119BR_MedicationID[0];
               AV65count = (long)(AV65count+1);
               BRK1V8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A126BR_Medication_RXFrequency)) )
            {
               AV57Option = A126BR_Medication_RXFrequency;
               AV58Options.Add(AV57Option, 0);
               AV63OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV65count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV58Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK1V8 )
            {
               BRK1V8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
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
         AV58Options = new GxSimpleCollection<String>();
         AV61OptionsDesc = new GxSimpleCollection<String>();
         AV63OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV66Session = context.GetSession();
         AV68GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV69GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV17TFBR_Medication_RXName = "";
         AV18TFBR_Medication_RXName_Sel = "";
         AV19TFBR_Medication_RXCode = "";
         AV20TFBR_Medication_RXCode_Sel = "";
         AV29TFBR_Medication_RXQuantity = "";
         AV30TFBR_Medication_RXQuantity_Sel = "";
         AV27TFBR_Medication_RXFrequency = "";
         AV73TFBR_Medication_RXFrequency_Sel = "";
         AV39TFBR_Medication_AdmitStartDate = DateTime.MinValue;
         AV40TFBR_Medication_AdmitStartDate_To = DateTime.MinValue;
         AV80BR_MedicationWWDS_1_Tfbr_medication_rxname = "";
         AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel = "";
         AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = "";
         AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel = "";
         AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = "";
         AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel = "";
         AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = "";
         AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel = "";
         AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate = DateTime.MinValue;
         AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to = DateTime.MinValue;
         scmdbuf = "";
         lV80BR_MedicationWWDS_1_Tfbr_medication_rxname = "";
         lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode = "";
         lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity = "";
         lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency = "";
         A121BR_Medication_RXName = "";
         A122BR_Medication_RXCode = "";
         A127BR_Medication_RXQuantity = "";
         A126BR_Medication_RXFrequency = "";
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         P001V2_A121BR_Medication_RXName = new String[] {""} ;
         P001V2_n121BR_Medication_RXName = new bool[] {false} ;
         P001V2_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         P001V2_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         P001V2_A126BR_Medication_RXFrequency = new String[] {""} ;
         P001V2_n126BR_Medication_RXFrequency = new bool[] {false} ;
         P001V2_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         P001V2_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         P001V2_A127BR_Medication_RXQuantity = new String[] {""} ;
         P001V2_n127BR_Medication_RXQuantity = new bool[] {false} ;
         P001V2_A122BR_Medication_RXCode = new String[] {""} ;
         P001V2_n122BR_Medication_RXCode = new bool[] {false} ;
         P001V2_A119BR_MedicationID = new long[1] ;
         AV57Option = "";
         P001V3_A122BR_Medication_RXCode = new String[] {""} ;
         P001V3_n122BR_Medication_RXCode = new bool[] {false} ;
         P001V3_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         P001V3_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         P001V3_A126BR_Medication_RXFrequency = new String[] {""} ;
         P001V3_n126BR_Medication_RXFrequency = new bool[] {false} ;
         P001V3_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         P001V3_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         P001V3_A127BR_Medication_RXQuantity = new String[] {""} ;
         P001V3_n127BR_Medication_RXQuantity = new bool[] {false} ;
         P001V3_A121BR_Medication_RXName = new String[] {""} ;
         P001V3_n121BR_Medication_RXName = new bool[] {false} ;
         P001V3_A119BR_MedicationID = new long[1] ;
         P001V4_A127BR_Medication_RXQuantity = new String[] {""} ;
         P001V4_n127BR_Medication_RXQuantity = new bool[] {false} ;
         P001V4_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         P001V4_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         P001V4_A126BR_Medication_RXFrequency = new String[] {""} ;
         P001V4_n126BR_Medication_RXFrequency = new bool[] {false} ;
         P001V4_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         P001V4_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         P001V4_A122BR_Medication_RXCode = new String[] {""} ;
         P001V4_n122BR_Medication_RXCode = new bool[] {false} ;
         P001V4_A121BR_Medication_RXName = new String[] {""} ;
         P001V4_n121BR_Medication_RXName = new bool[] {false} ;
         P001V4_A119BR_MedicationID = new long[1] ;
         P001V5_A126BR_Medication_RXFrequency = new String[] {""} ;
         P001V5_n126BR_Medication_RXFrequency = new bool[] {false} ;
         P001V5_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         P001V5_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         P001V5_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         P001V5_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         P001V5_A127BR_Medication_RXQuantity = new String[] {""} ;
         P001V5_n127BR_Medication_RXQuantity = new bool[] {false} ;
         P001V5_A122BR_Medication_RXCode = new String[] {""} ;
         P001V5_n122BR_Medication_RXCode = new bool[] {false} ;
         P001V5_A121BR_Medication_RXName = new String[] {""} ;
         P001V5_n121BR_Medication_RXName = new bool[] {false} ;
         P001V5_A119BR_MedicationID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicationwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P001V2_A121BR_Medication_RXName, P001V2_n121BR_Medication_RXName, P001V2_A132BR_Medication_AdmitStartDate, P001V2_n132BR_Medication_AdmitStartDate, P001V2_A126BR_Medication_RXFrequency, P001V2_n126BR_Medication_RXFrequency, P001V2_A128BR_Medication_RXDaysSupply, P001V2_n128BR_Medication_RXDaysSupply, P001V2_A127BR_Medication_RXQuantity, P001V2_n127BR_Medication_RXQuantity,
               P001V2_A122BR_Medication_RXCode, P001V2_n122BR_Medication_RXCode, P001V2_A119BR_MedicationID
               }
               , new Object[] {
               P001V3_A122BR_Medication_RXCode, P001V3_n122BR_Medication_RXCode, P001V3_A132BR_Medication_AdmitStartDate, P001V3_n132BR_Medication_AdmitStartDate, P001V3_A126BR_Medication_RXFrequency, P001V3_n126BR_Medication_RXFrequency, P001V3_A128BR_Medication_RXDaysSupply, P001V3_n128BR_Medication_RXDaysSupply, P001V3_A127BR_Medication_RXQuantity, P001V3_n127BR_Medication_RXQuantity,
               P001V3_A121BR_Medication_RXName, P001V3_n121BR_Medication_RXName, P001V3_A119BR_MedicationID
               }
               , new Object[] {
               P001V4_A127BR_Medication_RXQuantity, P001V4_n127BR_Medication_RXQuantity, P001V4_A132BR_Medication_AdmitStartDate, P001V4_n132BR_Medication_AdmitStartDate, P001V4_A126BR_Medication_RXFrequency, P001V4_n126BR_Medication_RXFrequency, P001V4_A128BR_Medication_RXDaysSupply, P001V4_n128BR_Medication_RXDaysSupply, P001V4_A122BR_Medication_RXCode, P001V4_n122BR_Medication_RXCode,
               P001V4_A121BR_Medication_RXName, P001V4_n121BR_Medication_RXName, P001V4_A119BR_MedicationID
               }
               , new Object[] {
               P001V5_A126BR_Medication_RXFrequency, P001V5_n126BR_Medication_RXFrequency, P001V5_A132BR_Medication_AdmitStartDate, P001V5_n132BR_Medication_AdmitStartDate, P001V5_A128BR_Medication_RXDaysSupply, P001V5_n128BR_Medication_RXDaysSupply, P001V5_A127BR_Medication_RXQuantity, P001V5_n127BR_Medication_RXQuantity, P001V5_A122BR_Medication_RXCode, P001V5_n122BR_Medication_RXCode,
               P001V5_A121BR_Medication_RXName, P001V5_n121BR_Medication_RXName, P001V5_A119BR_MedicationID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV78GXV1 ;
      private long A119BR_MedicationID ;
      private long AV65count ;
      private decimal AV31TFBR_Medication_RXDaysSupply ;
      private decimal AV32TFBR_Medication_RXDaysSupply_To ;
      private decimal AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ;
      private decimal AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ;
      private decimal A128BR_Medication_RXDaysSupply ;
      private String scmdbuf ;
      private DateTime AV39TFBR_Medication_AdmitStartDate ;
      private DateTime AV40TFBR_Medication_AdmitStartDate_To ;
      private DateTime AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ;
      private DateTime AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK1V2 ;
      private bool n121BR_Medication_RXName ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n122BR_Medication_RXCode ;
      private bool BRK1V4 ;
      private bool BRK1V6 ;
      private bool BRK1V8 ;
      private String AV64OptionIndexesJson ;
      private String AV59OptionsJson ;
      private String AV62OptionsDescJson ;
      private String AV55DDOName ;
      private String AV53SearchTxt ;
      private String AV54SearchTxtTo ;
      private String AV17TFBR_Medication_RXName ;
      private String AV18TFBR_Medication_RXName_Sel ;
      private String AV19TFBR_Medication_RXCode ;
      private String AV20TFBR_Medication_RXCode_Sel ;
      private String AV29TFBR_Medication_RXQuantity ;
      private String AV30TFBR_Medication_RXQuantity_Sel ;
      private String AV27TFBR_Medication_RXFrequency ;
      private String AV73TFBR_Medication_RXFrequency_Sel ;
      private String AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ;
      private String AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ;
      private String AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ;
      private String AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ;
      private String AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ;
      private String AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ;
      private String AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ;
      private String AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ;
      private String lV80BR_MedicationWWDS_1_Tfbr_medication_rxname ;
      private String lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ;
      private String lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ;
      private String lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ;
      private String A121BR_Medication_RXName ;
      private String A122BR_Medication_RXCode ;
      private String A127BR_Medication_RXQuantity ;
      private String A126BR_Medication_RXFrequency ;
      private String AV57Option ;
      private IGxSession AV66Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P001V2_A121BR_Medication_RXName ;
      private bool[] P001V2_n121BR_Medication_RXName ;
      private DateTime[] P001V2_A132BR_Medication_AdmitStartDate ;
      private bool[] P001V2_n132BR_Medication_AdmitStartDate ;
      private String[] P001V2_A126BR_Medication_RXFrequency ;
      private bool[] P001V2_n126BR_Medication_RXFrequency ;
      private decimal[] P001V2_A128BR_Medication_RXDaysSupply ;
      private bool[] P001V2_n128BR_Medication_RXDaysSupply ;
      private String[] P001V2_A127BR_Medication_RXQuantity ;
      private bool[] P001V2_n127BR_Medication_RXQuantity ;
      private String[] P001V2_A122BR_Medication_RXCode ;
      private bool[] P001V2_n122BR_Medication_RXCode ;
      private long[] P001V2_A119BR_MedicationID ;
      private String[] P001V3_A122BR_Medication_RXCode ;
      private bool[] P001V3_n122BR_Medication_RXCode ;
      private DateTime[] P001V3_A132BR_Medication_AdmitStartDate ;
      private bool[] P001V3_n132BR_Medication_AdmitStartDate ;
      private String[] P001V3_A126BR_Medication_RXFrequency ;
      private bool[] P001V3_n126BR_Medication_RXFrequency ;
      private decimal[] P001V3_A128BR_Medication_RXDaysSupply ;
      private bool[] P001V3_n128BR_Medication_RXDaysSupply ;
      private String[] P001V3_A127BR_Medication_RXQuantity ;
      private bool[] P001V3_n127BR_Medication_RXQuantity ;
      private String[] P001V3_A121BR_Medication_RXName ;
      private bool[] P001V3_n121BR_Medication_RXName ;
      private long[] P001V3_A119BR_MedicationID ;
      private String[] P001V4_A127BR_Medication_RXQuantity ;
      private bool[] P001V4_n127BR_Medication_RXQuantity ;
      private DateTime[] P001V4_A132BR_Medication_AdmitStartDate ;
      private bool[] P001V4_n132BR_Medication_AdmitStartDate ;
      private String[] P001V4_A126BR_Medication_RXFrequency ;
      private bool[] P001V4_n126BR_Medication_RXFrequency ;
      private decimal[] P001V4_A128BR_Medication_RXDaysSupply ;
      private bool[] P001V4_n128BR_Medication_RXDaysSupply ;
      private String[] P001V4_A122BR_Medication_RXCode ;
      private bool[] P001V4_n122BR_Medication_RXCode ;
      private String[] P001V4_A121BR_Medication_RXName ;
      private bool[] P001V4_n121BR_Medication_RXName ;
      private long[] P001V4_A119BR_MedicationID ;
      private String[] P001V5_A126BR_Medication_RXFrequency ;
      private bool[] P001V5_n126BR_Medication_RXFrequency ;
      private DateTime[] P001V5_A132BR_Medication_AdmitStartDate ;
      private bool[] P001V5_n132BR_Medication_AdmitStartDate ;
      private decimal[] P001V5_A128BR_Medication_RXDaysSupply ;
      private bool[] P001V5_n128BR_Medication_RXDaysSupply ;
      private String[] P001V5_A127BR_Medication_RXQuantity ;
      private bool[] P001V5_n127BR_Medication_RXQuantity ;
      private String[] P001V5_A122BR_Medication_RXCode ;
      private bool[] P001V5_n122BR_Medication_RXCode ;
      private String[] P001V5_A121BR_Medication_RXName ;
      private bool[] P001V5_n121BR_Medication_RXName ;
      private long[] P001V5_A119BR_MedicationID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV58Options ;
      private GxSimpleCollection<String> AV61OptionsDesc ;
      private GxSimpleCollection<String> AV63OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV68GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV69GridStateFilterValue ;
   }

   public class br_medicationwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P001V2( IGxContext context ,
                                             String AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [12] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_RXName], [BR_Medication_AdmitStartDate], [BR_Medication_RXFrequency], [BR_Medication_RXDaysSupply], [BR_Medication_RXQuantity], [BR_Medication_RXCode], [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_RXName]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P001V3( IGxContext context ,
                                             String AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_RXCode], [BR_Medication_AdmitStartDate], [BR_Medication_RXFrequency], [BR_Medication_RXDaysSupply], [BR_Medication_RXQuantity], [BR_Medication_RXName], [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_RXCode]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P001V4( IGxContext context ,
                                             String AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [12] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_RXQuantity], [BR_Medication_AdmitStartDate], [BR_Medication_RXFrequency], [BR_Medication_RXDaysSupply], [BR_Medication_RXCode], [BR_Medication_RXName], [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_RXQuantity]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P001V5( IGxContext context ,
                                             String AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel ,
                                             String AV80BR_MedicationWWDS_1_Tfbr_medication_rxname ,
                                             String AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel ,
                                             String AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode ,
                                             String AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel ,
                                             String AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity ,
                                             decimal AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply ,
                                             decimal AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to ,
                                             String AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel ,
                                             String AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency ,
                                             DateTime AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate ,
                                             DateTime AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to ,
                                             String A121BR_Medication_RXName ,
                                             String A122BR_Medication_RXCode ,
                                             String A127BR_Medication_RXQuantity ,
                                             decimal A128BR_Medication_RXDaysSupply ,
                                             String A126BR_Medication_RXFrequency ,
                                             DateTime A132BR_Medication_AdmitStartDate )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [12] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_RXFrequency], [BR_Medication_AdmitStartDate], [BR_Medication_RXDaysSupply], [BR_Medication_RXQuantity], [BR_Medication_RXCode], [BR_Medication_RXName], [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80BR_MedicationWWDS_1_Tfbr_medication_rxname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] like @lV80BR_MedicationWWDS_1_Tfbr_medication_rxname)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXName] = @AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] like @lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXCode] = @AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] like @lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXQuantity] = @AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] >= @AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXDaysSupply] <= @AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] like @lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_RXFrequency] = @AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( ! (DateTime.MinValue==AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] >= @AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_AdmitStartDate] <= @AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_RXFrequency]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P001V2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] );
               case 1 :
                     return conditional_P001V3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] );
               case 2 :
                     return conditional_P001V4(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] );
               case 3 :
                     return conditional_P001V5(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (DateTime)dynConstraints[17] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001V2 ;
          prmP001V2 = new Object[] {
          new Object[] {"@lV80BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001V3 ;
          prmP001V3 = new Object[] {
          new Object[] {"@lV80BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001V4 ;
          prmP001V4 = new Object[] {
          new Object[] {"@lV80BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmP001V5 ;
          prmP001V5 = new Object[] {
          new Object[] {"@lV80BR_MedicationWWDS_1_Tfbr_medication_rxname",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV81BR_MedicationWWDS_2_Tfbr_medication_rxname_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV82BR_MedicationWWDS_3_Tfbr_medication_rxcode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV83BR_MedicationWWDS_4_Tfbr_medication_rxcode_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV84BR_MedicationWWDS_5_Tfbr_medication_rxquantity",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV85BR_MedicationWWDS_6_Tfbr_medication_rxquantity_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV86BR_MedicationWWDS_7_Tfbr_medication_rxdayssupply",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV87BR_MedicationWWDS_8_Tfbr_medication_rxdayssupply_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV88BR_MedicationWWDS_9_Tfbr_medication_rxfrequency",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV89BR_MedicationWWDS_10_Tfbr_medication_rxfrequency_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV90BR_MedicationWWDS_11_Tfbr_medication_admitstartdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV91BR_MedicationWWDS_12_Tfbr_medication_admitstartdate_to",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001V2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V2,100,0,true,false )
             ,new CursorDef("P001V3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V3,100,0,true,false )
             ,new CursorDef("P001V4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V4,100,0,true,false )
             ,new CursorDef("P001V5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001V5,100,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
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
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_medicationwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_medicationwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_medicationwwgetfilterdata") )
          {
             return  ;
          }
          br_medicationwwgetfilterdata worker = new br_medicationwwgetfilterdata(context) ;
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
