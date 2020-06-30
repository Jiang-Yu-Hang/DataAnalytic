/*
               File: BR_Procedure_SurgeryWWGetFilterData
        Description: BR_Procedure_Surgery WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:33.54
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
   public class br_procedure_surgerywwgetfilterdata : GXProcedure
   {
      public br_procedure_surgerywwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_surgerywwgetfilterdata( IGxContext context )
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
         br_procedure_surgerywwgetfilterdata objbr_procedure_surgerywwgetfilterdata;
         objbr_procedure_surgerywwgetfilterdata = new br_procedure_surgerywwgetfilterdata();
         objbr_procedure_surgerywwgetfilterdata.AV21DDOName = aP0_DDOName;
         objbr_procedure_surgerywwgetfilterdata.AV19SearchTxt = aP1_SearchTxt;
         objbr_procedure_surgerywwgetfilterdata.AV20SearchTxtTo = aP2_SearchTxtTo;
         objbr_procedure_surgerywwgetfilterdata.AV25OptionsJson = "" ;
         objbr_procedure_surgerywwgetfilterdata.AV28OptionsDescJson = "" ;
         objbr_procedure_surgerywwgetfilterdata.AV30OptionIndexesJson = "" ;
         objbr_procedure_surgerywwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_procedure_surgerywwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_procedure_surgerywwgetfilterdata);
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_procedure_surgerywwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Surgery", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_PROCEDURE_SURGERY_NAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PROCEDURE_SURGERY_NAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_PROCEDURE_SURGERY_LOC") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PROCEDURE_SURGERY_LOCOPTIONS' */
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
         if ( StringUtil.StrCmp(AV32Session.Get("BR_Procedure_SurgeryWWGridState"), "") == 0 )
         {
            AV34GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Procedure_SurgeryWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV34GridState.FromXml(AV32Session.Get("BR_Procedure_SurgeryWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV39GXV1 = 1;
         while ( AV39GXV1 <= AV34GridState.gxTpr_Filtervalues.Count )
         {
            AV35GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV34GridState.gxTpr_Filtervalues.Item(AV39GXV1));
            if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERYID") == 0 )
            {
               AV11TFBR_Procedure_SurgeryID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Procedure_SurgeryID_To = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDUREID") == 0 )
            {
               AV13TFBR_ProcedureID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_ProcedureID_To = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_NAME") == 0 )
            {
               AV15TFBR_Procedure_Surgery_Name = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_NAME_SEL") == 0 )
            {
               AV16TFBR_Procedure_Surgery_Name_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_LOC") == 0 )
            {
               AV17TFBR_Procedure_Surgery_Loc = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_SURGERY_LOC_SEL") == 0 )
            {
               AV18TFBR_Procedure_Surgery_Loc_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            AV39GXV1 = (int)(AV39GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_PROCEDURE_SURGERY_NAMEOPTIONS' Routine */
         AV15TFBR_Procedure_Surgery_Name = AV19SearchTxt;
         AV16TFBR_Procedure_Surgery_Name_Sel = "";
         AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV11TFBR_Procedure_SurgeryID;
         AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV12TFBR_Procedure_SurgeryID_To;
         AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV13TFBR_ProcedureID;
         AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV14TFBR_ProcedureID_To;
         AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV15TFBR_Procedure_Surgery_Name;
         AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV16TFBR_Procedure_Surgery_Name_Sel;
         AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV17TFBR_Procedure_Surgery_Loc;
         AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV18TFBR_Procedure_Surgery_Loc_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                              AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                              AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                              AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                              AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                              AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                              AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                              AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                              A320BR_Procedure_SurgeryID ,
                                              A139BR_ProcedureID ,
                                              A321BR_Procedure_Surgery_Name ,
                                              A322BR_Procedure_Surgery_Loc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = StringUtil.Concat( StringUtil.RTrim( AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name), "%", "");
         lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = StringUtil.Concat( StringUtil.RTrim( AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc), "%", "");
         /* Using cursor P002X2 */
         pr_default.execute(0, new Object[] {AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid, AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to, AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid, AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to, lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name, AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel, lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc, AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2X2 = false;
            A321BR_Procedure_Surgery_Name = P002X2_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = P002X2_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = P002X2_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = P002X2_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = P002X2_A139BR_ProcedureID[0];
            A320BR_Procedure_SurgeryID = P002X2_A320BR_Procedure_SurgeryID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002X2_A321BR_Procedure_Surgery_Name[0], A321BR_Procedure_Surgery_Name) == 0 ) )
            {
               BRK2X2 = false;
               A320BR_Procedure_SurgeryID = P002X2_A320BR_Procedure_SurgeryID[0];
               AV31count = (long)(AV31count+1);
               BRK2X2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) )
            {
               AV23Option = A321BR_Procedure_Surgery_Name;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2X2 )
            {
               BRK2X2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_PROCEDURE_SURGERY_LOCOPTIONS' Routine */
         AV17TFBR_Procedure_Surgery_Loc = AV19SearchTxt;
         AV18TFBR_Procedure_Surgery_Loc_Sel = "";
         AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid = AV11TFBR_Procedure_SurgeryID;
         AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to = AV12TFBR_Procedure_SurgeryID_To;
         AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid = AV13TFBR_ProcedureID;
         AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to = AV14TFBR_ProcedureID_To;
         AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = AV15TFBR_Procedure_Surgery_Name;
         AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = AV16TFBR_Procedure_Surgery_Name_Sel;
         AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = AV17TFBR_Procedure_Surgery_Loc;
         AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = AV18TFBR_Procedure_Surgery_Loc_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                              AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                              AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                              AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                              AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                              AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                              AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                              AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                              A320BR_Procedure_SurgeryID ,
                                              A139BR_ProcedureID ,
                                              A321BR_Procedure_Surgery_Name ,
                                              A322BR_Procedure_Surgery_Loc } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = StringUtil.Concat( StringUtil.RTrim( AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name), "%", "");
         lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = StringUtil.Concat( StringUtil.RTrim( AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc), "%", "");
         /* Using cursor P002X3 */
         pr_default.execute(1, new Object[] {AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid, AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to, AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid, AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to, lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name, AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel, lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc, AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK2X4 = false;
            A322BR_Procedure_Surgery_Loc = P002X3_A322BR_Procedure_Surgery_Loc[0];
            n322BR_Procedure_Surgery_Loc = P002X3_n322BR_Procedure_Surgery_Loc[0];
            A321BR_Procedure_Surgery_Name = P002X3_A321BR_Procedure_Surgery_Name[0];
            n321BR_Procedure_Surgery_Name = P002X3_n321BR_Procedure_Surgery_Name[0];
            A139BR_ProcedureID = P002X3_A139BR_ProcedureID[0];
            A320BR_Procedure_SurgeryID = P002X3_A320BR_Procedure_SurgeryID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P002X3_A322BR_Procedure_Surgery_Loc[0], A322BR_Procedure_Surgery_Loc) == 0 ) )
            {
               BRK2X4 = false;
               A320BR_Procedure_SurgeryID = P002X3_A320BR_Procedure_SurgeryID[0];
               AV31count = (long)(AV31count+1);
               BRK2X4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A322BR_Procedure_Surgery_Loc)) )
            {
               AV23Option = A322BR_Procedure_Surgery_Loc;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2X4 )
            {
               BRK2X4 = true;
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
         AV15TFBR_Procedure_Surgery_Name = "";
         AV16TFBR_Procedure_Surgery_Name_Sel = "";
         AV17TFBR_Procedure_Surgery_Loc = "";
         AV18TFBR_Procedure_Surgery_Loc_Sel = "";
         AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = "";
         AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel = "";
         AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = "";
         AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel = "";
         scmdbuf = "";
         lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name = "";
         lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc = "";
         A321BR_Procedure_Surgery_Name = "";
         A322BR_Procedure_Surgery_Loc = "";
         P002X2_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         P002X2_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         P002X2_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         P002X2_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         P002X2_A139BR_ProcedureID = new long[1] ;
         P002X2_A320BR_Procedure_SurgeryID = new long[1] ;
         AV23Option = "";
         P002X3_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         P002X3_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         P002X3_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         P002X3_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         P002X3_A139BR_ProcedureID = new long[1] ;
         P002X3_A320BR_Procedure_SurgeryID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgerywwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002X2_A321BR_Procedure_Surgery_Name, P002X2_n321BR_Procedure_Surgery_Name, P002X2_A322BR_Procedure_Surgery_Loc, P002X2_n322BR_Procedure_Surgery_Loc, P002X2_A139BR_ProcedureID, P002X2_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               P002X3_A322BR_Procedure_Surgery_Loc, P002X3_n322BR_Procedure_Surgery_Loc, P002X3_A321BR_Procedure_Surgery_Name, P002X3_n321BR_Procedure_Surgery_Name, P002X3_A139BR_ProcedureID, P002X3_A320BR_Procedure_SurgeryID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV39GXV1 ;
      private long AV11TFBR_Procedure_SurgeryID ;
      private long AV12TFBR_Procedure_SurgeryID_To ;
      private long AV13TFBR_ProcedureID ;
      private long AV14TFBR_ProcedureID_To ;
      private long AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ;
      private long AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ;
      private long AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ;
      private long AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ;
      private long A320BR_Procedure_SurgeryID ;
      private long A139BR_ProcedureID ;
      private long AV31count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2X2 ;
      private bool n321BR_Procedure_Surgery_Name ;
      private bool n322BR_Procedure_Surgery_Loc ;
      private bool BRK2X4 ;
      private String AV30OptionIndexesJson ;
      private String AV25OptionsJson ;
      private String AV28OptionsDescJson ;
      private String AV21DDOName ;
      private String AV19SearchTxt ;
      private String AV20SearchTxtTo ;
      private String AV15TFBR_Procedure_Surgery_Name ;
      private String AV16TFBR_Procedure_Surgery_Name_Sel ;
      private String AV17TFBR_Procedure_Surgery_Loc ;
      private String AV18TFBR_Procedure_Surgery_Loc_Sel ;
      private String AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ;
      private String AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ;
      private String AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ;
      private String AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ;
      private String lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ;
      private String lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ;
      private String A321BR_Procedure_Surgery_Name ;
      private String A322BR_Procedure_Surgery_Loc ;
      private String AV23Option ;
      private IGxSession AV32Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002X2_A321BR_Procedure_Surgery_Name ;
      private bool[] P002X2_n321BR_Procedure_Surgery_Name ;
      private String[] P002X2_A322BR_Procedure_Surgery_Loc ;
      private bool[] P002X2_n322BR_Procedure_Surgery_Loc ;
      private long[] P002X2_A139BR_ProcedureID ;
      private long[] P002X2_A320BR_Procedure_SurgeryID ;
      private String[] P002X3_A322BR_Procedure_Surgery_Loc ;
      private bool[] P002X3_n322BR_Procedure_Surgery_Loc ;
      private String[] P002X3_A321BR_Procedure_Surgery_Name ;
      private bool[] P002X3_n321BR_Procedure_Surgery_Name ;
      private long[] P002X3_A139BR_ProcedureID ;
      private long[] P002X3_A320BR_Procedure_SurgeryID ;
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

   public class br_procedure_surgerywwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002X2( IGxContext context ,
                                             long AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                             long AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                             long AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                             long AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                             String AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                             String AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                             String AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                             String AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                             long A320BR_Procedure_SurgeryID ,
                                             long A139BR_ProcedureID ,
                                             String A321BR_Procedure_Surgery_Name ,
                                             String A322BR_Procedure_Surgery_Loc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [8] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID], [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
         if ( ! (0==AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] >= @AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] >= @AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] <= @AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] <= @AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] like @lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] like @lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] = @AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] = @AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] like @lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] like @lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] = @AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] = @AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Procedure_Surgery_Name]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P002X3( IGxContext context ,
                                             long AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid ,
                                             long AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to ,
                                             long AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid ,
                                             long AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to ,
                                             String AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel ,
                                             String AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name ,
                                             String AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel ,
                                             String AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc ,
                                             long A320BR_Procedure_SurgeryID ,
                                             long A139BR_ProcedureID ,
                                             String A321BR_Procedure_Surgery_Name ,
                                             String A322BR_Procedure_Surgery_Loc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [8] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Procedure_Surgery_Loc], [BR_Procedure_Surgery_Name], [BR_ProcedureID], [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK)";
         if ( ! (0==AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] >= @AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] >= @AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_SurgeryID] <= @AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_SurgeryID] <= @AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] >= @AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] >= @AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (0==AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_ProcedureID] <= @AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_ProcedureID] <= @AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] like @lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] like @lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Name] = @AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Name] = @AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] like @lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] like @lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Procedure_Surgery_Loc] = @AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Procedure_Surgery_Loc] = @AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [BR_Procedure_Surgery_Loc]";
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
                     return conditional_P002X2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
               case 1 :
                     return conditional_P002X3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (long)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
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
          Object[] prmP002X2 ;
          prmP002X2 = new Object[] {
          new Object[] {"@AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP002X3 ;
          prmP002X3 = new Object[] {
          new Object[] {"@AV41BR_Procedure_SurgeryWWDS_1_Tfbr_procedure_surgeryid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42BR_Procedure_SurgeryWWDS_2_Tfbr_procedure_surgeryid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV43BR_Procedure_SurgeryWWDS_3_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV44BR_Procedure_SurgeryWWDS_4_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV45BR_Procedure_SurgeryWWDS_5_Tfbr_procedure_surgery_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV46BR_Procedure_SurgeryWWDS_6_Tfbr_procedure_surgery_name_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47BR_Procedure_SurgeryWWDS_7_Tfbr_procedure_surgery_loc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48BR_Procedure_SurgeryWWDS_8_Tfbr_procedure_surgery_loc_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002X2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002X2,100,0,true,false )
             ,new CursorDef("P002X3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002X3,100,0,true,false )
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

 [ServiceContract(Namespace = "GeneXus.Programs.br_procedure_surgerywwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_procedure_surgerywwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_procedure_surgerywwgetfilterdata") )
          {
             return  ;
          }
          br_procedure_surgerywwgetfilterdata worker = new br_procedure_surgerywwgetfilterdata(context) ;
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
