/*
               File: WebPanel4GetFilterData
        Description: Web Panel4 Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 13:36:15.22
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
   public class webpanel4getfilterdata : GXProcedure
   {
      public webpanel4getfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public webpanel4getfilterdata( IGxContext context )
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
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV35DDOName = aP0_DDOName;
         this.AV33SearchTxt = aP1_SearchTxt;
         this.AV34SearchTxtTo = aP2_SearchTxtTo;
         this.AV39OptionsJson = "" ;
         this.AV42OptionsDescJson = "" ;
         this.AV44OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
         return AV44OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         webpanel4getfilterdata objwebpanel4getfilterdata;
         objwebpanel4getfilterdata = new webpanel4getfilterdata();
         objwebpanel4getfilterdata.AV35DDOName = aP0_DDOName;
         objwebpanel4getfilterdata.AV33SearchTxt = aP1_SearchTxt;
         objwebpanel4getfilterdata.AV34SearchTxtTo = aP2_SearchTxtTo;
         objwebpanel4getfilterdata.AV39OptionsJson = "" ;
         objwebpanel4getfilterdata.AV42OptionsDescJson = "" ;
         objwebpanel4getfilterdata.AV44OptionIndexesJson = "" ;
         objwebpanel4getfilterdata.context.SetSubmitInitialConfig(context);
         objwebpanel4getfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwebpanel4getfilterdata);
         aP3_OptionsJson=this.AV39OptionsJson;
         aP4_OptionsDescJson=this.AV42OptionsDescJson;
         aP5_OptionIndexesJson=this.AV44OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((webpanel4getfilterdata)stateInfo).executePrivate();
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
         AV38Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV41OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV43OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S111 ();
         if ( returnInSub )
         {
            this.cleanup();
            if (true) return;
         }
         if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_DEPARTMENT") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_DEPARTMENTOPTIONS' */
            S121 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         else if ( StringUtil.StrCmp(StringUtil.Upper( AV35DDOName), "DDO_VIEW_NE_ENCTYPE") == 0 )
         {
            /* Execute user subroutine: 'LOADVIEW_NE_ENCTYPEOPTIONS' */
            S131 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
         }
         AV39OptionsJson = AV38Options.ToJSonString(false);
         AV42OptionsDescJson = AV41OptionsDesc.ToJSonString(false);
         AV44OptionIndexesJson = AV43OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV46Session.Get("WebPanel4GridState"), "") == 0 )
         {
            AV48GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WebPanel4GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV48GridState.FromXml(AV46Session.Get("WebPanel4GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV53GXV1 = 1;
         while ( AV53GXV1 <= AV48GridState.gxTpr_Filtervalues.Count )
         {
            AV49GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV48GridState.gxTpr_Filtervalues.Item(AV53GXV1));
            if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCOUNTERID") == 0 )
            {
               AV11TFview_NE_EncounterID = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Value, "."));
               AV12TFview_NE_EncounterID_To = (long)(NumberUtil.Val( AV49GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT") == 0 )
            {
               AV13TFview_NE_Department = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_DEPARTMENT_SEL") == 0 )
            {
               AV14TFview_NE_Department_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE") == 0 )
            {
               AV15TFview_NE_ENCType = AV49GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV49GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV16TFview_NE_ENCType_Sel = AV49GridStateFilterValue.gxTpr_Value;
            }
            AV53GXV1 = (int)(AV53GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADVIEW_NE_DEPARTMENTOPTIONS' Routine */
         AV13TFview_NE_Department = AV33SearchTxt;
         AV14TFview_NE_Department_Sel = "";
         AV55WebPanel4DS_1_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV56WebPanel4DS_2_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV57WebPanel4DS_3_Tfview_ne_department = AV13TFview_NE_Department;
         AV58WebPanel4DS_4_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV59WebPanel4DS_5_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV60WebPanel4DS_6_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV55WebPanel4DS_1_Tfview_ne_encounterid ,
                                              AV56WebPanel4DS_2_Tfview_ne_encounterid_to ,
                                              AV58WebPanel4DS_4_Tfview_ne_department_sel ,
                                              AV57WebPanel4DS_3_Tfview_ne_department ,
                                              AV60WebPanel4DS_6_Tfview_ne_enctype_sel ,
                                              AV59WebPanel4DS_5_Tfview_ne_enctype ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV57WebPanel4DS_3_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV57WebPanel4DS_3_Tfview_ne_department), "%", "");
         lV59WebPanel4DS_5_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel4DS_5_Tfview_ne_enctype), "%", "");
         /* Using cursor P004M2 */
         pr_default.execute(0, new Object[] {AV55WebPanel4DS_1_Tfview_ne_encounterid, AV56WebPanel4DS_2_Tfview_ne_encounterid_to, lV57WebPanel4DS_3_Tfview_ne_department, AV58WebPanel4DS_4_Tfview_ne_department_sel, lV59WebPanel4DS_5_Tfview_ne_enctype, AV60WebPanel4DS_6_Tfview_ne_enctype_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK4M2 = false;
            A550view_NE_Department = P004M2_A550view_NE_Department[0];
            n550view_NE_Department = P004M2_n550view_NE_Department[0];
            A551view_NE_ENCType = P004M2_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004M2_n551view_NE_ENCType[0];
            A549view_NE_EncounterID = P004M2_A549view_NE_EncounterID[0];
            AV45count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P004M2_A550view_NE_Department[0], A550view_NE_Department) == 0 ) )
            {
               BRK4M2 = false;
               A549view_NE_EncounterID = P004M2_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4M2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A550view_NE_Department)) )
            {
               AV37Option = A550view_NE_Department;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4M2 )
            {
               BRK4M2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADVIEW_NE_ENCTYPEOPTIONS' Routine */
         AV15TFview_NE_ENCType = AV33SearchTxt;
         AV16TFview_NE_ENCType_Sel = "";
         AV55WebPanel4DS_1_Tfview_ne_encounterid = AV11TFview_NE_EncounterID;
         AV56WebPanel4DS_2_Tfview_ne_encounterid_to = AV12TFview_NE_EncounterID_To;
         AV57WebPanel4DS_3_Tfview_ne_department = AV13TFview_NE_Department;
         AV58WebPanel4DS_4_Tfview_ne_department_sel = AV14TFview_NE_Department_Sel;
         AV59WebPanel4DS_5_Tfview_ne_enctype = AV15TFview_NE_ENCType;
         AV60WebPanel4DS_6_Tfview_ne_enctype_sel = AV16TFview_NE_ENCType_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV55WebPanel4DS_1_Tfview_ne_encounterid ,
                                              AV56WebPanel4DS_2_Tfview_ne_encounterid_to ,
                                              AV58WebPanel4DS_4_Tfview_ne_department_sel ,
                                              AV57WebPanel4DS_3_Tfview_ne_department ,
                                              AV60WebPanel4DS_6_Tfview_ne_enctype_sel ,
                                              AV59WebPanel4DS_5_Tfview_ne_enctype ,
                                              A549view_NE_EncounterID ,
                                              A550view_NE_Department ,
                                              A551view_NE_ENCType } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV57WebPanel4DS_3_Tfview_ne_department = StringUtil.Concat( StringUtil.RTrim( AV57WebPanel4DS_3_Tfview_ne_department), "%", "");
         lV59WebPanel4DS_5_Tfview_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV59WebPanel4DS_5_Tfview_ne_enctype), "%", "");
         /* Using cursor P004M3 */
         pr_default.execute(1, new Object[] {AV55WebPanel4DS_1_Tfview_ne_encounterid, AV56WebPanel4DS_2_Tfview_ne_encounterid_to, lV57WebPanel4DS_3_Tfview_ne_department, AV58WebPanel4DS_4_Tfview_ne_department_sel, lV59WebPanel4DS_5_Tfview_ne_enctype, AV60WebPanel4DS_6_Tfview_ne_enctype_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK4M4 = false;
            A551view_NE_ENCType = P004M3_A551view_NE_ENCType[0];
            n551view_NE_ENCType = P004M3_n551view_NE_ENCType[0];
            A550view_NE_Department = P004M3_A550view_NE_Department[0];
            n550view_NE_Department = P004M3_n550view_NE_Department[0];
            A549view_NE_EncounterID = P004M3_A549view_NE_EncounterID[0];
            AV45count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P004M3_A551view_NE_ENCType[0], A551view_NE_ENCType) == 0 ) )
            {
               BRK4M4 = false;
               A549view_NE_EncounterID = P004M3_A549view_NE_EncounterID[0];
               AV45count = (long)(AV45count+1);
               BRK4M4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A551view_NE_ENCType)) )
            {
               AV37Option = A551view_NE_ENCType;
               AV38Options.Add(AV37Option, 0);
               AV43OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV45count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV38Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4M4 )
            {
               BRK4M4 = true;
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
         AV38Options = new GxSimpleCollection<String>();
         AV41OptionsDesc = new GxSimpleCollection<String>();
         AV43OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV46Session = context.GetSession();
         AV48GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV49GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV13TFview_NE_Department = "";
         AV14TFview_NE_Department_Sel = "";
         AV15TFview_NE_ENCType = "";
         AV16TFview_NE_ENCType_Sel = "";
         AV57WebPanel4DS_3_Tfview_ne_department = "";
         AV58WebPanel4DS_4_Tfview_ne_department_sel = "";
         AV59WebPanel4DS_5_Tfview_ne_enctype = "";
         AV60WebPanel4DS_6_Tfview_ne_enctype_sel = "";
         scmdbuf = "";
         lV57WebPanel4DS_3_Tfview_ne_department = "";
         lV59WebPanel4DS_5_Tfview_ne_enctype = "";
         A550view_NE_Department = "";
         A551view_NE_ENCType = "";
         P004M2_A550view_NE_Department = new String[] {""} ;
         P004M2_n550view_NE_Department = new bool[] {false} ;
         P004M2_A551view_NE_ENCType = new String[] {""} ;
         P004M2_n551view_NE_ENCType = new bool[] {false} ;
         P004M2_A549view_NE_EncounterID = new long[1] ;
         AV37Option = "";
         P004M3_A551view_NE_ENCType = new String[] {""} ;
         P004M3_n551view_NE_ENCType = new bool[] {false} ;
         P004M3_A550view_NE_Department = new String[] {""} ;
         P004M3_n550view_NE_Department = new bool[] {false} ;
         P004M3_A549view_NE_EncounterID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.webpanel4getfilterdata__default(),
            new Object[][] {
                new Object[] {
               P004M2_A550view_NE_Department, P004M2_n550view_NE_Department, P004M2_A551view_NE_ENCType, P004M2_n551view_NE_ENCType, P004M2_A549view_NE_EncounterID
               }
               , new Object[] {
               P004M3_A551view_NE_ENCType, P004M3_n551view_NE_ENCType, P004M3_A550view_NE_Department, P004M3_n550view_NE_Department, P004M3_A549view_NE_EncounterID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV53GXV1 ;
      private long AV11TFview_NE_EncounterID ;
      private long AV12TFview_NE_EncounterID_To ;
      private long AV55WebPanel4DS_1_Tfview_ne_encounterid ;
      private long AV56WebPanel4DS_2_Tfview_ne_encounterid_to ;
      private long A549view_NE_EncounterID ;
      private long AV45count ;
      private String scmdbuf ;
      private bool returnInSub ;
      private bool BRK4M2 ;
      private bool n550view_NE_Department ;
      private bool n551view_NE_ENCType ;
      private bool BRK4M4 ;
      private String AV44OptionIndexesJson ;
      private String AV39OptionsJson ;
      private String AV42OptionsDescJson ;
      private String AV35DDOName ;
      private String AV33SearchTxt ;
      private String AV34SearchTxtTo ;
      private String AV13TFview_NE_Department ;
      private String AV14TFview_NE_Department_Sel ;
      private String AV15TFview_NE_ENCType ;
      private String AV16TFview_NE_ENCType_Sel ;
      private String AV57WebPanel4DS_3_Tfview_ne_department ;
      private String AV58WebPanel4DS_4_Tfview_ne_department_sel ;
      private String AV59WebPanel4DS_5_Tfview_ne_enctype ;
      private String AV60WebPanel4DS_6_Tfview_ne_enctype_sel ;
      private String lV57WebPanel4DS_3_Tfview_ne_department ;
      private String lV59WebPanel4DS_5_Tfview_ne_enctype ;
      private String A550view_NE_Department ;
      private String A551view_NE_ENCType ;
      private String AV37Option ;
      private IGxSession AV46Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P004M2_A550view_NE_Department ;
      private bool[] P004M2_n550view_NE_Department ;
      private String[] P004M2_A551view_NE_ENCType ;
      private bool[] P004M2_n551view_NE_ENCType ;
      private long[] P004M2_A549view_NE_EncounterID ;
      private String[] P004M3_A551view_NE_ENCType ;
      private bool[] P004M3_n551view_NE_ENCType ;
      private String[] P004M3_A550view_NE_Department ;
      private bool[] P004M3_n550view_NE_Department ;
      private long[] P004M3_A549view_NE_EncounterID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV38Options ;
      private GxSimpleCollection<String> AV41OptionsDesc ;
      private GxSimpleCollection<String> AV43OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV48GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV49GridStateFilterValue ;
   }

   public class webpanel4getfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P004M2( IGxContext context ,
                                             long AV55WebPanel4DS_1_Tfview_ne_encounterid ,
                                             long AV56WebPanel4DS_2_Tfview_ne_encounterid_to ,
                                             String AV58WebPanel4DS_4_Tfview_ne_department_sel ,
                                             String AV57WebPanel4DS_3_Tfview_ne_department ,
                                             String AV60WebPanel4DS_6_Tfview_ne_enctype_sel ,
                                             String AV59WebPanel4DS_5_Tfview_ne_enctype ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [6] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_Department], [view_NE_ENCType], [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV55WebPanel4DS_1_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV55WebPanel4DS_1_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV55WebPanel4DS_1_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int1[0] = 1;
         }
         if ( ! (0==AV56WebPanel4DS_2_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV56WebPanel4DS_2_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV56WebPanel4DS_2_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58WebPanel4DS_4_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57WebPanel4DS_3_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV57WebPanel4DS_3_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV57WebPanel4DS_3_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58WebPanel4DS_4_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV58WebPanel4DS_4_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV58WebPanel4DS_4_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel4DS_6_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel4DS_5_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV59WebPanel4DS_5_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV59WebPanel4DS_5_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel4DS_6_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV60WebPanel4DS_6_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV60WebPanel4DS_6_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_Department]";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_P004M3( IGxContext context ,
                                             long AV55WebPanel4DS_1_Tfview_ne_encounterid ,
                                             long AV56WebPanel4DS_2_Tfview_ne_encounterid_to ,
                                             String AV58WebPanel4DS_4_Tfview_ne_department_sel ,
                                             String AV57WebPanel4DS_3_Tfview_ne_department ,
                                             String AV60WebPanel4DS_6_Tfview_ne_enctype_sel ,
                                             String AV59WebPanel4DS_5_Tfview_ne_enctype ,
                                             long A549view_NE_EncounterID ,
                                             String A550view_NE_Department ,
                                             String A551view_NE_ENCType )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT [view_NE_ENCType], [view_NE_Department], [view_NE_EncounterID] FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV55WebPanel4DS_1_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV55WebPanel4DS_1_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV55WebPanel4DS_1_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV56WebPanel4DS_2_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV56WebPanel4DS_2_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV56WebPanel4DS_2_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV58WebPanel4DS_4_Tfview_ne_department_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV57WebPanel4DS_3_Tfview_ne_department)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] like @lV57WebPanel4DS_3_Tfview_ne_department)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] like @lV57WebPanel4DS_3_Tfview_ne_department)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV58WebPanel4DS_4_Tfview_ne_department_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_Department] = @AV58WebPanel4DS_4_Tfview_ne_department_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_Department] = @AV58WebPanel4DS_4_Tfview_ne_department_sel)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel4DS_6_Tfview_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV59WebPanel4DS_5_Tfview_ne_enctype)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] like @lV59WebPanel4DS_5_Tfview_ne_enctype)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] like @lV59WebPanel4DS_5_Tfview_ne_enctype)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV60WebPanel4DS_6_Tfview_ne_enctype_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_ENCType] = @AV60WebPanel4DS_6_Tfview_ne_enctype_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_ENCType] = @AV60WebPanel4DS_6_Tfview_ne_enctype_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [view_NE_ENCType]";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P004M2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] );
               case 1 :
                     return conditional_P004M3(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] );
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
          Object[] prmP004M2 ;
          prmP004M2 = new Object[] {
          new Object[] {"@AV55WebPanel4DS_1_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56WebPanel4DS_2_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV57WebPanel4DS_3_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV58WebPanel4DS_4_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV59WebPanel4DS_5_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel4DS_6_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0}
          } ;
          Object[] prmP004M3 ;
          prmP004M3 = new Object[] {
          new Object[] {"@AV55WebPanel4DS_1_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV56WebPanel4DS_2_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV57WebPanel4DS_3_Tfview_ne_department",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV58WebPanel4DS_4_Tfview_ne_department_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV59WebPanel4DS_5_Tfview_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV60WebPanel4DS_6_Tfview_ne_enctype_sel",SqlDbType.NVarChar,4000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P004M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004M2,100,0,true,false )
             ,new CursorDef("P004M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP004M3,100,0,true,false )
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
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.webpanel4getfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class webpanel4getfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("webpanel4getfilterdata") )
          {
             return  ;
          }
          webpanel4getfilterdata worker = new webpanel4getfilterdata(context) ;
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
