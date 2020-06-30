/*
               File: BR_Medication_SchemeWWGetFilterData
        Description: BR_Medication_Scheme WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:2.31
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
   public class br_medication_schemewwgetfilterdata : GXProcedure
   {
      public br_medication_schemewwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_schemewwgetfilterdata( IGxContext context )
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
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
         return AV34OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_medication_schemewwgetfilterdata objbr_medication_schemewwgetfilterdata;
         objbr_medication_schemewwgetfilterdata = new br_medication_schemewwgetfilterdata();
         objbr_medication_schemewwgetfilterdata.AV25DDOName = aP0_DDOName;
         objbr_medication_schemewwgetfilterdata.AV23SearchTxt = aP1_SearchTxt;
         objbr_medication_schemewwgetfilterdata.AV24SearchTxtTo = aP2_SearchTxtTo;
         objbr_medication_schemewwgetfilterdata.AV29OptionsJson = "" ;
         objbr_medication_schemewwgetfilterdata.AV32OptionsDescJson = "" ;
         objbr_medication_schemewwgetfilterdata.AV34OptionIndexesJson = "" ;
         objbr_medication_schemewwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_medication_schemewwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_medication_schemewwgetfilterdata);
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_medication_schemewwgetfilterdata)stateInfo).executePrivate();
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
         AV28Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Scheme", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_MEDICATION_CHEM_NAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_CHEM_NAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_MEDICATION_CHEM_LINE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_CHEM_LINEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_BR_MEDICATION_CHEM_DETAIL") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_CHEM_DETAILOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV29OptionsJson = AV28Options.ToJSonString(false);
         AV32OptionsDescJson = AV31OptionsDesc.ToJSonString(false);
         AV34OptionIndexesJson = AV33OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV36Session.Get("BR_Medication_SchemeWWGridState"), "") == 0 )
         {
            AV38GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Medication_SchemeWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV38GridState.FromXml(AV36Session.Get("BR_Medication_SchemeWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV53GXV1 = 1;
         while ( AV53GXV1 <= AV38GridState.gxTpr_Filtervalues.Count )
         {
            AV39GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV38GridState.gxTpr_Filtervalues.Item(AV53GXV1));
            if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_SCHEMEID") == 0 )
            {
               AV11TFBR_Medication_SchemeID = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATIONID") == 0 )
            {
               AV13TFBR_MedicationID = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_MedicationID_To = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_NAME") == 0 )
            {
               AV41TFBR_Medication_Chem_Name = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_NAME_SEL") == 0 )
            {
               AV42TFBR_Medication_Chem_Name_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_CYCLE") == 0 )
            {
               AV43TFBR_Medication_Chem_Cycle = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, ".");
               AV44TFBR_Medication_Chem_Cycle_To = NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_LINE") == 0 )
            {
               AV45TFBR_Medication_Chem_Line = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_LINE_SEL") == 0 )
            {
               AV46TFBR_Medication_Chem_Line_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_DETAIL") == 0 )
            {
               AV49TFBR_Medication_Chem_Detail = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_CHEM_DETAIL_SEL") == 0 )
            {
               AV50TFBR_Medication_Chem_Detail_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            AV53GXV1 = (int)(AV53GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_MEDICATION_CHEM_NAMEOPTIONS' Routine */
         AV41TFBR_Medication_Chem_Name = AV23SearchTxt;
         AV42TFBR_Medication_Chem_Name_Sel = "";
         AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV11TFBR_Medication_SchemeID;
         AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV12TFBR_Medication_SchemeID_To;
         AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV13TFBR_MedicationID;
         AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV14TFBR_MedicationID_To;
         AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV41TFBR_Medication_Chem_Name;
         AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV42TFBR_Medication_Chem_Name_Sel;
         AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV43TFBR_Medication_Chem_Cycle;
         AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV44TFBR_Medication_Chem_Cycle_To;
         AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV45TFBR_Medication_Chem_Line;
         AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV46TFBR_Medication_Chem_Line_Sel;
         AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV49TFBR_Medication_Chem_Detail;
         AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV50TFBR_Medication_Chem_Detail_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                              AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                              AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                              AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                              AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                              AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                              AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                              AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                              AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                              AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                              AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                              AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                              A296BR_Medication_SchemeID ,
                                              A119BR_MedicationID ,
                                              A305BR_Medication_Chem_Name ,
                                              A306BR_Medication_Chem_Cycle ,
                                              A307BR_Medication_Chem_Line ,
                                              A313BR_Medication_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = StringUtil.Concat( StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name), "%", "");
         lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = StringUtil.Concat( StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line), "%", "");
         lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail), "%", "");
         /* Using cursor P002R2 */
         pr_default.execute(0, new Object[] {AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid, AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to, AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid, AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to, lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name, AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel, AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle, AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to, lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line, AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel, lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail, AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2R2 = false;
            A305BR_Medication_Chem_Name = P002R2_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = P002R2_n305BR_Medication_Chem_Name[0];
            A313BR_Medication_Chem_Detail = P002R2_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = P002R2_n313BR_Medication_Chem_Detail[0];
            A307BR_Medication_Chem_Line = P002R2_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = P002R2_n307BR_Medication_Chem_Line[0];
            A306BR_Medication_Chem_Cycle = P002R2_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = P002R2_n306BR_Medication_Chem_Cycle[0];
            A119BR_MedicationID = P002R2_A119BR_MedicationID[0];
            n119BR_MedicationID = P002R2_n119BR_MedicationID[0];
            A296BR_Medication_SchemeID = P002R2_A296BR_Medication_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002R2_A305BR_Medication_Chem_Name[0], A305BR_Medication_Chem_Name) == 0 ) )
            {
               BRK2R2 = false;
               A296BR_Medication_SchemeID = P002R2_A296BR_Medication_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK2R2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A305BR_Medication_Chem_Name)) )
            {
               AV27Option = A305BR_Medication_Chem_Name;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2R2 )
            {
               BRK2R2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICATION_CHEM_LINEOPTIONS' Routine */
         AV45TFBR_Medication_Chem_Line = AV23SearchTxt;
         AV46TFBR_Medication_Chem_Line_Sel = "";
         AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV11TFBR_Medication_SchemeID;
         AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV12TFBR_Medication_SchemeID_To;
         AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV13TFBR_MedicationID;
         AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV14TFBR_MedicationID_To;
         AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV41TFBR_Medication_Chem_Name;
         AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV42TFBR_Medication_Chem_Name_Sel;
         AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV43TFBR_Medication_Chem_Cycle;
         AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV44TFBR_Medication_Chem_Cycle_To;
         AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV45TFBR_Medication_Chem_Line;
         AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV46TFBR_Medication_Chem_Line_Sel;
         AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV49TFBR_Medication_Chem_Detail;
         AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV50TFBR_Medication_Chem_Detail_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                              AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                              AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                              AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                              AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                              AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                              AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                              AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                              AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                              AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                              AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                              AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                              A296BR_Medication_SchemeID ,
                                              A119BR_MedicationID ,
                                              A305BR_Medication_Chem_Name ,
                                              A306BR_Medication_Chem_Cycle ,
                                              A307BR_Medication_Chem_Line ,
                                              A313BR_Medication_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = StringUtil.Concat( StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name), "%", "");
         lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = StringUtil.Concat( StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line), "%", "");
         lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail), "%", "");
         /* Using cursor P002R3 */
         pr_default.execute(1, new Object[] {AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid, AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to, AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid, AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to, lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name, AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel, AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle, AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to, lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line, AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel, lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail, AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2R4 = false;
            A307BR_Medication_Chem_Line = P002R3_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = P002R3_n307BR_Medication_Chem_Line[0];
            A313BR_Medication_Chem_Detail = P002R3_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = P002R3_n313BR_Medication_Chem_Detail[0];
            A306BR_Medication_Chem_Cycle = P002R3_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = P002R3_n306BR_Medication_Chem_Cycle[0];
            A305BR_Medication_Chem_Name = P002R3_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = P002R3_n305BR_Medication_Chem_Name[0];
            A119BR_MedicationID = P002R3_A119BR_MedicationID[0];
            n119BR_MedicationID = P002R3_n119BR_MedicationID[0];
            A296BR_Medication_SchemeID = P002R3_A296BR_Medication_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002R3_A307BR_Medication_Chem_Line[0], A307BR_Medication_Chem_Line) == 0 ) )
            {
               BRK2R4 = false;
               A296BR_Medication_SchemeID = P002R3_A296BR_Medication_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK2R4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A307BR_Medication_Chem_Line)) )
            {
               AV27Option = A307BR_Medication_Chem_Line;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2R4 )
            {
               BRK2R4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_MEDICATION_CHEM_DETAILOPTIONS' Routine */
         AV49TFBR_Medication_Chem_Detail = AV23SearchTxt;
         AV50TFBR_Medication_Chem_Detail_Sel = "";
         AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid = AV11TFBR_Medication_SchemeID;
         AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to = AV12TFBR_Medication_SchemeID_To;
         AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid = AV13TFBR_MedicationID;
         AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to = AV14TFBR_MedicationID_To;
         AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = AV41TFBR_Medication_Chem_Name;
         AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = AV42TFBR_Medication_Chem_Name_Sel;
         AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle = AV43TFBR_Medication_Chem_Cycle;
         AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to = AV44TFBR_Medication_Chem_Cycle_To;
         AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = AV45TFBR_Medication_Chem_Line;
         AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = AV46TFBR_Medication_Chem_Line_Sel;
         AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = AV49TFBR_Medication_Chem_Detail;
         AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = AV50TFBR_Medication_Chem_Detail_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                              AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                              AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                              AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                              AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                              AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                              AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                              AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                              AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                              AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                              AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                              AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                              A296BR_Medication_SchemeID ,
                                              A119BR_MedicationID ,
                                              A305BR_Medication_Chem_Name ,
                                              A306BR_Medication_Chem_Cycle ,
                                              A307BR_Medication_Chem_Line ,
                                              A313BR_Medication_Chem_Detail } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = StringUtil.Concat( StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name), "%", "");
         lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = StringUtil.Concat( StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line), "%", "");
         lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = StringUtil.Concat( StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail), "%", "");
         /* Using cursor P002R4 */
         pr_default.execute(2, new Object[] {AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid, AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to, AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid, AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to, lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name, AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel, AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle, AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to, lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line, AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel, lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail, AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK2R6 = false;
            A313BR_Medication_Chem_Detail = P002R4_A313BR_Medication_Chem_Detail[0];
            n313BR_Medication_Chem_Detail = P002R4_n313BR_Medication_Chem_Detail[0];
            A307BR_Medication_Chem_Line = P002R4_A307BR_Medication_Chem_Line[0];
            n307BR_Medication_Chem_Line = P002R4_n307BR_Medication_Chem_Line[0];
            A306BR_Medication_Chem_Cycle = P002R4_A306BR_Medication_Chem_Cycle[0];
            n306BR_Medication_Chem_Cycle = P002R4_n306BR_Medication_Chem_Cycle[0];
            A305BR_Medication_Chem_Name = P002R4_A305BR_Medication_Chem_Name[0];
            n305BR_Medication_Chem_Name = P002R4_n305BR_Medication_Chem_Name[0];
            A119BR_MedicationID = P002R4_A119BR_MedicationID[0];
            n119BR_MedicationID = P002R4_n119BR_MedicationID[0];
            A296BR_Medication_SchemeID = P002R4_A296BR_Medication_SchemeID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P002R4_A313BR_Medication_Chem_Detail[0], A313BR_Medication_Chem_Detail) == 0 ) )
            {
               BRK2R6 = false;
               A296BR_Medication_SchemeID = P002R4_A296BR_Medication_SchemeID[0];
               AV35count = (long)(AV35count+1);
               BRK2R6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A313BR_Medication_Chem_Detail)) )
            {
               AV27Option = A313BR_Medication_Chem_Detail;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2R6 )
            {
               BRK2R6 = true;
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
         AV28Options = new GxSimpleCollection<String>();
         AV31OptionsDesc = new GxSimpleCollection<String>();
         AV33OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36Session = context.GetSession();
         AV38GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV39GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV41TFBR_Medication_Chem_Name = "";
         AV42TFBR_Medication_Chem_Name_Sel = "";
         AV45TFBR_Medication_Chem_Line = "";
         AV46TFBR_Medication_Chem_Line_Sel = "";
         AV49TFBR_Medication_Chem_Detail = "";
         AV50TFBR_Medication_Chem_Detail_Sel = "";
         AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = "";
         AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel = "";
         AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = "";
         AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel = "";
         AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = "";
         AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel = "";
         scmdbuf = "";
         lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name = "";
         lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line = "";
         lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail = "";
         A305BR_Medication_Chem_Name = "";
         A307BR_Medication_Chem_Line = "";
         A313BR_Medication_Chem_Detail = "";
         P002R2_A305BR_Medication_Chem_Name = new String[] {""} ;
         P002R2_n305BR_Medication_Chem_Name = new bool[] {false} ;
         P002R2_A313BR_Medication_Chem_Detail = new String[] {""} ;
         P002R2_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         P002R2_A307BR_Medication_Chem_Line = new String[] {""} ;
         P002R2_n307BR_Medication_Chem_Line = new bool[] {false} ;
         P002R2_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         P002R2_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         P002R2_A119BR_MedicationID = new long[1] ;
         P002R2_n119BR_MedicationID = new bool[] {false} ;
         P002R2_A296BR_Medication_SchemeID = new long[1] ;
         AV27Option = "";
         P002R3_A307BR_Medication_Chem_Line = new String[] {""} ;
         P002R3_n307BR_Medication_Chem_Line = new bool[] {false} ;
         P002R3_A313BR_Medication_Chem_Detail = new String[] {""} ;
         P002R3_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         P002R3_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         P002R3_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         P002R3_A305BR_Medication_Chem_Name = new String[] {""} ;
         P002R3_n305BR_Medication_Chem_Name = new bool[] {false} ;
         P002R3_A119BR_MedicationID = new long[1] ;
         P002R3_n119BR_MedicationID = new bool[] {false} ;
         P002R3_A296BR_Medication_SchemeID = new long[1] ;
         P002R4_A313BR_Medication_Chem_Detail = new String[] {""} ;
         P002R4_n313BR_Medication_Chem_Detail = new bool[] {false} ;
         P002R4_A307BR_Medication_Chem_Line = new String[] {""} ;
         P002R4_n307BR_Medication_Chem_Line = new bool[] {false} ;
         P002R4_A306BR_Medication_Chem_Cycle = new decimal[1] ;
         P002R4_n306BR_Medication_Chem_Cycle = new bool[] {false} ;
         P002R4_A305BR_Medication_Chem_Name = new String[] {""} ;
         P002R4_n305BR_Medication_Chem_Name = new bool[] {false} ;
         P002R4_A119BR_MedicationID = new long[1] ;
         P002R4_n119BR_MedicationID = new bool[] {false} ;
         P002R4_A296BR_Medication_SchemeID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_schemewwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002R2_A305BR_Medication_Chem_Name, P002R2_n305BR_Medication_Chem_Name, P002R2_A313BR_Medication_Chem_Detail, P002R2_n313BR_Medication_Chem_Detail, P002R2_A307BR_Medication_Chem_Line, P002R2_n307BR_Medication_Chem_Line, P002R2_A306BR_Medication_Chem_Cycle, P002R2_n306BR_Medication_Chem_Cycle, P002R2_A119BR_MedicationID, P002R2_n119BR_MedicationID,
               P002R2_A296BR_Medication_SchemeID
               }
               , new Object[] {
               P002R3_A307BR_Medication_Chem_Line, P002R3_n307BR_Medication_Chem_Line, P002R3_A313BR_Medication_Chem_Detail, P002R3_n313BR_Medication_Chem_Detail, P002R3_A306BR_Medication_Chem_Cycle, P002R3_n306BR_Medication_Chem_Cycle, P002R3_A305BR_Medication_Chem_Name, P002R3_n305BR_Medication_Chem_Name, P002R3_A119BR_MedicationID, P002R3_n119BR_MedicationID,
               P002R3_A296BR_Medication_SchemeID
               }
               , new Object[] {
               P002R4_A313BR_Medication_Chem_Detail, P002R4_n313BR_Medication_Chem_Detail, P002R4_A307BR_Medication_Chem_Line, P002R4_n307BR_Medication_Chem_Line, P002R4_A306BR_Medication_Chem_Cycle, P002R4_n306BR_Medication_Chem_Cycle, P002R4_A305BR_Medication_Chem_Name, P002R4_n305BR_Medication_Chem_Name, P002R4_A119BR_MedicationID, P002R4_n119BR_MedicationID,
               P002R4_A296BR_Medication_SchemeID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV53GXV1 ;
      private long AV11TFBR_Medication_SchemeID ;
      private long AV12TFBR_Medication_SchemeID_To ;
      private long AV13TFBR_MedicationID ;
      private long AV14TFBR_MedicationID_To ;
      private long AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ;
      private long AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ;
      private long AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ;
      private long AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ;
      private long A296BR_Medication_SchemeID ;
      private long A119BR_MedicationID ;
      private long AV35count ;
      private decimal AV43TFBR_Medication_Chem_Cycle ;
      private decimal AV44TFBR_Medication_Chem_Cycle_To ;
      private decimal AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ;
      private decimal AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ;
      private decimal A306BR_Medication_Chem_Cycle ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2R2 ;
      private bool n305BR_Medication_Chem_Name ;
      private bool n313BR_Medication_Chem_Detail ;
      private bool n307BR_Medication_Chem_Line ;
      private bool n306BR_Medication_Chem_Cycle ;
      private bool n119BR_MedicationID ;
      private bool BRK2R4 ;
      private bool BRK2R6 ;
      private String AV34OptionIndexesJson ;
      private String AV29OptionsJson ;
      private String AV32OptionsDescJson ;
      private String AV25DDOName ;
      private String AV23SearchTxt ;
      private String AV24SearchTxtTo ;
      private String AV41TFBR_Medication_Chem_Name ;
      private String AV42TFBR_Medication_Chem_Name_Sel ;
      private String AV45TFBR_Medication_Chem_Line ;
      private String AV46TFBR_Medication_Chem_Line_Sel ;
      private String AV49TFBR_Medication_Chem_Detail ;
      private String AV50TFBR_Medication_Chem_Detail_Sel ;
      private String AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ;
      private String AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ;
      private String AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ;
      private String AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ;
      private String AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ;
      private String AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ;
      private String lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ;
      private String lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ;
      private String lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ;
      private String A305BR_Medication_Chem_Name ;
      private String A307BR_Medication_Chem_Line ;
      private String A313BR_Medication_Chem_Detail ;
      private String AV27Option ;
      private IGxSession AV36Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002R2_A305BR_Medication_Chem_Name ;
      private bool[] P002R2_n305BR_Medication_Chem_Name ;
      private String[] P002R2_A313BR_Medication_Chem_Detail ;
      private bool[] P002R2_n313BR_Medication_Chem_Detail ;
      private String[] P002R2_A307BR_Medication_Chem_Line ;
      private bool[] P002R2_n307BR_Medication_Chem_Line ;
      private decimal[] P002R2_A306BR_Medication_Chem_Cycle ;
      private bool[] P002R2_n306BR_Medication_Chem_Cycle ;
      private long[] P002R2_A119BR_MedicationID ;
      private bool[] P002R2_n119BR_MedicationID ;
      private long[] P002R2_A296BR_Medication_SchemeID ;
      private String[] P002R3_A307BR_Medication_Chem_Line ;
      private bool[] P002R3_n307BR_Medication_Chem_Line ;
      private String[] P002R3_A313BR_Medication_Chem_Detail ;
      private bool[] P002R3_n313BR_Medication_Chem_Detail ;
      private decimal[] P002R3_A306BR_Medication_Chem_Cycle ;
      private bool[] P002R3_n306BR_Medication_Chem_Cycle ;
      private String[] P002R3_A305BR_Medication_Chem_Name ;
      private bool[] P002R3_n305BR_Medication_Chem_Name ;
      private long[] P002R3_A119BR_MedicationID ;
      private bool[] P002R3_n119BR_MedicationID ;
      private long[] P002R3_A296BR_Medication_SchemeID ;
      private String[] P002R4_A313BR_Medication_Chem_Detail ;
      private bool[] P002R4_n313BR_Medication_Chem_Detail ;
      private String[] P002R4_A307BR_Medication_Chem_Line ;
      private bool[] P002R4_n307BR_Medication_Chem_Line ;
      private decimal[] P002R4_A306BR_Medication_Chem_Cycle ;
      private bool[] P002R4_n306BR_Medication_Chem_Cycle ;
      private String[] P002R4_A305BR_Medication_Chem_Name ;
      private bool[] P002R4_n305BR_Medication_Chem_Name ;
      private long[] P002R4_A119BR_MedicationID ;
      private bool[] P002R4_n119BR_MedicationID ;
      private long[] P002R4_A296BR_Medication_SchemeID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV28Options ;
      private GxSimpleCollection<String> AV31OptionsDesc ;
      private GxSimpleCollection<String> AV33OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV38GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV39GridStateFilterValue ;
   }

   public class br_medication_schemewwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002R2( IGxContext context ,
                                             long AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                             long AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                             long AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                             long AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                             String AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                             String AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                             decimal AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                             decimal AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                             String AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                             String AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                             String AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                             String AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                             long A296BR_Medication_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A305BR_Medication_Chem_Name ,
                                             decimal A306BR_Medication_Chem_Cycle ,
                                             String A307BR_Medication_Chem_Line ,
                                             String A313BR_Medication_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [12] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_Chem_Name], [BR_Medication_Chem_Detail], [BR_Medication_Chem_Line], [BR_Medication_Chem_Cycle], [BR_MedicationID], [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_Chem_Name]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002R3( IGxContext context ,
                                             long AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                             long AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                             long AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                             long AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                             String AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                             String AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                             decimal AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                             decimal AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                             String AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                             String AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                             String AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                             String AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                             long A296BR_Medication_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A305BR_Medication_Chem_Name ,
                                             decimal A306BR_Medication_Chem_Cycle ,
                                             String A307BR_Medication_Chem_Line ,
                                             String A313BR_Medication_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_Chem_Line], [BR_Medication_Chem_Detail], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Name], [BR_MedicationID], [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_Chem_Line]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P002R4( IGxContext context ,
                                             long AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid ,
                                             long AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to ,
                                             long AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid ,
                                             long AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to ,
                                             String AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel ,
                                             String AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name ,
                                             decimal AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle ,
                                             decimal AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to ,
                                             String AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel ,
                                             String AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line ,
                                             String AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel ,
                                             String AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail ,
                                             long A296BR_Medication_SchemeID ,
                                             long A119BR_MedicationID ,
                                             String A305BR_Medication_Chem_Name ,
                                             decimal A306BR_Medication_Chem_Cycle ,
                                             String A307BR_Medication_Chem_Line ,
                                             String A313BR_Medication_Chem_Detail )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [12] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_Chem_Detail], [BR_Medication_Chem_Line], [BR_Medication_Chem_Cycle], [BR_Medication_Chem_Name], [BR_MedicationID], [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK)";
         if ( ! (0==AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] >= @AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicationID] <= @AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] like @lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Name] = @AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] >= @AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Cycle] <= @AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] like @lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Line] = @AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] like @lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Chem_Detail] = @AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_Chem_Detail]";
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
                     return conditional_P002R2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 1 :
                     return conditional_P002R3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 2 :
                     return conditional_P002R4(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
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
          Object[] prmP002R2 ;
          prmP002R2 = new Object[] {
          new Object[] {"@AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP002R3 ;
          prmP002R3 = new Object[] {
          new Object[] {"@AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP002R4 ;
          prmP002R4 = new Object[] {
          new Object[] {"@AV55BR_Medication_SchemeWWDS_1_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_Medication_SchemeWWDS_2_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV57BR_Medication_SchemeWWDS_3_Tfbr_medicationid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV58BR_Medication_SchemeWWDS_4_Tfbr_medicationid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV59BR_Medication_SchemeWWDS_5_Tfbr_medication_chem_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV60BR_Medication_SchemeWWDS_6_Tfbr_medication_chem_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV61BR_Medication_SchemeWWDS_7_Tfbr_medication_chem_cycle",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV62BR_Medication_SchemeWWDS_8_Tfbr_medication_chem_cycle_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV63BR_Medication_SchemeWWDS_9_Tfbr_medication_chem_line",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV64BR_Medication_SchemeWWDS_10_Tfbr_medication_chem_line_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV65BR_Medication_SchemeWWDS_11_Tfbr_medication_chem_detail",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Medication_SchemeWWDS_12_Tfbr_medication_chem_detail_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002R2,100,0,true,false )
             ,new CursorDef("P002R3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002R3,100,0,true,false )
             ,new CursorDef("P002R4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002R4,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
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
                return;
             case 2 :
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_medication_schemewwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_medication_schemewwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_medication_schemewwgetfilterdata") )
          {
             return  ;
          }
          br_medication_schemewwgetfilterdata worker = new br_medication_schemewwgetfilterdata(context) ;
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
