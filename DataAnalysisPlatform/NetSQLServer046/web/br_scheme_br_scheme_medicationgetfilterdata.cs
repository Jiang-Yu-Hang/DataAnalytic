/*
               File: BR_Scheme_BR_Scheme_MedicationGetFilterData
        Description: BR_Scheme_BR_Scheme_Medication Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:14.9
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
   public class br_scheme_br_scheme_medicationgetfilterdata : GXProcedure
   {
      public br_scheme_br_scheme_medicationgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme_br_scheme_medicationgetfilterdata( IGxContext context )
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
         br_scheme_br_scheme_medicationgetfilterdata objbr_scheme_br_scheme_medicationgetfilterdata;
         objbr_scheme_br_scheme_medicationgetfilterdata = new br_scheme_br_scheme_medicationgetfilterdata();
         objbr_scheme_br_scheme_medicationgetfilterdata.AV21DDOName = aP0_DDOName;
         objbr_scheme_br_scheme_medicationgetfilterdata.AV19SearchTxt = aP1_SearchTxt;
         objbr_scheme_br_scheme_medicationgetfilterdata.AV20SearchTxtTo = aP2_SearchTxtTo;
         objbr_scheme_br_scheme_medicationgetfilterdata.AV25OptionsJson = "" ;
         objbr_scheme_br_scheme_medicationgetfilterdata.AV28OptionsDescJson = "" ;
         objbr_scheme_br_scheme_medicationgetfilterdata.AV30OptionIndexesJson = "" ;
         objbr_scheme_br_scheme_medicationgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_scheme_br_scheme_medicationgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_scheme_br_scheme_medicationgetfilterdata);
         aP3_OptionsJson=this.AV25OptionsJson;
         aP4_OptionsDescJson=this.AV28OptionsDescJson;
         aP5_OptionIndexesJson=this.AV30OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_scheme_br_scheme_medicationgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Scheme_Medication", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_MEDICATION_RXNAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXNAMEOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV21DDOName), "DDO_BR_MEDICATION_RXUNIT") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_MEDICATION_RXUNITOPTIONS' */
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
         if ( StringUtil.StrCmp(AV32Session.Get("BR_Scheme_BR_Scheme_MedicationGridState"), "") == 0 )
         {
            AV34GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Scheme_BR_Scheme_MedicationGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV34GridState.FromXml(AV32Session.Get("BR_Scheme_BR_Scheme_MedicationGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV46GXV1 = 1;
         while ( AV46GXV1 <= AV34GridState.gxTpr_Filtervalues.Count )
         {
            AV35GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV34GridState.gxTpr_Filtervalues.Item(AV46GXV1));
            if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS") == 0 )
            {
               AV11TFBR_Scheme_Chem_Regimens = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_SCHEME_CHEM_REGIMENS_SEL") == 0 )
            {
               AV12TFBR_Scheme_Chem_Regimens_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME") == 0 )
            {
               AV38TFBR_Medication_RXName = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXNAME_SEL") == 0 )
            {
               AV39TFBR_Medication_RXName_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXDOSE") == 0 )
            {
               AV40TFBR_Medication_RXDose = NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, ".");
               AV41TFBR_Medication_RXDose_To = NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Valueto, ".");
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT") == 0 )
            {
               AV42TFBR_Medication_RXUnit = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "TFBR_MEDICATION_RXUNIT_SEL") == 0 )
            {
               AV43TFBR_Medication_RXUnit_Sel = AV35GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV35GridStateFilterValue.gxTpr_Name, "PARM_&BR_SCHEMEID") == 0 )
            {
               AV37BR_SchemeID = (long)(NumberUtil.Val( AV35GridStateFilterValue.gxTpr_Value, "."));
            }
            AV46GXV1 = (int)(AV46GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_SCHEME_CHEM_REGIMENSOPTIONS' Routine */
         AV11TFBR_Scheme_Chem_Regimens = AV19SearchTxt;
         AV12TFBR_Scheme_Chem_Regimens_Sel = "";
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                              AV11TFBR_Scheme_Chem_Regimens ,
                                              AV39TFBR_Medication_RXName_Sel ,
                                              AV38TFBR_Medication_RXName ,
                                              AV40TFBR_Medication_RXDose ,
                                              AV41TFBR_Medication_RXDose_To ,
                                              AV43TFBR_Medication_RXUnit_Sel ,
                                              AV42TFBR_Medication_RXUnit ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit ,
                                              AV37BR_SchemeID ,
                                              A327BR_SchemeID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV11TFBR_Scheme_Chem_Regimens = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens), "%", "");
         lV38TFBR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV38TFBR_Medication_RXName), "%", "");
         lV42TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV42TFBR_Medication_RXUnit), "%", "");
         /* Using cursor P00312 */
         pr_default.execute(0, new Object[] {AV37BR_SchemeID, lV11TFBR_Scheme_Chem_Regimens, AV12TFBR_Scheme_Chem_Regimens_Sel, lV38TFBR_Medication_RXName, AV39TFBR_Medication_RXName_Sel, AV40TFBR_Medication_RXDose, AV41TFBR_Medication_RXDose_To, lV42TFBR_Medication_RXUnit, AV43TFBR_Medication_RXUnit_Sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK312 = false;
            A119BR_MedicationID = P00312_A119BR_MedicationID[0];
            n119BR_MedicationID = P00312_n119BR_MedicationID[0];
            A327BR_SchemeID = P00312_A327BR_SchemeID[0];
            n327BR_SchemeID = P00312_n327BR_SchemeID[0];
            A125BR_Medication_RXUnit = P00312_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00312_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00312_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00312_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00312_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00312_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00312_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00312_n328BR_Scheme_Chem_Regimens[0];
            A332BR_Scheme_MedicationID = P00312_A332BR_Scheme_MedicationID[0];
            A125BR_Medication_RXUnit = P00312_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00312_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00312_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00312_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00312_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00312_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00312_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00312_n328BR_Scheme_Chem_Regimens[0];
            AV31count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P00312_A327BR_SchemeID[0] == A327BR_SchemeID ) )
            {
               BRK312 = false;
               A332BR_Scheme_MedicationID = P00312_A332BR_Scheme_MedicationID[0];
               AV31count = (long)(AV31count+1);
               BRK312 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) )
            {
               AV23Option = A328BR_Scheme_Chem_Regimens;
               AV22InsertIndex = 1;
               while ( ( AV22InsertIndex <= AV24Options.Count ) && ( StringUtil.StrCmp(((String)AV24Options.Item(AV22InsertIndex)), AV23Option) < 0 ) )
               {
                  AV22InsertIndex = (int)(AV22InsertIndex+1);
               }
               AV24Options.Add(AV23Option, AV22InsertIndex);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), AV22InsertIndex);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK312 )
            {
               BRK312 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADBR_MEDICATION_RXNAMEOPTIONS' Routine */
         AV38TFBR_Medication_RXName = AV19SearchTxt;
         AV39TFBR_Medication_RXName_Sel = "";
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                              AV11TFBR_Scheme_Chem_Regimens ,
                                              AV39TFBR_Medication_RXName_Sel ,
                                              AV38TFBR_Medication_RXName ,
                                              AV40TFBR_Medication_RXDose ,
                                              AV41TFBR_Medication_RXDose_To ,
                                              AV43TFBR_Medication_RXUnit_Sel ,
                                              AV42TFBR_Medication_RXUnit ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit ,
                                              AV37BR_SchemeID ,
                                              A327BR_SchemeID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV11TFBR_Scheme_Chem_Regimens = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens), "%", "");
         lV38TFBR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV38TFBR_Medication_RXName), "%", "");
         lV42TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV42TFBR_Medication_RXUnit), "%", "");
         /* Using cursor P00313 */
         pr_default.execute(1, new Object[] {AV37BR_SchemeID, lV11TFBR_Scheme_Chem_Regimens, AV12TFBR_Scheme_Chem_Regimens_Sel, lV38TFBR_Medication_RXName, AV39TFBR_Medication_RXName_Sel, AV40TFBR_Medication_RXDose, AV41TFBR_Medication_RXDose_To, lV42TFBR_Medication_RXUnit, AV43TFBR_Medication_RXUnit_Sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK314 = false;
            A119BR_MedicationID = P00313_A119BR_MedicationID[0];
            n119BR_MedicationID = P00313_n119BR_MedicationID[0];
            A327BR_SchemeID = P00313_A327BR_SchemeID[0];
            n327BR_SchemeID = P00313_n327BR_SchemeID[0];
            A121BR_Medication_RXName = P00313_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00313_n121BR_Medication_RXName[0];
            A125BR_Medication_RXUnit = P00313_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00313_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00313_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00313_n124BR_Medication_RXDose[0];
            A328BR_Scheme_Chem_Regimens = P00313_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00313_n328BR_Scheme_Chem_Regimens[0];
            A332BR_Scheme_MedicationID = P00313_A332BR_Scheme_MedicationID[0];
            A121BR_Medication_RXName = P00313_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00313_n121BR_Medication_RXName[0];
            A125BR_Medication_RXUnit = P00313_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00313_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00313_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00313_n124BR_Medication_RXDose[0];
            A328BR_Scheme_Chem_Regimens = P00313_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00313_n328BR_Scheme_Chem_Regimens[0];
            AV31count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( P00313_A327BR_SchemeID[0] == A327BR_SchemeID ) && ( StringUtil.StrCmp(P00313_A121BR_Medication_RXName[0], A121BR_Medication_RXName) == 0 ) )
            {
               BRK314 = false;
               A119BR_MedicationID = P00313_A119BR_MedicationID[0];
               n119BR_MedicationID = P00313_n119BR_MedicationID[0];
               A332BR_Scheme_MedicationID = P00313_A332BR_Scheme_MedicationID[0];
               AV31count = (long)(AV31count+1);
               BRK314 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A121BR_Medication_RXName)) )
            {
               AV23Option = A121BR_Medication_RXName;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK314 )
            {
               BRK314 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
      }

      protected void S141( )
      {
         /* 'LOADBR_MEDICATION_RXUNITOPTIONS' Routine */
         AV42TFBR_Medication_RXUnit = AV19SearchTxt;
         AV43TFBR_Medication_RXUnit_Sel = "";
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                              AV11TFBR_Scheme_Chem_Regimens ,
                                              AV39TFBR_Medication_RXName_Sel ,
                                              AV38TFBR_Medication_RXName ,
                                              AV40TFBR_Medication_RXDose ,
                                              AV41TFBR_Medication_RXDose_To ,
                                              AV43TFBR_Medication_RXUnit_Sel ,
                                              AV42TFBR_Medication_RXUnit ,
                                              A328BR_Scheme_Chem_Regimens ,
                                              A121BR_Medication_RXName ,
                                              A124BR_Medication_RXDose ,
                                              A125BR_Medication_RXUnit ,
                                              AV37BR_SchemeID ,
                                              A327BR_SchemeID } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.BOOLEAN,
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV11TFBR_Scheme_Chem_Regimens = StringUtil.Concat( StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens), "%", "");
         lV38TFBR_Medication_RXName = StringUtil.Concat( StringUtil.RTrim( AV38TFBR_Medication_RXName), "%", "");
         lV42TFBR_Medication_RXUnit = StringUtil.Concat( StringUtil.RTrim( AV42TFBR_Medication_RXUnit), "%", "");
         /* Using cursor P00314 */
         pr_default.execute(2, new Object[] {AV37BR_SchemeID, lV11TFBR_Scheme_Chem_Regimens, AV12TFBR_Scheme_Chem_Regimens_Sel, lV38TFBR_Medication_RXName, AV39TFBR_Medication_RXName_Sel, AV40TFBR_Medication_RXDose, AV41TFBR_Medication_RXDose_To, lV42TFBR_Medication_RXUnit, AV43TFBR_Medication_RXUnit_Sel});
         while ( (pr_default.getStatus(2) != 101) )
         {
            BRK316 = false;
            A119BR_MedicationID = P00314_A119BR_MedicationID[0];
            n119BR_MedicationID = P00314_n119BR_MedicationID[0];
            A327BR_SchemeID = P00314_A327BR_SchemeID[0];
            n327BR_SchemeID = P00314_n327BR_SchemeID[0];
            A125BR_Medication_RXUnit = P00314_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00314_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00314_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00314_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00314_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00314_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00314_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00314_n328BR_Scheme_Chem_Regimens[0];
            A332BR_Scheme_MedicationID = P00314_A332BR_Scheme_MedicationID[0];
            A125BR_Medication_RXUnit = P00314_A125BR_Medication_RXUnit[0];
            n125BR_Medication_RXUnit = P00314_n125BR_Medication_RXUnit[0];
            A124BR_Medication_RXDose = P00314_A124BR_Medication_RXDose[0];
            n124BR_Medication_RXDose = P00314_n124BR_Medication_RXDose[0];
            A121BR_Medication_RXName = P00314_A121BR_Medication_RXName[0];
            n121BR_Medication_RXName = P00314_n121BR_Medication_RXName[0];
            A328BR_Scheme_Chem_Regimens = P00314_A328BR_Scheme_Chem_Regimens[0];
            n328BR_Scheme_Chem_Regimens = P00314_n328BR_Scheme_Chem_Regimens[0];
            AV31count = 0;
            while ( (pr_default.getStatus(2) != 101) && ( P00314_A327BR_SchemeID[0] == A327BR_SchemeID ) && ( StringUtil.StrCmp(P00314_A125BR_Medication_RXUnit[0], A125BR_Medication_RXUnit) == 0 ) )
            {
               BRK316 = false;
               A119BR_MedicationID = P00314_A119BR_MedicationID[0];
               n119BR_MedicationID = P00314_n119BR_MedicationID[0];
               A332BR_Scheme_MedicationID = P00314_A332BR_Scheme_MedicationID[0];
               AV31count = (long)(AV31count+1);
               BRK316 = true;
               pr_default.readNext(2);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A125BR_Medication_RXUnit)) )
            {
               AV23Option = A125BR_Medication_RXUnit;
               AV24Options.Add(AV23Option, 0);
               AV29OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV31count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV24Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK316 )
            {
               BRK316 = true;
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
         AV11TFBR_Scheme_Chem_Regimens = "";
         AV12TFBR_Scheme_Chem_Regimens_Sel = "";
         AV38TFBR_Medication_RXName = "";
         AV39TFBR_Medication_RXName_Sel = "";
         AV42TFBR_Medication_RXUnit = "";
         AV43TFBR_Medication_RXUnit_Sel = "";
         scmdbuf = "";
         lV11TFBR_Scheme_Chem_Regimens = "";
         lV38TFBR_Medication_RXName = "";
         lV42TFBR_Medication_RXUnit = "";
         A328BR_Scheme_Chem_Regimens = "";
         A121BR_Medication_RXName = "";
         A125BR_Medication_RXUnit = "";
         P00312_A119BR_MedicationID = new long[1] ;
         P00312_n119BR_MedicationID = new bool[] {false} ;
         P00312_A327BR_SchemeID = new long[1] ;
         P00312_n327BR_SchemeID = new bool[] {false} ;
         P00312_A125BR_Medication_RXUnit = new String[] {""} ;
         P00312_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00312_A124BR_Medication_RXDose = new decimal[1] ;
         P00312_n124BR_Medication_RXDose = new bool[] {false} ;
         P00312_A121BR_Medication_RXName = new String[] {""} ;
         P00312_n121BR_Medication_RXName = new bool[] {false} ;
         P00312_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00312_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00312_A332BR_Scheme_MedicationID = new long[1] ;
         AV23Option = "";
         P00313_A119BR_MedicationID = new long[1] ;
         P00313_n119BR_MedicationID = new bool[] {false} ;
         P00313_A327BR_SchemeID = new long[1] ;
         P00313_n327BR_SchemeID = new bool[] {false} ;
         P00313_A121BR_Medication_RXName = new String[] {""} ;
         P00313_n121BR_Medication_RXName = new bool[] {false} ;
         P00313_A125BR_Medication_RXUnit = new String[] {""} ;
         P00313_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00313_A124BR_Medication_RXDose = new decimal[1] ;
         P00313_n124BR_Medication_RXDose = new bool[] {false} ;
         P00313_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00313_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00313_A332BR_Scheme_MedicationID = new long[1] ;
         P00314_A119BR_MedicationID = new long[1] ;
         P00314_n119BR_MedicationID = new bool[] {false} ;
         P00314_A327BR_SchemeID = new long[1] ;
         P00314_n327BR_SchemeID = new bool[] {false} ;
         P00314_A125BR_Medication_RXUnit = new String[] {""} ;
         P00314_n125BR_Medication_RXUnit = new bool[] {false} ;
         P00314_A124BR_Medication_RXDose = new decimal[1] ;
         P00314_n124BR_Medication_RXDose = new bool[] {false} ;
         P00314_A121BR_Medication_RXName = new String[] {""} ;
         P00314_n121BR_Medication_RXName = new bool[] {false} ;
         P00314_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         P00314_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         P00314_A332BR_Scheme_MedicationID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme_br_scheme_medicationgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00312_A119BR_MedicationID, P00312_n119BR_MedicationID, P00312_A327BR_SchemeID, P00312_n327BR_SchemeID, P00312_A125BR_Medication_RXUnit, P00312_n125BR_Medication_RXUnit, P00312_A124BR_Medication_RXDose, P00312_n124BR_Medication_RXDose, P00312_A121BR_Medication_RXName, P00312_n121BR_Medication_RXName,
               P00312_A328BR_Scheme_Chem_Regimens, P00312_n328BR_Scheme_Chem_Regimens, P00312_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               P00313_A119BR_MedicationID, P00313_n119BR_MedicationID, P00313_A327BR_SchemeID, P00313_n327BR_SchemeID, P00313_A121BR_Medication_RXName, P00313_n121BR_Medication_RXName, P00313_A125BR_Medication_RXUnit, P00313_n125BR_Medication_RXUnit, P00313_A124BR_Medication_RXDose, P00313_n124BR_Medication_RXDose,
               P00313_A328BR_Scheme_Chem_Regimens, P00313_n328BR_Scheme_Chem_Regimens, P00313_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               P00314_A119BR_MedicationID, P00314_n119BR_MedicationID, P00314_A327BR_SchemeID, P00314_n327BR_SchemeID, P00314_A125BR_Medication_RXUnit, P00314_n125BR_Medication_RXUnit, P00314_A124BR_Medication_RXDose, P00314_n124BR_Medication_RXDose, P00314_A121BR_Medication_RXName, P00314_n121BR_Medication_RXName,
               P00314_A328BR_Scheme_Chem_Regimens, P00314_n328BR_Scheme_Chem_Regimens, P00314_A332BR_Scheme_MedicationID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV46GXV1 ;
      private int AV22InsertIndex ;
      private long AV37BR_SchemeID ;
      private long A327BR_SchemeID ;
      private long A119BR_MedicationID ;
      private long A332BR_Scheme_MedicationID ;
      private long AV31count ;
      private decimal AV40TFBR_Medication_RXDose ;
      private decimal AV41TFBR_Medication_RXDose_To ;
      private decimal A124BR_Medication_RXDose ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK312 ;
      private bool n119BR_MedicationID ;
      private bool n327BR_SchemeID ;
      private bool n125BR_Medication_RXUnit ;
      private bool n124BR_Medication_RXDose ;
      private bool n121BR_Medication_RXName ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool BRK314 ;
      private bool BRK316 ;
      private String AV30OptionIndexesJson ;
      private String AV25OptionsJson ;
      private String AV28OptionsDescJson ;
      private String AV21DDOName ;
      private String AV19SearchTxt ;
      private String AV20SearchTxtTo ;
      private String AV11TFBR_Scheme_Chem_Regimens ;
      private String AV12TFBR_Scheme_Chem_Regimens_Sel ;
      private String AV38TFBR_Medication_RXName ;
      private String AV39TFBR_Medication_RXName_Sel ;
      private String AV42TFBR_Medication_RXUnit ;
      private String AV43TFBR_Medication_RXUnit_Sel ;
      private String lV11TFBR_Scheme_Chem_Regimens ;
      private String lV38TFBR_Medication_RXName ;
      private String lV42TFBR_Medication_RXUnit ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A121BR_Medication_RXName ;
      private String A125BR_Medication_RXUnit ;
      private String AV23Option ;
      private IGxSession AV32Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00312_A119BR_MedicationID ;
      private bool[] P00312_n119BR_MedicationID ;
      private long[] P00312_A327BR_SchemeID ;
      private bool[] P00312_n327BR_SchemeID ;
      private String[] P00312_A125BR_Medication_RXUnit ;
      private bool[] P00312_n125BR_Medication_RXUnit ;
      private decimal[] P00312_A124BR_Medication_RXDose ;
      private bool[] P00312_n124BR_Medication_RXDose ;
      private String[] P00312_A121BR_Medication_RXName ;
      private bool[] P00312_n121BR_Medication_RXName ;
      private String[] P00312_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00312_n328BR_Scheme_Chem_Regimens ;
      private long[] P00312_A332BR_Scheme_MedicationID ;
      private long[] P00313_A119BR_MedicationID ;
      private bool[] P00313_n119BR_MedicationID ;
      private long[] P00313_A327BR_SchemeID ;
      private bool[] P00313_n327BR_SchemeID ;
      private String[] P00313_A121BR_Medication_RXName ;
      private bool[] P00313_n121BR_Medication_RXName ;
      private String[] P00313_A125BR_Medication_RXUnit ;
      private bool[] P00313_n125BR_Medication_RXUnit ;
      private decimal[] P00313_A124BR_Medication_RXDose ;
      private bool[] P00313_n124BR_Medication_RXDose ;
      private String[] P00313_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00313_n328BR_Scheme_Chem_Regimens ;
      private long[] P00313_A332BR_Scheme_MedicationID ;
      private long[] P00314_A119BR_MedicationID ;
      private bool[] P00314_n119BR_MedicationID ;
      private long[] P00314_A327BR_SchemeID ;
      private bool[] P00314_n327BR_SchemeID ;
      private String[] P00314_A125BR_Medication_RXUnit ;
      private bool[] P00314_n125BR_Medication_RXUnit ;
      private decimal[] P00314_A124BR_Medication_RXDose ;
      private bool[] P00314_n124BR_Medication_RXDose ;
      private String[] P00314_A121BR_Medication_RXName ;
      private bool[] P00314_n121BR_Medication_RXName ;
      private String[] P00314_A328BR_Scheme_Chem_Regimens ;
      private bool[] P00314_n328BR_Scheme_Chem_Regimens ;
      private long[] P00314_A332BR_Scheme_MedicationID ;
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

   public class br_scheme_br_scheme_medicationgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00312( IGxContext context ,
                                             String AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                             String AV11TFBR_Scheme_Chem_Regimens ,
                                             String AV39TFBR_Medication_RXName_Sel ,
                                             String AV38TFBR_Medication_RXName ,
                                             decimal AV40TFBR_Medication_RXDose ,
                                             decimal AV41TFBR_Medication_RXDose_To ,
                                             String AV43TFBR_Medication_RXUnit_Sel ,
                                             String AV42TFBR_Medication_RXUnit ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             long AV37BR_SchemeID ,
                                             long A327BR_SchemeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [9] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[BR_MedicationID], T1.[BR_SchemeID], T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T2.[BR_Medication_RXName], T3.[BR_Scheme_Chem_Regimens], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BR_SchemeID] = @AV37BR_SchemeID)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV11TFBR_Scheme_Chem_Regimens)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV12TFBR_Scheme_Chem_Regimens_Sel)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Medication_RXName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV38TFBR_Medication_RXName)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV39TFBR_Medication_RXName_Sel)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV40TFBR_Medication_RXDose) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV40TFBR_Medication_RXDose)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV41TFBR_Medication_RXDose_To) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV41TFBR_Medication_RXDose_To)";
         }
         else
         {
            GXv_int2[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV42TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int2[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV43TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int2[8] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_SchemeID]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P00313( IGxContext context ,
                                             String AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                             String AV11TFBR_Scheme_Chem_Regimens ,
                                             String AV39TFBR_Medication_RXName_Sel ,
                                             String AV38TFBR_Medication_RXName ,
                                             decimal AV40TFBR_Medication_RXDose ,
                                             decimal AV41TFBR_Medication_RXDose_To ,
                                             String AV43TFBR_Medication_RXUnit_Sel ,
                                             String AV42TFBR_Medication_RXUnit ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             long AV37BR_SchemeID ,
                                             long A327BR_SchemeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [9] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T1.[BR_MedicationID], T1.[BR_SchemeID], T2.[BR_Medication_RXName], T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T3.[BR_Scheme_Chem_Regimens], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BR_SchemeID] = @AV37BR_SchemeID)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV11TFBR_Scheme_Chem_Regimens)";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV12TFBR_Scheme_Chem_Regimens_Sel)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Medication_RXName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV38TFBR_Medication_RXName)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV39TFBR_Medication_RXName_Sel)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV40TFBR_Medication_RXDose) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV40TFBR_Medication_RXDose)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV41TFBR_Medication_RXDose_To) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV41TFBR_Medication_RXDose_To)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV42TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV43TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_SchemeID], T2.[BR_Medication_RXName]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_P00314( IGxContext context ,
                                             String AV12TFBR_Scheme_Chem_Regimens_Sel ,
                                             String AV11TFBR_Scheme_Chem_Regimens ,
                                             String AV39TFBR_Medication_RXName_Sel ,
                                             String AV38TFBR_Medication_RXName ,
                                             decimal AV40TFBR_Medication_RXDose ,
                                             decimal AV41TFBR_Medication_RXDose_To ,
                                             String AV43TFBR_Medication_RXUnit_Sel ,
                                             String AV42TFBR_Medication_RXUnit ,
                                             String A328BR_Scheme_Chem_Regimens ,
                                             String A121BR_Medication_RXName ,
                                             decimal A124BR_Medication_RXDose ,
                                             String A125BR_Medication_RXUnit ,
                                             long AV37BR_SchemeID ,
                                             long A327BR_SchemeID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [9] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT T1.[BR_MedicationID], T1.[BR_SchemeID], T2.[BR_Medication_RXUnit], T2.[BR_Medication_RXDose], T2.[BR_Medication_RXName], T3.[BR_Scheme_Chem_Regimens], T1.[BR_Scheme_MedicationID] FROM (([BR_Scheme_Medication] T1 WITH (NOLOCK) LEFT JOIN [BR_Medication] T2 WITH (NOLOCK) ON T2.[BR_MedicationID] = T1.[BR_MedicationID]) LEFT JOIN [BR_Scheme] T3 WITH (NOLOCK) ON T3.[BR_SchemeID] = T1.[BR_SchemeID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BR_SchemeID] = @AV37BR_SchemeID)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBR_Scheme_Chem_Regimens)) ) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] like @lV11TFBR_Scheme_Chem_Regimens)";
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBR_Scheme_Chem_Regimens_Sel)) )
         {
            sWhereString = sWhereString + " and (T3.[BR_Scheme_Chem_Regimens] = @AV12TFBR_Scheme_Chem_Regimens_Sel)";
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV38TFBR_Medication_RXName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] like @lV38TFBR_Medication_RXName)";
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_Medication_RXName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXName] = @AV39TFBR_Medication_RXName_Sel)";
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV40TFBR_Medication_RXDose) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] >= @AV40TFBR_Medication_RXDose)";
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV41TFBR_Medication_RXDose_To) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXDose] <= @AV41TFBR_Medication_RXDose_To)";
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV42TFBR_Medication_RXUnit)) ) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] like @lV42TFBR_Medication_RXUnit)";
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43TFBR_Medication_RXUnit_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Medication_RXUnit] = @AV43TFBR_Medication_RXUnit_Sel)";
         }
         else
         {
            GXv_int6[8] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[BR_SchemeID], T2.[BR_Medication_RXUnit]";
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
                     return conditional_P00312(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] );
               case 1 :
                     return conditional_P00313(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] );
               case 2 :
                     return conditional_P00314(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (decimal)dynConstraints[10] , (String)dynConstraints[11] , (long)dynConstraints[12] , (long)dynConstraints[13] );
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
          Object[] prmP00312 ;
          prmP00312 = new Object[] {
          new Object[] {"@AV37BR_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV11TFBR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Scheme_Chem_Regimens_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV38TFBR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV39TFBR_Medication_RXName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV40TFBR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV41TFBR_Medication_RXDose_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV42TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV43TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP00313 ;
          prmP00313 = new Object[] {
          new Object[] {"@AV37BR_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV11TFBR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Scheme_Chem_Regimens_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV38TFBR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV39TFBR_Medication_RXName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV40TFBR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV41TFBR_Medication_RXDose_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV42TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV43TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          Object[] prmP00314 ;
          prmP00314 = new Object[] {
          new Object[] {"@AV37BR_SchemeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV11TFBR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV12TFBR_Scheme_Chem_Regimens_Sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV38TFBR_Medication_RXName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV39TFBR_Medication_RXName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV40TFBR_Medication_RXDose",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV41TFBR_Medication_RXDose_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV42TFBR_Medication_RXUnit",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV43TFBR_Medication_RXUnit_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00312", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00312,100,0,true,false )
             ,new CursorDef("P00313", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00313,100,0,true,false )
             ,new CursorDef("P00314", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00314,100,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                return;
             case 2 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                return;
             case 2 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.br_scheme_br_scheme_medicationgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_scheme_br_scheme_medicationgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_scheme_br_scheme_medicationgetfilterdata") )
          {
             return  ;
          }
          br_scheme_br_scheme_medicationgetfilterdata worker = new br_scheme_br_scheme_medicationgetfilterdata(context) ;
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
