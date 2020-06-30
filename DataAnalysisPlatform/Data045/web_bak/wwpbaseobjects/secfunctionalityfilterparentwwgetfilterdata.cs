/*
               File: WWPBaseObjects.SecFunctionalityFilterParentWWGetFilterData
        Description: Sec Functionality Filter Parent WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:20.13
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
   public class secfunctionalityfilterparentwwgetfilterdata : GXProcedure
   {
      public secfunctionalityfilterparentwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalityfilterparentwwgetfilterdata( IGxContext context )
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
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
         return AV28OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         secfunctionalityfilterparentwwgetfilterdata objsecfunctionalityfilterparentwwgetfilterdata;
         objsecfunctionalityfilterparentwwgetfilterdata = new secfunctionalityfilterparentwwgetfilterdata();
         objsecfunctionalityfilterparentwwgetfilterdata.AV19DDOName = aP0_DDOName;
         objsecfunctionalityfilterparentwwgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objsecfunctionalityfilterparentwwgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objsecfunctionalityfilterparentwwgetfilterdata.AV23OptionsJson = "" ;
         objsecfunctionalityfilterparentwwgetfilterdata.AV26OptionsDescJson = "" ;
         objsecfunctionalityfilterparentwwgetfilterdata.AV28OptionIndexesJson = "" ;
         objsecfunctionalityfilterparentwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objsecfunctionalityfilterparentwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecfunctionalityfilterparentwwgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secfunctionalityfilterparentwwgetfilterdata)stateInfo).executePrivate();
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
         AV22Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV25OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV27OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecFunctionality", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV39WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_SECFUNCTIONALITYKEY") == 0 )
            {
               /* Execute user subroutine: 'LOADSECFUNCTIONALITYKEYOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_SECFUNCTIONALITYDESCRIPTION") == 0 )
            {
               /* Execute user subroutine: 'LOADSECFUNCTIONALITYDESCRIPTIONOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV23OptionsJson = AV22Options.ToJSonString(false);
         AV26OptionsDescJson = AV25OptionsDesc.ToJSonString(false);
         AV28OptionIndexesJson = AV27OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV30Session.Get("WWPBaseObjects.SecFunctionalityFilterParentWWGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WWPBaseObjects.SecFunctionalityFilterParentWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("WWPBaseObjects.SecFunctionalityFilterParentWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV44GXV1 = 1;
         while ( AV44GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV44GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY") == 0 )
            {
               AV10TFSecFunctionalityKey = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY_SEL") == 0 )
            {
               AV11TFSecFunctionalityKey_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYDESCRIPTION") == 0 )
            {
               AV12TFSecFunctionalityDescription = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYDESCRIPTION_SEL") == 0 )
            {
               AV13TFSecFunctionalityDescription_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "PARM_&SECPARENTFUNCTIONALITYID") == 0 )
            {
               AV38SecParentFunctionalityId = (long)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
            }
            AV44GXV1 = (int)(AV44GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSECFUNCTIONALITYKEYOPTIONS' Routine */
         AV10TFSecFunctionalityKey = AV17SearchTxt;
         AV11TFSecFunctionalityKey_Sel = "";
         AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid = AV38SecParentFunctionalityId;
         AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = AV10TFSecFunctionalityKey;
         AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel = AV11TFSecFunctionalityKey_Sel;
         AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = AV12TFSecFunctionalityDescription;
         AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel = AV13TFSecFunctionalityDescription_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel ,
                                              AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ,
                                              AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel ,
                                              AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ,
                                              A3SecFunctionalityKey ,
                                              A8SecFunctionalityDescription ,
                                              AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid ,
                                              A2SecParentFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey), "%", "");
         lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription), "%", "");
         /* Using cursor P000U2 */
         pr_default.execute(0, new Object[] {AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid, lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey, AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel, lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription, AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0U2 = false;
            A2SecParentFunctionalityId = P000U2_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = P000U2_n2SecParentFunctionalityId[0];
            A3SecFunctionalityKey = P000U2_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = P000U2_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = P000U2_A1SecFunctionalityId[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P000U2_A2SecParentFunctionalityId[0] == A2SecParentFunctionalityId ) && ( StringUtil.StrCmp(P000U2_A3SecFunctionalityKey[0], A3SecFunctionalityKey) == 0 ) )
            {
               BRK0U2 = false;
               A1SecFunctionalityId = P000U2_A1SecFunctionalityId[0];
               AV29count = (long)(AV29count+1);
               BRK0U2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A3SecFunctionalityKey)) )
            {
               AV21Option = A3SecFunctionalityKey;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0U2 )
            {
               BRK0U2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADSECFUNCTIONALITYDESCRIPTIONOPTIONS' Routine */
         AV12TFSecFunctionalityDescription = AV17SearchTxt;
         AV13TFSecFunctionalityDescription_Sel = "";
         AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid = AV38SecParentFunctionalityId;
         AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = AV10TFSecFunctionalityKey;
         AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel = AV11TFSecFunctionalityKey_Sel;
         AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = AV12TFSecFunctionalityDescription;
         AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel = AV13TFSecFunctionalityDescription_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel ,
                                              AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ,
                                              AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel ,
                                              AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ,
                                              A3SecFunctionalityKey ,
                                              A8SecFunctionalityDescription ,
                                              AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid ,
                                              A2SecParentFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey), "%", "");
         lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription), "%", "");
         /* Using cursor P000U3 */
         pr_default.execute(1, new Object[] {AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid, lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey, AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel, lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription, AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK0U4 = false;
            A2SecParentFunctionalityId = P000U3_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = P000U3_n2SecParentFunctionalityId[0];
            A8SecFunctionalityDescription = P000U3_A8SecFunctionalityDescription[0];
            A3SecFunctionalityKey = P000U3_A3SecFunctionalityKey[0];
            A1SecFunctionalityId = P000U3_A1SecFunctionalityId[0];
            AV29count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( P000U3_A2SecParentFunctionalityId[0] == A2SecParentFunctionalityId ) && ( StringUtil.StrCmp(P000U3_A8SecFunctionalityDescription[0], A8SecFunctionalityDescription) == 0 ) )
            {
               BRK0U4 = false;
               A1SecFunctionalityId = P000U3_A1SecFunctionalityId[0];
               AV29count = (long)(AV29count+1);
               BRK0U4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A8SecFunctionalityDescription)) )
            {
               AV21Option = A8SecFunctionalityDescription;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0U4 )
            {
               BRK0U4 = true;
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
         AV22Options = new GxSimpleCollection<String>();
         AV25OptionsDesc = new GxSimpleCollection<String>();
         AV27OptionIndexes = new GxSimpleCollection<String>();
         AV39WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV30Session = context.GetSession();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TFSecFunctionalityKey = "";
         AV11TFSecFunctionalityKey_Sel = "";
         AV12TFSecFunctionalityDescription = "";
         AV13TFSecFunctionalityDescription_Sel = "";
         AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = "";
         AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel = "";
         AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = "";
         AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel = "";
         scmdbuf = "";
         lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey = "";
         lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription = "";
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         P000U2_A2SecParentFunctionalityId = new long[1] ;
         P000U2_n2SecParentFunctionalityId = new bool[] {false} ;
         P000U2_A3SecFunctionalityKey = new String[] {""} ;
         P000U2_A8SecFunctionalityDescription = new String[] {""} ;
         P000U2_A1SecFunctionalityId = new long[1] ;
         AV21Option = "";
         P000U3_A2SecParentFunctionalityId = new long[1] ;
         P000U3_n2SecParentFunctionalityId = new bool[] {false} ;
         P000U3_A8SecFunctionalityDescription = new String[] {""} ;
         P000U3_A3SecFunctionalityKey = new String[] {""} ;
         P000U3_A1SecFunctionalityId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalityfilterparentwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000U2_A2SecParentFunctionalityId, P000U2_n2SecParentFunctionalityId, P000U2_A3SecFunctionalityKey, P000U2_A8SecFunctionalityDescription, P000U2_A1SecFunctionalityId
               }
               , new Object[] {
               P000U3_A2SecParentFunctionalityId, P000U3_n2SecParentFunctionalityId, P000U3_A8SecFunctionalityDescription, P000U3_A3SecFunctionalityKey, P000U3_A1SecFunctionalityId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV44GXV1 ;
      private long AV38SecParentFunctionalityId ;
      private long AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid ;
      private long A2SecParentFunctionalityId ;
      private long A1SecFunctionalityId ;
      private long AV29count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK0U2 ;
      private bool n2SecParentFunctionalityId ;
      private bool BRK0U4 ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV10TFSecFunctionalityKey ;
      private String AV11TFSecFunctionalityKey_Sel ;
      private String AV12TFSecFunctionalityDescription ;
      private String AV13TFSecFunctionalityDescription_Sel ;
      private String AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ;
      private String AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel ;
      private String AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ;
      private String AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel ;
      private String lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ;
      private String lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000U2_A2SecParentFunctionalityId ;
      private bool[] P000U2_n2SecParentFunctionalityId ;
      private String[] P000U2_A3SecFunctionalityKey ;
      private String[] P000U2_A8SecFunctionalityDescription ;
      private long[] P000U2_A1SecFunctionalityId ;
      private long[] P000U3_A2SecParentFunctionalityId ;
      private bool[] P000U3_n2SecParentFunctionalityId ;
      private String[] P000U3_A8SecFunctionalityDescription ;
      private String[] P000U3_A3SecFunctionalityKey ;
      private long[] P000U3_A1SecFunctionalityId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV22Options ;
      private GxSimpleCollection<String> AV25OptionsDesc ;
      private GxSimpleCollection<String> AV27OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV39WWPContext ;
   }

   public class secfunctionalityfilterparentwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000U2( IGxContext context ,
                                             String AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel ,
                                             String AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ,
                                             String AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel ,
                                             String AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription ,
                                             long AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid ,
                                             long A2SecParentFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [5] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [SecParentFunctionalityId], [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([SecParentFunctionalityId] = @AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey)) ) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityKey] like @lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityKey] = @AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription)) ) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityDescription] like @lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityDescription] = @AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [SecParentFunctionalityId], [SecFunctionalityKey]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P000U3( IGxContext context ,
                                             String AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel ,
                                             String AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey ,
                                             String AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel ,
                                             String AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription ,
                                             long AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid ,
                                             long A2SecParentFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [5] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [SecParentFunctionalityId], [SecFunctionalityDescription], [SecFunctionalityKey], [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([SecParentFunctionalityId] = @AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey)) ) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityKey] like @lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey)";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityKey] = @AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription)) ) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityDescription] like @lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)) )
         {
            sWhereString = sWhereString + " and ([SecFunctionalityDescription] = @AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [SecParentFunctionalityId], [SecFunctionalityDescription]";
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
                     return conditional_P000U2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] );
               case 1 :
                     return conditional_P000U3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] );
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
          Object[] prmP000U2 ;
          prmP000U2 = new Object[] {
          new Object[] {"@AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP000U3 ;
          prmP000U3 = new Object[] {
          new Object[] {"@AV46WWPBaseObjects_SecFunctionalityFilterParentWWDS_1_Secparentfunctionalityid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV47WWPBaseObjects_SecFunctionalityFilterParentWWDS_2_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV48WWPBaseObjects_SecFunctionalityFilterParentWWDS_3_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV49WWPBaseObjects_SecFunctionalityFilterParentWWDS_4_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50WWPBaseObjects_SecFunctionalityFilterParentWWDS_5_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000U2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000U2,100,0,true,false )
             ,new CursorDef("P000U3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000U3,100,0,true,false )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[4])[0] = rslt.getLong(4) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((long[]) buf[4])[0] = rslt.getLong(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[5]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.wwpbaseobjects.secfunctionalityfilterparentwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class secfunctionalityfilterparentwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("secfunctionalityfilterparentwwgetfilterdata") )
          {
             return  ;
          }
          secfunctionalityfilterparentwwgetfilterdata worker = new secfunctionalityfilterparentwwgetfilterdata(context) ;
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
