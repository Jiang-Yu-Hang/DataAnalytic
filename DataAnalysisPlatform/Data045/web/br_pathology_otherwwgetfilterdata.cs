/*
               File: BR_Pathology_OtherWWGetFilterData
        Description: BR_Pathology_Other WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:0.66
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
   public class br_pathology_otherwwgetfilterdata : GXProcedure
   {
      public br_pathology_otherwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_otherwwgetfilterdata( IGxContext context )
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
         this.AV31DDOName = aP0_DDOName;
         this.AV29SearchTxt = aP1_SearchTxt;
         this.AV30SearchTxtTo = aP2_SearchTxtTo;
         this.AV35OptionsJson = "" ;
         this.AV38OptionsDescJson = "" ;
         this.AV40OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV31DDOName = aP0_DDOName;
         this.AV29SearchTxt = aP1_SearchTxt;
         this.AV30SearchTxtTo = aP2_SearchTxtTo;
         this.AV35OptionsJson = "" ;
         this.AV38OptionsDescJson = "" ;
         this.AV40OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
         return AV40OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_pathology_otherwwgetfilterdata objbr_pathology_otherwwgetfilterdata;
         objbr_pathology_otherwwgetfilterdata = new br_pathology_otherwwgetfilterdata();
         objbr_pathology_otherwwgetfilterdata.AV31DDOName = aP0_DDOName;
         objbr_pathology_otherwwgetfilterdata.AV29SearchTxt = aP1_SearchTxt;
         objbr_pathology_otherwwgetfilterdata.AV30SearchTxtTo = aP2_SearchTxtTo;
         objbr_pathology_otherwwgetfilterdata.AV35OptionsJson = "" ;
         objbr_pathology_otherwwgetfilterdata.AV38OptionsDescJson = "" ;
         objbr_pathology_otherwwgetfilterdata.AV40OptionIndexesJson = "" ;
         objbr_pathology_otherwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_pathology_otherwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_pathology_otherwwgetfilterdata);
         aP3_OptionsJson=this.AV35OptionsJson;
         aP4_OptionsDescJson=this.AV38OptionsDescJson;
         aP5_OptionIndexesJson=this.AV40OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_pathology_otherwwgetfilterdata)stateInfo).executePrivate();
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
         AV34Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV37OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV39OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Other", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_OTHER_BIO") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_OTHER_BIOOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_OTHER_BIONUMUNIT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_OTHER_BIONUMUNITOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_OTHER_BIOQUAL") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_OTHER_BIOQUALOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV31DDOName), "DDO_BR_PATHOLOGY_OTHER_ABNIND") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_OTHER_ABNINDOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV35OptionsJson = AV34Options.ToJSonString(false);
         AV38OptionsDescJson = AV37OptionsDesc.ToJSonString(false);
         AV40OptionIndexesJson = AV39OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV42Session.Get("BR_Pathology_OtherWWGridState"), "") == 0 )
         {
            AV44GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Pathology_OtherWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV44GridState.FromXml(AV42Session.Get("BR_Pathology_OtherWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV49GXV1 = 1;
         while ( AV49GXV1 <= AV44GridState.gxTpr_Filtervalues.Count )
         {
            AV45GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV44GridState.gxTpr_Filtervalues.Item(AV49GXV1));
            if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHERID") == 0 )
            {
               AV11TFBR_Pathology_OtherID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Pathology_OtherID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV13TFBR_PathologyID = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_PathologyID_To = (long)(NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIO") == 0 )
            {
               AV15TFBR_Pathology_Other_Bio = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIO_SEL") == 0 )
            {
               AV16TFBR_Pathology_Other_Bio_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUM") == 0 )
            {
               AV17TFBR_Pathology_Other_BioNum = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, ".");
               AV18TFBR_Pathology_Other_BioNum_To = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUMUNIT") == 0 )
            {
               AV19TFBR_Pathology_Other_BioNumUnit = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIONUMUNIT_SEL") == 0 )
            {
               AV20TFBR_Pathology_Other_BioNumUnit_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIOQUAL") == 0 )
            {
               AV21TFBR_Pathology_Other_BioQual = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_BIOQUAL_SEL") == 0 )
            {
               AV22TFBR_Pathology_Other_BioQual_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_LOW") == 0 )
            {
               AV23TFBR_Pathology_Other_Low = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, ".");
               AV24TFBR_Pathology_Other_Low_To = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_HIGH") == 0 )
            {
               AV25TFBR_Pathology_Other_High = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Value, ".");
               AV26TFBR_Pathology_Other_High_To = NumberUtil.Val( AV45GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_ABNIND") == 0 )
            {
               AV27TFBR_Pathology_Other_AbnInd = AV45GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV45GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_OTHER_ABNIND_SEL") == 0 )
            {
               AV28TFBR_Pathology_Other_AbnInd_Sel = AV45GridStateFilterValue.gxTpr_Value;
            }
            AV49GXV1 = (int)(AV49GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_PATHOLOGY_OTHER_BIOOPTIONS' Routine */
         AV15TFBR_Pathology_Other_Bio = AV29SearchTxt;
         AV16TFBR_Pathology_Other_Bio_Sel = "";
         AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV11TFBR_Pathology_OtherID;
         AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV12TFBR_Pathology_OtherID_To;
         AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV15TFBR_Pathology_Other_Bio;
         AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV16TFBR_Pathology_Other_Bio_Sel;
         AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV17TFBR_Pathology_Other_BioNum;
         AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV18TFBR_Pathology_Other_BioNum_To;
         AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV19TFBR_Pathology_Other_BioNumUnit;
         AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV20TFBR_Pathology_Other_BioNumUnit_Sel;
         AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV21TFBR_Pathology_Other_BioQual;
         AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV22TFBR_Pathology_Other_BioQual_Sel;
         AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV23TFBR_Pathology_Other_Low;
         AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV24TFBR_Pathology_Other_Low_To;
         AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV25TFBR_Pathology_Other_High;
         AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV26TFBR_Pathology_Other_High_To;
         AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV27TFBR_Pathology_Other_AbnInd;
         AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV28TFBR_Pathology_Other_AbnInd_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                              AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                              AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                              AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                              AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                              AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                              AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                              AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                              AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                              AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                              AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                              AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                              AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                              AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                              AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                              AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                              AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                              AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                              A288BR_Pathology_OtherID ,
                                              A226BR_PathologyID ,
                                              A289BR_Pathology_Other_Bio ,
                                              A290BR_Pathology_Other_BioNum ,
                                              A291BR_Pathology_Other_BioNumUnit ,
                                              A292BR_Pathology_Other_BioQual ,
                                              A293BR_Pathology_Other_Low ,
                                              A294BR_Pathology_Other_High ,
                                              A295BR_Pathology_Other_AbnInd } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
         lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
         lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
         lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
         /* Using cursor P002O2 */
         pr_default.execute(0, new Object[] {AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2O2 = false;
            A289BR_Pathology_Other_Bio = P002O2_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = P002O2_n289BR_Pathology_Other_Bio[0];
            A295BR_Pathology_Other_AbnInd = P002O2_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = P002O2_n295BR_Pathology_Other_AbnInd[0];
            A294BR_Pathology_Other_High = P002O2_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = P002O2_n294BR_Pathology_Other_High[0];
            A293BR_Pathology_Other_Low = P002O2_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = P002O2_n293BR_Pathology_Other_Low[0];
            A292BR_Pathology_Other_BioQual = P002O2_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = P002O2_n292BR_Pathology_Other_BioQual[0];
            A291BR_Pathology_Other_BioNumUnit = P002O2_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = P002O2_n291BR_Pathology_Other_BioNumUnit[0];
            A290BR_Pathology_Other_BioNum = P002O2_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = P002O2_n290BR_Pathology_Other_BioNum[0];
            A226BR_PathologyID = P002O2_A226BR_PathologyID[0];
            n226BR_PathologyID = P002O2_n226BR_PathologyID[0];
            A288BR_Pathology_OtherID = P002O2_A288BR_Pathology_OtherID[0];
            AV41count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002O2_A289BR_Pathology_Other_Bio[0], A289BR_Pathology_Other_Bio) == 0 ) )
            {
               BRK2O2 = false;
               A288BR_Pathology_OtherID = P002O2_A288BR_Pathology_OtherID[0];
               AV41count = (long)(AV41count+1);
               BRK2O2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) )
            {
               AV33Option = A289BR_Pathology_Other_Bio;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2O2 )
            {
               BRK2O2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_PATHOLOGY_OTHER_BIONUMUNITOPTIONS' Routine */
         AV19TFBR_Pathology_Other_BioNumUnit = AV29SearchTxt;
         AV20TFBR_Pathology_Other_BioNumUnit_Sel = "";
         AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV11TFBR_Pathology_OtherID;
         AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV12TFBR_Pathology_OtherID_To;
         AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV15TFBR_Pathology_Other_Bio;
         AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV16TFBR_Pathology_Other_Bio_Sel;
         AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV17TFBR_Pathology_Other_BioNum;
         AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV18TFBR_Pathology_Other_BioNum_To;
         AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV19TFBR_Pathology_Other_BioNumUnit;
         AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV20TFBR_Pathology_Other_BioNumUnit_Sel;
         AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV21TFBR_Pathology_Other_BioQual;
         AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV22TFBR_Pathology_Other_BioQual_Sel;
         AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV23TFBR_Pathology_Other_Low;
         AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV24TFBR_Pathology_Other_Low_To;
         AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV25TFBR_Pathology_Other_High;
         AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV26TFBR_Pathology_Other_High_To;
         AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV27TFBR_Pathology_Other_AbnInd;
         AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV28TFBR_Pathology_Other_AbnInd_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                              AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                              AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                              AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                              AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                              AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                              AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                              AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                              AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                              AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                              AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                              AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                              AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                              AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                              AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                              AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                              AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                              AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                              A288BR_Pathology_OtherID ,
                                              A226BR_PathologyID ,
                                              A289BR_Pathology_Other_Bio ,
                                              A290BR_Pathology_Other_BioNum ,
                                              A291BR_Pathology_Other_BioNumUnit ,
                                              A292BR_Pathology_Other_BioQual ,
                                              A293BR_Pathology_Other_Low ,
                                              A294BR_Pathology_Other_High ,
                                              A295BR_Pathology_Other_AbnInd } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
         lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
         lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
         lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
         /* Using cursor P002O3 */
         pr_default.execute(1, new Object[] {AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2O4 = false;
            A291BR_Pathology_Other_BioNumUnit = P002O3_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = P002O3_n291BR_Pathology_Other_BioNumUnit[0];
            A295BR_Pathology_Other_AbnInd = P002O3_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = P002O3_n295BR_Pathology_Other_AbnInd[0];
            A294BR_Pathology_Other_High = P002O3_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = P002O3_n294BR_Pathology_Other_High[0];
            A293BR_Pathology_Other_Low = P002O3_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = P002O3_n293BR_Pathology_Other_Low[0];
            A292BR_Pathology_Other_BioQual = P002O3_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = P002O3_n292BR_Pathology_Other_BioQual[0];
            A290BR_Pathology_Other_BioNum = P002O3_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = P002O3_n290BR_Pathology_Other_BioNum[0];
            A289BR_Pathology_Other_Bio = P002O3_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = P002O3_n289BR_Pathology_Other_Bio[0];
            A226BR_PathologyID = P002O3_A226BR_PathologyID[0];
            n226BR_PathologyID = P002O3_n226BR_PathologyID[0];
            A288BR_Pathology_OtherID = P002O3_A288BR_Pathology_OtherID[0];
            AV41count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002O3_A291BR_Pathology_Other_BioNumUnit[0], A291BR_Pathology_Other_BioNumUnit) == 0 ) )
            {
               BRK2O4 = false;
               A288BR_Pathology_OtherID = P002O3_A288BR_Pathology_OtherID[0];
               AV41count = (long)(AV41count+1);
               BRK2O4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit)) )
            {
               AV33Option = A291BR_Pathology_Other_BioNumUnit;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2O4 )
            {
               BRK2O4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_PATHOLOGY_OTHER_BIOQUALOPTIONS' Routine */
         AV21TFBR_Pathology_Other_BioQual = AV29SearchTxt;
         AV22TFBR_Pathology_Other_BioQual_Sel = "";
         AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV11TFBR_Pathology_OtherID;
         AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV12TFBR_Pathology_OtherID_To;
         AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV15TFBR_Pathology_Other_Bio;
         AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV16TFBR_Pathology_Other_Bio_Sel;
         AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV17TFBR_Pathology_Other_BioNum;
         AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV18TFBR_Pathology_Other_BioNum_To;
         AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV19TFBR_Pathology_Other_BioNumUnit;
         AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV20TFBR_Pathology_Other_BioNumUnit_Sel;
         AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV21TFBR_Pathology_Other_BioQual;
         AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV22TFBR_Pathology_Other_BioQual_Sel;
         AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV23TFBR_Pathology_Other_Low;
         AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV24TFBR_Pathology_Other_Low_To;
         AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV25TFBR_Pathology_Other_High;
         AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV26TFBR_Pathology_Other_High_To;
         AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV27TFBR_Pathology_Other_AbnInd;
         AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV28TFBR_Pathology_Other_AbnInd_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                              AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                              AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                              AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                              AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                              AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                              AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                              AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                              AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                              AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                              AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                              AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                              AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                              AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                              AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                              AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                              AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                              AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                              A288BR_Pathology_OtherID ,
                                              A226BR_PathologyID ,
                                              A289BR_Pathology_Other_Bio ,
                                              A290BR_Pathology_Other_BioNum ,
                                              A291BR_Pathology_Other_BioNumUnit ,
                                              A292BR_Pathology_Other_BioQual ,
                                              A293BR_Pathology_Other_Low ,
                                              A294BR_Pathology_Other_High ,
                                              A295BR_Pathology_Other_AbnInd } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
         lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
         lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
         lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
         /* Using cursor P002O4 */
         pr_default.execute(2, new Object[] {AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK2O6 = false;
            A292BR_Pathology_Other_BioQual = P002O4_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = P002O4_n292BR_Pathology_Other_BioQual[0];
            A295BR_Pathology_Other_AbnInd = P002O4_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = P002O4_n295BR_Pathology_Other_AbnInd[0];
            A294BR_Pathology_Other_High = P002O4_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = P002O4_n294BR_Pathology_Other_High[0];
            A293BR_Pathology_Other_Low = P002O4_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = P002O4_n293BR_Pathology_Other_Low[0];
            A291BR_Pathology_Other_BioNumUnit = P002O4_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = P002O4_n291BR_Pathology_Other_BioNumUnit[0];
            A290BR_Pathology_Other_BioNum = P002O4_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = P002O4_n290BR_Pathology_Other_BioNum[0];
            A289BR_Pathology_Other_Bio = P002O4_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = P002O4_n289BR_Pathology_Other_Bio[0];
            A226BR_PathologyID = P002O4_A226BR_PathologyID[0];
            n226BR_PathologyID = P002O4_n226BR_PathologyID[0];
            A288BR_Pathology_OtherID = P002O4_A288BR_Pathology_OtherID[0];
            AV41count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P002O4_A292BR_Pathology_Other_BioQual[0], A292BR_Pathology_Other_BioQual) == 0 ) )
            {
               BRK2O6 = false;
               A288BR_Pathology_OtherID = P002O4_A288BR_Pathology_OtherID[0];
               AV41count = (long)(AV41count+1);
               BRK2O6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) )
            {
               AV33Option = A292BR_Pathology_Other_BioQual;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2O6 )
            {
               BRK2O6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_PATHOLOGY_OTHER_ABNINDOPTIONS' Routine */
         AV27TFBR_Pathology_Other_AbnInd = AV29SearchTxt;
         AV28TFBR_Pathology_Other_AbnInd_Sel = "";
         AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid = AV11TFBR_Pathology_OtherID;
         AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to = AV12TFBR_Pathology_OtherID_To;
         AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = AV15TFBR_Pathology_Other_Bio;
         AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = AV16TFBR_Pathology_Other_Bio_Sel;
         AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum = AV17TFBR_Pathology_Other_BioNum;
         AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to = AV18TFBR_Pathology_Other_BioNum_To;
         AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = AV19TFBR_Pathology_Other_BioNumUnit;
         AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = AV20TFBR_Pathology_Other_BioNumUnit_Sel;
         AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = AV21TFBR_Pathology_Other_BioQual;
         AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = AV22TFBR_Pathology_Other_BioQual_Sel;
         AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low = AV23TFBR_Pathology_Other_Low;
         AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to = AV24TFBR_Pathology_Other_Low_To;
         AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high = AV25TFBR_Pathology_Other_High;
         AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to = AV26TFBR_Pathology_Other_High_To;
         AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = AV27TFBR_Pathology_Other_AbnInd;
         AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = AV28TFBR_Pathology_Other_AbnInd_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                              AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                              AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                              AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                              AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                              AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                              AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                              AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                              AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                              AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                              AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                              AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                              AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                              AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                              AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                              AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                              AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                              AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                              A288BR_Pathology_OtherID ,
                                              A226BR_PathologyID ,
                                              A289BR_Pathology_Other_Bio ,
                                              A290BR_Pathology_Other_BioNum ,
                                              A291BR_Pathology_Other_BioNumUnit ,
                                              A292BR_Pathology_Other_BioQual ,
                                              A293BR_Pathology_Other_Low ,
                                              A294BR_Pathology_Other_High ,
                                              A295BR_Pathology_Other_AbnInd } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = StringUtil.Concat( StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio), "%", "");
         lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = StringUtil.Concat( StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit), "%", "");
         lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = StringUtil.Concat( StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual), "%", "");
         lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind), "%", "");
         /* Using cursor P002O5 */
         pr_default.execute(3, new Object[] {AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid, AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to, AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid, AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to, lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio, AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel, AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum, AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to, lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit, AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel, lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual, AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel, AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low, AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to, AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high, AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to, lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind, AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK2O8 = false;
            A295BR_Pathology_Other_AbnInd = P002O5_A295BR_Pathology_Other_AbnInd[0];
            n295BR_Pathology_Other_AbnInd = P002O5_n295BR_Pathology_Other_AbnInd[0];
            A294BR_Pathology_Other_High = P002O5_A294BR_Pathology_Other_High[0];
            n294BR_Pathology_Other_High = P002O5_n294BR_Pathology_Other_High[0];
            A293BR_Pathology_Other_Low = P002O5_A293BR_Pathology_Other_Low[0];
            n293BR_Pathology_Other_Low = P002O5_n293BR_Pathology_Other_Low[0];
            A292BR_Pathology_Other_BioQual = P002O5_A292BR_Pathology_Other_BioQual[0];
            n292BR_Pathology_Other_BioQual = P002O5_n292BR_Pathology_Other_BioQual[0];
            A291BR_Pathology_Other_BioNumUnit = P002O5_A291BR_Pathology_Other_BioNumUnit[0];
            n291BR_Pathology_Other_BioNumUnit = P002O5_n291BR_Pathology_Other_BioNumUnit[0];
            A290BR_Pathology_Other_BioNum = P002O5_A290BR_Pathology_Other_BioNum[0];
            n290BR_Pathology_Other_BioNum = P002O5_n290BR_Pathology_Other_BioNum[0];
            A289BR_Pathology_Other_Bio = P002O5_A289BR_Pathology_Other_Bio[0];
            n289BR_Pathology_Other_Bio = P002O5_n289BR_Pathology_Other_Bio[0];
            A226BR_PathologyID = P002O5_A226BR_PathologyID[0];
            n226BR_PathologyID = P002O5_n226BR_PathologyID[0];
            A288BR_Pathology_OtherID = P002O5_A288BR_Pathology_OtherID[0];
            AV41count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P002O5_A295BR_Pathology_Other_AbnInd[0], A295BR_Pathology_Other_AbnInd) == 0 ) )
            {
               BRK2O8 = false;
               A288BR_Pathology_OtherID = P002O5_A288BR_Pathology_OtherID[0];
               AV41count = (long)(AV41count+1);
               BRK2O8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A295BR_Pathology_Other_AbnInd)) )
            {
               AV33Option = A295BR_Pathology_Other_AbnInd;
               AV34Options.Add(AV33Option, 0);
               AV39OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV41count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV34Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2O8 )
            {
               BRK2O8 = true;
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
         AV34Options = new GxSimpleCollection<String>();
         AV37OptionsDesc = new GxSimpleCollection<String>();
         AV39OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV42Session = context.GetSession();
         AV44GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV45GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Pathology_Other_Bio = "";
         AV16TFBR_Pathology_Other_Bio_Sel = "";
         AV19TFBR_Pathology_Other_BioNumUnit = "";
         AV20TFBR_Pathology_Other_BioNumUnit_Sel = "";
         AV21TFBR_Pathology_Other_BioQual = "";
         AV22TFBR_Pathology_Other_BioQual_Sel = "";
         AV27TFBR_Pathology_Other_AbnInd = "";
         AV28TFBR_Pathology_Other_AbnInd_Sel = "";
         AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = "";
         AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel = "";
         AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = "";
         AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel = "";
         AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = "";
         AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel = "";
         AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = "";
         AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel = "";
         scmdbuf = "";
         lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio = "";
         lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit = "";
         lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual = "";
         lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind = "";
         A289BR_Pathology_Other_Bio = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         A292BR_Pathology_Other_BioQual = "";
         A295BR_Pathology_Other_AbnInd = "";
         P002O2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         P002O2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         P002O2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         P002O2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         P002O2_A294BR_Pathology_Other_High = new decimal[1] ;
         P002O2_n294BR_Pathology_Other_High = new bool[] {false} ;
         P002O2_A293BR_Pathology_Other_Low = new decimal[1] ;
         P002O2_n293BR_Pathology_Other_Low = new bool[] {false} ;
         P002O2_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         P002O2_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         P002O2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         P002O2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         P002O2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         P002O2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         P002O2_A226BR_PathologyID = new long[1] ;
         P002O2_n226BR_PathologyID = new bool[] {false} ;
         P002O2_A288BR_Pathology_OtherID = new long[1] ;
         AV33Option = "";
         P002O3_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         P002O3_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         P002O3_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         P002O3_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         P002O3_A294BR_Pathology_Other_High = new decimal[1] ;
         P002O3_n294BR_Pathology_Other_High = new bool[] {false} ;
         P002O3_A293BR_Pathology_Other_Low = new decimal[1] ;
         P002O3_n293BR_Pathology_Other_Low = new bool[] {false} ;
         P002O3_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         P002O3_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         P002O3_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         P002O3_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         P002O3_A289BR_Pathology_Other_Bio = new String[] {""} ;
         P002O3_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         P002O3_A226BR_PathologyID = new long[1] ;
         P002O3_n226BR_PathologyID = new bool[] {false} ;
         P002O3_A288BR_Pathology_OtherID = new long[1] ;
         P002O4_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         P002O4_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         P002O4_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         P002O4_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         P002O4_A294BR_Pathology_Other_High = new decimal[1] ;
         P002O4_n294BR_Pathology_Other_High = new bool[] {false} ;
         P002O4_A293BR_Pathology_Other_Low = new decimal[1] ;
         P002O4_n293BR_Pathology_Other_Low = new bool[] {false} ;
         P002O4_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         P002O4_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         P002O4_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         P002O4_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         P002O4_A289BR_Pathology_Other_Bio = new String[] {""} ;
         P002O4_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         P002O4_A226BR_PathologyID = new long[1] ;
         P002O4_n226BR_PathologyID = new bool[] {false} ;
         P002O4_A288BR_Pathology_OtherID = new long[1] ;
         P002O5_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         P002O5_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         P002O5_A294BR_Pathology_Other_High = new decimal[1] ;
         P002O5_n294BR_Pathology_Other_High = new bool[] {false} ;
         P002O5_A293BR_Pathology_Other_Low = new decimal[1] ;
         P002O5_n293BR_Pathology_Other_Low = new bool[] {false} ;
         P002O5_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         P002O5_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         P002O5_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         P002O5_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         P002O5_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         P002O5_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         P002O5_A289BR_Pathology_Other_Bio = new String[] {""} ;
         P002O5_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         P002O5_A226BR_PathologyID = new long[1] ;
         P002O5_n226BR_PathologyID = new bool[] {false} ;
         P002O5_A288BR_Pathology_OtherID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_otherwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002O2_A289BR_Pathology_Other_Bio, P002O2_n289BR_Pathology_Other_Bio, P002O2_A295BR_Pathology_Other_AbnInd, P002O2_n295BR_Pathology_Other_AbnInd, P002O2_A294BR_Pathology_Other_High, P002O2_n294BR_Pathology_Other_High, P002O2_A293BR_Pathology_Other_Low, P002O2_n293BR_Pathology_Other_Low, P002O2_A292BR_Pathology_Other_BioQual, P002O2_n292BR_Pathology_Other_BioQual,
               P002O2_A291BR_Pathology_Other_BioNumUnit, P002O2_n291BR_Pathology_Other_BioNumUnit, P002O2_A290BR_Pathology_Other_BioNum, P002O2_n290BR_Pathology_Other_BioNum, P002O2_A226BR_PathologyID, P002O2_n226BR_PathologyID, P002O2_A288BR_Pathology_OtherID
               }
               , new Object[] {
               P002O3_A291BR_Pathology_Other_BioNumUnit, P002O3_n291BR_Pathology_Other_BioNumUnit, P002O3_A295BR_Pathology_Other_AbnInd, P002O3_n295BR_Pathology_Other_AbnInd, P002O3_A294BR_Pathology_Other_High, P002O3_n294BR_Pathology_Other_High, P002O3_A293BR_Pathology_Other_Low, P002O3_n293BR_Pathology_Other_Low, P002O3_A292BR_Pathology_Other_BioQual, P002O3_n292BR_Pathology_Other_BioQual,
               P002O3_A290BR_Pathology_Other_BioNum, P002O3_n290BR_Pathology_Other_BioNum, P002O3_A289BR_Pathology_Other_Bio, P002O3_n289BR_Pathology_Other_Bio, P002O3_A226BR_PathologyID, P002O3_n226BR_PathologyID, P002O3_A288BR_Pathology_OtherID
               }
               , new Object[] {
               P002O4_A292BR_Pathology_Other_BioQual, P002O4_n292BR_Pathology_Other_BioQual, P002O4_A295BR_Pathology_Other_AbnInd, P002O4_n295BR_Pathology_Other_AbnInd, P002O4_A294BR_Pathology_Other_High, P002O4_n294BR_Pathology_Other_High, P002O4_A293BR_Pathology_Other_Low, P002O4_n293BR_Pathology_Other_Low, P002O4_A291BR_Pathology_Other_BioNumUnit, P002O4_n291BR_Pathology_Other_BioNumUnit,
               P002O4_A290BR_Pathology_Other_BioNum, P002O4_n290BR_Pathology_Other_BioNum, P002O4_A289BR_Pathology_Other_Bio, P002O4_n289BR_Pathology_Other_Bio, P002O4_A226BR_PathologyID, P002O4_n226BR_PathologyID, P002O4_A288BR_Pathology_OtherID
               }
               , new Object[] {
               P002O5_A295BR_Pathology_Other_AbnInd, P002O5_n295BR_Pathology_Other_AbnInd, P002O5_A294BR_Pathology_Other_High, P002O5_n294BR_Pathology_Other_High, P002O5_A293BR_Pathology_Other_Low, P002O5_n293BR_Pathology_Other_Low, P002O5_A292BR_Pathology_Other_BioQual, P002O5_n292BR_Pathology_Other_BioQual, P002O5_A291BR_Pathology_Other_BioNumUnit, P002O5_n291BR_Pathology_Other_BioNumUnit,
               P002O5_A290BR_Pathology_Other_BioNum, P002O5_n290BR_Pathology_Other_BioNum, P002O5_A289BR_Pathology_Other_Bio, P002O5_n289BR_Pathology_Other_Bio, P002O5_A226BR_PathologyID, P002O5_n226BR_PathologyID, P002O5_A288BR_Pathology_OtherID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV49GXV1 ;
      private long AV11TFBR_Pathology_OtherID ;
      private long AV12TFBR_Pathology_OtherID_To ;
      private long AV13TFBR_PathologyID ;
      private long AV14TFBR_PathologyID_To ;
      private long AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ;
      private long AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ;
      private long AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ;
      private long AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ;
      private long A288BR_Pathology_OtherID ;
      private long A226BR_PathologyID ;
      private long AV41count ;
      private decimal AV17TFBR_Pathology_Other_BioNum ;
      private decimal AV18TFBR_Pathology_Other_BioNum_To ;
      private decimal AV23TFBR_Pathology_Other_Low ;
      private decimal AV24TFBR_Pathology_Other_Low_To ;
      private decimal AV25TFBR_Pathology_Other_High ;
      private decimal AV26TFBR_Pathology_Other_High_To ;
      private decimal AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ;
      private decimal AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ;
      private decimal AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ;
      private decimal AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ;
      private decimal AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ;
      private decimal AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal A294BR_Pathology_Other_High ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2O2 ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool n294BR_Pathology_Other_High ;
      private bool n293BR_Pathology_Other_Low ;
      private bool n292BR_Pathology_Other_BioQual ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n226BR_PathologyID ;
      private bool BRK2O4 ;
      private bool BRK2O6 ;
      private bool BRK2O8 ;
      private String AV40OptionIndexesJson ;
      private String AV35OptionsJson ;
      private String AV38OptionsDescJson ;
      private String AV31DDOName ;
      private String AV29SearchTxt ;
      private String AV30SearchTxtTo ;
      private String AV15TFBR_Pathology_Other_Bio ;
      private String AV16TFBR_Pathology_Other_Bio_Sel ;
      private String AV19TFBR_Pathology_Other_BioNumUnit ;
      private String AV20TFBR_Pathology_Other_BioNumUnit_Sel ;
      private String AV21TFBR_Pathology_Other_BioQual ;
      private String AV22TFBR_Pathology_Other_BioQual_Sel ;
      private String AV27TFBR_Pathology_Other_AbnInd ;
      private String AV28TFBR_Pathology_Other_AbnInd_Sel ;
      private String AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ;
      private String AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ;
      private String AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ;
      private String AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ;
      private String AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ;
      private String AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ;
      private String AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ;
      private String AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ;
      private String lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ;
      private String lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ;
      private String lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ;
      private String lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A292BR_Pathology_Other_BioQual ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String AV33Option ;
      private IGxSession AV42Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002O2_A289BR_Pathology_Other_Bio ;
      private bool[] P002O2_n289BR_Pathology_Other_Bio ;
      private String[] P002O2_A295BR_Pathology_Other_AbnInd ;
      private bool[] P002O2_n295BR_Pathology_Other_AbnInd ;
      private decimal[] P002O2_A294BR_Pathology_Other_High ;
      private bool[] P002O2_n294BR_Pathology_Other_High ;
      private decimal[] P002O2_A293BR_Pathology_Other_Low ;
      private bool[] P002O2_n293BR_Pathology_Other_Low ;
      private String[] P002O2_A292BR_Pathology_Other_BioQual ;
      private bool[] P002O2_n292BR_Pathology_Other_BioQual ;
      private String[] P002O2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] P002O2_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] P002O2_A290BR_Pathology_Other_BioNum ;
      private bool[] P002O2_n290BR_Pathology_Other_BioNum ;
      private long[] P002O2_A226BR_PathologyID ;
      private bool[] P002O2_n226BR_PathologyID ;
      private long[] P002O2_A288BR_Pathology_OtherID ;
      private String[] P002O3_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] P002O3_n291BR_Pathology_Other_BioNumUnit ;
      private String[] P002O3_A295BR_Pathology_Other_AbnInd ;
      private bool[] P002O3_n295BR_Pathology_Other_AbnInd ;
      private decimal[] P002O3_A294BR_Pathology_Other_High ;
      private bool[] P002O3_n294BR_Pathology_Other_High ;
      private decimal[] P002O3_A293BR_Pathology_Other_Low ;
      private bool[] P002O3_n293BR_Pathology_Other_Low ;
      private String[] P002O3_A292BR_Pathology_Other_BioQual ;
      private bool[] P002O3_n292BR_Pathology_Other_BioQual ;
      private decimal[] P002O3_A290BR_Pathology_Other_BioNum ;
      private bool[] P002O3_n290BR_Pathology_Other_BioNum ;
      private String[] P002O3_A289BR_Pathology_Other_Bio ;
      private bool[] P002O3_n289BR_Pathology_Other_Bio ;
      private long[] P002O3_A226BR_PathologyID ;
      private bool[] P002O3_n226BR_PathologyID ;
      private long[] P002O3_A288BR_Pathology_OtherID ;
      private String[] P002O4_A292BR_Pathology_Other_BioQual ;
      private bool[] P002O4_n292BR_Pathology_Other_BioQual ;
      private String[] P002O4_A295BR_Pathology_Other_AbnInd ;
      private bool[] P002O4_n295BR_Pathology_Other_AbnInd ;
      private decimal[] P002O4_A294BR_Pathology_Other_High ;
      private bool[] P002O4_n294BR_Pathology_Other_High ;
      private decimal[] P002O4_A293BR_Pathology_Other_Low ;
      private bool[] P002O4_n293BR_Pathology_Other_Low ;
      private String[] P002O4_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] P002O4_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] P002O4_A290BR_Pathology_Other_BioNum ;
      private bool[] P002O4_n290BR_Pathology_Other_BioNum ;
      private String[] P002O4_A289BR_Pathology_Other_Bio ;
      private bool[] P002O4_n289BR_Pathology_Other_Bio ;
      private long[] P002O4_A226BR_PathologyID ;
      private bool[] P002O4_n226BR_PathologyID ;
      private long[] P002O4_A288BR_Pathology_OtherID ;
      private String[] P002O5_A295BR_Pathology_Other_AbnInd ;
      private bool[] P002O5_n295BR_Pathology_Other_AbnInd ;
      private decimal[] P002O5_A294BR_Pathology_Other_High ;
      private bool[] P002O5_n294BR_Pathology_Other_High ;
      private decimal[] P002O5_A293BR_Pathology_Other_Low ;
      private bool[] P002O5_n293BR_Pathology_Other_Low ;
      private String[] P002O5_A292BR_Pathology_Other_BioQual ;
      private bool[] P002O5_n292BR_Pathology_Other_BioQual ;
      private String[] P002O5_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] P002O5_n291BR_Pathology_Other_BioNumUnit ;
      private decimal[] P002O5_A290BR_Pathology_Other_BioNum ;
      private bool[] P002O5_n290BR_Pathology_Other_BioNum ;
      private String[] P002O5_A289BR_Pathology_Other_Bio ;
      private bool[] P002O5_n289BR_Pathology_Other_Bio ;
      private long[] P002O5_A226BR_PathologyID ;
      private bool[] P002O5_n226BR_PathologyID ;
      private long[] P002O5_A288BR_Pathology_OtherID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV34Options ;
      private GxSimpleCollection<String> AV37OptionsDesc ;
      private GxSimpleCollection<String> AV39OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV44GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV45GridStateFilterValue ;
   }

   public class br_pathology_otherwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002O2( IGxContext context ,
                                             long AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [18] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Other_Bio], [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_PathologyID], [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK)";
         if ( ! (0==AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int2[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int2[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int2[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int2[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int2[17] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Other_Bio]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002O3( IGxContext context ,
                                             long AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [18] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_PathologyID], [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK)";
         if ( ! (0==AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int4[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int4[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int4[17] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Other_BioNumUnit]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P002O4( IGxContext context ,
                                             long AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [18] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Other_BioQual], [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_PathologyID], [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK)";
         if ( ! (0==AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int6[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int6[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int6[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int6[17] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Other_BioQual]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P002O5( IGxContext context ,
                                             long AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid ,
                                             long AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to ,
                                             long AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid ,
                                             long AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to ,
                                             String AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel ,
                                             String AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio ,
                                             decimal AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum ,
                                             decimal AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to ,
                                             String AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel ,
                                             String AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit ,
                                             String AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel ,
                                             String AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual ,
                                             decimal AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low ,
                                             decimal AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to ,
                                             decimal AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high ,
                                             decimal AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to ,
                                             String AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel ,
                                             String AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind ,
                                             long A288BR_Pathology_OtherID ,
                                             long A226BR_PathologyID ,
                                             String A289BR_Pathology_Other_Bio ,
                                             decimal A290BR_Pathology_Other_BioNum ,
                                             String A291BR_Pathology_Other_BioNumUnit ,
                                             String A292BR_Pathology_Other_BioQual ,
                                             decimal A293BR_Pathology_Other_Low ,
                                             decimal A294BR_Pathology_Other_High ,
                                             String A295BR_Pathology_Other_AbnInd )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [18] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Other_AbnInd], [BR_Pathology_Other_High], [BR_Pathology_Other_Low], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_Bio], [BR_PathologyID], [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK)";
         if ( ! (0==AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] >= @AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_OtherID] <= @AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! (0==AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] like @lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Bio] = @AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] >= @AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNum] <= @AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] like @lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioNumUnit] = @AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] like @lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_BioQual] = @AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] >= @AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low)";
            }
         }
         else
         {
            GXv_int8[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_Low] <= @AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to)";
            }
         }
         else
         {
            GXv_int8[13] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] >= @AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high)";
            }
         }
         else
         {
            GXv_int8[14] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_High] <= @AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to)";
            }
         }
         else
         {
            GXv_int8[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] like @lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind)";
            }
         }
         else
         {
            GXv_int8[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Other_AbnInd] = @AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel)";
            }
         }
         else
         {
            GXv_int8[17] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Other_AbnInd]";
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
                     return conditional_P002O2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] );
               case 1 :
                     return conditional_P002O3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] );
               case 2 :
                     return conditional_P002O4(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] );
               case 3 :
                     return conditional_P002O5(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (decimal)dynConstraints[12] , (decimal)dynConstraints[13] , (decimal)dynConstraints[14] , (decimal)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (long)dynConstraints[18] , (long)dynConstraints[19] , (String)dynConstraints[20] , (decimal)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (String)dynConstraints[26] );
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
          Object[] prmP002O2 ;
          prmP002O2 = new Object[] {
          new Object[] {"@AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002O3 ;
          prmP002O3 = new Object[] {
          new Object[] {"@AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002O4 ;
          prmP002O4 = new Object[] {
          new Object[] {"@AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002O5 ;
          prmP002O5 = new Object[] {
          new Object[] {"@AV51BR_Pathology_OtherWWDS_1_Tfbr_pathology_otherid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Pathology_OtherWWDS_2_Tfbr_pathology_otherid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Pathology_OtherWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Pathology_OtherWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Pathology_OtherWWDS_5_Tfbr_pathology_other_bio",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56BR_Pathology_OtherWWDS_6_Tfbr_pathology_other_bio_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV57BR_Pathology_OtherWWDS_7_Tfbr_pathology_other_bionum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV58BR_Pathology_OtherWWDS_8_Tfbr_pathology_other_bionum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV59BR_Pathology_OtherWWDS_9_Tfbr_pathology_other_bionumunit",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV60BR_Pathology_OtherWWDS_10_Tfbr_pathology_other_bionumunit_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV61BR_Pathology_OtherWWDS_11_Tfbr_pathology_other_bioqual",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV62BR_Pathology_OtherWWDS_12_Tfbr_pathology_other_bioqual_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV63BR_Pathology_OtherWWDS_13_Tfbr_pathology_other_low",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV64BR_Pathology_OtherWWDS_14_Tfbr_pathology_other_low_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV65BR_Pathology_OtherWWDS_15_Tfbr_pathology_other_high",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV66BR_Pathology_OtherWWDS_16_Tfbr_pathology_other_high_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV67BR_Pathology_OtherWWDS_17_Tfbr_pathology_other_abnind",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_OtherWWDS_18_Tfbr_pathology_other_abnind_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002O2,100,0,true,false )
             ,new CursorDef("P002O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002O3,100,0,true,false )
             ,new CursorDef("P002O4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002O4,100,0,true,false )
             ,new CursorDef("P002O5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002O5,100,0,true,false )
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
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
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
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                return;
             case 3 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[24]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[25]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[31]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[32]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[33]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[34]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_pathology_otherwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_pathology_otherwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_pathology_otherwwgetfilterdata") )
          {
             return  ;
          }
          br_pathology_otherwwgetfilterdata worker = new br_pathology_otherwwgetfilterdata(context) ;
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
