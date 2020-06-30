/*
               File: BR_MedicalImaging_DiagWWGetFilterData
        Description: BR_Medical Imaging_Diag WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:22.37
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
   public class br_medicalimaging_diagwwgetfilterdata : GXProcedure
   {
      public br_medicalimaging_diagwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging_diagwwgetfilterdata( IGxContext context )
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
         br_medicalimaging_diagwwgetfilterdata objbr_medicalimaging_diagwwgetfilterdata;
         objbr_medicalimaging_diagwwgetfilterdata = new br_medicalimaging_diagwwgetfilterdata();
         objbr_medicalimaging_diagwwgetfilterdata.AV23DDOName = aP0_DDOName;
         objbr_medicalimaging_diagwwgetfilterdata.AV21SearchTxt = aP1_SearchTxt;
         objbr_medicalimaging_diagwwgetfilterdata.AV22SearchTxtTo = aP2_SearchTxtTo;
         objbr_medicalimaging_diagwwgetfilterdata.AV27OptionsJson = "" ;
         objbr_medicalimaging_diagwwgetfilterdata.AV30OptionsDescJson = "" ;
         objbr_medicalimaging_diagwwgetfilterdata.AV32OptionIndexesJson = "" ;
         objbr_medicalimaging_diagwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_medicalimaging_diagwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_medicalimaging_diagwwgetfilterdata);
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_medicalimaging_diagwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Home", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_MEDICALIMAGING_DIAG_LOC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICALIMAGING_DIAG_LOCOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_MEDICALIMAGING_DIAG_ORGAN") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICALIMAGING_DIAG_ORGANOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_MEDICALIMAGING_DIAG_DIS") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICALIMAGING_DIAG_DISOPTIONS' */
               S141 ();
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
         if ( StringUtil.StrCmp(AV34Session.Get("BR_MedicalImaging_DiagWWGridState"), "") == 0 )
         {
            AV36GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_MedicalImaging_DiagWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV36GridState.FromXml(AV34Session.Get("BR_MedicalImaging_DiagWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV43GXV1 = 1;
         while ( AV43GXV1 <= AV36GridState.gxTpr_Filtervalues.Count )
         {
            AV37GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV36GridState.gxTpr_Filtervalues.Item(AV43GXV1));
            if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAGID") == 0 )
            {
               AV11TFBR_MedicalImaging_DiagID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_MedicalImaging_DiagID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGINGID") == 0 )
            {
               AV13TFBR_MedicalImagingID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_MedicalImagingID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_LOC") == 0 )
            {
               AV15TFBR_MedicalImaging_Diag_Loc = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_LOC_SEL") == 0 )
            {
               AV16TFBR_MedicalImaging_Diag_Loc_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_ORGAN") == 0 )
            {
               AV17TFBR_MedicalImaging_Diag_Organ = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_ORGAN_SEL") == 0 )
            {
               AV18TFBR_MedicalImaging_Diag_Organ_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_DIS") == 0 )
            {
               AV19TFBR_MedicalImaging_Diag_Dis = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_DIS_SEL") == 0 )
            {
               AV20TFBR_MedicalImaging_Diag_Dis_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_MEDICALIMAGING_DIAG_NO") == 0 )
            {
               AV39TFBR_MedicalImaging_Diag_No = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV40TFBR_MedicalImaging_Diag_No_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            AV43GXV1 = (int)(AV43GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_MEDICALIMAGING_DIAG_LOCOPTIONS' Routine */
         AV15TFBR_MedicalImaging_Diag_Loc = AV21SearchTxt;
         AV16TFBR_MedicalImaging_Diag_Loc_Sel = "";
         AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV11TFBR_MedicalImaging_DiagID;
         AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV12TFBR_MedicalImaging_DiagID_To;
         AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV13TFBR_MedicalImagingID;
         AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV14TFBR_MedicalImagingID_To;
         AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV15TFBR_MedicalImaging_Diag_Loc;
         AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV16TFBR_MedicalImaging_Diag_Loc_Sel;
         AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV17TFBR_MedicalImaging_Diag_Organ;
         AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV18TFBR_MedicalImaging_Diag_Organ_Sel;
         AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV19TFBR_MedicalImaging_Diag_Dis;
         AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV20TFBR_MedicalImaging_Diag_Dis_Sel;
         AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV39TFBR_MedicalImaging_Diag_No;
         AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV40TFBR_MedicalImaging_Diag_No_To;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                              AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                              AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                              AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                              AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                              AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                              AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                              AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                              AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                              AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                              AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                              AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                              A270BR_MedicalImaging_DiagID ,
                                              A225BR_MedicalImagingID ,
                                              A271BR_MedicalImaging_Diag_Loc ,
                                              A272BR_MedicalImaging_Diag_Organ ,
                                              A273BR_MedicalImaging_Diag_Dis ,
                                              A517BR_MedicalImaging_Diag_No } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc), "%", "");
         lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ), "%", "");
         lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = StringUtil.Concat( StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis), "%", "");
         /* Using cursor P002I2 */
         pr_default.execute(0, new Object[] {AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid, AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to, AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid, AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to, lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc, AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel, lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ, AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel, lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis, AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel, AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no, AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2I2 = false;
            A271BR_MedicalImaging_Diag_Loc = P002I2_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = P002I2_n271BR_MedicalImaging_Diag_Loc[0];
            A517BR_MedicalImaging_Diag_No = P002I2_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = P002I2_n517BR_MedicalImaging_Diag_No[0];
            A273BR_MedicalImaging_Diag_Dis = P002I2_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = P002I2_n273BR_MedicalImaging_Diag_Dis[0];
            A272BR_MedicalImaging_Diag_Organ = P002I2_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = P002I2_n272BR_MedicalImaging_Diag_Organ[0];
            A225BR_MedicalImagingID = P002I2_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = P002I2_n225BR_MedicalImagingID[0];
            A270BR_MedicalImaging_DiagID = P002I2_A270BR_MedicalImaging_DiagID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002I2_A271BR_MedicalImaging_Diag_Loc[0], A271BR_MedicalImaging_Diag_Loc) == 0 ) )
            {
               BRK2I2 = false;
               A270BR_MedicalImaging_DiagID = P002I2_A270BR_MedicalImaging_DiagID[0];
               AV33count = (long)(AV33count+1);
               BRK2I2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A271BR_MedicalImaging_Diag_Loc)) )
            {
               AV25Option = A271BR_MedicalImaging_Diag_Loc;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2I2 )
            {
               BRK2I2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICALIMAGING_DIAG_ORGANOPTIONS' Routine */
         AV17TFBR_MedicalImaging_Diag_Organ = AV21SearchTxt;
         AV18TFBR_MedicalImaging_Diag_Organ_Sel = "";
         AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV11TFBR_MedicalImaging_DiagID;
         AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV12TFBR_MedicalImaging_DiagID_To;
         AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV13TFBR_MedicalImagingID;
         AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV14TFBR_MedicalImagingID_To;
         AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV15TFBR_MedicalImaging_Diag_Loc;
         AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV16TFBR_MedicalImaging_Diag_Loc_Sel;
         AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV17TFBR_MedicalImaging_Diag_Organ;
         AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV18TFBR_MedicalImaging_Diag_Organ_Sel;
         AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV19TFBR_MedicalImaging_Diag_Dis;
         AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV20TFBR_MedicalImaging_Diag_Dis_Sel;
         AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV39TFBR_MedicalImaging_Diag_No;
         AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV40TFBR_MedicalImaging_Diag_No_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                              AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                              AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                              AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                              AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                              AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                              AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                              AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                              AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                              AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                              AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                              AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                              A270BR_MedicalImaging_DiagID ,
                                              A225BR_MedicalImagingID ,
                                              A271BR_MedicalImaging_Diag_Loc ,
                                              A272BR_MedicalImaging_Diag_Organ ,
                                              A273BR_MedicalImaging_Diag_Dis ,
                                              A517BR_MedicalImaging_Diag_No } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc), "%", "");
         lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ), "%", "");
         lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = StringUtil.Concat( StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis), "%", "");
         /* Using cursor P002I3 */
         pr_default.execute(1, new Object[] {AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid, AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to, AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid, AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to, lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc, AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel, lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ, AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel, lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis, AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel, AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no, AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2I4 = false;
            A272BR_MedicalImaging_Diag_Organ = P002I3_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = P002I3_n272BR_MedicalImaging_Diag_Organ[0];
            A517BR_MedicalImaging_Diag_No = P002I3_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = P002I3_n517BR_MedicalImaging_Diag_No[0];
            A273BR_MedicalImaging_Diag_Dis = P002I3_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = P002I3_n273BR_MedicalImaging_Diag_Dis[0];
            A271BR_MedicalImaging_Diag_Loc = P002I3_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = P002I3_n271BR_MedicalImaging_Diag_Loc[0];
            A225BR_MedicalImagingID = P002I3_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = P002I3_n225BR_MedicalImagingID[0];
            A270BR_MedicalImaging_DiagID = P002I3_A270BR_MedicalImaging_DiagID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002I3_A272BR_MedicalImaging_Diag_Organ[0], A272BR_MedicalImaging_Diag_Organ) == 0 ) )
            {
               BRK2I4 = false;
               A270BR_MedicalImaging_DiagID = P002I3_A270BR_MedicalImaging_DiagID[0];
               AV33count = (long)(AV33count+1);
               BRK2I4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A272BR_MedicalImaging_Diag_Organ)) )
            {
               AV25Option = A272BR_MedicalImaging_Diag_Organ;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2I4 )
            {
               BRK2I4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_MEDICALIMAGING_DIAG_DISOPTIONS' Routine */
         AV19TFBR_MedicalImaging_Diag_Dis = AV21SearchTxt;
         AV20TFBR_MedicalImaging_Diag_Dis_Sel = "";
         AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid = AV11TFBR_MedicalImaging_DiagID;
         AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to = AV12TFBR_MedicalImaging_DiagID_To;
         AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid = AV13TFBR_MedicalImagingID;
         AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to = AV14TFBR_MedicalImagingID_To;
         AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = AV15TFBR_MedicalImaging_Diag_Loc;
         AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = AV16TFBR_MedicalImaging_Diag_Loc_Sel;
         AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = AV17TFBR_MedicalImaging_Diag_Organ;
         AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = AV18TFBR_MedicalImaging_Diag_Organ_Sel;
         AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = AV19TFBR_MedicalImaging_Diag_Dis;
         AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = AV20TFBR_MedicalImaging_Diag_Dis_Sel;
         AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no = AV39TFBR_MedicalImaging_Diag_No;
         AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to = AV40TFBR_MedicalImaging_Diag_No_To;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                              AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                              AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                              AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                              AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                              AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                              AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                              AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                              AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                              AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                              AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                              AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                              A270BR_MedicalImaging_DiagID ,
                                              A225BR_MedicalImagingID ,
                                              A271BR_MedicalImaging_Diag_Loc ,
                                              A272BR_MedicalImaging_Diag_Organ ,
                                              A273BR_MedicalImaging_Diag_Dis ,
                                              A517BR_MedicalImaging_Diag_No } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = StringUtil.Concat( StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc), "%", "");
         lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = StringUtil.Concat( StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ), "%", "");
         lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = StringUtil.Concat( StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis), "%", "");
         /* Using cursor P002I4 */
         pr_default.execute(2, new Object[] {AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid, AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to, AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid, AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to, lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc, AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel, lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ, AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel, lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis, AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel, AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no, AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK2I6 = false;
            A273BR_MedicalImaging_Diag_Dis = P002I4_A273BR_MedicalImaging_Diag_Dis[0];
            n273BR_MedicalImaging_Diag_Dis = P002I4_n273BR_MedicalImaging_Diag_Dis[0];
            A517BR_MedicalImaging_Diag_No = P002I4_A517BR_MedicalImaging_Diag_No[0];
            n517BR_MedicalImaging_Diag_No = P002I4_n517BR_MedicalImaging_Diag_No[0];
            A272BR_MedicalImaging_Diag_Organ = P002I4_A272BR_MedicalImaging_Diag_Organ[0];
            n272BR_MedicalImaging_Diag_Organ = P002I4_n272BR_MedicalImaging_Diag_Organ[0];
            A271BR_MedicalImaging_Diag_Loc = P002I4_A271BR_MedicalImaging_Diag_Loc[0];
            n271BR_MedicalImaging_Diag_Loc = P002I4_n271BR_MedicalImaging_Diag_Loc[0];
            A225BR_MedicalImagingID = P002I4_A225BR_MedicalImagingID[0];
            n225BR_MedicalImagingID = P002I4_n225BR_MedicalImagingID[0];
            A270BR_MedicalImaging_DiagID = P002I4_A270BR_MedicalImaging_DiagID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P002I4_A273BR_MedicalImaging_Diag_Dis[0], A273BR_MedicalImaging_Diag_Dis) == 0 ) )
            {
               BRK2I6 = false;
               A270BR_MedicalImaging_DiagID = P002I4_A270BR_MedicalImaging_DiagID[0];
               AV33count = (long)(AV33count+1);
               BRK2I6 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A273BR_MedicalImaging_Diag_Dis)) )
            {
               AV25Option = A273BR_MedicalImaging_Diag_Dis;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2I6 )
            {
               BRK2I6 = true;
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
         AV26Options = new GxSimpleCollection<String>();
         AV29OptionsDesc = new GxSimpleCollection<String>();
         AV31OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV34Session = context.GetSession();
         AV36GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV37GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_MedicalImaging_Diag_Loc = "";
         AV16TFBR_MedicalImaging_Diag_Loc_Sel = "";
         AV17TFBR_MedicalImaging_Diag_Organ = "";
         AV18TFBR_MedicalImaging_Diag_Organ_Sel = "";
         AV19TFBR_MedicalImaging_Diag_Dis = "";
         AV20TFBR_MedicalImaging_Diag_Dis_Sel = "";
         AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = "";
         AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel = "";
         AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = "";
         AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel = "";
         AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = "";
         AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel = "";
         scmdbuf = "";
         lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc = "";
         lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ = "";
         lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis = "";
         A271BR_MedicalImaging_Diag_Loc = "";
         A272BR_MedicalImaging_Diag_Organ = "";
         A273BR_MedicalImaging_Diag_Dis = "";
         P002I2_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         P002I2_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         P002I2_A517BR_MedicalImaging_Diag_No = new long[1] ;
         P002I2_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         P002I2_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         P002I2_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         P002I2_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         P002I2_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         P002I2_A225BR_MedicalImagingID = new long[1] ;
         P002I2_n225BR_MedicalImagingID = new bool[] {false} ;
         P002I2_A270BR_MedicalImaging_DiagID = new long[1] ;
         AV25Option = "";
         P002I3_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         P002I3_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         P002I3_A517BR_MedicalImaging_Diag_No = new long[1] ;
         P002I3_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         P002I3_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         P002I3_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         P002I3_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         P002I3_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         P002I3_A225BR_MedicalImagingID = new long[1] ;
         P002I3_n225BR_MedicalImagingID = new bool[] {false} ;
         P002I3_A270BR_MedicalImaging_DiagID = new long[1] ;
         P002I4_A273BR_MedicalImaging_Diag_Dis = new String[] {""} ;
         P002I4_n273BR_MedicalImaging_Diag_Dis = new bool[] {false} ;
         P002I4_A517BR_MedicalImaging_Diag_No = new long[1] ;
         P002I4_n517BR_MedicalImaging_Diag_No = new bool[] {false} ;
         P002I4_A272BR_MedicalImaging_Diag_Organ = new String[] {""} ;
         P002I4_n272BR_MedicalImaging_Diag_Organ = new bool[] {false} ;
         P002I4_A271BR_MedicalImaging_Diag_Loc = new String[] {""} ;
         P002I4_n271BR_MedicalImaging_Diag_Loc = new bool[] {false} ;
         P002I4_A225BR_MedicalImagingID = new long[1] ;
         P002I4_n225BR_MedicalImagingID = new bool[] {false} ;
         P002I4_A270BR_MedicalImaging_DiagID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging_diagwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002I2_A271BR_MedicalImaging_Diag_Loc, P002I2_n271BR_MedicalImaging_Diag_Loc, P002I2_A517BR_MedicalImaging_Diag_No, P002I2_n517BR_MedicalImaging_Diag_No, P002I2_A273BR_MedicalImaging_Diag_Dis, P002I2_n273BR_MedicalImaging_Diag_Dis, P002I2_A272BR_MedicalImaging_Diag_Organ, P002I2_n272BR_MedicalImaging_Diag_Organ, P002I2_A225BR_MedicalImagingID, P002I2_n225BR_MedicalImagingID,
               P002I2_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               P002I3_A272BR_MedicalImaging_Diag_Organ, P002I3_n272BR_MedicalImaging_Diag_Organ, P002I3_A517BR_MedicalImaging_Diag_No, P002I3_n517BR_MedicalImaging_Diag_No, P002I3_A273BR_MedicalImaging_Diag_Dis, P002I3_n273BR_MedicalImaging_Diag_Dis, P002I3_A271BR_MedicalImaging_Diag_Loc, P002I3_n271BR_MedicalImaging_Diag_Loc, P002I3_A225BR_MedicalImagingID, P002I3_n225BR_MedicalImagingID,
               P002I3_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               P002I4_A273BR_MedicalImaging_Diag_Dis, P002I4_n273BR_MedicalImaging_Diag_Dis, P002I4_A517BR_MedicalImaging_Diag_No, P002I4_n517BR_MedicalImaging_Diag_No, P002I4_A272BR_MedicalImaging_Diag_Organ, P002I4_n272BR_MedicalImaging_Diag_Organ, P002I4_A271BR_MedicalImaging_Diag_Loc, P002I4_n271BR_MedicalImaging_Diag_Loc, P002I4_A225BR_MedicalImagingID, P002I4_n225BR_MedicalImagingID,
               P002I4_A270BR_MedicalImaging_DiagID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV43GXV1 ;
      private long AV11TFBR_MedicalImaging_DiagID ;
      private long AV12TFBR_MedicalImaging_DiagID_To ;
      private long AV13TFBR_MedicalImagingID ;
      private long AV14TFBR_MedicalImagingID_To ;
      private long AV39TFBR_MedicalImaging_Diag_No ;
      private long AV40TFBR_MedicalImaging_Diag_No_To ;
      private long AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ;
      private long AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ;
      private long AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ;
      private long AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ;
      private long AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ;
      private long AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ;
      private long A270BR_MedicalImaging_DiagID ;
      private long A225BR_MedicalImagingID ;
      private long A517BR_MedicalImaging_Diag_No ;
      private long AV33count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2I2 ;
      private bool n271BR_MedicalImaging_Diag_Loc ;
      private bool n517BR_MedicalImaging_Diag_No ;
      private bool n273BR_MedicalImaging_Diag_Dis ;
      private bool n272BR_MedicalImaging_Diag_Organ ;
      private bool n225BR_MedicalImagingID ;
      private bool BRK2I4 ;
      private bool BRK2I6 ;
      private String AV32OptionIndexesJson ;
      private String AV27OptionsJson ;
      private String AV30OptionsDescJson ;
      private String AV23DDOName ;
      private String AV21SearchTxt ;
      private String AV22SearchTxtTo ;
      private String AV15TFBR_MedicalImaging_Diag_Loc ;
      private String AV16TFBR_MedicalImaging_Diag_Loc_Sel ;
      private String AV17TFBR_MedicalImaging_Diag_Organ ;
      private String AV18TFBR_MedicalImaging_Diag_Organ_Sel ;
      private String AV19TFBR_MedicalImaging_Diag_Dis ;
      private String AV20TFBR_MedicalImaging_Diag_Dis_Sel ;
      private String AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ;
      private String AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ;
      private String AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ;
      private String AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ;
      private String AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ;
      private String AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ;
      private String lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ;
      private String lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ;
      private String lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ;
      private String A271BR_MedicalImaging_Diag_Loc ;
      private String A272BR_MedicalImaging_Diag_Organ ;
      private String A273BR_MedicalImaging_Diag_Dis ;
      private String AV25Option ;
      private IGxSession AV34Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002I2_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] P002I2_n271BR_MedicalImaging_Diag_Loc ;
      private long[] P002I2_A517BR_MedicalImaging_Diag_No ;
      private bool[] P002I2_n517BR_MedicalImaging_Diag_No ;
      private String[] P002I2_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] P002I2_n273BR_MedicalImaging_Diag_Dis ;
      private String[] P002I2_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] P002I2_n272BR_MedicalImaging_Diag_Organ ;
      private long[] P002I2_A225BR_MedicalImagingID ;
      private bool[] P002I2_n225BR_MedicalImagingID ;
      private long[] P002I2_A270BR_MedicalImaging_DiagID ;
      private String[] P002I3_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] P002I3_n272BR_MedicalImaging_Diag_Organ ;
      private long[] P002I3_A517BR_MedicalImaging_Diag_No ;
      private bool[] P002I3_n517BR_MedicalImaging_Diag_No ;
      private String[] P002I3_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] P002I3_n273BR_MedicalImaging_Diag_Dis ;
      private String[] P002I3_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] P002I3_n271BR_MedicalImaging_Diag_Loc ;
      private long[] P002I3_A225BR_MedicalImagingID ;
      private bool[] P002I3_n225BR_MedicalImagingID ;
      private long[] P002I3_A270BR_MedicalImaging_DiagID ;
      private String[] P002I4_A273BR_MedicalImaging_Diag_Dis ;
      private bool[] P002I4_n273BR_MedicalImaging_Diag_Dis ;
      private long[] P002I4_A517BR_MedicalImaging_Diag_No ;
      private bool[] P002I4_n517BR_MedicalImaging_Diag_No ;
      private String[] P002I4_A272BR_MedicalImaging_Diag_Organ ;
      private bool[] P002I4_n272BR_MedicalImaging_Diag_Organ ;
      private String[] P002I4_A271BR_MedicalImaging_Diag_Loc ;
      private bool[] P002I4_n271BR_MedicalImaging_Diag_Loc ;
      private long[] P002I4_A225BR_MedicalImagingID ;
      private bool[] P002I4_n225BR_MedicalImagingID ;
      private long[] P002I4_A270BR_MedicalImaging_DiagID ;
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

   public class br_medicalimaging_diagwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002I2( IGxContext context ,
                                             long AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                             long AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                             long AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                             long AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                             String AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                             String AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                             String AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                             String AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                             String AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                             String AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                             long AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                             long AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                             long A270BR_MedicalImaging_DiagID ,
                                             long A225BR_MedicalImagingID ,
                                             String A271BR_MedicalImaging_Diag_Loc ,
                                             String A272BR_MedicalImaging_Diag_Organ ,
                                             String A273BR_MedicalImaging_Diag_Dis ,
                                             long A517BR_MedicalImaging_Diag_No )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [12] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_MedicalImaging_Diag_Loc], [BR_MedicalImaging_Diag_No], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImagingID], [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         if ( ! (0==AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( ! (0==AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! (0==AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_MedicalImaging_Diag_Loc]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002I3( IGxContext context ,
                                             long AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                             long AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                             long AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                             long AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                             String AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                             String AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                             String AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                             String AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                             String AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                             String AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                             long AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                             long AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                             long A270BR_MedicalImaging_DiagID ,
                                             long A225BR_MedicalImagingID ,
                                             String A271BR_MedicalImaging_Diag_Loc ,
                                             String A272BR_MedicalImaging_Diag_Organ ,
                                             String A273BR_MedicalImaging_Diag_Dis ,
                                             long A517BR_MedicalImaging_Diag_No )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_No], [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImagingID], [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         if ( ! (0==AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( ! (0==AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! (0==AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_MedicalImaging_Diag_Organ]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P002I4( IGxContext context ,
                                             long AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid ,
                                             long AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to ,
                                             long AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid ,
                                             long AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to ,
                                             String AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel ,
                                             String AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc ,
                                             String AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel ,
                                             String AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ ,
                                             String AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel ,
                                             String AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis ,
                                             long AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no ,
                                             long AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to ,
                                             long A270BR_MedicalImaging_DiagID ,
                                             long A225BR_MedicalImagingID ,
                                             String A271BR_MedicalImaging_Diag_Loc ,
                                             String A272BR_MedicalImaging_Diag_Organ ,
                                             String A273BR_MedicalImaging_Diag_Dis ,
                                             long A517BR_MedicalImaging_Diag_No )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [12] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [BR_MedicalImaging_Diag_Dis], [BR_MedicalImaging_Diag_No], [BR_MedicalImaging_Diag_Organ], [BR_MedicalImaging_Diag_Loc], [BR_MedicalImagingID], [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK)";
         if ( ! (0==AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] >= @AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_DiagID] <= @AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (0==AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] >= @AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (0==AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImagingID] <= @AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] like @lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Loc] = @AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] like @lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Organ] = @AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] like @lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_Dis] = @AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( ! (0==AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] >= @AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! (0==AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_MedicalImaging_Diag_No] <= @AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_MedicalImaging_Diag_Dis]";
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
                     return conditional_P002I2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (long)dynConstraints[17] );
               case 1 :
                     return conditional_P002I3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (long)dynConstraints[17] );
               case 2 :
                     return conditional_P002I4(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (long)dynConstraints[17] );
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
          Object[] prmP002I2 ;
          prmP002I2 = new Object[] {
          new Object[] {"@AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002I3 ;
          prmP002I3 = new Object[] {
          new Object[] {"@AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to",SqlDbType.Decimal,18,0}
          } ;
          Object[] prmP002I4 ;
          prmP002I4 = new Object[] {
          new Object[] {"@AV45BR_MedicalImaging_DiagWWDS_1_Tfbr_medicalimaging_diagid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_MedicalImaging_DiagWWDS_2_Tfbr_medicalimaging_diagid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV47BR_MedicalImaging_DiagWWDS_3_Tfbr_medicalimagingid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48BR_MedicalImaging_DiagWWDS_4_Tfbr_medicalimagingid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV49BR_MedicalImaging_DiagWWDS_5_Tfbr_medicalimaging_diag_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50BR_MedicalImaging_DiagWWDS_6_Tfbr_medicalimaging_diag_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51BR_MedicalImaging_DiagWWDS_7_Tfbr_medicalimaging_diag_organ",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV52BR_MedicalImaging_DiagWWDS_8_Tfbr_medicalimaging_diag_organ_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV53BR_MedicalImaging_DiagWWDS_9_Tfbr_medicalimaging_diag_dis",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV54BR_MedicalImaging_DiagWWDS_10_Tfbr_medicalimaging_diag_dis_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV55BR_MedicalImaging_DiagWWDS_11_Tfbr_medicalimaging_diag_no",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56BR_MedicalImaging_DiagWWDS_12_Tfbr_medicalimaging_diag_no_to",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002I2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002I2,100,0,true,false )
             ,new CursorDef("P002I3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002I3,100,0,true,false )
             ,new CursorDef("P002I4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002I4,100,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
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
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
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
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
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
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
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
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
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
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_medicalimaging_diagwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_medicalimaging_diagwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_medicalimaging_diagwwgetfilterdata") )
          {
             return  ;
          }
          br_medicalimaging_diagwwgetfilterdata worker = new br_medicalimaging_diagwwgetfilterdata(context) ;
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
