/*
               File: BR_Pathology_DiagWWGetFilterData
        Description: BR_Pathology_Diag WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:27.6
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
   public class br_pathology_diagwwgetfilterdata : GXProcedure
   {
      public br_pathology_diagwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_diagwwgetfilterdata( IGxContext context )
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
         this.AV39DDOName = aP0_DDOName;
         this.AV37SearchTxt = aP1_SearchTxt;
         this.AV38SearchTxtTo = aP2_SearchTxtTo;
         this.AV43OptionsJson = "" ;
         this.AV46OptionsDescJson = "" ;
         this.AV48OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV43OptionsJson;
         aP4_OptionsDescJson=this.AV46OptionsDescJson;
         aP5_OptionIndexesJson=this.AV48OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV39DDOName = aP0_DDOName;
         this.AV37SearchTxt = aP1_SearchTxt;
         this.AV38SearchTxtTo = aP2_SearchTxtTo;
         this.AV43OptionsJson = "" ;
         this.AV46OptionsDescJson = "" ;
         this.AV48OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV43OptionsJson;
         aP4_OptionsDescJson=this.AV46OptionsDescJson;
         aP5_OptionIndexesJson=this.AV48OptionIndexesJson;
         return AV48OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_pathology_diagwwgetfilterdata objbr_pathology_diagwwgetfilterdata;
         objbr_pathology_diagwwgetfilterdata = new br_pathology_diagwwgetfilterdata();
         objbr_pathology_diagwwgetfilterdata.AV39DDOName = aP0_DDOName;
         objbr_pathology_diagwwgetfilterdata.AV37SearchTxt = aP1_SearchTxt;
         objbr_pathology_diagwwgetfilterdata.AV38SearchTxtTo = aP2_SearchTxtTo;
         objbr_pathology_diagwwgetfilterdata.AV43OptionsJson = "" ;
         objbr_pathology_diagwwgetfilterdata.AV46OptionsDescJson = "" ;
         objbr_pathology_diagwwgetfilterdata.AV48OptionIndexesJson = "" ;
         objbr_pathology_diagwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_pathology_diagwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_pathology_diagwwgetfilterdata);
         aP3_OptionsJson=this.AV43OptionsJson;
         aP4_OptionsDescJson=this.AV46OptionsDescJson;
         aP5_OptionIndexesJson=this.AV48OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_pathology_diagwwgetfilterdata)stateInfo).executePrivate();
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
         AV42Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV45OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV47OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology_Diag", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV39DDOName), "DDO_BR_PATHOLOGY_DIAG_LOC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIAG_LOCOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV39DDOName), "DDO_BR_PATHOLOGY_DIAG_ORGAN") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIAG_ORGANOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV39DDOName), "DDO_BR_PATHOLOGY_DIAG_TUMORTYPE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIAG_TUMORTYPEOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV39DDOName), "DDO_BR_PATHOLOGY_DIAG_TUMORSTAGE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIAG_TUMORSTAGEOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV39DDOName), "DDO_BR_PATHOLOGY_DIAG_TUMORGRADE") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_DIAG_TUMORGRADEOPTIONS' */
               S161 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV43OptionsJson = AV42Options.ToJSonString(false);
         AV46OptionsDescJson = AV45OptionsDesc.ToJSonString(false);
         AV48OptionIndexesJson = AV47OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV50Session.Get("BR_Pathology_DiagWWGridState"), "") == 0 )
         {
            AV52GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Pathology_DiagWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV52GridState.FromXml(AV50Session.Get("BR_Pathology_DiagWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV57GXV1 = 1;
         while ( AV57GXV1 <= AV52GridState.gxTpr_Filtervalues.Count )
         {
            AV53GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV52GridState.gxTpr_Filtervalues.Item(AV57GXV1));
            if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAGID") == 0 )
            {
               AV11TFBR_Pathology_DiagID = (long)(NumberUtil.Val( AV53GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Pathology_DiagID_To = (long)(NumberUtil.Val( AV53GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV13TFBR_PathologyID = (long)(NumberUtil.Val( AV53GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_PathologyID_To = (long)(NumberUtil.Val( AV53GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_LOC") == 0 )
            {
               AV15TFBR_Pathology_Diag_Loc = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_LOC_SEL") == 0 )
            {
               AV16TFBR_Pathology_Diag_Loc_Sel = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_ORGAN") == 0 )
            {
               AV17TFBR_Pathology_Diag_Organ = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_ORGAN_SEL") == 0 )
            {
               AV18TFBR_Pathology_Diag_Organ_Sel = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORTYPE") == 0 )
            {
               AV19TFBR_Pathology_Diag_TumorType = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORTYPE_SEL") == 0 )
            {
               AV20TFBR_Pathology_Diag_TumorType_Sel = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORSTAGE") == 0 )
            {
               AV21TFBR_Pathology_Diag_TumorStage = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORSTAGE_SEL") == 0 )
            {
               AV22TFBR_Pathology_Diag_TumorStage_Sel = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORGRADE") == 0 )
            {
               AV23TFBR_Pathology_Diag_TumorGrade = AV53GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV53GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIAG_TUMORGRADE_SEL") == 0 )
            {
               AV24TFBR_Pathology_Diag_TumorGrade_Sel = AV53GridStateFilterValue.gxTpr_Value;
            }
            AV57GXV1 = (int)(AV57GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_PATHOLOGY_DIAG_LOCOPTIONS' Routine */
         AV15TFBR_Pathology_Diag_Loc = AV37SearchTxt;
         AV16TFBR_Pathology_Diag_Loc_Sel = "";
         AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV11TFBR_Pathology_DiagID;
         AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV12TFBR_Pathology_DiagID_To;
         AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV15TFBR_Pathology_Diag_Loc;
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV16TFBR_Pathology_Diag_Loc_Sel;
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV17TFBR_Pathology_Diag_Organ;
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV18TFBR_Pathology_Diag_Organ_Sel;
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV19TFBR_Pathology_Diag_TumorType;
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV20TFBR_Pathology_Diag_TumorType_Sel;
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV21TFBR_Pathology_Diag_TumorStage;
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV22TFBR_Pathology_Diag_TumorStage_Sel;
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV23TFBR_Pathology_Diag_TumorGrade;
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV24TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor P002N2 */
         pr_default.execute(0, new Object[] {AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2N2 = false;
            A277BR_Pathology_Diag_Loc = P002N2_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = P002N2_n277BR_Pathology_Diag_Loc[0];
            A281BR_Pathology_Diag_TumorGrade = P002N2_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = P002N2_n281BR_Pathology_Diag_TumorGrade[0];
            A280BR_Pathology_Diag_TumorStage = P002N2_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = P002N2_n280BR_Pathology_Diag_TumorStage[0];
            A279BR_Pathology_Diag_TumorType = P002N2_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = P002N2_n279BR_Pathology_Diag_TumorType[0];
            A278BR_Pathology_Diag_Organ = P002N2_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = P002N2_n278BR_Pathology_Diag_Organ[0];
            A226BR_PathologyID = P002N2_A226BR_PathologyID[0];
            n226BR_PathologyID = P002N2_n226BR_PathologyID[0];
            A276BR_Pathology_DiagID = P002N2_A276BR_Pathology_DiagID[0];
            AV49count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002N2_A277BR_Pathology_Diag_Loc[0], A277BR_Pathology_Diag_Loc) == 0 ) )
            {
               BRK2N2 = false;
               A276BR_Pathology_DiagID = P002N2_A276BR_Pathology_DiagID[0];
               AV49count = (long)(AV49count+1);
               BRK2N2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A277BR_Pathology_Diag_Loc)) )
            {
               AV41Option = A277BR_Pathology_Diag_Loc;
               AV42Options.Add(AV41Option, 0);
               AV47OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV49count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV42Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2N2 )
            {
               BRK2N2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_PATHOLOGY_DIAG_ORGANOPTIONS' Routine */
         AV17TFBR_Pathology_Diag_Organ = AV37SearchTxt;
         AV18TFBR_Pathology_Diag_Organ_Sel = "";
         AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV11TFBR_Pathology_DiagID;
         AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV12TFBR_Pathology_DiagID_To;
         AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV15TFBR_Pathology_Diag_Loc;
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV16TFBR_Pathology_Diag_Loc_Sel;
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV17TFBR_Pathology_Diag_Organ;
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV18TFBR_Pathology_Diag_Organ_Sel;
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV19TFBR_Pathology_Diag_TumorType;
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV20TFBR_Pathology_Diag_TumorType_Sel;
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV21TFBR_Pathology_Diag_TumorStage;
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV22TFBR_Pathology_Diag_TumorStage_Sel;
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV23TFBR_Pathology_Diag_TumorGrade;
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV24TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor P002N3 */
         pr_default.execute(1, new Object[] {AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2N4 = false;
            A278BR_Pathology_Diag_Organ = P002N3_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = P002N3_n278BR_Pathology_Diag_Organ[0];
            A281BR_Pathology_Diag_TumorGrade = P002N3_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = P002N3_n281BR_Pathology_Diag_TumorGrade[0];
            A280BR_Pathology_Diag_TumorStage = P002N3_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = P002N3_n280BR_Pathology_Diag_TumorStage[0];
            A279BR_Pathology_Diag_TumorType = P002N3_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = P002N3_n279BR_Pathology_Diag_TumorType[0];
            A277BR_Pathology_Diag_Loc = P002N3_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = P002N3_n277BR_Pathology_Diag_Loc[0];
            A226BR_PathologyID = P002N3_A226BR_PathologyID[0];
            n226BR_PathologyID = P002N3_n226BR_PathologyID[0];
            A276BR_Pathology_DiagID = P002N3_A276BR_Pathology_DiagID[0];
            AV49count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002N3_A278BR_Pathology_Diag_Organ[0], A278BR_Pathology_Diag_Organ) == 0 ) )
            {
               BRK2N4 = false;
               A276BR_Pathology_DiagID = P002N3_A276BR_Pathology_DiagID[0];
               AV49count = (long)(AV49count+1);
               BRK2N4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A278BR_Pathology_Diag_Organ)) )
            {
               AV41Option = A278BR_Pathology_Diag_Organ;
               AV42Options.Add(AV41Option, 0);
               AV47OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV49count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV42Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2N4 )
            {
               BRK2N4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_PATHOLOGY_DIAG_TUMORTYPEOPTIONS' Routine */
         AV19TFBR_Pathology_Diag_TumorType = AV37SearchTxt;
         AV20TFBR_Pathology_Diag_TumorType_Sel = "";
         AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV11TFBR_Pathology_DiagID;
         AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV12TFBR_Pathology_DiagID_To;
         AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV15TFBR_Pathology_Diag_Loc;
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV16TFBR_Pathology_Diag_Loc_Sel;
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV17TFBR_Pathology_Diag_Organ;
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV18TFBR_Pathology_Diag_Organ_Sel;
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV19TFBR_Pathology_Diag_TumorType;
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV20TFBR_Pathology_Diag_TumorType_Sel;
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV21TFBR_Pathology_Diag_TumorStage;
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV22TFBR_Pathology_Diag_TumorStage_Sel;
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV23TFBR_Pathology_Diag_TumorGrade;
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV24TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor P002N4 */
         pr_default.execute(2, new Object[] {AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK2N6 = false;
            A279BR_Pathology_Diag_TumorType = P002N4_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = P002N4_n279BR_Pathology_Diag_TumorType[0];
            A281BR_Pathology_Diag_TumorGrade = P002N4_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = P002N4_n281BR_Pathology_Diag_TumorGrade[0];
            A280BR_Pathology_Diag_TumorStage = P002N4_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = P002N4_n280BR_Pathology_Diag_TumorStage[0];
            A278BR_Pathology_Diag_Organ = P002N4_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = P002N4_n278BR_Pathology_Diag_Organ[0];
            A277BR_Pathology_Diag_Loc = P002N4_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = P002N4_n277BR_Pathology_Diag_Loc[0];
            A226BR_PathologyID = P002N4_A226BR_PathologyID[0];
            n226BR_PathologyID = P002N4_n226BR_PathologyID[0];
            A276BR_Pathology_DiagID = P002N4_A276BR_Pathology_DiagID[0];
            AV49count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P002N4_A279BR_Pathology_Diag_TumorType[0], A279BR_Pathology_Diag_TumorType) == 0 ) )
            {
               BRK2N6 = false;
               A276BR_Pathology_DiagID = P002N4_A276BR_Pathology_DiagID[0];
               AV49count = (long)(AV49count+1);
               BRK2N6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A279BR_Pathology_Diag_TumorType)) )
            {
               AV41Option = A279BR_Pathology_Diag_TumorType;
               AV42Options.Add(AV41Option, 0);
               AV47OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV49count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV42Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2N6 )
            {
               BRK2N6 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADBR_PATHOLOGY_DIAG_TUMORSTAGEOPTIONS' Routine */
         AV21TFBR_Pathology_Diag_TumorStage = AV37SearchTxt;
         AV22TFBR_Pathology_Diag_TumorStage_Sel = "";
         AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV11TFBR_Pathology_DiagID;
         AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV12TFBR_Pathology_DiagID_To;
         AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV15TFBR_Pathology_Diag_Loc;
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV16TFBR_Pathology_Diag_Loc_Sel;
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV17TFBR_Pathology_Diag_Organ;
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV18TFBR_Pathology_Diag_Organ_Sel;
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV19TFBR_Pathology_Diag_TumorType;
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV20TFBR_Pathology_Diag_TumorType_Sel;
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV21TFBR_Pathology_Diag_TumorStage;
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV22TFBR_Pathology_Diag_TumorStage_Sel;
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV23TFBR_Pathology_Diag_TumorGrade;
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV24TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor P002N5 */
         pr_default.execute(3, new Object[] {AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK2N8 = false;
            A280BR_Pathology_Diag_TumorStage = P002N5_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = P002N5_n280BR_Pathology_Diag_TumorStage[0];
            A281BR_Pathology_Diag_TumorGrade = P002N5_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = P002N5_n281BR_Pathology_Diag_TumorGrade[0];
            A279BR_Pathology_Diag_TumorType = P002N5_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = P002N5_n279BR_Pathology_Diag_TumorType[0];
            A278BR_Pathology_Diag_Organ = P002N5_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = P002N5_n278BR_Pathology_Diag_Organ[0];
            A277BR_Pathology_Diag_Loc = P002N5_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = P002N5_n277BR_Pathology_Diag_Loc[0];
            A226BR_PathologyID = P002N5_A226BR_PathologyID[0];
            n226BR_PathologyID = P002N5_n226BR_PathologyID[0];
            A276BR_Pathology_DiagID = P002N5_A276BR_Pathology_DiagID[0];
            AV49count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P002N5_A280BR_Pathology_Diag_TumorStage[0], A280BR_Pathology_Diag_TumorStage) == 0 ) )
            {
               BRK2N8 = false;
               A276BR_Pathology_DiagID = P002N5_A276BR_Pathology_DiagID[0];
               AV49count = (long)(AV49count+1);
               BRK2N8 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A280BR_Pathology_Diag_TumorStage)) )
            {
               AV41Option = A280BR_Pathology_Diag_TumorStage;
               AV42Options.Add(AV41Option, 0);
               AV47OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV49count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV42Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2N8 )
            {
               BRK2N8 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
      }

      protected void S161( )
      {
         /* 'LOADBR_PATHOLOGY_DIAG_TUMORGRADEOPTIONS' Routine */
         AV23TFBR_Pathology_Diag_TumorGrade = AV37SearchTxt;
         AV24TFBR_Pathology_Diag_TumorGrade_Sel = "";
         AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid = AV11TFBR_Pathology_DiagID;
         AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to = AV12TFBR_Pathology_DiagID_To;
         AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = AV15TFBR_Pathology_Diag_Loc;
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = AV16TFBR_Pathology_Diag_Loc_Sel;
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = AV17TFBR_Pathology_Diag_Organ;
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = AV18TFBR_Pathology_Diag_Organ_Sel;
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = AV19TFBR_Pathology_Diag_TumorType;
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = AV20TFBR_Pathology_Diag_TumorType_Sel;
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = AV21TFBR_Pathology_Diag_TumorStage;
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = AV22TFBR_Pathology_Diag_TumorStage_Sel;
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = AV23TFBR_Pathology_Diag_TumorGrade;
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = AV24TFBR_Pathology_Diag_TumorGrade_Sel;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                              AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                              AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                              AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                              AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                              AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                              AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                              AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                              AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                              AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                              AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                              AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                              AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                              AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                              A276BR_Pathology_DiagID ,
                                              A226BR_PathologyID ,
                                              A277BR_Pathology_Diag_Loc ,
                                              A278BR_Pathology_Diag_Organ ,
                                              A279BR_Pathology_Diag_TumorType ,
                                              A280BR_Pathology_Diag_TumorStage ,
                                              A281BR_Pathology_Diag_TumorGrade } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc), "%", "");
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ), "%", "");
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = StringUtil.Concat( StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype), "%", "");
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = StringUtil.Concat( StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage), "%", "");
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = StringUtil.Concat( StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade), "%", "");
         /* Using cursor P002N6 */
         pr_default.execute(4, new Object[] {AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid, AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to, AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid, AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to, lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc, AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel, lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ, AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel, lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype, AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel, lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage, AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel, lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade, AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK2N10 = false;
            A281BR_Pathology_Diag_TumorGrade = P002N6_A281BR_Pathology_Diag_TumorGrade[0];
            n281BR_Pathology_Diag_TumorGrade = P002N6_n281BR_Pathology_Diag_TumorGrade[0];
            A280BR_Pathology_Diag_TumorStage = P002N6_A280BR_Pathology_Diag_TumorStage[0];
            n280BR_Pathology_Diag_TumorStage = P002N6_n280BR_Pathology_Diag_TumorStage[0];
            A279BR_Pathology_Diag_TumorType = P002N6_A279BR_Pathology_Diag_TumorType[0];
            n279BR_Pathology_Diag_TumorType = P002N6_n279BR_Pathology_Diag_TumorType[0];
            A278BR_Pathology_Diag_Organ = P002N6_A278BR_Pathology_Diag_Organ[0];
            n278BR_Pathology_Diag_Organ = P002N6_n278BR_Pathology_Diag_Organ[0];
            A277BR_Pathology_Diag_Loc = P002N6_A277BR_Pathology_Diag_Loc[0];
            n277BR_Pathology_Diag_Loc = P002N6_n277BR_Pathology_Diag_Loc[0];
            A226BR_PathologyID = P002N6_A226BR_PathologyID[0];
            n226BR_PathologyID = P002N6_n226BR_PathologyID[0];
            A276BR_Pathology_DiagID = P002N6_A276BR_Pathology_DiagID[0];
            AV49count = 0;
            while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(P002N6_A281BR_Pathology_Diag_TumorGrade[0], A281BR_Pathology_Diag_TumorGrade) == 0 ) )
            {
               BRK2N10 = false;
               A276BR_Pathology_DiagID = P002N6_A276BR_Pathology_DiagID[0];
               AV49count = (long)(AV49count+1);
               BRK2N10 = true;
               pr_default.readNext(4);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A281BR_Pathology_Diag_TumorGrade)) )
            {
               AV41Option = A281BR_Pathology_Diag_TumorGrade;
               AV42Options.Add(AV41Option, 0);
               AV47OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV49count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV42Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2N10 )
            {
               BRK2N10 = true;
               pr_default.readNext(4);
            }
         }
         pr_default.close(4);
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
         AV42Options = new GxSimpleCollection<String>();
         AV45OptionsDesc = new GxSimpleCollection<String>();
         AV47OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV50Session = context.GetSession();
         AV52GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV53GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Pathology_Diag_Loc = "";
         AV16TFBR_Pathology_Diag_Loc_Sel = "";
         AV17TFBR_Pathology_Diag_Organ = "";
         AV18TFBR_Pathology_Diag_Organ_Sel = "";
         AV19TFBR_Pathology_Diag_TumorType = "";
         AV20TFBR_Pathology_Diag_TumorType_Sel = "";
         AV21TFBR_Pathology_Diag_TumorStage = "";
         AV22TFBR_Pathology_Diag_TumorStage_Sel = "";
         AV23TFBR_Pathology_Diag_TumorGrade = "";
         AV24TFBR_Pathology_Diag_TumorGrade_Sel = "";
         AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = "";
         AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel = "";
         AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = "";
         AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel = "";
         AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = "";
         AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel = "";
         AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = "";
         AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel = "";
         AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = "";
         AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel = "";
         scmdbuf = "";
         lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc = "";
         lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ = "";
         lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype = "";
         lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage = "";
         lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade = "";
         A277BR_Pathology_Diag_Loc = "";
         A278BR_Pathology_Diag_Organ = "";
         A279BR_Pathology_Diag_TumorType = "";
         A280BR_Pathology_Diag_TumorStage = "";
         A281BR_Pathology_Diag_TumorGrade = "";
         P002N2_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         P002N2_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         P002N2_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         P002N2_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         P002N2_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         P002N2_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         P002N2_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         P002N2_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         P002N2_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         P002N2_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         P002N2_A226BR_PathologyID = new long[1] ;
         P002N2_n226BR_PathologyID = new bool[] {false} ;
         P002N2_A276BR_Pathology_DiagID = new long[1] ;
         AV41Option = "";
         P002N3_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         P002N3_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         P002N3_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         P002N3_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         P002N3_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         P002N3_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         P002N3_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         P002N3_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         P002N3_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         P002N3_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         P002N3_A226BR_PathologyID = new long[1] ;
         P002N3_n226BR_PathologyID = new bool[] {false} ;
         P002N3_A276BR_Pathology_DiagID = new long[1] ;
         P002N4_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         P002N4_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         P002N4_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         P002N4_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         P002N4_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         P002N4_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         P002N4_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         P002N4_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         P002N4_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         P002N4_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         P002N4_A226BR_PathologyID = new long[1] ;
         P002N4_n226BR_PathologyID = new bool[] {false} ;
         P002N4_A276BR_Pathology_DiagID = new long[1] ;
         P002N5_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         P002N5_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         P002N5_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         P002N5_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         P002N5_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         P002N5_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         P002N5_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         P002N5_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         P002N5_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         P002N5_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         P002N5_A226BR_PathologyID = new long[1] ;
         P002N5_n226BR_PathologyID = new bool[] {false} ;
         P002N5_A276BR_Pathology_DiagID = new long[1] ;
         P002N6_A281BR_Pathology_Diag_TumorGrade = new String[] {""} ;
         P002N6_n281BR_Pathology_Diag_TumorGrade = new bool[] {false} ;
         P002N6_A280BR_Pathology_Diag_TumorStage = new String[] {""} ;
         P002N6_n280BR_Pathology_Diag_TumorStage = new bool[] {false} ;
         P002N6_A279BR_Pathology_Diag_TumorType = new String[] {""} ;
         P002N6_n279BR_Pathology_Diag_TumorType = new bool[] {false} ;
         P002N6_A278BR_Pathology_Diag_Organ = new String[] {""} ;
         P002N6_n278BR_Pathology_Diag_Organ = new bool[] {false} ;
         P002N6_A277BR_Pathology_Diag_Loc = new String[] {""} ;
         P002N6_n277BR_Pathology_Diag_Loc = new bool[] {false} ;
         P002N6_A226BR_PathologyID = new long[1] ;
         P002N6_n226BR_PathologyID = new bool[] {false} ;
         P002N6_A276BR_Pathology_DiagID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_diagwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002N2_A277BR_Pathology_Diag_Loc, P002N2_n277BR_Pathology_Diag_Loc, P002N2_A281BR_Pathology_Diag_TumorGrade, P002N2_n281BR_Pathology_Diag_TumorGrade, P002N2_A280BR_Pathology_Diag_TumorStage, P002N2_n280BR_Pathology_Diag_TumorStage, P002N2_A279BR_Pathology_Diag_TumorType, P002N2_n279BR_Pathology_Diag_TumorType, P002N2_A278BR_Pathology_Diag_Organ, P002N2_n278BR_Pathology_Diag_Organ,
               P002N2_A226BR_PathologyID, P002N2_n226BR_PathologyID, P002N2_A276BR_Pathology_DiagID
               }
               , new Object[] {
               P002N3_A278BR_Pathology_Diag_Organ, P002N3_n278BR_Pathology_Diag_Organ, P002N3_A281BR_Pathology_Diag_TumorGrade, P002N3_n281BR_Pathology_Diag_TumorGrade, P002N3_A280BR_Pathology_Diag_TumorStage, P002N3_n280BR_Pathology_Diag_TumorStage, P002N3_A279BR_Pathology_Diag_TumorType, P002N3_n279BR_Pathology_Diag_TumorType, P002N3_A277BR_Pathology_Diag_Loc, P002N3_n277BR_Pathology_Diag_Loc,
               P002N3_A226BR_PathologyID, P002N3_n226BR_PathologyID, P002N3_A276BR_Pathology_DiagID
               }
               , new Object[] {
               P002N4_A279BR_Pathology_Diag_TumorType, P002N4_n279BR_Pathology_Diag_TumorType, P002N4_A281BR_Pathology_Diag_TumorGrade, P002N4_n281BR_Pathology_Diag_TumorGrade, P002N4_A280BR_Pathology_Diag_TumorStage, P002N4_n280BR_Pathology_Diag_TumorStage, P002N4_A278BR_Pathology_Diag_Organ, P002N4_n278BR_Pathology_Diag_Organ, P002N4_A277BR_Pathology_Diag_Loc, P002N4_n277BR_Pathology_Diag_Loc,
               P002N4_A226BR_PathologyID, P002N4_n226BR_PathologyID, P002N4_A276BR_Pathology_DiagID
               }
               , new Object[] {
               P002N5_A280BR_Pathology_Diag_TumorStage, P002N5_n280BR_Pathology_Diag_TumorStage, P002N5_A281BR_Pathology_Diag_TumorGrade, P002N5_n281BR_Pathology_Diag_TumorGrade, P002N5_A279BR_Pathology_Diag_TumorType, P002N5_n279BR_Pathology_Diag_TumorType, P002N5_A278BR_Pathology_Diag_Organ, P002N5_n278BR_Pathology_Diag_Organ, P002N5_A277BR_Pathology_Diag_Loc, P002N5_n277BR_Pathology_Diag_Loc,
               P002N5_A226BR_PathologyID, P002N5_n226BR_PathologyID, P002N5_A276BR_Pathology_DiagID
               }
               , new Object[] {
               P002N6_A281BR_Pathology_Diag_TumorGrade, P002N6_n281BR_Pathology_Diag_TumorGrade, P002N6_A280BR_Pathology_Diag_TumorStage, P002N6_n280BR_Pathology_Diag_TumorStage, P002N6_A279BR_Pathology_Diag_TumorType, P002N6_n279BR_Pathology_Diag_TumorType, P002N6_A278BR_Pathology_Diag_Organ, P002N6_n278BR_Pathology_Diag_Organ, P002N6_A277BR_Pathology_Diag_Loc, P002N6_n277BR_Pathology_Diag_Loc,
               P002N6_A226BR_PathologyID, P002N6_n226BR_PathologyID, P002N6_A276BR_Pathology_DiagID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV57GXV1 ;
      private long AV11TFBR_Pathology_DiagID ;
      private long AV12TFBR_Pathology_DiagID_To ;
      private long AV13TFBR_PathologyID ;
      private long AV14TFBR_PathologyID_To ;
      private long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ;
      private long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ;
      private long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ;
      private long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ;
      private long A276BR_Pathology_DiagID ;
      private long A226BR_PathologyID ;
      private long AV49count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2N2 ;
      private bool n277BR_Pathology_Diag_Loc ;
      private bool n281BR_Pathology_Diag_TumorGrade ;
      private bool n280BR_Pathology_Diag_TumorStage ;
      private bool n279BR_Pathology_Diag_TumorType ;
      private bool n278BR_Pathology_Diag_Organ ;
      private bool n226BR_PathologyID ;
      private bool BRK2N4 ;
      private bool BRK2N6 ;
      private bool BRK2N8 ;
      private bool BRK2N10 ;
      private String AV48OptionIndexesJson ;
      private String AV43OptionsJson ;
      private String AV46OptionsDescJson ;
      private String AV39DDOName ;
      private String AV37SearchTxt ;
      private String AV38SearchTxtTo ;
      private String AV15TFBR_Pathology_Diag_Loc ;
      private String AV16TFBR_Pathology_Diag_Loc_Sel ;
      private String AV17TFBR_Pathology_Diag_Organ ;
      private String AV18TFBR_Pathology_Diag_Organ_Sel ;
      private String AV19TFBR_Pathology_Diag_TumorType ;
      private String AV20TFBR_Pathology_Diag_TumorType_Sel ;
      private String AV21TFBR_Pathology_Diag_TumorStage ;
      private String AV22TFBR_Pathology_Diag_TumorStage_Sel ;
      private String AV23TFBR_Pathology_Diag_TumorGrade ;
      private String AV24TFBR_Pathology_Diag_TumorGrade_Sel ;
      private String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ;
      private String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ;
      private String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ;
      private String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ;
      private String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ;
      private String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ;
      private String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ;
      private String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ;
      private String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ;
      private String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ;
      private String lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ;
      private String lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ;
      private String lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ;
      private String lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ;
      private String lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ;
      private String A277BR_Pathology_Diag_Loc ;
      private String A278BR_Pathology_Diag_Organ ;
      private String A279BR_Pathology_Diag_TumorType ;
      private String A280BR_Pathology_Diag_TumorStage ;
      private String A281BR_Pathology_Diag_TumorGrade ;
      private String AV41Option ;
      private IGxSession AV50Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002N2_A277BR_Pathology_Diag_Loc ;
      private bool[] P002N2_n277BR_Pathology_Diag_Loc ;
      private String[] P002N2_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] P002N2_n281BR_Pathology_Diag_TumorGrade ;
      private String[] P002N2_A280BR_Pathology_Diag_TumorStage ;
      private bool[] P002N2_n280BR_Pathology_Diag_TumorStage ;
      private String[] P002N2_A279BR_Pathology_Diag_TumorType ;
      private bool[] P002N2_n279BR_Pathology_Diag_TumorType ;
      private String[] P002N2_A278BR_Pathology_Diag_Organ ;
      private bool[] P002N2_n278BR_Pathology_Diag_Organ ;
      private long[] P002N2_A226BR_PathologyID ;
      private bool[] P002N2_n226BR_PathologyID ;
      private long[] P002N2_A276BR_Pathology_DiagID ;
      private String[] P002N3_A278BR_Pathology_Diag_Organ ;
      private bool[] P002N3_n278BR_Pathology_Diag_Organ ;
      private String[] P002N3_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] P002N3_n281BR_Pathology_Diag_TumorGrade ;
      private String[] P002N3_A280BR_Pathology_Diag_TumorStage ;
      private bool[] P002N3_n280BR_Pathology_Diag_TumorStage ;
      private String[] P002N3_A279BR_Pathology_Diag_TumorType ;
      private bool[] P002N3_n279BR_Pathology_Diag_TumorType ;
      private String[] P002N3_A277BR_Pathology_Diag_Loc ;
      private bool[] P002N3_n277BR_Pathology_Diag_Loc ;
      private long[] P002N3_A226BR_PathologyID ;
      private bool[] P002N3_n226BR_PathologyID ;
      private long[] P002N3_A276BR_Pathology_DiagID ;
      private String[] P002N4_A279BR_Pathology_Diag_TumorType ;
      private bool[] P002N4_n279BR_Pathology_Diag_TumorType ;
      private String[] P002N4_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] P002N4_n281BR_Pathology_Diag_TumorGrade ;
      private String[] P002N4_A280BR_Pathology_Diag_TumorStage ;
      private bool[] P002N4_n280BR_Pathology_Diag_TumorStage ;
      private String[] P002N4_A278BR_Pathology_Diag_Organ ;
      private bool[] P002N4_n278BR_Pathology_Diag_Organ ;
      private String[] P002N4_A277BR_Pathology_Diag_Loc ;
      private bool[] P002N4_n277BR_Pathology_Diag_Loc ;
      private long[] P002N4_A226BR_PathologyID ;
      private bool[] P002N4_n226BR_PathologyID ;
      private long[] P002N4_A276BR_Pathology_DiagID ;
      private String[] P002N5_A280BR_Pathology_Diag_TumorStage ;
      private bool[] P002N5_n280BR_Pathology_Diag_TumorStage ;
      private String[] P002N5_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] P002N5_n281BR_Pathology_Diag_TumorGrade ;
      private String[] P002N5_A279BR_Pathology_Diag_TumorType ;
      private bool[] P002N5_n279BR_Pathology_Diag_TumorType ;
      private String[] P002N5_A278BR_Pathology_Diag_Organ ;
      private bool[] P002N5_n278BR_Pathology_Diag_Organ ;
      private String[] P002N5_A277BR_Pathology_Diag_Loc ;
      private bool[] P002N5_n277BR_Pathology_Diag_Loc ;
      private long[] P002N5_A226BR_PathologyID ;
      private bool[] P002N5_n226BR_PathologyID ;
      private long[] P002N5_A276BR_Pathology_DiagID ;
      private String[] P002N6_A281BR_Pathology_Diag_TumorGrade ;
      private bool[] P002N6_n281BR_Pathology_Diag_TumorGrade ;
      private String[] P002N6_A280BR_Pathology_Diag_TumorStage ;
      private bool[] P002N6_n280BR_Pathology_Diag_TumorStage ;
      private String[] P002N6_A279BR_Pathology_Diag_TumorType ;
      private bool[] P002N6_n279BR_Pathology_Diag_TumorType ;
      private String[] P002N6_A278BR_Pathology_Diag_Organ ;
      private bool[] P002N6_n278BR_Pathology_Diag_Organ ;
      private String[] P002N6_A277BR_Pathology_Diag_Loc ;
      private bool[] P002N6_n277BR_Pathology_Diag_Loc ;
      private long[] P002N6_A226BR_PathologyID ;
      private bool[] P002N6_n226BR_PathologyID ;
      private long[] P002N6_A276BR_Pathology_DiagID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV42Options ;
      private GxSimpleCollection<String> AV45OptionsDesc ;
      private GxSimpleCollection<String> AV47OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV52GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV53GridStateFilterValue ;
   }

   public class br_pathology_diagwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002N2( IGxContext context ,
                                             long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [14] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Diag_Loc], [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Organ], [BR_PathologyID], [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int2[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int2[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Diag_Loc]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002N3( IGxContext context ,
                                             long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [14] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Loc], [BR_PathologyID], [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Diag_Organ]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P002N4( IGxContext context ,
                                             long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [14] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc], [BR_PathologyID], [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Diag_TumorType]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P002N5( IGxContext context ,
                                             long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [14] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc], [BR_PathologyID], [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( ! (0==AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! (0==AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int8[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
         }
         else
         {
            GXv_int8[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Diag_TumorStage]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      protected Object[] conditional_P002N6( IGxContext context ,
                                             long AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid ,
                                             long AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to ,
                                             long AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid ,
                                             long AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to ,
                                             String AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel ,
                                             String AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc ,
                                             String AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel ,
                                             String AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ ,
                                             String AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel ,
                                             String AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype ,
                                             String AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel ,
                                             String AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage ,
                                             String AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel ,
                                             String AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade ,
                                             long A276BR_Pathology_DiagID ,
                                             long A226BR_PathologyID ,
                                             String A277BR_Pathology_Diag_Loc ,
                                             String A278BR_Pathology_Diag_Organ ,
                                             String A279BR_Pathology_Diag_TumorType ,
                                             String A280BR_Pathology_Diag_TumorStage ,
                                             String A281BR_Pathology_Diag_TumorGrade )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [14] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Diag_TumorGrade], [BR_Pathology_Diag_TumorStage], [BR_Pathology_Diag_TumorType], [BR_Pathology_Diag_Organ], [BR_Pathology_Diag_Loc], [BR_PathologyID], [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK)";
         if ( ! (0==AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] >= @AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid)";
            }
         }
         else
         {
            GXv_int10[0] = 1;
         }
         if ( ! (0==AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_DiagID] <= @AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to)";
            }
         }
         else
         {
            GXv_int10[1] = 1;
         }
         if ( ! (0==AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int10[2] = 1;
         }
         if ( ! (0==AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int10[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] like @lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc)";
            }
         }
         else
         {
            GXv_int10[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Loc] = @AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int10[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] like @lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ)";
            }
         }
         else
         {
            GXv_int10[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_Organ] = @AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int10[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] like @lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype)";
            }
         }
         else
         {
            GXv_int10[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorType] = @AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel)";
            }
         }
         else
         {
            GXv_int10[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] like @lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage)";
            }
         }
         else
         {
            GXv_int10[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorStage] = @AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel)";
            }
         }
         else
         {
            GXv_int10[11] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] like @lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade)";
            }
         }
         else
         {
            GXv_int10[12] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Diag_TumorGrade] = @AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel)";
            }
         }
         else
         {
            GXv_int10[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Diag_TumorGrade]";
         GXv_Object11[0] = scmdbuf;
         GXv_Object11[1] = GXv_int10;
         return GXv_Object11 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P002N2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] );
               case 1 :
                     return conditional_P002N3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] );
               case 2 :
                     return conditional_P002N4(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] );
               case 3 :
                     return conditional_P002N5(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] );
               case 4 :
                     return conditional_P002N6(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002N2 ;
          prmP002N2 = new Object[] {
          new Object[] {"@AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002N3 ;
          prmP002N3 = new Object[] {
          new Object[] {"@AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002N4 ;
          prmP002N4 = new Object[] {
          new Object[] {"@AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002N5 ;
          prmP002N5 = new Object[] {
          new Object[] {"@AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP002N6 ;
          prmP002N6 = new Object[] {
          new Object[] {"@AV59BR_Pathology_DiagWWDS_1_Tfbr_pathology_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV60BR_Pathology_DiagWWDS_2_Tfbr_pathology_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_Pathology_DiagWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV62BR_Pathology_DiagWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV63BR_Pathology_DiagWWDS_5_Tfbr_pathology_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV64BR_Pathology_DiagWWDS_6_Tfbr_pathology_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV65BR_Pathology_DiagWWDS_7_Tfbr_pathology_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV66BR_Pathology_DiagWWDS_8_Tfbr_pathology_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV67BR_Pathology_DiagWWDS_9_Tfbr_pathology_diag_tumortype",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV68BR_Pathology_DiagWWDS_10_Tfbr_pathology_diag_tumortype_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV69BR_Pathology_DiagWWDS_11_Tfbr_pathology_diag_tumorstage",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV70BR_Pathology_DiagWWDS_12_Tfbr_pathology_diag_tumorstage_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV71BR_Pathology_DiagWWDS_13_Tfbr_pathology_diag_tumorgrade",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV72BR_Pathology_DiagWWDS_14_Tfbr_pathology_diag_tumorgrade_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002N2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N2,100,0,true,false )
             ,new CursorDef("P002N3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N3,100,0,true,false )
             ,new CursorDef("P002N4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N4,100,0,true,false )
             ,new CursorDef("P002N5", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N5,100,0,true,false )
             ,new CursorDef("P002N6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002N6,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
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
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
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
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
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
             case 3 :
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
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
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
             case 4 :
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
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.br_pathology_diagwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_pathology_diagwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_pathology_diagwwgetfilterdata") )
          {
             return  ;
          }
          br_pathology_diagwwgetfilterdata worker = new br_pathology_diagwwgetfilterdata(context) ;
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
