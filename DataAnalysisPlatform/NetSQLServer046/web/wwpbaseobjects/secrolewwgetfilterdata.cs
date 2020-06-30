/*
               File: WWPBaseObjects.SecRoleWWGetFilterData
        Description: Sec Role WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:1.94
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secrolewwgetfilterdata : GXProcedure
   {
      public secrolewwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secrolewwgetfilterdata( IGxContext context )
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
         this.AV16DDOName = aP0_DDOName;
         this.AV14SearchTxt = aP1_SearchTxt;
         this.AV15SearchTxtTo = aP2_SearchTxtTo;
         this.AV20OptionsJson = "" ;
         this.AV23OptionsDescJson = "" ;
         this.AV25OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV16DDOName = aP0_DDOName;
         this.AV14SearchTxt = aP1_SearchTxt;
         this.AV15SearchTxtTo = aP2_SearchTxtTo;
         this.AV20OptionsJson = "" ;
         this.AV23OptionsDescJson = "" ;
         this.AV25OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
         return AV25OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         secrolewwgetfilterdata objsecrolewwgetfilterdata;
         objsecrolewwgetfilterdata = new secrolewwgetfilterdata();
         objsecrolewwgetfilterdata.AV16DDOName = aP0_DDOName;
         objsecrolewwgetfilterdata.AV14SearchTxt = aP1_SearchTxt;
         objsecrolewwgetfilterdata.AV15SearchTxtTo = aP2_SearchTxtTo;
         objsecrolewwgetfilterdata.AV20OptionsJson = "" ;
         objsecrolewwgetfilterdata.AV23OptionsDescJson = "" ;
         objsecrolewwgetfilterdata.AV25OptionIndexesJson = "" ;
         objsecrolewwgetfilterdata.context.SetSubmitInitialConfig(context);
         objsecrolewwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecrolewwgetfilterdata);
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secrolewwgetfilterdata)stateInfo).executePrivate();
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
         AV19Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV22OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV24OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecRole", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV46WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV16DDOName), "DDO_SECROLENAME") == 0 )
            {
               /* Execute user subroutine: 'LOADSECROLENAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV16DDOName), "DDO_SECROLEDESCRIPTION") == 0 )
            {
               /* Execute user subroutine: 'LOADSECROLEDESCRIPTIONOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV20OptionsJson = AV19Options.ToJSonString(false);
         AV23OptionsDescJson = AV22OptionsDesc.ToJSonString(false);
         AV25OptionIndexesJson = AV24OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV27Session.Get("WWPBaseObjects.SecRoleWWGridState"), "") == 0 )
         {
            AV29GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WWPBaseObjects.SecRoleWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV29GridState.FromXml(AV27Session.Get("WWPBaseObjects.SecRoleWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV49GXV1 = 1;
         while ( AV49GXV1 <= AV29GridState.gxTpr_Filtervalues.Count )
         {
            AV30GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV29GridState.gxTpr_Filtervalues.Item(AV49GXV1));
            if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLENAME") == 0 )
            {
               AV10TFSecRoleName = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLENAME_SEL") == 0 )
            {
               AV11TFSecRoleName_Sel = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION") == 0 )
            {
               AV12TFSecRoleDescription = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION_SEL") == 0 )
            {
               AV13TFSecRoleDescription_Sel = AV30GridStateFilterValue.gxTpr_Value;
            }
            AV49GXV1 = (int)(AV49GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSECROLENAMEOPTIONS' Routine */
         AV10TFSecRoleName = AV14SearchTxt;
         AV11TFSecRoleName_Sel = "";
         AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV10TFSecRoleName;
         AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV11TFSecRoleName_Sel;
         AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV12TFSecRoleDescription;
         AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV13TFSecRoleDescription_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                              AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                              AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                              AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = StringUtil.Concat( StringUtil.RTrim( AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename), "%", "");
         lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = StringUtil.Concat( StringUtil.RTrim( AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription), "%", "");
         /* Using cursor P00162 */
         pr_default.execute(0, new Object[] {lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename, AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel, lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription, AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK162 = false;
            A13SecRoleName = P00162_A13SecRoleName[0];
            A12SecRoleDescription = P00162_A12SecRoleDescription[0];
            A4SecRoleId = P00162_A4SecRoleId[0];
            AV26count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00162_A13SecRoleName[0], A13SecRoleName) == 0 ) )
            {
               BRK162 = false;
               A4SecRoleId = P00162_A4SecRoleId[0];
               AV26count = (long)(AV26count+1);
               BRK162 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A13SecRoleName)) )
            {
               AV18Option = A13SecRoleName;
               AV19Options.Add(AV18Option, 0);
               AV24OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV26count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV19Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK162 )
            {
               BRK162 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADSECROLEDESCRIPTIONOPTIONS' Routine */
         AV12TFSecRoleDescription = AV14SearchTxt;
         AV13TFSecRoleDescription_Sel = "";
         AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = AV10TFSecRoleName;
         AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = AV11TFSecRoleName_Sel;
         AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = AV12TFSecRoleDescription;
         AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = AV13TFSecRoleDescription_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                              AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                              AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                              AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = StringUtil.Concat( StringUtil.RTrim( AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename), "%", "");
         lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = StringUtil.Concat( StringUtil.RTrim( AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription), "%", "");
         /* Using cursor P00163 */
         pr_default.execute(1, new Object[] {lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename, AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel, lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription, AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK164 = false;
            A12SecRoleDescription = P00163_A12SecRoleDescription[0];
            A13SecRoleName = P00163_A13SecRoleName[0];
            A4SecRoleId = P00163_A4SecRoleId[0];
            AV26count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00163_A12SecRoleDescription[0], A12SecRoleDescription) == 0 ) )
            {
               BRK164 = false;
               A4SecRoleId = P00163_A4SecRoleId[0];
               AV26count = (long)(AV26count+1);
               BRK164 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A12SecRoleDescription)) )
            {
               AV18Option = A12SecRoleDescription;
               AV19Options.Add(AV18Option, 0);
               AV24OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV26count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV19Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK164 )
            {
               BRK164 = true;
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
         AV19Options = new GxSimpleCollection<String>();
         AV22OptionsDesc = new GxSimpleCollection<String>();
         AV24OptionIndexes = new GxSimpleCollection<String>();
         AV46WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV27Session = context.GetSession();
         AV29GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV30GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TFSecRoleName = "";
         AV11TFSecRoleName_Sel = "";
         AV12TFSecRoleDescription = "";
         AV13TFSecRoleDescription_Sel = "";
         AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = "";
         AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel = "";
         AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = "";
         AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel = "";
         scmdbuf = "";
         lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename = "";
         lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription = "";
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         P00162_A13SecRoleName = new String[] {""} ;
         P00162_A12SecRoleDescription = new String[] {""} ;
         P00162_A4SecRoleId = new short[1] ;
         AV18Option = "";
         P00163_A12SecRoleDescription = new String[] {""} ;
         P00163_A13SecRoleName = new String[] {""} ;
         P00163_A4SecRoleId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolewwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00162_A13SecRoleName, P00162_A12SecRoleDescription, P00162_A4SecRoleId
               }
               , new Object[] {
               P00163_A12SecRoleDescription, P00163_A13SecRoleName, P00163_A4SecRoleId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A4SecRoleId ;
      private int AV49GXV1 ;
      private long AV26count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK162 ;
      private bool BRK164 ;
      private String AV25OptionIndexesJson ;
      private String AV20OptionsJson ;
      private String AV23OptionsDescJson ;
      private String AV16DDOName ;
      private String AV14SearchTxt ;
      private String AV15SearchTxtTo ;
      private String AV10TFSecRoleName ;
      private String AV11TFSecRoleName_Sel ;
      private String AV12TFSecRoleDescription ;
      private String AV13TFSecRoleDescription_Sel ;
      private String AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ;
      private String AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ;
      private String AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ;
      private String AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ;
      private String lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ;
      private String lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ;
      private String A13SecRoleName ;
      private String A12SecRoleDescription ;
      private String AV18Option ;
      private IGxSession AV27Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00162_A13SecRoleName ;
      private String[] P00162_A12SecRoleDescription ;
      private short[] P00162_A4SecRoleId ;
      private String[] P00163_A12SecRoleDescription ;
      private String[] P00163_A13SecRoleName ;
      private short[] P00163_A4SecRoleId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV19Options ;
      private GxSimpleCollection<String> AV22OptionsDesc ;
      private GxSimpleCollection<String> AV24OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV29GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV30GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV46WWPContext ;
   }

   public class secrolewwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00162( IGxContext context ,
                                             String AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                             String AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                             String AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                             String AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [4] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [SecRoleName], [SecRoleDescription], [SecRoleId] FROM [SecRole] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] like @lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] like @lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] = @AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] = @AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] like @lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] like @lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] = @AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] = @AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [SecRoleName]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00163( IGxContext context ,
                                             String AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel ,
                                             String AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename ,
                                             String AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel ,
                                             String AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [4] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [SecRoleDescription], [SecRoleName], [SecRoleId] FROM [SecRole] WITH (NOLOCK)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] like @lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] like @lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleName] = @AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleName] = @AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] like @lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] like @lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecRoleDescription] = @AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecRoleDescription] = @AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [SecRoleDescription]";
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
                     return conditional_P00162(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] );
               case 1 :
                     return conditional_P00163(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] );
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
          Object[] prmP00162 ;
          prmP00162 = new Object[] {
          new Object[] {"@lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel",SqlDbType.NVarChar,120,0}
          } ;
          Object[] prmP00163 ;
          prmP00163 = new Object[] {
          new Object[] {"@lV51WWPBaseObjects_SecRoleWWDS_1_Tfsecrolename",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV52WWPBaseObjects_SecRoleWWDS_2_Tfsecrolename_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV53WWPBaseObjects_SecRoleWWDS_3_Tfsecroledescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV54WWPBaseObjects_SecRoleWWDS_4_Tfsecroledescription_sel",SqlDbType.NVarChar,120,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00162", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00162,100,0,true,false )
             ,new CursorDef("P00163", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00163,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.wwpbaseobjects.secrolewwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class secrolewwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("secrolewwgetfilterdata") )
          {
             return  ;
          }
          secrolewwgetfilterdata worker = new secrolewwgetfilterdata(context) ;
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
