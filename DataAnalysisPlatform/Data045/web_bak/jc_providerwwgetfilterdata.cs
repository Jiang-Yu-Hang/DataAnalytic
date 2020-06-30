/*
               File: JC_ProviderWWGetFilterData
        Description: JC_Provider WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:41.67
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
   public class jc_providerwwgetfilterdata : GXProcedure
   {
      public jc_providerwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public jc_providerwwgetfilterdata( IGxContext context )
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
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV25DDOName = aP0_DDOName;
         this.AV23SearchTxt = aP1_SearchTxt;
         this.AV24SearchTxtTo = aP2_SearchTxtTo;
         this.AV29OptionsJson = "" ;
         this.AV32OptionsDescJson = "" ;
         this.AV34OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
         return AV34OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         jc_providerwwgetfilterdata objjc_providerwwgetfilterdata;
         objjc_providerwwgetfilterdata = new jc_providerwwgetfilterdata();
         objjc_providerwwgetfilterdata.AV25DDOName = aP0_DDOName;
         objjc_providerwwgetfilterdata.AV23SearchTxt = aP1_SearchTxt;
         objjc_providerwwgetfilterdata.AV24SearchTxtTo = aP2_SearchTxtTo;
         objjc_providerwwgetfilterdata.AV29OptionsJson = "" ;
         objjc_providerwwgetfilterdata.AV32OptionsDescJson = "" ;
         objjc_providerwwgetfilterdata.AV34OptionIndexesJson = "" ;
         objjc_providerwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objjc_providerwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objjc_providerwwgetfilterdata);
         aP3_OptionsJson=this.AV29OptionsJson;
         aP4_OptionsDescJson=this.AV32OptionsDescJson;
         aP5_OptionIndexesJson=this.AV34OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((jc_providerwwgetfilterdata)stateInfo).executePrivate();
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
         AV28Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV31OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV33OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWJC_Provider", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_JC_PROVIDERNAME") == 0 )
            {
               /* Execute user subroutine: 'LOADJC_PROVIDERNAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_JC_PROVIDERSHORTNAME") == 0 )
            {
               /* Execute user subroutine: 'LOADJC_PROVIDERSHORTNAMEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_JC_PROVIDERADDRESSS") == 0 )
            {
               /* Execute user subroutine: 'LOADJC_PROVIDERADDRESSSOPTIONS' */
               S141 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_JC_PROVIDERPHONE") == 0 )
            {
               /* Execute user subroutine: 'LOADJC_PROVIDERPHONEOPTIONS' */
               S151 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV25DDOName), "DDO_JC_PROVIDERUSER") == 0 )
            {
               /* Execute user subroutine: 'LOADJC_PROVIDERUSEROPTIONS' */
               S161 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV29OptionsJson = AV28Options.ToJSonString(false);
         AV32OptionsDescJson = AV31OptionsDesc.ToJSonString(false);
         AV34OptionIndexesJson = AV33OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV36Session.Get("JC_ProviderWWGridState"), "") == 0 )
         {
            AV38GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "JC_ProviderWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV38GridState.FromXml(AV36Session.Get("JC_ProviderWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV43GXV1 = 1;
         while ( AV43GXV1 <= AV38GridState.gxTpr_Filtervalues.Count )
         {
            AV39GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV38GridState.gxTpr_Filtervalues.Item(AV43GXV1));
            if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERID") == 0 )
            {
               AV11TFJC_ProviderID = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Value, "."));
               AV12TFJC_ProviderID_To = (long)(NumberUtil.Val( AV39GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERNAME") == 0 )
            {
               AV13TFJC_ProviderName = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERNAME_SEL") == 0 )
            {
               AV14TFJC_ProviderName_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERSHORTNAME") == 0 )
            {
               AV15TFJC_ProviderShortName = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERSHORTNAME_SEL") == 0 )
            {
               AV16TFJC_ProviderShortName_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERADDRESSS") == 0 )
            {
               AV17TFJC_ProviderAddresss = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERADDRESSS_SEL") == 0 )
            {
               AV18TFJC_ProviderAddresss_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERPHONE") == 0 )
            {
               AV19TFJC_ProviderPhone = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERPHONE_SEL") == 0 )
            {
               AV20TFJC_ProviderPhone_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERUSER") == 0 )
            {
               AV21TFJC_ProviderUser = AV39GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV39GridStateFilterValue.gxTpr_Name, "TFJC_PROVIDERUSER_SEL") == 0 )
            {
               AV22TFJC_ProviderUser_Sel = AV39GridStateFilterValue.gxTpr_Value;
            }
            AV43GXV1 = (int)(AV43GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADJC_PROVIDERNAMEOPTIONS' Routine */
         AV13TFJC_ProviderName = AV23SearchTxt;
         AV14TFJC_ProviderName_Sel = "";
         AV45JC_ProviderWWDS_1_Tfjc_providerid = AV11TFJC_ProviderID;
         AV46JC_ProviderWWDS_2_Tfjc_providerid_to = AV12TFJC_ProviderID_To;
         AV47JC_ProviderWWDS_3_Tfjc_providername = AV13TFJC_ProviderName;
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = AV14TFJC_ProviderName_Sel;
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = AV15TFJC_ProviderShortName;
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV16TFJC_ProviderShortName_Sel;
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = AV17TFJC_ProviderAddresss;
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV18TFJC_ProviderAddresss_Sel;
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = AV19TFJC_ProviderPhone;
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV20TFJC_ProviderPhone_Sel;
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = AV21TFJC_ProviderUser;
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV22TFJC_ProviderUser_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor P00492 */
         pr_default.execute(0, new Object[] {AV45JC_ProviderWWDS_1_Tfjc_providerid, AV46JC_ProviderWWDS_2_Tfjc_providerid_to, lV47JC_ProviderWWDS_3_Tfjc_providername, AV48JC_ProviderWWDS_4_Tfjc_providername_sel, lV49JC_ProviderWWDS_5_Tfjc_providershortname, AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV51JC_ProviderWWDS_7_Tfjc_provideraddresss, AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV53JC_ProviderWWDS_9_Tfjc_providerphone, AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV55JC_ProviderWWDS_11_Tfjc_provideruser, AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK492 = false;
            A89JC_ProviderName = P00492_A89JC_ProviderName[0];
            n89JC_ProviderName = P00492_n89JC_ProviderName[0];
            A163JC_ProviderUser = P00492_A163JC_ProviderUser[0];
            n163JC_ProviderUser = P00492_n163JC_ProviderUser[0];
            A162JC_ProviderPhone = P00492_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = P00492_n162JC_ProviderPhone[0];
            A161JC_ProviderAddresss = P00492_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = P00492_n161JC_ProviderAddresss[0];
            A160JC_ProviderShortName = P00492_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = P00492_n160JC_ProviderShortName[0];
            A87JC_ProviderID = P00492_A87JC_ProviderID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00492_A89JC_ProviderName[0], A89JC_ProviderName) == 0 ) )
            {
               BRK492 = false;
               A87JC_ProviderID = P00492_A87JC_ProviderID[0];
               AV35count = (long)(AV35count+1);
               BRK492 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A89JC_ProviderName)) )
            {
               AV27Option = A89JC_ProviderName;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK492 )
            {
               BRK492 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADJC_PROVIDERSHORTNAMEOPTIONS' Routine */
         AV15TFJC_ProviderShortName = AV23SearchTxt;
         AV16TFJC_ProviderShortName_Sel = "";
         AV45JC_ProviderWWDS_1_Tfjc_providerid = AV11TFJC_ProviderID;
         AV46JC_ProviderWWDS_2_Tfjc_providerid_to = AV12TFJC_ProviderID_To;
         AV47JC_ProviderWWDS_3_Tfjc_providername = AV13TFJC_ProviderName;
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = AV14TFJC_ProviderName_Sel;
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = AV15TFJC_ProviderShortName;
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV16TFJC_ProviderShortName_Sel;
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = AV17TFJC_ProviderAddresss;
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV18TFJC_ProviderAddresss_Sel;
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = AV19TFJC_ProviderPhone;
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV20TFJC_ProviderPhone_Sel;
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = AV21TFJC_ProviderUser;
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV22TFJC_ProviderUser_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor P00493 */
         pr_default.execute(1, new Object[] {AV45JC_ProviderWWDS_1_Tfjc_providerid, AV46JC_ProviderWWDS_2_Tfjc_providerid_to, lV47JC_ProviderWWDS_3_Tfjc_providername, AV48JC_ProviderWWDS_4_Tfjc_providername_sel, lV49JC_ProviderWWDS_5_Tfjc_providershortname, AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV51JC_ProviderWWDS_7_Tfjc_provideraddresss, AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV53JC_ProviderWWDS_9_Tfjc_providerphone, AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV55JC_ProviderWWDS_11_Tfjc_provideruser, AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK494 = false;
            A160JC_ProviderShortName = P00493_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = P00493_n160JC_ProviderShortName[0];
            A163JC_ProviderUser = P00493_A163JC_ProviderUser[0];
            n163JC_ProviderUser = P00493_n163JC_ProviderUser[0];
            A162JC_ProviderPhone = P00493_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = P00493_n162JC_ProviderPhone[0];
            A161JC_ProviderAddresss = P00493_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = P00493_n161JC_ProviderAddresss[0];
            A89JC_ProviderName = P00493_A89JC_ProviderName[0];
            n89JC_ProviderName = P00493_n89JC_ProviderName[0];
            A87JC_ProviderID = P00493_A87JC_ProviderID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00493_A160JC_ProviderShortName[0], A160JC_ProviderShortName) == 0 ) )
            {
               BRK494 = false;
               A87JC_ProviderID = P00493_A87JC_ProviderID[0];
               AV35count = (long)(AV35count+1);
               BRK494 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A160JC_ProviderShortName)) )
            {
               AV27Option = A160JC_ProviderShortName;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK494 )
            {
               BRK494 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADJC_PROVIDERADDRESSSOPTIONS' Routine */
         AV17TFJC_ProviderAddresss = AV23SearchTxt;
         AV18TFJC_ProviderAddresss_Sel = "";
         AV45JC_ProviderWWDS_1_Tfjc_providerid = AV11TFJC_ProviderID;
         AV46JC_ProviderWWDS_2_Tfjc_providerid_to = AV12TFJC_ProviderID_To;
         AV47JC_ProviderWWDS_3_Tfjc_providername = AV13TFJC_ProviderName;
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = AV14TFJC_ProviderName_Sel;
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = AV15TFJC_ProviderShortName;
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV16TFJC_ProviderShortName_Sel;
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = AV17TFJC_ProviderAddresss;
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV18TFJC_ProviderAddresss_Sel;
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = AV19TFJC_ProviderPhone;
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV20TFJC_ProviderPhone_Sel;
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = AV21TFJC_ProviderUser;
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV22TFJC_ProviderUser_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor P00494 */
         pr_default.execute(2, new Object[] {AV45JC_ProviderWWDS_1_Tfjc_providerid, AV46JC_ProviderWWDS_2_Tfjc_providerid_to, lV47JC_ProviderWWDS_3_Tfjc_providername, AV48JC_ProviderWWDS_4_Tfjc_providername_sel, lV49JC_ProviderWWDS_5_Tfjc_providershortname, AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV51JC_ProviderWWDS_7_Tfjc_provideraddresss, AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV53JC_ProviderWWDS_9_Tfjc_providerphone, AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV55JC_ProviderWWDS_11_Tfjc_provideruser, AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK496 = false;
            A161JC_ProviderAddresss = P00494_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = P00494_n161JC_ProviderAddresss[0];
            A163JC_ProviderUser = P00494_A163JC_ProviderUser[0];
            n163JC_ProviderUser = P00494_n163JC_ProviderUser[0];
            A162JC_ProviderPhone = P00494_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = P00494_n162JC_ProviderPhone[0];
            A160JC_ProviderShortName = P00494_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = P00494_n160JC_ProviderShortName[0];
            A89JC_ProviderName = P00494_A89JC_ProviderName[0];
            n89JC_ProviderName = P00494_n89JC_ProviderName[0];
            A87JC_ProviderID = P00494_A87JC_ProviderID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P00494_A161JC_ProviderAddresss[0], A161JC_ProviderAddresss) == 0 ) )
            {
               BRK496 = false;
               A87JC_ProviderID = P00494_A87JC_ProviderID[0];
               AV35count = (long)(AV35count+1);
               BRK496 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A161JC_ProviderAddresss)) )
            {
               AV27Option = A161JC_ProviderAddresss;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK496 )
            {
               BRK496 = true;
               pr_default.readNext(2);
            }
         }
         pr_default.close(2);
      }

      protected void S151( )
      {
         /* 'LOADJC_PROVIDERPHONEOPTIONS' Routine */
         AV19TFJC_ProviderPhone = AV23SearchTxt;
         AV20TFJC_ProviderPhone_Sel = "";
         AV45JC_ProviderWWDS_1_Tfjc_providerid = AV11TFJC_ProviderID;
         AV46JC_ProviderWWDS_2_Tfjc_providerid_to = AV12TFJC_ProviderID_To;
         AV47JC_ProviderWWDS_3_Tfjc_providername = AV13TFJC_ProviderName;
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = AV14TFJC_ProviderName_Sel;
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = AV15TFJC_ProviderShortName;
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV16TFJC_ProviderShortName_Sel;
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = AV17TFJC_ProviderAddresss;
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV18TFJC_ProviderAddresss_Sel;
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = AV19TFJC_ProviderPhone;
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV20TFJC_ProviderPhone_Sel;
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = AV21TFJC_ProviderUser;
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV22TFJC_ProviderUser_Sel;
         pr_default.dynParam(3, new Object[]{ new Object[]{
                                              AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor P00495 */
         pr_default.execute(3, new Object[] {AV45JC_ProviderWWDS_1_Tfjc_providerid, AV46JC_ProviderWWDS_2_Tfjc_providerid_to, lV47JC_ProviderWWDS_3_Tfjc_providername, AV48JC_ProviderWWDS_4_Tfjc_providername_sel, lV49JC_ProviderWWDS_5_Tfjc_providershortname, AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV51JC_ProviderWWDS_7_Tfjc_provideraddresss, AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV53JC_ProviderWWDS_9_Tfjc_providerphone, AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV55JC_ProviderWWDS_11_Tfjc_provideruser, AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         while ( (pr_default.getStatus(3) != 101) )
         {
            BRK498 = false;
            A162JC_ProviderPhone = P00495_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = P00495_n162JC_ProviderPhone[0];
            A163JC_ProviderUser = P00495_A163JC_ProviderUser[0];
            n163JC_ProviderUser = P00495_n163JC_ProviderUser[0];
            A161JC_ProviderAddresss = P00495_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = P00495_n161JC_ProviderAddresss[0];
            A160JC_ProviderShortName = P00495_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = P00495_n160JC_ProviderShortName[0];
            A89JC_ProviderName = P00495_A89JC_ProviderName[0];
            n89JC_ProviderName = P00495_n89JC_ProviderName[0];
            A87JC_ProviderID = P00495_A87JC_ProviderID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(3) != 101) && ( StringUtil.StrCmp(P00495_A162JC_ProviderPhone[0], A162JC_ProviderPhone) == 0 ) )
            {
               BRK498 = false;
               A87JC_ProviderID = P00495_A87JC_ProviderID[0];
               AV35count = (long)(AV35count+1);
               BRK498 = true;
               pr_default.readNext(3);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A162JC_ProviderPhone)) )
            {
               AV27Option = A162JC_ProviderPhone;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK498 )
            {
               BRK498 = true;
               pr_default.readNext(3);
            }
         }
         pr_default.close(3);
      }

      protected void S161( )
      {
         /* 'LOADJC_PROVIDERUSEROPTIONS' Routine */
         AV21TFJC_ProviderUser = AV23SearchTxt;
         AV22TFJC_ProviderUser_Sel = "";
         AV45JC_ProviderWWDS_1_Tfjc_providerid = AV11TFJC_ProviderID;
         AV46JC_ProviderWWDS_2_Tfjc_providerid_to = AV12TFJC_ProviderID_To;
         AV47JC_ProviderWWDS_3_Tfjc_providername = AV13TFJC_ProviderName;
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = AV14TFJC_ProviderName_Sel;
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = AV15TFJC_ProviderShortName;
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = AV16TFJC_ProviderShortName_Sel;
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = AV17TFJC_ProviderAddresss;
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = AV18TFJC_ProviderAddresss_Sel;
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = AV19TFJC_ProviderPhone;
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = AV20TFJC_ProviderPhone_Sel;
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = AV21TFJC_ProviderUser;
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = AV22TFJC_ProviderUser_Sel;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                              AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                              AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                              AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                              AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                              AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                              AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                              AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                              AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                              AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                              AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                              AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                              A87JC_ProviderID ,
                                              A89JC_ProviderName ,
                                              A160JC_ProviderShortName ,
                                              A161JC_ProviderAddresss ,
                                              A162JC_ProviderPhone ,
                                              A163JC_ProviderUser } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV47JC_ProviderWWDS_3_Tfjc_providername = StringUtil.Concat( StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername), "%", "");
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = StringUtil.Concat( StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname), "%", "");
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = StringUtil.Concat( StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss), "%", "");
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = StringUtil.PadR( StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone), 20, "%");
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = StringUtil.Concat( StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser), "%", "");
         /* Using cursor P00496 */
         pr_default.execute(4, new Object[] {AV45JC_ProviderWWDS_1_Tfjc_providerid, AV46JC_ProviderWWDS_2_Tfjc_providerid_to, lV47JC_ProviderWWDS_3_Tfjc_providername, AV48JC_ProviderWWDS_4_Tfjc_providername_sel, lV49JC_ProviderWWDS_5_Tfjc_providershortname, AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel, lV51JC_ProviderWWDS_7_Tfjc_provideraddresss, AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel, lV53JC_ProviderWWDS_9_Tfjc_providerphone, AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel, lV55JC_ProviderWWDS_11_Tfjc_provideruser, AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel});
         while ( (pr_default.getStatus(4) != 101) )
         {
            BRK4910 = false;
            A163JC_ProviderUser = P00496_A163JC_ProviderUser[0];
            n163JC_ProviderUser = P00496_n163JC_ProviderUser[0];
            A162JC_ProviderPhone = P00496_A162JC_ProviderPhone[0];
            n162JC_ProviderPhone = P00496_n162JC_ProviderPhone[0];
            A161JC_ProviderAddresss = P00496_A161JC_ProviderAddresss[0];
            n161JC_ProviderAddresss = P00496_n161JC_ProviderAddresss[0];
            A160JC_ProviderShortName = P00496_A160JC_ProviderShortName[0];
            n160JC_ProviderShortName = P00496_n160JC_ProviderShortName[0];
            A89JC_ProviderName = P00496_A89JC_ProviderName[0];
            n89JC_ProviderName = P00496_n89JC_ProviderName[0];
            A87JC_ProviderID = P00496_A87JC_ProviderID[0];
            AV35count = 0;
            while ( (pr_default.getStatus(4) != 101) && ( StringUtil.StrCmp(P00496_A163JC_ProviderUser[0], A163JC_ProviderUser) == 0 ) )
            {
               BRK4910 = false;
               A87JC_ProviderID = P00496_A87JC_ProviderID[0];
               AV35count = (long)(AV35count+1);
               BRK4910 = true;
               pr_default.readNext(4);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A163JC_ProviderUser)) )
            {
               AV27Option = A163JC_ProviderUser;
               AV28Options.Add(AV27Option, 0);
               AV33OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV35count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV28Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK4910 )
            {
               BRK4910 = true;
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
         AV28Options = new GxSimpleCollection<String>();
         AV31OptionsDesc = new GxSimpleCollection<String>();
         AV33OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV36Session = context.GetSession();
         AV38GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV39GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV13TFJC_ProviderName = "";
         AV14TFJC_ProviderName_Sel = "";
         AV15TFJC_ProviderShortName = "";
         AV16TFJC_ProviderShortName_Sel = "";
         AV17TFJC_ProviderAddresss = "";
         AV18TFJC_ProviderAddresss_Sel = "";
         AV19TFJC_ProviderPhone = "";
         AV20TFJC_ProviderPhone_Sel = "";
         AV21TFJC_ProviderUser = "";
         AV22TFJC_ProviderUser_Sel = "";
         AV47JC_ProviderWWDS_3_Tfjc_providername = "";
         AV48JC_ProviderWWDS_4_Tfjc_providername_sel = "";
         AV49JC_ProviderWWDS_5_Tfjc_providershortname = "";
         AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel = "";
         AV51JC_ProviderWWDS_7_Tfjc_provideraddresss = "";
         AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel = "";
         AV53JC_ProviderWWDS_9_Tfjc_providerphone = "";
         AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel = "";
         AV55JC_ProviderWWDS_11_Tfjc_provideruser = "";
         AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel = "";
         scmdbuf = "";
         lV47JC_ProviderWWDS_3_Tfjc_providername = "";
         lV49JC_ProviderWWDS_5_Tfjc_providershortname = "";
         lV51JC_ProviderWWDS_7_Tfjc_provideraddresss = "";
         lV53JC_ProviderWWDS_9_Tfjc_providerphone = "";
         lV55JC_ProviderWWDS_11_Tfjc_provideruser = "";
         A89JC_ProviderName = "";
         A160JC_ProviderShortName = "";
         A161JC_ProviderAddresss = "";
         A162JC_ProviderPhone = "";
         A163JC_ProviderUser = "";
         P00492_A89JC_ProviderName = new String[] {""} ;
         P00492_n89JC_ProviderName = new bool[] {false} ;
         P00492_A163JC_ProviderUser = new String[] {""} ;
         P00492_n163JC_ProviderUser = new bool[] {false} ;
         P00492_A162JC_ProviderPhone = new String[] {""} ;
         P00492_n162JC_ProviderPhone = new bool[] {false} ;
         P00492_A161JC_ProviderAddresss = new String[] {""} ;
         P00492_n161JC_ProviderAddresss = new bool[] {false} ;
         P00492_A160JC_ProviderShortName = new String[] {""} ;
         P00492_n160JC_ProviderShortName = new bool[] {false} ;
         P00492_A87JC_ProviderID = new long[1] ;
         AV27Option = "";
         P00493_A160JC_ProviderShortName = new String[] {""} ;
         P00493_n160JC_ProviderShortName = new bool[] {false} ;
         P00493_A163JC_ProviderUser = new String[] {""} ;
         P00493_n163JC_ProviderUser = new bool[] {false} ;
         P00493_A162JC_ProviderPhone = new String[] {""} ;
         P00493_n162JC_ProviderPhone = new bool[] {false} ;
         P00493_A161JC_ProviderAddresss = new String[] {""} ;
         P00493_n161JC_ProviderAddresss = new bool[] {false} ;
         P00493_A89JC_ProviderName = new String[] {""} ;
         P00493_n89JC_ProviderName = new bool[] {false} ;
         P00493_A87JC_ProviderID = new long[1] ;
         P00494_A161JC_ProviderAddresss = new String[] {""} ;
         P00494_n161JC_ProviderAddresss = new bool[] {false} ;
         P00494_A163JC_ProviderUser = new String[] {""} ;
         P00494_n163JC_ProviderUser = new bool[] {false} ;
         P00494_A162JC_ProviderPhone = new String[] {""} ;
         P00494_n162JC_ProviderPhone = new bool[] {false} ;
         P00494_A160JC_ProviderShortName = new String[] {""} ;
         P00494_n160JC_ProviderShortName = new bool[] {false} ;
         P00494_A89JC_ProviderName = new String[] {""} ;
         P00494_n89JC_ProviderName = new bool[] {false} ;
         P00494_A87JC_ProviderID = new long[1] ;
         P00495_A162JC_ProviderPhone = new String[] {""} ;
         P00495_n162JC_ProviderPhone = new bool[] {false} ;
         P00495_A163JC_ProviderUser = new String[] {""} ;
         P00495_n163JC_ProviderUser = new bool[] {false} ;
         P00495_A161JC_ProviderAddresss = new String[] {""} ;
         P00495_n161JC_ProviderAddresss = new bool[] {false} ;
         P00495_A160JC_ProviderShortName = new String[] {""} ;
         P00495_n160JC_ProviderShortName = new bool[] {false} ;
         P00495_A89JC_ProviderName = new String[] {""} ;
         P00495_n89JC_ProviderName = new bool[] {false} ;
         P00495_A87JC_ProviderID = new long[1] ;
         P00496_A163JC_ProviderUser = new String[] {""} ;
         P00496_n163JC_ProviderUser = new bool[] {false} ;
         P00496_A162JC_ProviderPhone = new String[] {""} ;
         P00496_n162JC_ProviderPhone = new bool[] {false} ;
         P00496_A161JC_ProviderAddresss = new String[] {""} ;
         P00496_n161JC_ProviderAddresss = new bool[] {false} ;
         P00496_A160JC_ProviderShortName = new String[] {""} ;
         P00496_n160JC_ProviderShortName = new bool[] {false} ;
         P00496_A89JC_ProviderName = new String[] {""} ;
         P00496_n89JC_ProviderName = new bool[] {false} ;
         P00496_A87JC_ProviderID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.jc_providerwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00492_A89JC_ProviderName, P00492_n89JC_ProviderName, P00492_A163JC_ProviderUser, P00492_n163JC_ProviderUser, P00492_A162JC_ProviderPhone, P00492_n162JC_ProviderPhone, P00492_A161JC_ProviderAddresss, P00492_n161JC_ProviderAddresss, P00492_A160JC_ProviderShortName, P00492_n160JC_ProviderShortName,
               P00492_A87JC_ProviderID
               }
               , new Object[] {
               P00493_A160JC_ProviderShortName, P00493_n160JC_ProviderShortName, P00493_A163JC_ProviderUser, P00493_n163JC_ProviderUser, P00493_A162JC_ProviderPhone, P00493_n162JC_ProviderPhone, P00493_A161JC_ProviderAddresss, P00493_n161JC_ProviderAddresss, P00493_A89JC_ProviderName, P00493_n89JC_ProviderName,
               P00493_A87JC_ProviderID
               }
               , new Object[] {
               P00494_A161JC_ProviderAddresss, P00494_n161JC_ProviderAddresss, P00494_A163JC_ProviderUser, P00494_n163JC_ProviderUser, P00494_A162JC_ProviderPhone, P00494_n162JC_ProviderPhone, P00494_A160JC_ProviderShortName, P00494_n160JC_ProviderShortName, P00494_A89JC_ProviderName, P00494_n89JC_ProviderName,
               P00494_A87JC_ProviderID
               }
               , new Object[] {
               P00495_A162JC_ProviderPhone, P00495_n162JC_ProviderPhone, P00495_A163JC_ProviderUser, P00495_n163JC_ProviderUser, P00495_A161JC_ProviderAddresss, P00495_n161JC_ProviderAddresss, P00495_A160JC_ProviderShortName, P00495_n160JC_ProviderShortName, P00495_A89JC_ProviderName, P00495_n89JC_ProviderName,
               P00495_A87JC_ProviderID
               }
               , new Object[] {
               P00496_A163JC_ProviderUser, P00496_n163JC_ProviderUser, P00496_A162JC_ProviderPhone, P00496_n162JC_ProviderPhone, P00496_A161JC_ProviderAddresss, P00496_n161JC_ProviderAddresss, P00496_A160JC_ProviderShortName, P00496_n160JC_ProviderShortName, P00496_A89JC_ProviderName, P00496_n89JC_ProviderName,
               P00496_A87JC_ProviderID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV43GXV1 ;
      private long AV11TFJC_ProviderID ;
      private long AV12TFJC_ProviderID_To ;
      private long AV45JC_ProviderWWDS_1_Tfjc_providerid ;
      private long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ;
      private long A87JC_ProviderID ;
      private long AV35count ;
      private String AV19TFJC_ProviderPhone ;
      private String AV20TFJC_ProviderPhone_Sel ;
      private String AV53JC_ProviderWWDS_9_Tfjc_providerphone ;
      private String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ;
      private String scmdbuf ;
      private String lV53JC_ProviderWWDS_9_Tfjc_providerphone ;
      private String A162JC_ProviderPhone ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK492 ;
      private bool n89JC_ProviderName ;
      private bool n163JC_ProviderUser ;
      private bool n162JC_ProviderPhone ;
      private bool n161JC_ProviderAddresss ;
      private bool n160JC_ProviderShortName ;
      private bool BRK494 ;
      private bool BRK496 ;
      private bool BRK498 ;
      private bool BRK4910 ;
      private String AV34OptionIndexesJson ;
      private String AV29OptionsJson ;
      private String AV32OptionsDescJson ;
      private String AV25DDOName ;
      private String AV23SearchTxt ;
      private String AV24SearchTxtTo ;
      private String AV13TFJC_ProviderName ;
      private String AV14TFJC_ProviderName_Sel ;
      private String AV15TFJC_ProviderShortName ;
      private String AV16TFJC_ProviderShortName_Sel ;
      private String AV17TFJC_ProviderAddresss ;
      private String AV18TFJC_ProviderAddresss_Sel ;
      private String AV21TFJC_ProviderUser ;
      private String AV22TFJC_ProviderUser_Sel ;
      private String AV47JC_ProviderWWDS_3_Tfjc_providername ;
      private String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ;
      private String AV49JC_ProviderWWDS_5_Tfjc_providershortname ;
      private String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ;
      private String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ;
      private String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ;
      private String AV55JC_ProviderWWDS_11_Tfjc_provideruser ;
      private String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ;
      private String lV47JC_ProviderWWDS_3_Tfjc_providername ;
      private String lV49JC_ProviderWWDS_5_Tfjc_providershortname ;
      private String lV51JC_ProviderWWDS_7_Tfjc_provideraddresss ;
      private String lV55JC_ProviderWWDS_11_Tfjc_provideruser ;
      private String A89JC_ProviderName ;
      private String A160JC_ProviderShortName ;
      private String A161JC_ProviderAddresss ;
      private String A163JC_ProviderUser ;
      private String AV27Option ;
      private IGxSession AV36Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00492_A89JC_ProviderName ;
      private bool[] P00492_n89JC_ProviderName ;
      private String[] P00492_A163JC_ProviderUser ;
      private bool[] P00492_n163JC_ProviderUser ;
      private String[] P00492_A162JC_ProviderPhone ;
      private bool[] P00492_n162JC_ProviderPhone ;
      private String[] P00492_A161JC_ProviderAddresss ;
      private bool[] P00492_n161JC_ProviderAddresss ;
      private String[] P00492_A160JC_ProviderShortName ;
      private bool[] P00492_n160JC_ProviderShortName ;
      private long[] P00492_A87JC_ProviderID ;
      private String[] P00493_A160JC_ProviderShortName ;
      private bool[] P00493_n160JC_ProviderShortName ;
      private String[] P00493_A163JC_ProviderUser ;
      private bool[] P00493_n163JC_ProviderUser ;
      private String[] P00493_A162JC_ProviderPhone ;
      private bool[] P00493_n162JC_ProviderPhone ;
      private String[] P00493_A161JC_ProviderAddresss ;
      private bool[] P00493_n161JC_ProviderAddresss ;
      private String[] P00493_A89JC_ProviderName ;
      private bool[] P00493_n89JC_ProviderName ;
      private long[] P00493_A87JC_ProviderID ;
      private String[] P00494_A161JC_ProviderAddresss ;
      private bool[] P00494_n161JC_ProviderAddresss ;
      private String[] P00494_A163JC_ProviderUser ;
      private bool[] P00494_n163JC_ProviderUser ;
      private String[] P00494_A162JC_ProviderPhone ;
      private bool[] P00494_n162JC_ProviderPhone ;
      private String[] P00494_A160JC_ProviderShortName ;
      private bool[] P00494_n160JC_ProviderShortName ;
      private String[] P00494_A89JC_ProviderName ;
      private bool[] P00494_n89JC_ProviderName ;
      private long[] P00494_A87JC_ProviderID ;
      private String[] P00495_A162JC_ProviderPhone ;
      private bool[] P00495_n162JC_ProviderPhone ;
      private String[] P00495_A163JC_ProviderUser ;
      private bool[] P00495_n163JC_ProviderUser ;
      private String[] P00495_A161JC_ProviderAddresss ;
      private bool[] P00495_n161JC_ProviderAddresss ;
      private String[] P00495_A160JC_ProviderShortName ;
      private bool[] P00495_n160JC_ProviderShortName ;
      private String[] P00495_A89JC_ProviderName ;
      private bool[] P00495_n89JC_ProviderName ;
      private long[] P00495_A87JC_ProviderID ;
      private String[] P00496_A163JC_ProviderUser ;
      private bool[] P00496_n163JC_ProviderUser ;
      private String[] P00496_A162JC_ProviderPhone ;
      private bool[] P00496_n162JC_ProviderPhone ;
      private String[] P00496_A161JC_ProviderAddresss ;
      private bool[] P00496_n161JC_ProviderAddresss ;
      private String[] P00496_A160JC_ProviderShortName ;
      private bool[] P00496_n160JC_ProviderShortName ;
      private String[] P00496_A89JC_ProviderName ;
      private bool[] P00496_n89JC_ProviderName ;
      private long[] P00496_A87JC_ProviderID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV28Options ;
      private GxSimpleCollection<String> AV31OptionsDesc ;
      private GxSimpleCollection<String> AV33OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV38GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV39GridStateFilterValue ;
   }

   public class jc_providerwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00492( IGxContext context ,
                                             long AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [12] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderName], [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderAddresss], [JC_ProviderShortName], [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV45JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV46JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int2[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int2[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int2[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [JC_ProviderName]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00493( IGxContext context ,
                                             long AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderShortName], [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderAddresss], [JC_ProviderName], [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV45JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV46JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [JC_ProviderShortName]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P00494( IGxContext context ,
                                             long AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [12] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderAddresss], [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderShortName], [JC_ProviderName], [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV45JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV46JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [JC_ProviderAddresss]";
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      protected Object[] conditional_P00495( IGxContext context ,
                                             long AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int8 ;
         GXv_int8 = new short [12] ;
         Object[] GXv_Object9 ;
         GXv_Object9 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderPhone], [JC_ProviderUser], [JC_ProviderAddresss], [JC_ProviderShortName], [JC_ProviderName], [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV45JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int8[0] = 1;
         }
         if ( ! (0==AV46JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int8[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int8[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int8[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int8[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int8[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int8[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int8[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int8[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int8[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int8[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
         }
         else
         {
            GXv_int8[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [JC_ProviderPhone]";
         GXv_Object9[0] = scmdbuf;
         GXv_Object9[1] = GXv_int8;
         return GXv_Object9 ;
      }

      protected Object[] conditional_P00496( IGxContext context ,
                                             long AV45JC_ProviderWWDS_1_Tfjc_providerid ,
                                             long AV46JC_ProviderWWDS_2_Tfjc_providerid_to ,
                                             String AV48JC_ProviderWWDS_4_Tfjc_providername_sel ,
                                             String AV47JC_ProviderWWDS_3_Tfjc_providername ,
                                             String AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel ,
                                             String AV49JC_ProviderWWDS_5_Tfjc_providershortname ,
                                             String AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel ,
                                             String AV51JC_ProviderWWDS_7_Tfjc_provideraddresss ,
                                             String AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel ,
                                             String AV53JC_ProviderWWDS_9_Tfjc_providerphone ,
                                             String AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel ,
                                             String AV55JC_ProviderWWDS_11_Tfjc_provideruser ,
                                             long A87JC_ProviderID ,
                                             String A89JC_ProviderName ,
                                             String A160JC_ProviderShortName ,
                                             String A161JC_ProviderAddresss ,
                                             String A162JC_ProviderPhone ,
                                             String A163JC_ProviderUser )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int10 ;
         GXv_int10 = new short [12] ;
         Object[] GXv_Object11 ;
         GXv_Object11 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderUser], [JC_ProviderPhone], [JC_ProviderAddresss], [JC_ProviderShortName], [JC_ProviderName], [JC_ProviderID] FROM [JC_Provider] WITH (NOLOCK)";
         if ( ! (0==AV45JC_ProviderWWDS_1_Tfjc_providerid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] >= @AV45JC_ProviderWWDS_1_Tfjc_providerid)";
            }
         }
         else
         {
            GXv_int10[0] = 1;
         }
         if ( ! (0==AV46JC_ProviderWWDS_2_Tfjc_providerid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderID] <= @AV46JC_ProviderWWDS_2_Tfjc_providerid_to)";
            }
         }
         else
         {
            GXv_int10[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47JC_ProviderWWDS_3_Tfjc_providername)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] like @lV47JC_ProviderWWDS_3_Tfjc_providername)";
            }
         }
         else
         {
            GXv_int10[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48JC_ProviderWWDS_4_Tfjc_providername_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderName] = @AV48JC_ProviderWWDS_4_Tfjc_providername_sel)";
            }
         }
         else
         {
            GXv_int10[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV49JC_ProviderWWDS_5_Tfjc_providershortname)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] like @lV49JC_ProviderWWDS_5_Tfjc_providershortname)";
            }
         }
         else
         {
            GXv_int10[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderShortName] = @AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel)";
            }
         }
         else
         {
            GXv_int10[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51JC_ProviderWWDS_7_Tfjc_provideraddresss)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] like @lV51JC_ProviderWWDS_7_Tfjc_provideraddresss)";
            }
         }
         else
         {
            GXv_int10[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderAddresss] = @AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel)";
            }
         }
         else
         {
            GXv_int10[7] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV53JC_ProviderWWDS_9_Tfjc_providerphone)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] like @lV53JC_ProviderWWDS_9_Tfjc_providerphone)";
            }
         }
         else
         {
            GXv_int10[8] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderPhone] = @AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel)";
            }
         }
         else
         {
            GXv_int10[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55JC_ProviderWWDS_11_Tfjc_provideruser)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] like @lV55JC_ProviderWWDS_11_Tfjc_provideruser)";
            }
         }
         else
         {
            GXv_int10[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([JC_ProviderUser] = @AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel)";
            }
         }
         else
         {
            GXv_int10[11] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [JC_ProviderUser]";
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
                     return conditional_P00492(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 1 :
                     return conditional_P00493(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 2 :
                     return conditional_P00494(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 3 :
                     return conditional_P00495(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
               case 4 :
                     return conditional_P00496(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (String)dynConstraints[16] , (String)dynConstraints[17] );
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
          Object[] prmP00492 ;
          prmP00492 = new Object[] {
          new Object[] {"@AV45JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV49JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV53JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP00493 ;
          prmP00493 = new Object[] {
          new Object[] {"@AV45JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV49JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV53JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP00494 ;
          prmP00494 = new Object[] {
          new Object[] {"@AV45JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV49JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV53JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP00495 ;
          prmP00495 = new Object[] {
          new Object[] {"@AV45JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV49JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV53JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          Object[] prmP00496 ;
          prmP00496 = new Object[] {
          new Object[] {"@AV45JC_ProviderWWDS_1_Tfjc_providerid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV46JC_ProviderWWDS_2_Tfjc_providerid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV47JC_ProviderWWDS_3_Tfjc_providername",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48JC_ProviderWWDS_4_Tfjc_providername_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV49JC_ProviderWWDS_5_Tfjc_providershortname",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV50JC_ProviderWWDS_6_Tfjc_providershortname_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV51JC_ProviderWWDS_7_Tfjc_provideraddresss",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@AV52JC_ProviderWWDS_8_Tfjc_provideraddresss_sel",SqlDbType.NVarChar,1024,0} ,
          new Object[] {"@lV53JC_ProviderWWDS_9_Tfjc_providerphone",SqlDbType.NChar,20,0} ,
          new Object[] {"@AV54JC_ProviderWWDS_10_Tfjc_providerphone_sel",SqlDbType.NChar,20,0} ,
          new Object[] {"@lV55JC_ProviderWWDS_11_Tfjc_provideruser",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV56JC_ProviderWWDS_12_Tfjc_provideruser_sel",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00492", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00492,100,0,true,false )
             ,new CursorDef("P00493", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00493,100,0,true,false )
             ,new CursorDef("P00494", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00494,100,0,true,false )
             ,new CursorDef("P00495", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00495,100,0,true,false )
             ,new CursorDef("P00496", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00496,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getString(3, 20) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 20) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getString(3, 20) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                return;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
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
                return;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 20) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 3 :
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
             case 4 :
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
                   stmt.SetParameter(sIdx, (String)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
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
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[23]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.jc_providerwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class jc_providerwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("jc_providerwwgetfilterdata") )
          {
             return  ;
          }
          jc_providerwwgetfilterdata worker = new jc_providerwwgetfilterdata(context) ;
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
