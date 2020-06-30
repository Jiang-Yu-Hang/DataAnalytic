/*
               File: WWPBaseObjects.SecFunctionalityWWGetFilterData
        Description: Sec Functionality WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.72
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
   public class secfunctionalitywwgetfilterdata : GXProcedure
   {
      public secfunctionalitywwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalitywwgetfilterdata( IGxContext context )
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
         secfunctionalitywwgetfilterdata objsecfunctionalitywwgetfilterdata;
         objsecfunctionalitywwgetfilterdata = new secfunctionalitywwgetfilterdata();
         objsecfunctionalitywwgetfilterdata.AV19DDOName = aP0_DDOName;
         objsecfunctionalitywwgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objsecfunctionalitywwgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objsecfunctionalitywwgetfilterdata.AV23OptionsJson = "" ;
         objsecfunctionalitywwgetfilterdata.AV26OptionsDescJson = "" ;
         objsecfunctionalitywwgetfilterdata.AV28OptionIndexesJson = "" ;
         objsecfunctionalitywwgetfilterdata.context.SetSubmitInitialConfig(context);
         objsecfunctionalitywwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecfunctionalitywwgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secfunctionalitywwgetfilterdata)stateInfo).executePrivate();
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
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV38WWPContext) ;
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
         if ( StringUtil.StrCmp(AV30Session.Get("WWPBaseObjects.SecFunctionalityWWGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WWPBaseObjects.SecFunctionalityWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("WWPBaseObjects.SecFunctionalityWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV44GXV1 = 1;
         while ( AV44GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV44GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYKEY") == 0 )
            {
               AV41SecFunctionalityKey = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYDESCRIPTION") == 0 )
            {
               AV37SecFunctionalityDescription = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY") == 0 )
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
            AV44GXV1 = (int)(AV44GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSECFUNCTIONALITYKEYOPTIONS' Routine */
         AV10TFSecFunctionalityKey = AV17SearchTxt;
         AV11TFSecFunctionalityKey_Sel = "";
         AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV41SecFunctionalityKey;
         AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV37SecFunctionalityDescription;
         AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV10TFSecFunctionalityKey;
         AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV11TFSecFunctionalityKey_Sel;
         AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV12TFSecFunctionalityDescription;
         AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV13TFSecFunctionalityDescription_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                              AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                              AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                              AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                              AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                              AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                              A3SecFunctionalityKey ,
                                              A8SecFunctionalityDescription } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey), "%", "");
         lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription), "%", "");
         lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey), "%", "");
         lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription), "%", "");
         /* Using cursor P000Z2 */
         pr_default.execute(0, new Object[] {lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey, lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription, lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey, AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel, lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription, AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0Z2 = false;
            A3SecFunctionalityKey = P000Z2_A3SecFunctionalityKey[0];
            A8SecFunctionalityDescription = P000Z2_A8SecFunctionalityDescription[0];
            A1SecFunctionalityId = P000Z2_A1SecFunctionalityId[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P000Z2_A3SecFunctionalityKey[0], A3SecFunctionalityKey) == 0 ) )
            {
               BRK0Z2 = false;
               A1SecFunctionalityId = P000Z2_A1SecFunctionalityId[0];
               AV29count = (long)(AV29count+1);
               BRK0Z2 = true;
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
            if ( ! BRK0Z2 )
            {
               BRK0Z2 = true;
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
         AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = AV41SecFunctionalityKey;
         AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = AV37SecFunctionalityDescription;
         AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = AV10TFSecFunctionalityKey;
         AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = AV11TFSecFunctionalityKey_Sel;
         AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = AV12TFSecFunctionalityDescription;
         AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = AV13TFSecFunctionalityDescription_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                              AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                              AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                              AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                              AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                              AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                              A3SecFunctionalityKey ,
                                              A8SecFunctionalityDescription } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING
                                              }
         } ) ;
         lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey), "%", "");
         lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription), "%", "");
         lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = StringUtil.Concat( StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey), "%", "");
         lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = StringUtil.Concat( StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription), "%", "");
         /* Using cursor P000Z3 */
         pr_default.execute(1, new Object[] {lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey, lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription, lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey, AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel, lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription, AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK0Z4 = false;
            A8SecFunctionalityDescription = P000Z3_A8SecFunctionalityDescription[0];
            A3SecFunctionalityKey = P000Z3_A3SecFunctionalityKey[0];
            A1SecFunctionalityId = P000Z3_A1SecFunctionalityId[0];
            AV29count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P000Z3_A8SecFunctionalityDescription[0], A8SecFunctionalityDescription) == 0 ) )
            {
               BRK0Z4 = false;
               A1SecFunctionalityId = P000Z3_A1SecFunctionalityId[0];
               AV29count = (long)(AV29count+1);
               BRK0Z4 = true;
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
            if ( ! BRK0Z4 )
            {
               BRK0Z4 = true;
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
         AV38WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV30Session = context.GetSession();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV41SecFunctionalityKey = "";
         AV37SecFunctionalityDescription = "";
         AV10TFSecFunctionalityKey = "";
         AV11TFSecFunctionalityKey_Sel = "";
         AV12TFSecFunctionalityDescription = "";
         AV13TFSecFunctionalityDescription_Sel = "";
         AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = "";
         AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = "";
         AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = "";
         AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel = "";
         AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = "";
         AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel = "";
         scmdbuf = "";
         lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey = "";
         lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription = "";
         lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey = "";
         lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription = "";
         A3SecFunctionalityKey = "";
         A8SecFunctionalityDescription = "";
         P000Z2_A3SecFunctionalityKey = new String[] {""} ;
         P000Z2_A8SecFunctionalityDescription = new String[] {""} ;
         P000Z2_A1SecFunctionalityId = new long[1] ;
         AV21Option = "";
         P000Z3_A8SecFunctionalityDescription = new String[] {""} ;
         P000Z3_A3SecFunctionalityKey = new String[] {""} ;
         P000Z3_A1SecFunctionalityId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalitywwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000Z2_A3SecFunctionalityKey, P000Z2_A8SecFunctionalityDescription, P000Z2_A1SecFunctionalityId
               }
               , new Object[] {
               P000Z3_A8SecFunctionalityDescription, P000Z3_A3SecFunctionalityKey, P000Z3_A1SecFunctionalityId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV44GXV1 ;
      private long A1SecFunctionalityId ;
      private long AV29count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK0Z2 ;
      private bool BRK0Z4 ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV41SecFunctionalityKey ;
      private String AV37SecFunctionalityDescription ;
      private String AV10TFSecFunctionalityKey ;
      private String AV11TFSecFunctionalityKey_Sel ;
      private String AV12TFSecFunctionalityDescription ;
      private String AV13TFSecFunctionalityDescription_Sel ;
      private String AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ;
      private String AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ;
      private String AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ;
      private String AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ;
      private String AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ;
      private String AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ;
      private String lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ;
      private String lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ;
      private String lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ;
      private String lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ;
      private String A3SecFunctionalityKey ;
      private String A8SecFunctionalityDescription ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000Z2_A3SecFunctionalityKey ;
      private String[] P000Z2_A8SecFunctionalityDescription ;
      private long[] P000Z2_A1SecFunctionalityId ;
      private String[] P000Z3_A8SecFunctionalityDescription ;
      private String[] P000Z3_A3SecFunctionalityKey ;
      private long[] P000Z3_A1SecFunctionalityId ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV22Options ;
      private GxSimpleCollection<String> AV25OptionsDesc ;
      private GxSimpleCollection<String> AV27OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV38WWPContext ;
   }

   public class secfunctionalitywwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000Z2( IGxContext context ,
                                             String AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                             String AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                             String AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                             String AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                             String AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                             String AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [6] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [SecFunctionalityKey], [SecFunctionalityDescription], [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] like '%' + @lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] like '%' + @lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] like '%' + @lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] like '%' + @lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] like @lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] like @lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] = @AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] = @AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] like @lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] like @lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] = @AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] = @AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [SecFunctionalityKey]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P000Z3( IGxContext context ,
                                             String AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey ,
                                             String AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription ,
                                             String AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel ,
                                             String AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey ,
                                             String AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel ,
                                             String AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription ,
                                             String A3SecFunctionalityKey ,
                                             String A8SecFunctionalityDescription )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [6] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [SecFunctionalityDescription], [SecFunctionalityKey], [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] like '%' + @lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] like '%' + @lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey + '%')";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] like '%' + @lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] like '%' + @lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription + '%')";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] like @lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] like @lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityKey] = @AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityKey] = @AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] like @lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] like @lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([SecFunctionalityDescription] = @AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([SecFunctionalityDescription] = @AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [SecFunctionalityDescription]";
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
                     return conditional_P000Z2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] );
               case 1 :
                     return conditional_P000Z3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] );
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
          Object[] prmP000Z2 ;
          prmP000Z2 = new Object[] {
          new Object[] {"@lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP000Z3 ;
          prmP000Z3 = new Object[] {
          new Object[] {"@lV46WWPBaseObjects_SecFunctionalityWWDS_1_Secfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV47WWPBaseObjects_SecFunctionalityWWDS_2_Secfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV48WWPBaseObjects_SecFunctionalityWWDS_3_Tfsecfunctionalitykey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV49WWPBaseObjects_SecFunctionalityWWDS_4_Tfsecfunctionalitykey_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV50WWPBaseObjects_SecFunctionalityWWDS_5_Tfsecfunctionalitydescription",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV51WWPBaseObjects_SecFunctionalityWWDS_6_Tfsecfunctionalitydescription_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z2,100,0,true,false )
             ,new CursorDef("P000Z3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z3,100,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((long[]) buf[2])[0] = rslt.getLong(3) ;
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
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
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
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.wwpbaseobjects.secfunctionalitywwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class secfunctionalitywwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("secfunctionalitywwgetfilterdata") )
          {
             return  ;
          }
          secfunctionalitywwgetfilterdata worker = new secfunctionalitywwgetfilterdata(context) ;
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
