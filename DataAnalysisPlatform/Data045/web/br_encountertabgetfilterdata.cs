/*
               File: BR_EncounterTabGetFilterData
        Description: BR_Encounter Tab Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:10.18
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
   public class br_encountertabgetfilterdata : GXProcedure
   {
      public br_encountertabgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encountertabgetfilterdata( IGxContext context )
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
         this.AV17DDOName = aP0_DDOName;
         this.AV15SearchTxt = aP1_SearchTxt;
         this.AV16SearchTxtTo = aP2_SearchTxtTo;
         this.AV21OptionsJson = "" ;
         this.AV24OptionsDescJson = "" ;
         this.AV26OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV17DDOName = aP0_DDOName;
         this.AV15SearchTxt = aP1_SearchTxt;
         this.AV16SearchTxtTo = aP2_SearchTxtTo;
         this.AV21OptionsJson = "" ;
         this.AV24OptionsDescJson = "" ;
         this.AV26OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
         return AV26OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         br_encountertabgetfilterdata objbr_encountertabgetfilterdata;
         objbr_encountertabgetfilterdata = new br_encountertabgetfilterdata();
         objbr_encountertabgetfilterdata.AV17DDOName = aP0_DDOName;
         objbr_encountertabgetfilterdata.AV15SearchTxt = aP1_SearchTxt;
         objbr_encountertabgetfilterdata.AV16SearchTxtTo = aP2_SearchTxtTo;
         objbr_encountertabgetfilterdata.AV21OptionsJson = "" ;
         objbr_encountertabgetfilterdata.AV24OptionsDescJson = "" ;
         objbr_encountertabgetfilterdata.AV26OptionIndexesJson = "" ;
         objbr_encountertabgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_encountertabgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_encountertabgetfilterdata);
         aP3_OptionsJson=this.AV21OptionsJson;
         aP4_OptionsDescJson=this.AV24OptionsDescJson;
         aP5_OptionIndexesJson=this.AV26OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_encountertabgetfilterdata)stateInfo).executePrivate();
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
         AV20Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV25OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV17DDOName), "DDO_BR_ENCOUNTER_DEPARTMENTADM") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTER_DEPARTMENTADMOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV17DDOName), "DDO_BR_ENCOUNTER_DEPARTMENTDISCH") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_ENCOUNTER_DEPARTMENTDISCHOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV21OptionsJson = AV20Options.ToJSonString(false);
         AV24OptionsDescJson = AV23OptionsDesc.ToJSonString(false);
         AV26OptionIndexesJson = AV25OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV28Session.Get("BR_EncounterTabGridState"), "") == 0 )
         {
            AV30GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_EncounterTabGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV30GridState.FromXml(AV28Session.Get("BR_EncounterTabGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV38GXV1 = 1;
         while ( AV38GXV1 <= AV30GridState.gxTpr_Filtervalues.Count )
         {
            AV31GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV30GridState.gxTpr_Filtervalues.Item(AV38GXV1));
            if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTERID") == 0 )
            {
               AV33BR_EncounterID = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTADM") == 0 )
            {
               AV11TFBR_Encounter_Departmentadm = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTADM_SEL") == 0 )
            {
               AV12TFBR_Encounter_Departmentadm_Sel = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTDISCH") == 0 )
            {
               AV13TFBR_Encounter_Departmentdisch = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_DEPARTMENTDISCH_SEL") == 0 )
            {
               AV14TFBR_Encounter_Departmentdisch_Sel = AV31GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV31GridStateFilterValue.gxTpr_Name, "PARM_&BR_INFORMATION_ID") == 0 )
            {
               AV34BR_Information_ID = (long)(NumberUtil.Val( AV31GridStateFilterValue.gxTpr_Value, "."));
            }
            AV38GXV1 = (int)(AV38GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_ENCOUNTER_DEPARTMENTADMOPTIONS' Routine */
         AV11TFBR_Encounter_Departmentadm = AV15SearchTxt;
         AV12TFBR_Encounter_Departmentadm_Sel = "";
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV33BR_EncounterID ,
                                              AV12TFBR_Encounter_Departmentadm_Sel ,
                                              AV11TFBR_Encounter_Departmentadm ,
                                              AV14TFBR_Encounter_Departmentdisch_Sel ,
                                              AV13TFBR_Encounter_Departmentdisch ,
                                              A19BR_EncounterID ,
                                              A570BR_Encounter_Departmentadm ,
                                              A572BR_Encounter_Departmentdisch ,
                                              A360BAS_TenantTenantCode ,
                                              AV35tCurrentCode ,
                                              AV34BR_Information_ID ,
                                              A85BR_Information_ID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV33BR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV33BR_EncounterID), "%", "");
         lV11TFBR_Encounter_Departmentadm = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Encounter_Departmentadm), "%", "");
         lV13TFBR_Encounter_Departmentdisch = StringUtil.Concat( StringUtil.RTrim( AV13TFBR_Encounter_Departmentdisch), "%", "");
         /* Using cursor P004R2 */
         pr_default.execute(0, new Object[] {AV34BR_Information_ID, AV35tCurrentCode, lV33BR_EncounterID, lV11TFBR_Encounter_Departmentadm, AV12TFBR_Encounter_Departmentadm_Sel, lV13TFBR_Encounter_Departmentdisch, AV14TFBR_Encounter_Departmentdisch_Sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4R2 = false;
            A85BR_Information_ID = P004R2_A85BR_Information_ID[0];
            n85BR_Information_ID = P004R2_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = P004R2_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = P004R2_n360BAS_TenantTenantCode[0];
            A570BR_Encounter_Departmentadm = P004R2_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = P004R2_n570BR_Encounter_Departmentadm[0];
            A572BR_Encounter_Departmentdisch = P004R2_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = P004R2_n572BR_Encounter_Departmentdisch[0];
            A19BR_EncounterID = P004R2_A19BR_EncounterID[0];
            AV27count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P004R2_A85BR_Information_ID[0] == A85BR_Information_ID ) && ( StringUtil.StrCmp(P004R2_A570BR_Encounter_Departmentadm[0], A570BR_Encounter_Departmentadm) == 0 ) )
            {
               BRK4R2 = false;
               A19BR_EncounterID = P004R2_A19BR_EncounterID[0];
               AV27count = (long)(AV27count+1);
               BRK4R2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A570BR_Encounter_Departmentadm)) )
            {
               AV19Option = A570BR_Encounter_Departmentadm;
               AV20Options.Add(AV19Option, 0);
               AV25OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV27count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV20Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4R2 )
            {
               BRK4R2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_ENCOUNTER_DEPARTMENTDISCHOPTIONS' Routine */
         AV13TFBR_Encounter_Departmentdisch = AV15SearchTxt;
         AV14TFBR_Encounter_Departmentdisch_Sel = "";
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV33BR_EncounterID ,
                                              AV12TFBR_Encounter_Departmentadm_Sel ,
                                              AV11TFBR_Encounter_Departmentadm ,
                                              AV14TFBR_Encounter_Departmentdisch_Sel ,
                                              AV13TFBR_Encounter_Departmentdisch ,
                                              A19BR_EncounterID ,
                                              A570BR_Encounter_Departmentadm ,
                                              A572BR_Encounter_Departmentdisch ,
                                              A360BAS_TenantTenantCode ,
                                              AV35tCurrentCode ,
                                              AV34BR_Information_ID ,
                                              A85BR_Information_ID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV33BR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV33BR_EncounterID), "%", "");
         lV11TFBR_Encounter_Departmentadm = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Encounter_Departmentadm), "%", "");
         lV13TFBR_Encounter_Departmentdisch = StringUtil.Concat( StringUtil.RTrim( AV13TFBR_Encounter_Departmentdisch), "%", "");
         /* Using cursor P004R3 */
         pr_default.execute(1, new Object[] {AV34BR_Information_ID, AV35tCurrentCode, lV33BR_EncounterID, lV11TFBR_Encounter_Departmentadm, AV12TFBR_Encounter_Departmentadm_Sel, lV13TFBR_Encounter_Departmentdisch, AV14TFBR_Encounter_Departmentdisch_Sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4R4 = false;
            A85BR_Information_ID = P004R3_A85BR_Information_ID[0];
            n85BR_Information_ID = P004R3_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = P004R3_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = P004R3_n360BAS_TenantTenantCode[0];
            A572BR_Encounter_Departmentdisch = P004R3_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = P004R3_n572BR_Encounter_Departmentdisch[0];
            A570BR_Encounter_Departmentadm = P004R3_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = P004R3_n570BR_Encounter_Departmentadm[0];
            A19BR_EncounterID = P004R3_A19BR_EncounterID[0];
            AV27count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( P004R3_A85BR_Information_ID[0] == A85BR_Information_ID ) && ( StringUtil.StrCmp(P004R3_A572BR_Encounter_Departmentdisch[0], A572BR_Encounter_Departmentdisch) == 0 ) )
            {
               BRK4R4 = false;
               A19BR_EncounterID = P004R3_A19BR_EncounterID[0];
               AV27count = (long)(AV27count+1);
               BRK4R4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A572BR_Encounter_Departmentdisch)) )
            {
               AV19Option = A572BR_Encounter_Departmentdisch;
               AV20Options.Add(AV19Option, 0);
               AV25OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV27count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV20Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4R4 )
            {
               BRK4R4 = true;
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
         AV20Options = new GxSimpleCollection<String>();
         AV23OptionsDesc = new GxSimpleCollection<String>();
         AV25OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV28Session = context.GetSession();
         AV30GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV31GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV33BR_EncounterID = "";
         AV11TFBR_Encounter_Departmentadm = "";
         AV12TFBR_Encounter_Departmentadm_Sel = "";
         AV13TFBR_Encounter_Departmentdisch = "";
         AV14TFBR_Encounter_Departmentdisch_Sel = "";
         scmdbuf = "";
         lV33BR_EncounterID = "";
         lV11TFBR_Encounter_Departmentadm = "";
         lV13TFBR_Encounter_Departmentdisch = "";
         A570BR_Encounter_Departmentadm = "";
         A572BR_Encounter_Departmentdisch = "";
         A360BAS_TenantTenantCode = "";
         AV35tCurrentCode = "";
         P004R2_A85BR_Information_ID = new long[1] ;
         P004R2_n85BR_Information_ID = new bool[] {false} ;
         P004R2_A360BAS_TenantTenantCode = new String[] {""} ;
         P004R2_n360BAS_TenantTenantCode = new bool[] {false} ;
         P004R2_A570BR_Encounter_Departmentadm = new String[] {""} ;
         P004R2_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         P004R2_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         P004R2_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         P004R2_A19BR_EncounterID = new long[1] ;
         AV19Option = "";
         P004R3_A85BR_Information_ID = new long[1] ;
         P004R3_n85BR_Information_ID = new bool[] {false} ;
         P004R3_A360BAS_TenantTenantCode = new String[] {""} ;
         P004R3_n360BAS_TenantTenantCode = new bool[] {false} ;
         P004R3_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         P004R3_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         P004R3_A570BR_Encounter_Departmentadm = new String[] {""} ;
         P004R3_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         P004R3_A19BR_EncounterID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountertabgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004R2_A85BR_Information_ID, P004R2_n85BR_Information_ID, P004R2_A360BAS_TenantTenantCode, P004R2_n360BAS_TenantTenantCode, P004R2_A570BR_Encounter_Departmentadm, P004R2_n570BR_Encounter_Departmentadm, P004R2_A572BR_Encounter_Departmentdisch, P004R2_n572BR_Encounter_Departmentdisch, P004R2_A19BR_EncounterID
               }
               , new Object[] {
               P004R3_A85BR_Information_ID, P004R3_n85BR_Information_ID, P004R3_A360BAS_TenantTenantCode, P004R3_n360BAS_TenantTenantCode, P004R3_A572BR_Encounter_Departmentdisch, P004R3_n572BR_Encounter_Departmentdisch, P004R3_A570BR_Encounter_Departmentadm, P004R3_n570BR_Encounter_Departmentadm, P004R3_A19BR_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV38GXV1 ;
      private long AV34BR_Information_ID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV27count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK4R2 ;
      private bool n85BR_Information_ID ;
      private bool n360BAS_TenantTenantCode ;
      private bool n570BR_Encounter_Departmentadm ;
      private bool n572BR_Encounter_Departmentdisch ;
      private bool BRK4R4 ;
      private String AV26OptionIndexesJson ;
      private String AV21OptionsJson ;
      private String AV24OptionsDescJson ;
      private String AV17DDOName ;
      private String AV15SearchTxt ;
      private String AV16SearchTxtTo ;
      private String AV33BR_EncounterID ;
      private String AV11TFBR_Encounter_Departmentadm ;
      private String AV12TFBR_Encounter_Departmentadm_Sel ;
      private String AV13TFBR_Encounter_Departmentdisch ;
      private String AV14TFBR_Encounter_Departmentdisch_Sel ;
      private String lV33BR_EncounterID ;
      private String lV11TFBR_Encounter_Departmentadm ;
      private String lV13TFBR_Encounter_Departmentdisch ;
      private String A570BR_Encounter_Departmentadm ;
      private String A572BR_Encounter_Departmentdisch ;
      private String A360BAS_TenantTenantCode ;
      private String AV35tCurrentCode ;
      private String AV19Option ;
      private IGxSession AV28Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P004R2_A85BR_Information_ID ;
      private bool[] P004R2_n85BR_Information_ID ;
      private String[] P004R2_A360BAS_TenantTenantCode ;
      private bool[] P004R2_n360BAS_TenantTenantCode ;
      private String[] P004R2_A570BR_Encounter_Departmentadm ;
      private bool[] P004R2_n570BR_Encounter_Departmentadm ;
      private String[] P004R2_A572BR_Encounter_Departmentdisch ;
      private bool[] P004R2_n572BR_Encounter_Departmentdisch ;
      private long[] P004R2_A19BR_EncounterID ;
      private long[] P004R3_A85BR_Information_ID ;
      private bool[] P004R3_n85BR_Information_ID ;
      private String[] P004R3_A360BAS_TenantTenantCode ;
      private bool[] P004R3_n360BAS_TenantTenantCode ;
      private String[] P004R3_A572BR_Encounter_Departmentdisch ;
      private bool[] P004R3_n572BR_Encounter_Departmentdisch ;
      private String[] P004R3_A570BR_Encounter_Departmentadm ;
      private bool[] P004R3_n570BR_Encounter_Departmentadm ;
      private long[] P004R3_A19BR_EncounterID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV20Options ;
      private GxSimpleCollection<String> AV23OptionsDesc ;
      private GxSimpleCollection<String> AV25OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV30GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV31GridStateFilterValue ;
   }

   public class br_encountertabgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004R2( IGxContext context ,
                                             String AV33BR_EncounterID ,
                                             String AV12TFBR_Encounter_Departmentadm_Sel ,
                                             String AV11TFBR_Encounter_Departmentadm ,
                                             String AV14TFBR_Encounter_Departmentdisch_Sel ,
                                             String AV13TFBR_Encounter_Departmentdisch ,
                                             long A19BR_EncounterID ,
                                             String A570BR_Encounter_Departmentadm ,
                                             String A572BR_Encounter_Departmentdisch ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV35tCurrentCode ,
                                             long AV34BR_Information_ID ,
                                             long A85BR_Information_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [7] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Information_ID], [BAS_TenantTenantCode], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentdisch], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_Information_ID] = @AV34BR_Information_ID)";
         scmdbuf = scmdbuf + " and ([BAS_TenantTenantCode] = @AV35tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33BR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([BR_EncounterID] AS decimal(18,0))) like '%' + @lV33BR_EncounterID + '%')";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Encounter_Departmentadm_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Encounter_Departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] like @lV11TFBR_Encounter_Departmentadm)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Encounter_Departmentadm_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] = @AV12TFBR_Encounter_Departmentadm_Sel)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV14TFBR_Encounter_Departmentdisch_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13TFBR_Encounter_Departmentdisch)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] like @lV13TFBR_Encounter_Departmentdisch)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14TFBR_Encounter_Departmentdisch_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] = @AV14TFBR_Encounter_Departmentdisch_Sel)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Information_ID], [BR_Encounter_Departmentadm]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P004R3( IGxContext context ,
                                             String AV33BR_EncounterID ,
                                             String AV12TFBR_Encounter_Departmentadm_Sel ,
                                             String AV11TFBR_Encounter_Departmentadm ,
                                             String AV14TFBR_Encounter_Departmentdisch_Sel ,
                                             String AV13TFBR_Encounter_Departmentdisch ,
                                             long A19BR_EncounterID ,
                                             String A570BR_Encounter_Departmentadm ,
                                             String A572BR_Encounter_Departmentdisch ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV35tCurrentCode ,
                                             long AV34BR_Information_ID ,
                                             long A85BR_Information_ID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [7] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [BR_Information_ID], [BAS_TenantTenantCode], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentadm], [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_Information_ID] = @AV34BR_Information_ID)";
         scmdbuf = scmdbuf + " and ([BAS_TenantTenantCode] = @AV35tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33BR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([BR_EncounterID] AS decimal(18,0))) like '%' + @lV33BR_EncounterID + '%')";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Encounter_Departmentadm_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Encounter_Departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] like @lV11TFBR_Encounter_Departmentadm)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Encounter_Departmentadm_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentadm] = @AV12TFBR_Encounter_Departmentadm_Sel)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV14TFBR_Encounter_Departmentdisch_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13TFBR_Encounter_Departmentdisch)) ) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] like @lV13TFBR_Encounter_Departmentdisch)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14TFBR_Encounter_Departmentdisch_Sel)) )
         {
            sWhereString = sWhereString + " and ([BR_Encounter_Departmentdisch] = @AV14TFBR_Encounter_Departmentdisch_Sel)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [BR_Information_ID], [BR_Encounter_Departmentdisch]";
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
                     return conditional_P004R2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] );
               case 1 :
                     return conditional_P004R3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] );
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
          Object[] prmP004R2 ;
          prmP004R2 = new Object[] {
          new Object[] {"@AV34BR_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV35tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV33BR_EncounterID",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV11TFBR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Encounter_Departmentadm_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV13TFBR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV14TFBR_Encounter_Departmentdisch_Sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP004R3 ;
          prmP004R3 = new Object[] {
          new Object[] {"@AV34BR_Information_ID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV35tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV33BR_EncounterID",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV11TFBR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Encounter_Departmentadm_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV13TFBR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV14TFBR_Encounter_Departmentdisch_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004R2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004R2,100,0,true,false )
             ,new CursorDef("P004R3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004R3,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((long[]) buf[8])[0] = rslt.getLong(5) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_encountertabgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_encountertabgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_encountertabgetfilterdata") )
          {
             return  ;
          }
          br_encountertabgetfilterdata worker = new br_encountertabgetfilterdata(context) ;
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
