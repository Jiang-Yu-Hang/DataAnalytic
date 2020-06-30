/*
               File: BR_Procedure_RadioWWGetFilterData
        Description: BR_Procedure_Radio WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:3.83
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
   public class br_procedure_radiowwgetfilterdata : GXProcedure
   {
      public br_procedure_radiowwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_radiowwgetfilterdata( IGxContext context )
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
         br_procedure_radiowwgetfilterdata objbr_procedure_radiowwgetfilterdata;
         objbr_procedure_radiowwgetfilterdata = new br_procedure_radiowwgetfilterdata();
         objbr_procedure_radiowwgetfilterdata.AV21DDOName = aP0_DDOName;
         objbr_procedure_radiowwgetfilterdata.AV19SearchTxt = aP1_SearchTxt;
         objbr_procedure_radiowwgetfilterdata.AV20SearchTxtTo = aP2_SearchTxtTo;
         objbr_procedure_radiowwgetfilterdata.AV25OptionsJson = "" ;
         objbr_procedure_radiowwgetfilterdata.AV28OptionsDescJson = "" ;
         objbr_procedure_radiowwgetfilterdata.AV30OptionIndexesJson = "" ;
         objbr_procedure_radiowwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_procedure_radiowwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_procedure_radiowwgetfilterdata);
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_procedure_radiowwgetfilterdata)stateInfo).executePrivate();
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
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Radio", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_PROCEDURE_RADIO_LOC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PROCEDURE_RADIO_LOCOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_PROCEDURE_RADIO_AMOUNT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PROCEDURE_RADIO_AMOUNTOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
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
         if ( StringUtil.StrCmp(AV32Session.Get("BR_Procedure_RadioWWGridState"), "") == 0 )
         {
            AV34GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Procedure_RadioWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV34GridState.FromXml(AV32Session.Get("BR_Procedure_RadioWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV40GXV1 = 1;
         while ( AV40GXV1 <= AV34GridState.gxTpr_Filtervalues.Count )
         {
            AV35GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV34GridState.gxTpr_Filtervalues.Item(AV40GXV1));
            if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIOID") == 0 )
            {
               AV11TFBR_Procedure_RadioID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Procedure_RadioID_To = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDUREID") == 0 )
            {
               AV13TFBR_ProcedureID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_ProcedureID_To = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_LOC") == 0 )
            {
               AV15TFBR_Procedure_Radio_Loc = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_LOC_SEL") == 0 )
            {
               AV16TFBR_Procedure_Radio_Loc_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_AMOUNT") == 0 )
            {
               AV17TFBR_Procedure_Radio_Amount = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIO_AMOUNT_SEL") == 0 )
            {
               AV37TFBR_Procedure_Radio_Amount_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            AV40GXV1 = (int)(AV40GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_PROCEDURE_RADIO_LOCOPTIONS' Routine */
         AV15TFBR_Procedure_Radio_Loc = AV19SearchTxt;
         AV16TFBR_Procedure_Radio_Loc_Sel = "";
         AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV11TFBR_Procedure_RadioID;
         AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV12TFBR_Procedure_RadioID_To;
         AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV13TFBR_ProcedureID;
         AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV14TFBR_ProcedureID_To;
         AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV15TFBR_Procedure_Radio_Loc;
         AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV16TFBR_Procedure_Radio_Loc_Sel;
         AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV17TFBR_Procedure_Radio_Amount;
         AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV37TFBR_Procedure_Radio_Amount_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                              AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                              AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                              AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                              AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                              AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                              AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                              AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                              A323BR_Procedure_RadioID ,
                                              A139BR_ProcedureID ,
                                              A324BR_Procedure_Radio_Loc ,
                                              A325BR_Procedure_Radio_Amount } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = StringUtil.Concat( StringUtil.RTrim( AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc), "%", "");
         lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = StringUtil.Concat( StringUtil.RTrim( AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount), "%", "");
         /* Using cursor P002Y2 */
         pr_default.execute(0, new Object[] {AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid, AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to, AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid, AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to, lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc, AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel, lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount, AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2Y2 = false;
            A324BR_Procedure_Radio_Loc = P002Y2_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = P002Y2_n324BR_Procedure_Radio_Loc[0];
            A325BR_Procedure_Radio_Amount = P002Y2_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = P002Y2_n325BR_Procedure_Radio_Amount[0];
            A139BR_ProcedureID = P002Y2_A139BR_ProcedureID[0];
            A323BR_Procedure_RadioID = P002Y2_A323BR_Procedure_RadioID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002Y2_A324BR_Procedure_Radio_Loc[0], A324BR_Procedure_Radio_Loc) == 0 ) )
            {
               BRK2Y2 = false;
               A323BR_Procedure_RadioID = P002Y2_A323BR_Procedure_RadioID[0];
               AV31count = (long)(AV31count+1);
               BRK2Y2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A324BR_Procedure_Radio_Loc)) )
            {
               AV23Option = A324BR_Procedure_Radio_Loc;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2Y2 )
            {
               BRK2Y2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_PROCEDURE_RADIO_AMOUNTOPTIONS' Routine */
         AV17TFBR_Procedure_Radio_Amount = AV19SearchTxt;
         AV37TFBR_Procedure_Radio_Amount_Sel = "";
         AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid = AV11TFBR_Procedure_RadioID;
         AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to = AV12TFBR_Procedure_RadioID_To;
         AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid = AV13TFBR_ProcedureID;
         AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to = AV14TFBR_ProcedureID_To;
         AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = AV15TFBR_Procedure_Radio_Loc;
         AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = AV16TFBR_Procedure_Radio_Loc_Sel;
         AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = AV17TFBR_Procedure_Radio_Amount;
         AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = AV37TFBR_Procedure_Radio_Amount_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                              AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                              AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                              AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                              AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                              AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                              AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                              AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                              A323BR_Procedure_RadioID ,
                                              A139BR_ProcedureID ,
                                              A324BR_Procedure_Radio_Loc ,
                                              A325BR_Procedure_Radio_Amount } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = StringUtil.Concat( StringUtil.RTrim( AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc), "%", "");
         lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = StringUtil.Concat( StringUtil.RTrim( AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount), "%", "");
         /* Using cursor P002Y3 */
         pr_default.execute(1, new Object[] {AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid, AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to, AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid, AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to, lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc, AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel, lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount, AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2Y4 = false;
            A325BR_Procedure_Radio_Amount = P002Y3_A325BR_Procedure_Radio_Amount[0];
            n325BR_Procedure_Radio_Amount = P002Y3_n325BR_Procedure_Radio_Amount[0];
            A324BR_Procedure_Radio_Loc = P002Y3_A324BR_Procedure_Radio_Loc[0];
            n324BR_Procedure_Radio_Loc = P002Y3_n324BR_Procedure_Radio_Loc[0];
            A139BR_ProcedureID = P002Y3_A139BR_ProcedureID[0];
            A323BR_Procedure_RadioID = P002Y3_A323BR_Procedure_RadioID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002Y3_A325BR_Procedure_Radio_Amount[0], A325BR_Procedure_Radio_Amount) == 0 ) )
            {
               BRK2Y4 = false;
               A323BR_Procedure_RadioID = P002Y3_A323BR_Procedure_RadioID[0];
               AV31count = (long)(AV31count+1);
               BRK2Y4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A325BR_Procedure_Radio_Amount)) )
            {
               AV23Option = A325BR_Procedure_Radio_Amount;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2Y4 )
            {
               BRK2Y4 = true;
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
         AV24Options = new GxSimpleCollection<String>();
         AV27OptionsDesc = new GxSimpleCollection<String>();
         AV29OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV32Session = context.GetSession();
         AV34GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV35GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Procedure_Radio_Loc = "";
         AV16TFBR_Procedure_Radio_Loc_Sel = "";
         AV17TFBR_Procedure_Radio_Amount = "";
         AV37TFBR_Procedure_Radio_Amount_Sel = "";
         AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = "";
         AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel = "";
         AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = "";
         AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel = "";
         scmdbuf = "";
         lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc = "";
         lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount = "";
         A324BR_Procedure_Radio_Loc = "";
         A325BR_Procedure_Radio_Amount = "";
         P002Y2_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         P002Y2_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         P002Y2_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         P002Y2_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         P002Y2_A139BR_ProcedureID = new long[1] ;
         P002Y2_A323BR_Procedure_RadioID = new long[1] ;
         AV23Option = "";
         P002Y3_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         P002Y3_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         P002Y3_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         P002Y3_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         P002Y3_A139BR_ProcedureID = new long[1] ;
         P002Y3_A323BR_Procedure_RadioID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_radiowwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002Y2_A324BR_Procedure_Radio_Loc, P002Y2_n324BR_Procedure_Radio_Loc, P002Y2_A325BR_Procedure_Radio_Amount, P002Y2_n325BR_Procedure_Radio_Amount, P002Y2_A139BR_ProcedureID, P002Y2_A323BR_Procedure_RadioID
               }
               , new Object[] {
               P002Y3_A325BR_Procedure_Radio_Amount, P002Y3_n325BR_Procedure_Radio_Amount, P002Y3_A324BR_Procedure_Radio_Loc, P002Y3_n324BR_Procedure_Radio_Loc, P002Y3_A139BR_ProcedureID, P002Y3_A323BR_Procedure_RadioID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV40GXV1 ;
      private long AV11TFBR_Procedure_RadioID ;
      private long AV12TFBR_Procedure_RadioID_To ;
      private long AV13TFBR_ProcedureID ;
      private long AV14TFBR_ProcedureID_To ;
      private long AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ;
      private long AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ;
      private long AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid ;
      private long AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ;
      private long A323BR_Procedure_RadioID ;
      private long A139BR_ProcedureID ;
      private long AV31count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2Y2 ;
      private bool n324BR_Procedure_Radio_Loc ;
      private bool n325BR_Procedure_Radio_Amount ;
      private bool BRK2Y4 ;
      private String AV30OptionIndexesJson ;
      private String AV25OptionsJson ;
      private String AV28OptionsDescJson ;
      private String AV21DDOName ;
      private String AV19SearchTxt ;
      private String AV20SearchTxtTo ;
      private String AV15TFBR_Procedure_Radio_Loc ;
      private String AV16TFBR_Procedure_Radio_Loc_Sel ;
      private String AV17TFBR_Procedure_Radio_Amount ;
      private String AV37TFBR_Procedure_Radio_Amount_Sel ;
      private String AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ;
      private String AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ;
      private String AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ;
      private String AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ;
      private String lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ;
      private String lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ;
      private String A324BR_Procedure_Radio_Loc ;
      private String A325BR_Procedure_Radio_Amount ;
      private String AV23Option ;
      private IGxSession AV32Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002Y2_A324BR_Procedure_Radio_Loc ;
      private bool[] P002Y2_n324BR_Procedure_Radio_Loc ;
      private String[] P002Y2_A325BR_Procedure_Radio_Amount ;
      private bool[] P002Y2_n325BR_Procedure_Radio_Amount ;
      private long[] P002Y2_A139BR_ProcedureID ;
      private long[] P002Y2_A323BR_Procedure_RadioID ;
      private String[] P002Y3_A325BR_Procedure_Radio_Amount ;
      private bool[] P002Y3_n325BR_Procedure_Radio_Amount ;
      private String[] P002Y3_A324BR_Procedure_Radio_Loc ;
      private bool[] P002Y3_n324BR_Procedure_Radio_Loc ;
      private long[] P002Y3_A139BR_ProcedureID ;
      private long[] P002Y3_A323BR_Procedure_RadioID ;
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

   public class br_procedure_radiowwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002Y2( IGxContext context ,
                                             long AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                             long AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                             long AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                             long AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                             String AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                             String AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                             String AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                             String AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                             long A323BR_Procedure_RadioID ,
                                             long A139BR_ProcedureID ,
                                             String A324BR_Procedure_Radio_Loc ,
                                             String A325BR_Procedure_Radio_Amount )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [8] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Procedure_Radio_Loc], [BR_Procedure_Radio_Amount], [BR_ProcedureID], [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (NOLOCK)";
         if ( ! (0==AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] >= @AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] >= @AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] <= @AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] <= @AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] like @lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] like @lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] = @AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] = @AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] like @lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] like @lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] = @AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] = @AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Procedure_Radio_Loc]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002Y3( IGxContext context ,
                                             long AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid ,
                                             long AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to ,
                                             long AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid ,
                                             long AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to ,
                                             String AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel ,
                                             String AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc ,
                                             String AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel ,
                                             String AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount ,
                                             long A323BR_Procedure_RadioID ,
                                             long A139BR_ProcedureID ,
                                             String A324BR_Procedure_Radio_Loc ,
                                             String A325BR_Procedure_Radio_Amount )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [8] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Procedure_Radio_Amount], [BR_Procedure_Radio_Loc], [BR_ProcedureID], [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (NOLOCK)";
         if ( ! (0==AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] >= @AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] >= @AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_RadioID] <= @AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_RadioID] <= @AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] like @lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] like @lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Loc] = @AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Loc] = @AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] like @lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] like @lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Radio_Amount] = @AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Radio_Amount] = @AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Procedure_Radio_Amount]";
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
                     return conditional_P002Y2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
               case 1 :
                     return conditional_P002Y3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
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
          Object[] prmP002Y2 ;
          prmP002Y2 = new Object[] {
          new Object[] {"@AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP002Y3 ;
          prmP002Y3 = new Object[] {
          new Object[] {"@AV42BR_Procedure_RadioWWDS_1_Tfbr_procedure_radioid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV43BR_Procedure_RadioWWDS_2_Tfbr_procedure_radioid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Procedure_RadioWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV45BR_Procedure_RadioWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV46BR_Procedure_RadioWWDS_5_Tfbr_procedure_radio_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV47BR_Procedure_RadioWWDS_6_Tfbr_procedure_radio_loc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV48BR_Procedure_RadioWWDS_7_Tfbr_procedure_radio_amount",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49BR_Procedure_RadioWWDS_8_Tfbr_procedure_radio_amount_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002Y2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002Y2,100,0,true,false )
             ,new CursorDef("P002Y3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002Y3,100,0,true,false )
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
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                return;
             case 1 :
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_procedure_radiowwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_procedure_radiowwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_procedure_radiowwgetfilterdata") )
          {
             return  ;
          }
          br_procedure_radiowwgetfilterdata worker = new br_procedure_radiowwgetfilterdata(context) ;
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
