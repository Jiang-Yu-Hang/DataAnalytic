/*
               File: BR_Encounter_RefuseReasonWWGetFilterData
        Description: BR_Encounter_Refuse Reason WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:38.58
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
   public class br_encounter_refusereasonwwgetfilterdata : GXProcedure
   {
      public br_encounter_refusereasonwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_refusereasonwwgetfilterdata( IGxContext context )
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
         br_encounter_refusereasonwwgetfilterdata objbr_encounter_refusereasonwwgetfilterdata;
         objbr_encounter_refusereasonwwgetfilterdata = new br_encounter_refusereasonwwgetfilterdata();
         objbr_encounter_refusereasonwwgetfilterdata.AV23DDOName = aP0_DDOName;
         objbr_encounter_refusereasonwwgetfilterdata.AV21SearchTxt = aP1_SearchTxt;
         objbr_encounter_refusereasonwwgetfilterdata.AV22SearchTxtTo = aP2_SearchTxtTo;
         objbr_encounter_refusereasonwwgetfilterdata.AV27OptionsJson = "" ;
         objbr_encounter_refusereasonwwgetfilterdata.AV30OptionsDescJson = "" ;
         objbr_encounter_refusereasonwwgetfilterdata.AV32OptionIndexesJson = "" ;
         objbr_encounter_refusereasonwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encounter_refusereasonwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encounter_refusereasonwwgetfilterdata);
         aP3_OptionsJson=this.AV27OptionsJson;
         aP4_OptionsDescJson=this.AV30OptionsDescJson;
         aP5_OptionIndexesJson=this.AV32OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encounter_refusereasonwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV23DDOName), "DDO_BR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTER_REFUSEREASON_REASONOPTIONS' */
               S121 ();
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
         if ( StringUtil.StrCmp(AV34Session.Get("BR_Encounter_RefuseReasonWWGridState"), "") == 0 )
         {
            AV36GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Encounter_RefuseReasonWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV36GridState.FromXml(AV34Session.Get("BR_Encounter_RefuseReasonWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV41GXV1 = 1;
         while ( AV41GXV1 <= AV36GridState.gxTpr_Filtervalues.Count )
         {
            AV37GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV36GridState.gxTpr_Filtervalues.Item(AV41GXV1));
            if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASONID") == 0 )
            {
               AV11TFBR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Encounter_RefuseReasonID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV13TFBR_EncounterID = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_EncounterID_To = (long)(NumberUtil.Val( AV37GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               AV15TFBR_Encounter_RefuseReason_Reason = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL") == 0 )
            {
               AV16TFBR_Encounter_RefuseReason_Reason_Sel = AV37GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE") == 0 )
            {
               AV17TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( AV37GridStateFilterValue.gxTpr_Value, 0);
               AV18TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( AV37GridStateFilterValue.gxTpr_Valueto, 0);
            }
            else if ( StringUtil.StrCmp(AV37GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_STATUS_SEL") == 0 )
            {
               AV19TFBR_Encounter_RefuseReason_Status_SelsJson = AV37GridStateFilterValue.gxTpr_Value;
               AV20TFBR_Encounter_RefuseReason_Status_Sels.FromJSonString(AV19TFBR_Encounter_RefuseReason_Status_SelsJson, null);
            }
            AV41GXV1 = (int)(AV41GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_ENCOUNTER_REFUSEREASON_REASONOPTIONS' Routine */
         AV15TFBR_Encounter_RefuseReason_Reason = AV21SearchTxt;
         AV16TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV11TFBR_Encounter_RefuseReasonID;
         AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV12TFBR_Encounter_RefuseReasonID_To;
         AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV13TFBR_EncounterID;
         AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV14TFBR_EncounterID_To;
         AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV15TFBR_Encounter_RefuseReason_Reason;
         AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV16TFBR_Encounter_RefuseReason_Reason_Sel;
         AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV17TFBR_Encounter_RefuseReason_NoApproveDate;
         AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV18TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV20TFBR_Encounter_RefuseReason_Status_Sels;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A351BR_Encounter_RefuseReason_Status ,
                                              AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                              AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                              AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                              AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                              AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                              AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                              AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                              AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                              AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                              AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels.Count ,
                                              A348BR_Encounter_RefuseReasonID ,
                                              A19BR_EncounterID ,
                                              A349BR_Encounter_RefuseReason_Reason ,
                                              A350BR_Encounter_RefuseReason_NoApproveDate } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.INT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason), "%", "");
         /* Using cursor P003A2 */
         pr_default.execute(0, new Object[] {AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid, AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to, AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid, AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to, lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason, AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel, AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate, AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK3A2 = false;
            A349BR_Encounter_RefuseReason_Reason = P003A2_A349BR_Encounter_RefuseReason_Reason[0];
            n349BR_Encounter_RefuseReason_Reason = P003A2_n349BR_Encounter_RefuseReason_Reason[0];
            A351BR_Encounter_RefuseReason_Status = P003A2_A351BR_Encounter_RefuseReason_Status[0];
            n351BR_Encounter_RefuseReason_Status = P003A2_n351BR_Encounter_RefuseReason_Status[0];
            A350BR_Encounter_RefuseReason_NoApproveDate = P003A2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
            n350BR_Encounter_RefuseReason_NoApproveDate = P003A2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
            A19BR_EncounterID = P003A2_A19BR_EncounterID[0];
            A348BR_Encounter_RefuseReasonID = P003A2_A348BR_Encounter_RefuseReasonID[0];
            AV33count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P003A2_A349BR_Encounter_RefuseReason_Reason[0], A349BR_Encounter_RefuseReason_Reason) == 0 ) )
            {
               BRK3A2 = false;
               A348BR_Encounter_RefuseReasonID = P003A2_A348BR_Encounter_RefuseReasonID[0];
               AV33count = (long)(AV33count+1);
               BRK3A2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A349BR_Encounter_RefuseReason_Reason)) )
            {
               AV25Option = A349BR_Encounter_RefuseReason_Reason;
               AV26Options.Add(AV25Option, 0);
               AV31OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV33count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV26Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK3A2 )
            {
               BRK3A2 = true;
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
         AV26Options = new GxSimpleCollection<String>();
         AV29OptionsDesc = new GxSimpleCollection<String>();
         AV31OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV34Session = context.GetSession();
         AV36GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV37GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Encounter_RefuseReason_Reason = "";
         AV16TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV17TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         AV18TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
         AV19TFBR_Encounter_RefuseReason_Status_SelsJson = "";
         AV20TFBR_Encounter_RefuseReason_Status_Sels = new GxSimpleCollection<short>();
         AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = "";
         AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = "";
         AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = (DateTime)(DateTime.MinValue);
         AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         P003A2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         P003A2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         P003A2_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         P003A2_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         P003A2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         P003A2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         P003A2_A19BR_EncounterID = new long[1] ;
         P003A2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         AV25Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereasonwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P003A2_A349BR_Encounter_RefuseReason_Reason, P003A2_n349BR_Encounter_RefuseReason_Reason, P003A2_A351BR_Encounter_RefuseReason_Status, P003A2_n351BR_Encounter_RefuseReason_Status, P003A2_A350BR_Encounter_RefuseReason_NoApproveDate, P003A2_n350BR_Encounter_RefuseReason_NoApproveDate, P003A2_A19BR_EncounterID, P003A2_A348BR_Encounter_RefuseReasonID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A351BR_Encounter_RefuseReason_Status ;
      private int AV41GXV1 ;
      private int AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count ;
      private long AV11TFBR_Encounter_RefuseReasonID ;
      private long AV12TFBR_Encounter_RefuseReasonID_To ;
      private long AV13TFBR_EncounterID ;
      private long AV14TFBR_EncounterID_To ;
      private long AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ;
      private long AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ;
      private long AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ;
      private long AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long A19BR_EncounterID ;
      private long AV33count ;
      private String scmdbuf ;
      private DateTime AV17TFBR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime AV18TFBR_Encounter_RefuseReason_NoApproveDate_To ;
      private DateTime AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ;
      private DateTime AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK3A2 ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String AV32OptionIndexesJson ;
      private String AV27OptionsJson ;
      private String AV30OptionsDescJson ;
      private String AV19TFBR_Encounter_RefuseReason_Status_SelsJson ;
      private String AV23DDOName ;
      private String AV21SearchTxt ;
      private String AV22SearchTxtTo ;
      private String AV15TFBR_Encounter_RefuseReason_Reason ;
      private String AV16TFBR_Encounter_RefuseReason_Reason_Sel ;
      private String AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ;
      private String AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ;
      private String lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String AV25Option ;
      private GxSimpleCollection<short> AV20TFBR_Encounter_RefuseReason_Status_Sels ;
      private GxSimpleCollection<short> AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ;
      private IGxSession AV34Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P003A2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] P003A2_n349BR_Encounter_RefuseReason_Reason ;
      private short[] P003A2_A351BR_Encounter_RefuseReason_Status ;
      private bool[] P003A2_n351BR_Encounter_RefuseReason_Status ;
      private DateTime[] P003A2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] P003A2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private long[] P003A2_A19BR_EncounterID ;
      private long[] P003A2_A348BR_Encounter_RefuseReasonID ;
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

   public class br_encounter_refusereasonwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P003A2( IGxContext context ,
                                             short A351BR_Encounter_RefuseReason_Status ,
                                             GxSimpleCollection<short> AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                             long AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                             long AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                             long AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                             long AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                             String AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             int AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count ,
                                             long A348BR_Encounter_RefuseReasonID ,
                                             long A19BR_EncounterID ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [8] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Encounter_RefuseReason_Reason], [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_NoApproveDate], [BR_EncounterID], [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         if ( ! (0==AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] >= @AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] >= @AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] <= @AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] <= @AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] like @lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] like @lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] = @AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] = @AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV51BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Encounter_RefuseReason_Reason]";
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
                     return conditional_P003A2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (int)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (DateTime)dynConstraints[14] );
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
          Object[] prmP003A2 ;
          prmP003A2 = new Object[] {
          new Object[] {"@AV43BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV45BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV48BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV49BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV50BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003A2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003A2,100,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_encounter_refusereasonwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encounter_refusereasonwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encounter_refusereasonwwgetfilterdata") )
          {
             return  ;
          }
          br_encounter_refusereasonwwgetfilterdata worker = new br_encounter_refusereasonwwgetfilterdata(context) ;
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
