/*
               File: BR_Medication_DetailWWGetFilterData
        Description: BR_Medication_Detail WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:5.47
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
   public class br_medication_detailwwgetfilterdata : GXProcedure
   {
      public br_medication_detailwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_detailwwgetfilterdata( IGxContext context )
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
         this.AV23DDOName = aP0_DDOName;
         this.AV21SearchTxt = aP1_SearchTxt;
         this.AV22SearchTxtTo = aP2_SearchTxtTo;
         this.AV27OptionsJson = "" ;
         this.AV30OptionsDescJson = "" ;
         this.AV32OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV23DDOName = aP0_DDOName;
         this.AV21SearchTxt = aP1_SearchTxt;
         this.AV22SearchTxtTo = aP2_SearchTxtTo;
         this.AV27OptionsJson = "" ;
         this.AV30OptionsDescJson = "" ;
         this.AV32OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
         return AV32OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_medication_detailwwgetfilterdata objbr_medication_detailwwgetfilterdata;
         objbr_medication_detailwwgetfilterdata = new br_medication_detailwwgetfilterdata();
         objbr_medication_detailwwgetfilterdata.AV23DDOName = aP0_DDOName;
         objbr_medication_detailwwgetfilterdata.AV21SearchTxt = aP1_SearchTxt;
         objbr_medication_detailwwgetfilterdata.AV22SearchTxtTo = aP2_SearchTxtTo;
         objbr_medication_detailwwgetfilterdata.AV27OptionsJson = "" ;
         objbr_medication_detailwwgetfilterdata.AV30OptionsDescJson = "" ;
         objbr_medication_detailwwgetfilterdata.AV32OptionIndexesJson = "" ;
         objbr_medication_detailwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_medication_detailwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_medication_detailwwgetfilterdata);
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_medication_detailwwgetfilterdata)stateInfo).executePrivate();
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
         AV26Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV29OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_MEDICATION_DRUG_NAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_DRUG_NAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_MEDICATION_DRUG_UNIT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_DRUG_UNITOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV27OptionsJson = AV26Options.ToJSonString(false);
         AV30OptionsDescJson = AV29OptionsDesc.ToJSonString(false);
         AV32OptionIndexesJson = AV31OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV34Session.Get("BR_Medication_DetailWWGridState"), "") == 0 )
         {
            AV36GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Medication_DetailWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV36GridState.FromXml(AV34Session.Get("BR_Medication_DetailWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV47GXV1 = 1;
         while ( AV47GXV1 <= AV36GridState.gxTpr_Filtervalues.Count )
         {
            AV37GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV36GridState.gxTpr_Filtervalues.Item(AV47GXV1));
            if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DETAILID") == 0 )
            {
               AV11TFBR_Medication_DetailID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Medication_DetailID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_SCHEMEID") == 0 )
            {
               AV13TFBR_Medication_SchemeID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_Medication_SchemeID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NAME") == 0 )
            {
               AV39TFBR_Medication_Drug_Name = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NAME_SEL") == 0 )
            {
               AV40TFBR_Medication_Drug_Name_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_NUM") == 0 )
            {
               AV41TFBR_Medication_Drug_Num = NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, ".");
               AV42TFBR_Medication_Drug_Num_To = NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_UNIT") == 0 )
            {
               AV43TFBR_Medication_Drug_Unit = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_DRUG_UNIT_SEL") == 0 )
            {
               AV44TFBR_Medication_Drug_Unit_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            AV47GXV1 = (int)(AV47GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_MEDICATION_DRUG_NAMEOPTIONS' Routine */
         AV39TFBR_Medication_Drug_Name = AV21SearchTxt;
         AV40TFBR_Medication_Drug_Name_Sel = "";
         AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV11TFBR_Medication_DetailID;
         AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV12TFBR_Medication_DetailID_To;
         AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV13TFBR_Medication_SchemeID;
         AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV14TFBR_Medication_SchemeID_To;
         AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV39TFBR_Medication_Drug_Name;
         AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV40TFBR_Medication_Drug_Name_Sel;
         AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV41TFBR_Medication_Drug_Num;
         AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV42TFBR_Medication_Drug_Num_To;
         AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV43TFBR_Medication_Drug_Unit;
         AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV44TFBR_Medication_Drug_Unit_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                              AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                              AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                              AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                              AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                              AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                              AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                              AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                              AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                              AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                              A301BR_Medication_DetailID ,
                                              A296BR_Medication_SchemeID ,
                                              A310BR_Medication_Drug_Name ,
                                              A311BR_Medication_Drug_Num ,
                                              A312BR_Medication_Drug_Unit } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = StringUtil.Concat( StringUtil.RTrim( AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name), "%", "");
         lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = StringUtil.Concat( StringUtil.RTrim( AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit), "%", "");
         /* Using cursor P002K2 */
         pr_default.execute(0, new Object[] {AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid, AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to, AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid, AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to, lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name, AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel, AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num, AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to, lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit, AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2K2 = false;
            A310BR_Medication_Drug_Name = P002K2_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = P002K2_n310BR_Medication_Drug_Name[0];
            A312BR_Medication_Drug_Unit = P002K2_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = P002K2_n312BR_Medication_Drug_Unit[0];
            A311BR_Medication_Drug_Num = P002K2_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = P002K2_n311BR_Medication_Drug_Num[0];
            A296BR_Medication_SchemeID = P002K2_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = P002K2_n296BR_Medication_SchemeID[0];
            A301BR_Medication_DetailID = P002K2_A301BR_Medication_DetailID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002K2_A310BR_Medication_Drug_Name[0], A310BR_Medication_Drug_Name) == 0 ) )
            {
               BRK2K2 = false;
               A301BR_Medication_DetailID = P002K2_A301BR_Medication_DetailID[0];
               AV33count = (long)(AV33count+1);
               BRK2K2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) )
            {
               AV25Option = A310BR_Medication_Drug_Name;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2K2 )
            {
               BRK2K2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICATION_DRUG_UNITOPTIONS' Routine */
         AV43TFBR_Medication_Drug_Unit = AV21SearchTxt;
         AV44TFBR_Medication_Drug_Unit_Sel = "";
         AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid = AV11TFBR_Medication_DetailID;
         AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to = AV12TFBR_Medication_DetailID_To;
         AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid = AV13TFBR_Medication_SchemeID;
         AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to = AV14TFBR_Medication_SchemeID_To;
         AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = AV39TFBR_Medication_Drug_Name;
         AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = AV40TFBR_Medication_Drug_Name_Sel;
         AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num = AV41TFBR_Medication_Drug_Num;
         AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to = AV42TFBR_Medication_Drug_Num_To;
         AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = AV43TFBR_Medication_Drug_Unit;
         AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = AV44TFBR_Medication_Drug_Unit_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                              AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                              AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                              AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                              AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                              AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                              AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                              AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                              AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                              AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                              A301BR_Medication_DetailID ,
                                              A296BR_Medication_SchemeID ,
                                              A310BR_Medication_Drug_Name ,
                                              A311BR_Medication_Drug_Num ,
                                              A312BR_Medication_Drug_Unit } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = StringUtil.Concat( StringUtil.RTrim( AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name), "%", "");
         lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = StringUtil.Concat( StringUtil.RTrim( AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit), "%", "");
         /* Using cursor P002K3 */
         pr_default.execute(1, new Object[] {AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid, AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to, AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid, AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to, lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name, AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel, AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num, AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to, lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit, AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2K4 = false;
            A312BR_Medication_Drug_Unit = P002K3_A312BR_Medication_Drug_Unit[0];
            n312BR_Medication_Drug_Unit = P002K3_n312BR_Medication_Drug_Unit[0];
            A311BR_Medication_Drug_Num = P002K3_A311BR_Medication_Drug_Num[0];
            n311BR_Medication_Drug_Num = P002K3_n311BR_Medication_Drug_Num[0];
            A310BR_Medication_Drug_Name = P002K3_A310BR_Medication_Drug_Name[0];
            n310BR_Medication_Drug_Name = P002K3_n310BR_Medication_Drug_Name[0];
            A296BR_Medication_SchemeID = P002K3_A296BR_Medication_SchemeID[0];
            n296BR_Medication_SchemeID = P002K3_n296BR_Medication_SchemeID[0];
            A301BR_Medication_DetailID = P002K3_A301BR_Medication_DetailID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002K3_A312BR_Medication_Drug_Unit[0], A312BR_Medication_Drug_Unit) == 0 ) )
            {
               BRK2K4 = false;
               A301BR_Medication_DetailID = P002K3_A301BR_Medication_DetailID[0];
               AV33count = (long)(AV33count+1);
               BRK2K4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A312BR_Medication_Drug_Unit)) )
            {
               AV25Option = A312BR_Medication_Drug_Unit;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2K4 )
            {
               BRK2K4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
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
         AV26Options = new GxSimpleCollection<String>();
         AV29OptionsDesc = new GxSimpleCollection<String>();
         AV31OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV34Session = context.GetSession();
         AV36GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV37GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV39TFBR_Medication_Drug_Name = "";
         AV40TFBR_Medication_Drug_Name_Sel = "";
         AV43TFBR_Medication_Drug_Unit = "";
         AV44TFBR_Medication_Drug_Unit_Sel = "";
         AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = "";
         AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel = "";
         AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = "";
         AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel = "";
         scmdbuf = "";
         lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name = "";
         lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit = "";
         A310BR_Medication_Drug_Name = "";
         A312BR_Medication_Drug_Unit = "";
         P002K2_A310BR_Medication_Drug_Name = new String[] {""} ;
         P002K2_n310BR_Medication_Drug_Name = new bool[] {false} ;
         P002K2_A312BR_Medication_Drug_Unit = new String[] {""} ;
         P002K2_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         P002K2_A311BR_Medication_Drug_Num = new decimal[1] ;
         P002K2_n311BR_Medication_Drug_Num = new bool[] {false} ;
         P002K2_A296BR_Medication_SchemeID = new long[1] ;
         P002K2_n296BR_Medication_SchemeID = new bool[] {false} ;
         P002K2_A301BR_Medication_DetailID = new long[1] ;
         AV25Option = "";
         P002K3_A312BR_Medication_Drug_Unit = new String[] {""} ;
         P002K3_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         P002K3_A311BR_Medication_Drug_Num = new decimal[1] ;
         P002K3_n311BR_Medication_Drug_Num = new bool[] {false} ;
         P002K3_A310BR_Medication_Drug_Name = new String[] {""} ;
         P002K3_n310BR_Medication_Drug_Name = new bool[] {false} ;
         P002K3_A296BR_Medication_SchemeID = new long[1] ;
         P002K3_n296BR_Medication_SchemeID = new bool[] {false} ;
         P002K3_A301BR_Medication_DetailID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detailwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002K2_A310BR_Medication_Drug_Name, P002K2_n310BR_Medication_Drug_Name, P002K2_A312BR_Medication_Drug_Unit, P002K2_n312BR_Medication_Drug_Unit, P002K2_A311BR_Medication_Drug_Num, P002K2_n311BR_Medication_Drug_Num, P002K2_A296BR_Medication_SchemeID, P002K2_n296BR_Medication_SchemeID, P002K2_A301BR_Medication_DetailID
               }
               , new Object[] {
               P002K3_A312BR_Medication_Drug_Unit, P002K3_n312BR_Medication_Drug_Unit, P002K3_A311BR_Medication_Drug_Num, P002K3_n311BR_Medication_Drug_Num, P002K3_A310BR_Medication_Drug_Name, P002K3_n310BR_Medication_Drug_Name, P002K3_A296BR_Medication_SchemeID, P002K3_n296BR_Medication_SchemeID, P002K3_A301BR_Medication_DetailID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV47GXV1 ;
      private long AV11TFBR_Medication_DetailID ;
      private long AV12TFBR_Medication_DetailID_To ;
      private long AV13TFBR_Medication_SchemeID ;
      private long AV14TFBR_Medication_SchemeID_To ;
      private long AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ;
      private long AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ;
      private long AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ;
      private long AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ;
      private long A301BR_Medication_DetailID ;
      private long A296BR_Medication_SchemeID ;
      private long AV33count ;
      private decimal AV41TFBR_Medication_Drug_Num ;
      private decimal AV42TFBR_Medication_Drug_Num_To ;
      private decimal AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ;
      private decimal AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ;
      private decimal A311BR_Medication_Drug_Num ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2K2 ;
      private bool n310BR_Medication_Drug_Name ;
      private bool n312BR_Medication_Drug_Unit ;
      private bool n311BR_Medication_Drug_Num ;
      private bool n296BR_Medication_SchemeID ;
      private bool BRK2K4 ;
      private String AV32OptionIndexesJson ;
      private String AV27OptionsJson ;
      private String AV30OptionsDescJson ;
      private String AV23DDOName ;
      private String AV21SearchTxt ;
      private String AV22SearchTxtTo ;
      private String AV39TFBR_Medication_Drug_Name ;
      private String AV40TFBR_Medication_Drug_Name_Sel ;
      private String AV43TFBR_Medication_Drug_Unit ;
      private String AV44TFBR_Medication_Drug_Unit_Sel ;
      private String AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ;
      private String AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ;
      private String AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ;
      private String AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ;
      private String lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ;
      private String lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ;
      private String A310BR_Medication_Drug_Name ;
      private String A312BR_Medication_Drug_Unit ;
      private String AV25Option ;
      private IGxSession AV34Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002K2_A310BR_Medication_Drug_Name ;
      private bool[] P002K2_n310BR_Medication_Drug_Name ;
      private String[] P002K2_A312BR_Medication_Drug_Unit ;
      private bool[] P002K2_n312BR_Medication_Drug_Unit ;
      private decimal[] P002K2_A311BR_Medication_Drug_Num ;
      private bool[] P002K2_n311BR_Medication_Drug_Num ;
      private long[] P002K2_A296BR_Medication_SchemeID ;
      private bool[] P002K2_n296BR_Medication_SchemeID ;
      private long[] P002K2_A301BR_Medication_DetailID ;
      private String[] P002K3_A312BR_Medication_Drug_Unit ;
      private bool[] P002K3_n312BR_Medication_Drug_Unit ;
      private decimal[] P002K3_A311BR_Medication_Drug_Num ;
      private bool[] P002K3_n311BR_Medication_Drug_Num ;
      private String[] P002K3_A310BR_Medication_Drug_Name ;
      private bool[] P002K3_n310BR_Medication_Drug_Name ;
      private long[] P002K3_A296BR_Medication_SchemeID ;
      private bool[] P002K3_n296BR_Medication_SchemeID ;
      private long[] P002K3_A301BR_Medication_DetailID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV26Options ;
      private GxSimpleCollection<String> AV29OptionsDesc ;
      private GxSimpleCollection<String> AV31OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV36GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV37GridStateFilterValue ;
   }

   public class br_medication_detailwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002K2( IGxContext context ,
                                             long AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                             long AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                             long AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                             long AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                             String AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                             String AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                             decimal AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                             decimal AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                             String AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                             String AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                             long A301BR_Medication_DetailID ,
                                             long A296BR_Medication_SchemeID ,
                                             String A310BR_Medication_Drug_Name ,
                                             decimal A311BR_Medication_Drug_Num ,
                                             String A312BR_Medication_Drug_Unit )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [10] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_Drug_Name], [BR_Medication_Drug_Unit], [BR_Medication_Drug_Num], [BR_Medication_SchemeID], [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK)";
         if ( ! (0==AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] >= @AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] >= @AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] <= @AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] <= @AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] like @lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] like @lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] = @AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] = @AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] >= @AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] >= @AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] <= @AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] <= @AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] like @lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] like @lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] = @AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] = @AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_Drug_Name]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002K3( IGxContext context ,
                                             long AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid ,
                                             long AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to ,
                                             long AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid ,
                                             long AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to ,
                                             String AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel ,
                                             String AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name ,
                                             decimal AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num ,
                                             decimal AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to ,
                                             String AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel ,
                                             String AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit ,
                                             long A301BR_Medication_DetailID ,
                                             long A296BR_Medication_SchemeID ,
                                             String A310BR_Medication_Drug_Name ,
                                             decimal A311BR_Medication_Drug_Num ,
                                             String A312BR_Medication_Drug_Unit )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [10] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Medication_Drug_Unit], [BR_Medication_Drug_Num], [BR_Medication_Drug_Name], [BR_Medication_SchemeID], [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK)";
         if ( ! (0==AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] >= @AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] >= @AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_DetailID] <= @AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_DetailID] <= @AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] >= @AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] >= @AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_SchemeID] <= @AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_SchemeID] <= @AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] like @lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] like @lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Name] = @AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Name] = @AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] >= @AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] >= @AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Num] <= @AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Num] <= @AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] like @lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] like @lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Medication_Drug_Unit] = @AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Medication_Drug_Unit] = @AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Medication_Drug_Unit]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P002K2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (decimal)dynConstraints[13] , (String)dynConstraints[14] );
               case 1 :
                     return conditional_P002K3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (String)dynConstraints[12] , (decimal)dynConstraints[13] , (String)dynConstraints[14] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002K2 ;
          prmP002K2 = new Object[] {
          new Object[] {"@AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002K3 ;
          prmP002K3 = new Object[] {
          new Object[] {"@AV49BR_Medication_DetailWWDS_1_Tfbr_medication_detailid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV50BR_Medication_DetailWWDS_2_Tfbr_medication_detailid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV51BR_Medication_DetailWWDS_3_Tfbr_medication_schemeid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Medication_DetailWWDS_4_Tfbr_medication_schemeid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV53BR_Medication_DetailWWDS_5_Tfbr_medication_drug_name",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV54BR_Medication_DetailWWDS_6_Tfbr_medication_drug_name_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV55BR_Medication_DetailWWDS_7_Tfbr_medication_drug_num",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV56BR_Medication_DetailWWDS_8_Tfbr_medication_drug_num_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV57BR_Medication_DetailWWDS_9_Tfbr_medication_drug_unit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV58BR_Medication_DetailWWDS_10_Tfbr_medication_drug_unit_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002K2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002K2,100,0,true,false )
             ,new CursorDef("P002K3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002K3,100,0,true,false )
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
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_medication_detailwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_medication_detailwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_medication_detailwwgetfilterdata") )
          {
             return  ;
          }
          br_medication_detailwwgetfilterdata worker = new br_medication_detailwwgetfilterdata(context) ;
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
