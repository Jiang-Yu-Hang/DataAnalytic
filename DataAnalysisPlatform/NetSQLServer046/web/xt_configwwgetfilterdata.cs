/*
               File: XT_ConfigWWGetFilterData
        Description: XT_Config WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:17.61
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
   public class xt_configwwgetfilterdata : GXProcedure
   {
      public xt_configwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_configwwgetfilterdata( IGxContext context )
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
         xt_configwwgetfilterdata objxt_configwwgetfilterdata;
         objxt_configwwgetfilterdata = new xt_configwwgetfilterdata();
         objxt_configwwgetfilterdata.AV21DDOName = aP0_DDOName;
         objxt_configwwgetfilterdata.AV19SearchTxt = aP1_SearchTxt;
         objxt_configwwgetfilterdata.AV20SearchTxtTo = aP2_SearchTxtTo;
         objxt_configwwgetfilterdata.AV25OptionsJson = "" ;
         objxt_configwwgetfilterdata.AV28OptionsDescJson = "" ;
         objxt_configwwgetfilterdata.AV30OptionIndexesJson = "" ;
         objxt_configwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objxt_configwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objxt_configwwgetfilterdata);
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((xt_configwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWXT_Config", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_XT_CONFIGKEY") == 0 )
            {
               /* Execute user subroutine: 'LOADXT_CONFIGKEYOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_XT_CONFIGVALUE1") == 0 )
            {
               /* Execute user subroutine: 'LOADXT_CONFIGVALUE1OPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_XT_CONFIGVALUE2") == 0 )
            {
               /* Execute user subroutine: 'LOADXT_CONFIGVALUE2OPTIONS' */
               S141 ();
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
         if ( StringUtil.StrCmp(AV32Session.Get("XT_ConfigWWGridState"), "") == 0 )
         {
            AV34GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "XT_ConfigWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV34GridState.FromXml(AV32Session.Get("XT_ConfigWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV39GXV1 = 1;
         while ( AV39GXV1 <= AV34GridState.gxTpr_Filtervalues.Count )
         {
            AV35GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV34GridState.gxTpr_Filtervalues.Item(AV39GXV1));
            if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGID") == 0 )
            {
               AV11TFXT_ConfigID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
               AV12TFXT_ConfigID_To = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGKEY") == 0 )
            {
               AV13TFXT_ConfigKey = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGKEY_SEL") == 0 )
            {
               AV14TFXT_ConfigKey_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE1") == 0 )
            {
               AV15TFXT_ConfigValue1 = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE1_SEL") == 0 )
            {
               AV16TFXT_ConfigValue1_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE2") == 0 )
            {
               AV17TFXT_ConfigValue2 = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFXT_CONFIGVALUE2_SEL") == 0 )
            {
               AV18TFXT_ConfigValue2_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            AV39GXV1 = (int)(AV39GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADXT_CONFIGKEYOPTIONS' Routine */
         AV13TFXT_ConfigKey = AV19SearchTxt;
         AV14TFXT_ConfigKey_Sel = "";
         AV41XT_ConfigWWDS_1_Tfxt_configid = AV11TFXT_ConfigID;
         AV42XT_ConfigWWDS_2_Tfxt_configid_to = AV12TFXT_ConfigID_To;
         AV43XT_ConfigWWDS_3_Tfxt_configkey = AV13TFXT_ConfigKey;
         AV44XT_ConfigWWDS_4_Tfxt_configkey_sel = AV14TFXT_ConfigKey_Sel;
         AV45XT_ConfigWWDS_5_Tfxt_configvalue1 = AV15TFXT_ConfigValue1;
         AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV16TFXT_ConfigValue1_Sel;
         AV47XT_ConfigWWDS_7_Tfxt_configvalue2 = AV17TFXT_ConfigValue2;
         AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV18TFXT_ConfigValue2_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                              AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                              AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                              AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                              AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                              AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                              AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                              AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                              A195XT_ConfigID ,
                                              A196XT_ConfigKey ,
                                              A197XT_ConfigValue1 ,
                                              A198XT_ConfigValue2 } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV43XT_ConfigWWDS_3_Tfxt_configkey = StringUtil.Concat( StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey), "%", "");
         lV45XT_ConfigWWDS_5_Tfxt_configvalue1 = StringUtil.Concat( StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1), "%", "");
         lV47XT_ConfigWWDS_7_Tfxt_configvalue2 = StringUtil.Concat( StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2), "%", "");
         /* Using cursor P00372 */
         pr_default.execute(0, new Object[] {AV41XT_ConfigWWDS_1_Tfxt_configid, AV42XT_ConfigWWDS_2_Tfxt_configid_to, lV43XT_ConfigWWDS_3_Tfxt_configkey, AV44XT_ConfigWWDS_4_Tfxt_configkey_sel, lV45XT_ConfigWWDS_5_Tfxt_configvalue1, AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel, lV47XT_ConfigWWDS_7_Tfxt_configvalue2, AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK372 = false;
            A196XT_ConfigKey = P00372_A196XT_ConfigKey[0];
            n196XT_ConfigKey = P00372_n196XT_ConfigKey[0];
            A198XT_ConfigValue2 = P00372_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = P00372_n198XT_ConfigValue2[0];
            A197XT_ConfigValue1 = P00372_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = P00372_n197XT_ConfigValue1[0];
            A195XT_ConfigID = P00372_A195XT_ConfigID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P00372_A196XT_ConfigKey[0], A196XT_ConfigKey) == 0 ) )
            {
               BRK372 = false;
               A195XT_ConfigID = P00372_A195XT_ConfigID[0];
               AV31count = (long)(AV31count+1);
               BRK372 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A196XT_ConfigKey)) )
            {
               AV23Option = A196XT_ConfigKey;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK372 )
            {
               BRK372 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADXT_CONFIGVALUE1OPTIONS' Routine */
         AV15TFXT_ConfigValue1 = AV19SearchTxt;
         AV16TFXT_ConfigValue1_Sel = "";
         AV41XT_ConfigWWDS_1_Tfxt_configid = AV11TFXT_ConfigID;
         AV42XT_ConfigWWDS_2_Tfxt_configid_to = AV12TFXT_ConfigID_To;
         AV43XT_ConfigWWDS_3_Tfxt_configkey = AV13TFXT_ConfigKey;
         AV44XT_ConfigWWDS_4_Tfxt_configkey_sel = AV14TFXT_ConfigKey_Sel;
         AV45XT_ConfigWWDS_5_Tfxt_configvalue1 = AV15TFXT_ConfigValue1;
         AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV16TFXT_ConfigValue1_Sel;
         AV47XT_ConfigWWDS_7_Tfxt_configvalue2 = AV17TFXT_ConfigValue2;
         AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV18TFXT_ConfigValue2_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                              AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                              AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                              AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                              AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                              AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                              AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                              AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                              A195XT_ConfigID ,
                                              A196XT_ConfigKey ,
                                              A197XT_ConfigValue1 ,
                                              A198XT_ConfigValue2 } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV43XT_ConfigWWDS_3_Tfxt_configkey = StringUtil.Concat( StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey), "%", "");
         lV45XT_ConfigWWDS_5_Tfxt_configvalue1 = StringUtil.Concat( StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1), "%", "");
         lV47XT_ConfigWWDS_7_Tfxt_configvalue2 = StringUtil.Concat( StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2), "%", "");
         /* Using cursor P00373 */
         pr_default.execute(1, new Object[] {AV41XT_ConfigWWDS_1_Tfxt_configid, AV42XT_ConfigWWDS_2_Tfxt_configid_to, lV43XT_ConfigWWDS_3_Tfxt_configkey, AV44XT_ConfigWWDS_4_Tfxt_configkey_sel, lV45XT_ConfigWWDS_5_Tfxt_configvalue1, AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel, lV47XT_ConfigWWDS_7_Tfxt_configvalue2, AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK374 = false;
            A197XT_ConfigValue1 = P00373_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = P00373_n197XT_ConfigValue1[0];
            A198XT_ConfigValue2 = P00373_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = P00373_n198XT_ConfigValue2[0];
            A196XT_ConfigKey = P00373_A196XT_ConfigKey[0];
            n196XT_ConfigKey = P00373_n196XT_ConfigKey[0];
            A195XT_ConfigID = P00373_A195XT_ConfigID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( StringUtil.StrCmp(P00373_A197XT_ConfigValue1[0], A197XT_ConfigValue1) == 0 ) )
            {
               BRK374 = false;
               A195XT_ConfigID = P00373_A195XT_ConfigID[0];
               AV31count = (long)(AV31count+1);
               BRK374 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A197XT_ConfigValue1)) )
            {
               AV23Option = A197XT_ConfigValue1;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK374 )
            {
               BRK374 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADXT_CONFIGVALUE2OPTIONS' Routine */
         AV17TFXT_ConfigValue2 = AV19SearchTxt;
         AV18TFXT_ConfigValue2_Sel = "";
         AV41XT_ConfigWWDS_1_Tfxt_configid = AV11TFXT_ConfigID;
         AV42XT_ConfigWWDS_2_Tfxt_configid_to = AV12TFXT_ConfigID_To;
         AV43XT_ConfigWWDS_3_Tfxt_configkey = AV13TFXT_ConfigKey;
         AV44XT_ConfigWWDS_4_Tfxt_configkey_sel = AV14TFXT_ConfigKey_Sel;
         AV45XT_ConfigWWDS_5_Tfxt_configvalue1 = AV15TFXT_ConfigValue1;
         AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel = AV16TFXT_ConfigValue1_Sel;
         AV47XT_ConfigWWDS_7_Tfxt_configvalue2 = AV17TFXT_ConfigValue2;
         AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel = AV18TFXT_ConfigValue2_Sel;
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                              AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                              AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                              AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                              AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                              AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                              AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                              AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                              A195XT_ConfigID ,
                                              A196XT_ConfigKey ,
                                              A197XT_ConfigValue1 ,
                                              A198XT_ConfigValue2 } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV43XT_ConfigWWDS_3_Tfxt_configkey = StringUtil.Concat( StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey), "%", "");
         lV45XT_ConfigWWDS_5_Tfxt_configvalue1 = StringUtil.Concat( StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1), "%", "");
         lV47XT_ConfigWWDS_7_Tfxt_configvalue2 = StringUtil.Concat( StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2), "%", "");
         /* Using cursor P00374 */
         pr_default.execute(2, new Object[] {AV41XT_ConfigWWDS_1_Tfxt_configid, AV42XT_ConfigWWDS_2_Tfxt_configid_to, lV43XT_ConfigWWDS_3_Tfxt_configkey, AV44XT_ConfigWWDS_4_Tfxt_configkey_sel, lV45XT_ConfigWWDS_5_Tfxt_configvalue1, AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel, lV47XT_ConfigWWDS_7_Tfxt_configvalue2, AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK376 = false;
            A198XT_ConfigValue2 = P00374_A198XT_ConfigValue2[0];
            n198XT_ConfigValue2 = P00374_n198XT_ConfigValue2[0];
            A197XT_ConfigValue1 = P00374_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = P00374_n197XT_ConfigValue1[0];
            A196XT_ConfigKey = P00374_A196XT_ConfigKey[0];
            n196XT_ConfigKey = P00374_n196XT_ConfigKey[0];
            A195XT_ConfigID = P00374_A195XT_ConfigID[0];
            AV31count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( StringUtil.StrCmp(P00374_A198XT_ConfigValue2[0], A198XT_ConfigValue2) == 0 ) )
            {
               BRK376 = false;
               A195XT_ConfigID = P00374_A195XT_ConfigID[0];
               AV31count = (long)(AV31count+1);
               BRK376 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A198XT_ConfigValue2)) )
            {
               AV23Option = A198XT_ConfigValue2;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK376 )
            {
               BRK376 = true;
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
         AV24Options = new GxSimpleCollection<String>();
         AV27OptionsDesc = new GxSimpleCollection<String>();
         AV29OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV32Session = context.GetSession();
         AV34GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV35GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV13TFXT_ConfigKey = "";
         AV14TFXT_ConfigKey_Sel = "";
         AV15TFXT_ConfigValue1 = "";
         AV16TFXT_ConfigValue1_Sel = "";
         AV17TFXT_ConfigValue2 = "";
         AV18TFXT_ConfigValue2_Sel = "";
         AV43XT_ConfigWWDS_3_Tfxt_configkey = "";
         AV44XT_ConfigWWDS_4_Tfxt_configkey_sel = "";
         AV45XT_ConfigWWDS_5_Tfxt_configvalue1 = "";
         AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel = "";
         AV47XT_ConfigWWDS_7_Tfxt_configvalue2 = "";
         AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel = "";
         scmdbuf = "";
         lV43XT_ConfigWWDS_3_Tfxt_configkey = "";
         lV45XT_ConfigWWDS_5_Tfxt_configvalue1 = "";
         lV47XT_ConfigWWDS_7_Tfxt_configvalue2 = "";
         A196XT_ConfigKey = "";
         A197XT_ConfigValue1 = "";
         A198XT_ConfigValue2 = "";
         P00372_A196XT_ConfigKey = new String[] {""} ;
         P00372_n196XT_ConfigKey = new bool[] {false} ;
         P00372_A198XT_ConfigValue2 = new String[] {""} ;
         P00372_n198XT_ConfigValue2 = new bool[] {false} ;
         P00372_A197XT_ConfigValue1 = new String[] {""} ;
         P00372_n197XT_ConfigValue1 = new bool[] {false} ;
         P00372_A195XT_ConfigID = new long[1] ;
         AV23Option = "";
         P00373_A197XT_ConfigValue1 = new String[] {""} ;
         P00373_n197XT_ConfigValue1 = new bool[] {false} ;
         P00373_A198XT_ConfigValue2 = new String[] {""} ;
         P00373_n198XT_ConfigValue2 = new bool[] {false} ;
         P00373_A196XT_ConfigKey = new String[] {""} ;
         P00373_n196XT_ConfigKey = new bool[] {false} ;
         P00373_A195XT_ConfigID = new long[1] ;
         P00374_A198XT_ConfigValue2 = new String[] {""} ;
         P00374_n198XT_ConfigValue2 = new bool[] {false} ;
         P00374_A197XT_ConfigValue1 = new String[] {""} ;
         P00374_n197XT_ConfigValue1 = new bool[] {false} ;
         P00374_A196XT_ConfigKey = new String[] {""} ;
         P00374_n196XT_ConfigKey = new bool[] {false} ;
         P00374_A195XT_ConfigID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_configwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00372_A196XT_ConfigKey, P00372_n196XT_ConfigKey, P00372_A198XT_ConfigValue2, P00372_n198XT_ConfigValue2, P00372_A197XT_ConfigValue1, P00372_n197XT_ConfigValue1, P00372_A195XT_ConfigID
               }
               , new Object[] {
               P00373_A197XT_ConfigValue1, P00373_n197XT_ConfigValue1, P00373_A198XT_ConfigValue2, P00373_n198XT_ConfigValue2, P00373_A196XT_ConfigKey, P00373_n196XT_ConfigKey, P00373_A195XT_ConfigID
               }
               , new Object[] {
               P00374_A198XT_ConfigValue2, P00374_n198XT_ConfigValue2, P00374_A197XT_ConfigValue1, P00374_n197XT_ConfigValue1, P00374_A196XT_ConfigKey, P00374_n196XT_ConfigKey, P00374_A195XT_ConfigID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV39GXV1 ;
      private long AV11TFXT_ConfigID ;
      private long AV12TFXT_ConfigID_To ;
      private long AV41XT_ConfigWWDS_1_Tfxt_configid ;
      private long AV42XT_ConfigWWDS_2_Tfxt_configid_to ;
      private long A195XT_ConfigID ;
      private long AV31count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK372 ;
      private bool n196XT_ConfigKey ;
      private bool n198XT_ConfigValue2 ;
      private bool n197XT_ConfigValue1 ;
      private bool BRK374 ;
      private bool BRK376 ;
      private String AV30OptionIndexesJson ;
      private String AV25OptionsJson ;
      private String AV28OptionsDescJson ;
      private String AV21DDOName ;
      private String AV19SearchTxt ;
      private String AV20SearchTxtTo ;
      private String AV13TFXT_ConfigKey ;
      private String AV14TFXT_ConfigKey_Sel ;
      private String AV15TFXT_ConfigValue1 ;
      private String AV16TFXT_ConfigValue1_Sel ;
      private String AV17TFXT_ConfigValue2 ;
      private String AV18TFXT_ConfigValue2_Sel ;
      private String AV43XT_ConfigWWDS_3_Tfxt_configkey ;
      private String AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ;
      private String AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ;
      private String AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ;
      private String AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ;
      private String AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ;
      private String lV43XT_ConfigWWDS_3_Tfxt_configkey ;
      private String lV45XT_ConfigWWDS_5_Tfxt_configvalue1 ;
      private String lV47XT_ConfigWWDS_7_Tfxt_configvalue2 ;
      private String A196XT_ConfigKey ;
      private String A197XT_ConfigValue1 ;
      private String A198XT_ConfigValue2 ;
      private String AV23Option ;
      private IGxSession AV32Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00372_A196XT_ConfigKey ;
      private bool[] P00372_n196XT_ConfigKey ;
      private String[] P00372_A198XT_ConfigValue2 ;
      private bool[] P00372_n198XT_ConfigValue2 ;
      private String[] P00372_A197XT_ConfigValue1 ;
      private bool[] P00372_n197XT_ConfigValue1 ;
      private long[] P00372_A195XT_ConfigID ;
      private String[] P00373_A197XT_ConfigValue1 ;
      private bool[] P00373_n197XT_ConfigValue1 ;
      private String[] P00373_A198XT_ConfigValue2 ;
      private bool[] P00373_n198XT_ConfigValue2 ;
      private String[] P00373_A196XT_ConfigKey ;
      private bool[] P00373_n196XT_ConfigKey ;
      private long[] P00373_A195XT_ConfigID ;
      private String[] P00374_A198XT_ConfigValue2 ;
      private bool[] P00374_n198XT_ConfigValue2 ;
      private String[] P00374_A197XT_ConfigValue1 ;
      private bool[] P00374_n197XT_ConfigValue1 ;
      private String[] P00374_A196XT_ConfigKey ;
      private bool[] P00374_n196XT_ConfigKey ;
      private long[] P00374_A195XT_ConfigID ;
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

   public class xt_configwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00372( IGxContext context ,
                                             long AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                             long AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                             String AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                             String AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                             String AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                             String AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                             String AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                             String AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                             long A195XT_ConfigID ,
                                             String A196XT_ConfigKey ,
                                             String A197XT_ConfigValue1 ,
                                             String A198XT_ConfigValue2 )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [8] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [XT_ConfigKey], [XT_ConfigValue2], [XT_ConfigValue1], [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK)";
         if ( ! (0==AV41XT_ConfigWWDS_1_Tfxt_configid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV42XT_ConfigWWDS_2_Tfxt_configid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [XT_ConfigKey]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00373( IGxContext context ,
                                             long AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                             long AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                             String AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                             String AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                             String AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                             String AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                             String AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                             String AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                             long A195XT_ConfigID ,
                                             String A196XT_ConfigKey ,
                                             String A197XT_ConfigValue1 ,
                                             String A198XT_ConfigValue2 )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [8] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT [XT_ConfigValue1], [XT_ConfigValue2], [XT_ConfigKey], [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK)";
         if ( ! (0==AV41XT_ConfigWWDS_1_Tfxt_configid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV42XT_ConfigWWDS_2_Tfxt_configid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
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
         scmdbuf = scmdbuf + " ORDER BY [XT_ConfigValue1]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P00374( IGxContext context ,
                                             long AV41XT_ConfigWWDS_1_Tfxt_configid ,
                                             long AV42XT_ConfigWWDS_2_Tfxt_configid_to ,
                                             String AV44XT_ConfigWWDS_4_Tfxt_configkey_sel ,
                                             String AV43XT_ConfigWWDS_3_Tfxt_configkey ,
                                             String AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel ,
                                             String AV45XT_ConfigWWDS_5_Tfxt_configvalue1 ,
                                             String AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel ,
                                             String AV47XT_ConfigWWDS_7_Tfxt_configvalue2 ,
                                             long A195XT_ConfigID ,
                                             String A196XT_ConfigKey ,
                                             String A197XT_ConfigValue1 ,
                                             String A198XT_ConfigValue2 )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [8] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT [XT_ConfigValue2], [XT_ConfigValue1], [XT_ConfigKey], [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK)";
         if ( ! (0==AV41XT_ConfigWWDS_1_Tfxt_configid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] >= @AV41XT_ConfigWWDS_1_Tfxt_configid)";
            }
         }
         else
         {
            GXv_int6[0] = 1;
         }
         if ( ! (0==AV42XT_ConfigWWDS_2_Tfxt_configid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigID] <= @AV42XT_ConfigWWDS_2_Tfxt_configid_to)";
            }
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43XT_ConfigWWDS_3_Tfxt_configkey)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] like @lV43XT_ConfigWWDS_3_Tfxt_configkey)";
            }
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigKey] = @AV44XT_ConfigWWDS_4_Tfxt_configkey_sel)";
            }
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV45XT_ConfigWWDS_5_Tfxt_configvalue1)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] like @lV45XT_ConfigWWDS_5_Tfxt_configvalue1)";
            }
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue1] = @AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel)";
            }
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47XT_ConfigWWDS_7_Tfxt_configvalue2)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] like @lV47XT_ConfigWWDS_7_Tfxt_configvalue2)";
            }
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([XT_ConfigValue2] = @AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel)";
            }
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [XT_ConfigValue2]";
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
                     return conditional_P00372(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
               case 1 :
                     return conditional_P00373(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
               case 2 :
                     return conditional_P00374(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (long)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] );
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
          Object[] prmP00372 ;
          prmP00372 = new Object[] {
          new Object[] {"@AV41XT_ConfigWWDS_1_Tfxt_configid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42XT_ConfigWWDS_2_Tfxt_configid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV43XT_ConfigWWDS_3_Tfxt_configkey",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV44XT_ConfigWWDS_4_Tfxt_configkey_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV45XT_ConfigWWDS_5_Tfxt_configvalue1",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV47XT_ConfigWWDS_7_Tfxt_configvalue2",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel",SqlDbType.NVarChar,200,0}
          } ;
          Object[] prmP00373 ;
          prmP00373 = new Object[] {
          new Object[] {"@AV41XT_ConfigWWDS_1_Tfxt_configid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42XT_ConfigWWDS_2_Tfxt_configid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV43XT_ConfigWWDS_3_Tfxt_configkey",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV44XT_ConfigWWDS_4_Tfxt_configkey_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV45XT_ConfigWWDS_5_Tfxt_configvalue1",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV47XT_ConfigWWDS_7_Tfxt_configvalue2",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel",SqlDbType.NVarChar,200,0}
          } ;
          Object[] prmP00374 ;
          prmP00374 = new Object[] {
          new Object[] {"@AV41XT_ConfigWWDS_1_Tfxt_configid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42XT_ConfigWWDS_2_Tfxt_configid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV43XT_ConfigWWDS_3_Tfxt_configkey",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV44XT_ConfigWWDS_4_Tfxt_configkey_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV45XT_ConfigWWDS_5_Tfxt_configvalue1",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV46XT_ConfigWWDS_6_Tfxt_configvalue1_sel",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@lV47XT_ConfigWWDS_7_Tfxt_configvalue2",SqlDbType.NVarChar,200,0} ,
          new Object[] {"@AV48XT_ConfigWWDS_8_Tfxt_configvalue2_sel",SqlDbType.NVarChar,200,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00372", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00372,100,0,true,false )
             ,new CursorDef("P00373", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00373,100,0,true,false )
             ,new CursorDef("P00374", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00374,100,0,true,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
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
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
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
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
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
             case 2 :
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
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.xt_configwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class xt_configwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("xt_configwwgetfilterdata") )
          {
             return  ;
          }
          xt_configwwgetfilterdata worker = new xt_configwwgetfilterdata(context) ;
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
