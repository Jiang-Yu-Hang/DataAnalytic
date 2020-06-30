/*
               File: BR_Encounter_BC
        Description: 就诊信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:17.58
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_encounter_bc : GXHttpHandler, IGxSilentTrn
   {
      public br_encounter_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow0E15( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0E15( ) ;
         standaloneModal( ) ;
         AddRow0E15( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E110E2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z19BR_EncounterID = A19BR_EncounterID;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_0E0( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0E15( ) ;
            }
            else
            {
               CheckExtendedTable0E15( ) ;
               if ( AnyError == 0 )
               {
                  ZM0E15( 33) ;
                  ZM0E15( 34) ;
                  ZM0E15( 35) ;
               }
               CloseExtendedTableCursors0E15( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E120E2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV14WWPContext) ;
         AV16IsAuthorized = true;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean1) ;
            AV16IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean1) ;
            AV16IsAuthorized = GXt_boolean1;
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV16IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Encounter", out  GXt_boolean1) ;
            AV16IsAuthorized = GXt_boolean1;
         }
         if ( ! AV16IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV31Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV13WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV31Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV32GXV1 = 1;
            while ( AV32GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV12TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV32GXV1));
               if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "BR_Information_ID") == 0 )
               {
                  AV8Insert_BR_Information_ID = (long)(NumberUtil.Val( AV12TrnContextAtt.gxTpr_Attributevalue, "."));
               }
               else if ( StringUtil.StrCmp(AV12TrnContextAtt.gxTpr_Attributename, "BAS_TenantTenantCode") == 0 )
               {
                  AV29Insert_BAS_TenantTenantCode = AV12TrnContextAtt.gxTpr_Attributevalue;
               }
               AV32GXV1 = (int)(AV32GXV1+1);
            }
         }
      }

      protected void E110E2( )
      {
         /* After Trn Routine */
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
      }

      protected void ZM0E15( short GX_JID )
      {
         if ( ( GX_JID == 32 ) || ( GX_JID == 0 ) )
         {
            Z35BR_Encounter_EncID = A35BR_Encounter_EncID;
            Z172BR_Encounter_Status = A172BR_Encounter_Status;
            Z183BR_Encounter_CrtUser = A183BR_Encounter_CrtUser;
            Z512BR_Encounter_CrtDisplayName = A512BR_Encounter_CrtDisplayName;
            Z182BR_Encounter_CrtDate = A182BR_Encounter_CrtDate;
            Z470BR_Encounter_Department_Code = A470BR_Encounter_Department_Code;
            Z471BR_Encounter_ENCType_Code = A471BR_Encounter_ENCType_Code;
            Z472BR_Encounter_AdmitSource_Code = A472BR_Encounter_AdmitSource_Code;
            Z473BR_Encounter_DischargeStatus_Code = A473BR_Encounter_DischargeStatus_Code;
            Z84BR_Encounter_Department = A84BR_Encounter_Department;
            Z570BR_Encounter_Departmentadm = A570BR_Encounter_Departmentadm;
            Z571BR_Encounter_Departmentadm_Code = A571BR_Encounter_Departmentadm_Code;
            Z572BR_Encounter_Departmentdisch = A572BR_Encounter_Departmentdisch;
            Z573BR_Encounter_Departmentdisch_Code = A573BR_Encounter_Departmentdisch_Code;
            Z90BR_Encounter_ENCType = A90BR_Encounter_ENCType;
            Z91BR_Encounter_AdmitDate = A91BR_Encounter_AdmitDate;
            Z92BR_Encounter_AdmitSource = A92BR_Encounter_AdmitSource;
            Z93BR_Encounter_DischargeDate = A93BR_Encounter_DischargeDate;
            Z94BR_Encounter_DischargeStatus = A94BR_Encounter_DischargeStatus;
            Z574BR_Encounter_Insurance = A574BR_Encounter_Insurance;
            Z575BR_Encounter_Insurance_Code = A575BR_Encounter_Insurance_Code;
            Z187BR_Encounter_UpdDate = A187BR_Encounter_UpdDate;
            Z186BR_Encounter_UpdUser = A186BR_Encounter_UpdUser;
            Z333BR_Encounter_IsDLT = A333BR_Encounter_IsDLT;
            Z184BR_Encounter_SubmitUser = A184BR_Encounter_SubmitUser;
            Z335BR_Encounter_Reason = A335BR_Encounter_Reason;
            Z185BR_Encounter_SubmitDate = A185BR_Encounter_SubmitDate;
            Z188BR_Encounter_RecheckUser = A188BR_Encounter_RecheckUser;
            Z336BR_Encounter_FReason = A336BR_Encounter_FReason;
            Z189BR_Encounter_RecheckDate = A189BR_Encounter_RecheckDate;
            Z190BR_Encounter_Approver = A190BR_Encounter_Approver;
            Z191BR_Encounter_ApproveDate = A191BR_Encounter_ApproveDate;
            Z192BR_Encounter_IsRandApprove = A192BR_Encounter_IsRandApprove;
            Z203BR_Encounter_IsRandApprover = A203BR_Encounter_IsRandApprover;
            Z204BR_Encounter_IsRandNoApprover = A204BR_Encounter_IsRandNoApprover;
            Z205BR_Encounter_IsRandApproveDate = A205BR_Encounter_IsRandApproveDate;
            Z206BR_Encounter_IsRandNoApproveDate = A206BR_Encounter_IsRandNoApproveDate;
            Z193BR_Encounter_IsRandRecheck = A193BR_Encounter_IsRandRecheck;
            Z207BR_Encounter_IsRandRecheckr = A207BR_Encounter_IsRandRecheckr;
            Z208BR_Encounter_IsRandNoRecheckr = A208BR_Encounter_IsRandNoRecheckr;
            Z209BR_Encounter_IsRandRecheckDate = A209BR_Encounter_IsRandRecheckDate;
            Z210BR_Encounter_IsRandNoRecheckDate = A210BR_Encounter_IsRandNoRecheckDate;
            Z202BR_Encounter_IsUpdate = A202BR_Encounter_IsUpdate;
            Z537BR_Encounter_Datasource = A537BR_Encounter_Datasource;
            Z560EncounterIDEncrypt = A560EncounterIDEncrypt;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
         }
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
         if ( ( GX_JID == 34 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 35 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -32 )
         {
            Z19BR_EncounterID = A19BR_EncounterID;
            Z35BR_Encounter_EncID = A35BR_Encounter_EncID;
            Z172BR_Encounter_Status = A172BR_Encounter_Status;
            Z183BR_Encounter_CrtUser = A183BR_Encounter_CrtUser;
            Z512BR_Encounter_CrtDisplayName = A512BR_Encounter_CrtDisplayName;
            Z182BR_Encounter_CrtDate = A182BR_Encounter_CrtDate;
            Z470BR_Encounter_Department_Code = A470BR_Encounter_Department_Code;
            Z471BR_Encounter_ENCType_Code = A471BR_Encounter_ENCType_Code;
            Z472BR_Encounter_AdmitSource_Code = A472BR_Encounter_AdmitSource_Code;
            Z473BR_Encounter_DischargeStatus_Code = A473BR_Encounter_DischargeStatus_Code;
            Z84BR_Encounter_Department = A84BR_Encounter_Department;
            Z570BR_Encounter_Departmentadm = A570BR_Encounter_Departmentadm;
            Z571BR_Encounter_Departmentadm_Code = A571BR_Encounter_Departmentadm_Code;
            Z572BR_Encounter_Departmentdisch = A572BR_Encounter_Departmentdisch;
            Z573BR_Encounter_Departmentdisch_Code = A573BR_Encounter_Departmentdisch_Code;
            Z90BR_Encounter_ENCType = A90BR_Encounter_ENCType;
            Z91BR_Encounter_AdmitDate = A91BR_Encounter_AdmitDate;
            Z92BR_Encounter_AdmitSource = A92BR_Encounter_AdmitSource;
            Z93BR_Encounter_DischargeDate = A93BR_Encounter_DischargeDate;
            Z94BR_Encounter_DischargeStatus = A94BR_Encounter_DischargeStatus;
            Z574BR_Encounter_Insurance = A574BR_Encounter_Insurance;
            Z575BR_Encounter_Insurance_Code = A575BR_Encounter_Insurance_Code;
            Z187BR_Encounter_UpdDate = A187BR_Encounter_UpdDate;
            Z186BR_Encounter_UpdUser = A186BR_Encounter_UpdUser;
            Z333BR_Encounter_IsDLT = A333BR_Encounter_IsDLT;
            Z184BR_Encounter_SubmitUser = A184BR_Encounter_SubmitUser;
            Z335BR_Encounter_Reason = A335BR_Encounter_Reason;
            Z185BR_Encounter_SubmitDate = A185BR_Encounter_SubmitDate;
            Z188BR_Encounter_RecheckUser = A188BR_Encounter_RecheckUser;
            Z336BR_Encounter_FReason = A336BR_Encounter_FReason;
            Z189BR_Encounter_RecheckDate = A189BR_Encounter_RecheckDate;
            Z190BR_Encounter_Approver = A190BR_Encounter_Approver;
            Z191BR_Encounter_ApproveDate = A191BR_Encounter_ApproveDate;
            Z192BR_Encounter_IsRandApprove = A192BR_Encounter_IsRandApprove;
            Z203BR_Encounter_IsRandApprover = A203BR_Encounter_IsRandApprover;
            Z204BR_Encounter_IsRandNoApprover = A204BR_Encounter_IsRandNoApprover;
            Z205BR_Encounter_IsRandApproveDate = A205BR_Encounter_IsRandApproveDate;
            Z206BR_Encounter_IsRandNoApproveDate = A206BR_Encounter_IsRandNoApproveDate;
            Z193BR_Encounter_IsRandRecheck = A193BR_Encounter_IsRandRecheck;
            Z207BR_Encounter_IsRandRecheckr = A207BR_Encounter_IsRandRecheckr;
            Z208BR_Encounter_IsRandNoRecheckr = A208BR_Encounter_IsRandNoRecheckr;
            Z209BR_Encounter_IsRandRecheckDate = A209BR_Encounter_IsRandRecheckDate;
            Z210BR_Encounter_IsRandNoRecheckDate = A210BR_Encounter_IsRandNoRecheckDate;
            Z202BR_Encounter_IsUpdate = A202BR_Encounter_IsUpdate;
            Z537BR_Encounter_Datasource = A537BR_Encounter_Datasource;
            Z560EncounterIDEncrypt = A560EncounterIDEncrypt;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z360BAS_TenantTenantCode = A360BAS_TenantTenantCode;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0E15( )
      {
         /* Using cursor BC000E7 */
         pr_default.execute(4, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound15 = 1;
            A35BR_Encounter_EncID = BC000E7_A35BR_Encounter_EncID[0];
            n35BR_Encounter_EncID = BC000E7_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = BC000E7_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = BC000E7_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = BC000E7_A183BR_Encounter_CrtUser[0];
            n183BR_Encounter_CrtUser = BC000E7_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = BC000E7_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = BC000E7_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = BC000E7_A182BR_Encounter_CrtDate[0];
            n182BR_Encounter_CrtDate = BC000E7_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = BC000E7_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = BC000E7_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = BC000E7_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = BC000E7_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = BC000E7_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = BC000E7_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = BC000E7_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = BC000E7_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = BC000E7_A84BR_Encounter_Department[0];
            n84BR_Encounter_Department = BC000E7_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = BC000E7_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = BC000E7_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = BC000E7_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = BC000E7_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = BC000E7_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = BC000E7_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = BC000E7_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = BC000E7_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = BC000E7_A90BR_Encounter_ENCType[0];
            n90BR_Encounter_ENCType = BC000E7_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = BC000E7_A91BR_Encounter_AdmitDate[0];
            n91BR_Encounter_AdmitDate = BC000E7_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = BC000E7_A92BR_Encounter_AdmitSource[0];
            n92BR_Encounter_AdmitSource = BC000E7_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = BC000E7_A93BR_Encounter_DischargeDate[0];
            n93BR_Encounter_DischargeDate = BC000E7_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = BC000E7_A94BR_Encounter_DischargeStatus[0];
            n94BR_Encounter_DischargeStatus = BC000E7_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = BC000E7_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = BC000E7_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = BC000E7_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = BC000E7_n575BR_Encounter_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000E7_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000E7_n36BR_Information_PatientNo[0];
            A187BR_Encounter_UpdDate = BC000E7_A187BR_Encounter_UpdDate[0];
            n187BR_Encounter_UpdDate = BC000E7_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = BC000E7_A186BR_Encounter_UpdUser[0];
            n186BR_Encounter_UpdUser = BC000E7_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = BC000E7_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = BC000E7_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = BC000E7_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = BC000E7_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = BC000E7_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = BC000E7_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = BC000E7_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = BC000E7_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = BC000E7_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = BC000E7_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = BC000E7_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = BC000E7_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = BC000E7_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = BC000E7_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = BC000E7_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = BC000E7_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = BC000E7_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = BC000E7_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = BC000E7_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = BC000E7_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = BC000E7_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = BC000E7_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = BC000E7_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = BC000E7_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = BC000E7_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = BC000E7_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = BC000E7_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = BC000E7_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = BC000E7_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = BC000E7_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = BC000E7_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = BC000E7_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = BC000E7_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = BC000E7_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = BC000E7_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = BC000E7_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = BC000E7_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = BC000E7_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = BC000E7_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = BC000E7_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = BC000E7_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = BC000E7_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = BC000E7_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = BC000E7_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = BC000E7_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000E7_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC000E7_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC000E7_n360BAS_TenantTenantCode[0];
            ZM0E15( -32) ;
         }
         pr_default.close(4);
         OnLoadActions0E15( ) ;
      }

      protected void OnLoadActions0E15( )
      {
         AV31Pgmname = "BR_Encounter_BC";
      }

      protected void CheckExtendedTable0E15( )
      {
         standaloneModal( ) ;
         AV31Pgmname = "BR_Encounter_BC";
         if ( ! ( (DateTime.MinValue==A91BR_Encounter_AdmitDate) || ( A91BR_Encounter_AdmitDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������/������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A93BR_Encounter_DischargeDate) || ( A93BR_Encounter_DischargeDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A172BR_Encounter_Status == 1 ) || ( A172BR_Encounter_Status == 2 ) || ( A172BR_Encounter_Status == 3 ) || ( A172BR_Encounter_Status == 4 ) || ( A172BR_Encounter_Status == 5 ) || ( A172BR_Encounter_Status == 6 ) || (0==A172BR_Encounter_Status) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC000E4 */
         pr_default.execute(2, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = BC000E4_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = BC000E4_n36BR_Information_PatientNo[0];
         pr_default.close(2);
         /* Using cursor BC000E6 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) || String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配' T64'", "ForeignKeyNotFound", 1, "BR_INFORMATION_ID");
               AnyError = 1;
            }
         }
         pr_default.close(3);
         if ( (0==A85BR_Information_ID) )
         {
            GX_msglist.addItem("患者是必须选择的", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC000E5 */
         pr_datastore1.execute(0, new Object[] {n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
         if ( (pr_datastore1.getStatus(0) == 101) )
         {
            if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) ) )
            {
               GX_msglist.addItem("不匹配'BAS_Tenant'", "ForeignKeyNotFound", 1, "BAS_TENANTTENANTCODE");
               AnyError = 1;
            }
         }
         pr_datastore1.close(0);
         if ( ! ( (DateTime.MinValue==A182BR_Encounter_CrtDate) || ( A182BR_Encounter_CrtDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A187BR_Encounter_UpdDate) || ( A187BR_Encounter_UpdDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A185BR_Encounter_SubmitDate) || ( A185BR_Encounter_SubmitDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A189BR_Encounter_RecheckDate) || ( A189BR_Encounter_RecheckDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A191BR_Encounter_ApproveDate) || ( A191BR_Encounter_ApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������������/������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A205BR_Encounter_IsRandApproveDate) || ( A205BR_Encounter_IsRandApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A206BR_Encounter_IsRandNoApproveDate) || ( A206BR_Encounter_IsRandNoApproveDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域���������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A209BR_Encounter_IsRandRecheckDate) || ( A209BR_Encounter_IsRandRecheckDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( (DateTime.MinValue==A210BR_Encounter_IsRandNoRecheckDate) || ( A210BR_Encounter_IsRandNoRecheckDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域���������������������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ! ( ( A537BR_Encounter_Datasource == 1 ) || (0==A537BR_Encounter_Datasource) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0E15( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_datastore1.close(0);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0E15( )
      {
         /* Using cursor BC000E8 */
         pr_default.execute(5, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC000E3 */
         pr_default.execute(1, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0E15( 32) ;
            RcdFound15 = 1;
            A19BR_EncounterID = BC000E3_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000E3_n19BR_EncounterID[0];
            A35BR_Encounter_EncID = BC000E3_A35BR_Encounter_EncID[0];
            n35BR_Encounter_EncID = BC000E3_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = BC000E3_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = BC000E3_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = BC000E3_A183BR_Encounter_CrtUser[0];
            n183BR_Encounter_CrtUser = BC000E3_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = BC000E3_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = BC000E3_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = BC000E3_A182BR_Encounter_CrtDate[0];
            n182BR_Encounter_CrtDate = BC000E3_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = BC000E3_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = BC000E3_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = BC000E3_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = BC000E3_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = BC000E3_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = BC000E3_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = BC000E3_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = BC000E3_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = BC000E3_A84BR_Encounter_Department[0];
            n84BR_Encounter_Department = BC000E3_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = BC000E3_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = BC000E3_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = BC000E3_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = BC000E3_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = BC000E3_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = BC000E3_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = BC000E3_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = BC000E3_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = BC000E3_A90BR_Encounter_ENCType[0];
            n90BR_Encounter_ENCType = BC000E3_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = BC000E3_A91BR_Encounter_AdmitDate[0];
            n91BR_Encounter_AdmitDate = BC000E3_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = BC000E3_A92BR_Encounter_AdmitSource[0];
            n92BR_Encounter_AdmitSource = BC000E3_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = BC000E3_A93BR_Encounter_DischargeDate[0];
            n93BR_Encounter_DischargeDate = BC000E3_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = BC000E3_A94BR_Encounter_DischargeStatus[0];
            n94BR_Encounter_DischargeStatus = BC000E3_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = BC000E3_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = BC000E3_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = BC000E3_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = BC000E3_n575BR_Encounter_Insurance_Code[0];
            A187BR_Encounter_UpdDate = BC000E3_A187BR_Encounter_UpdDate[0];
            n187BR_Encounter_UpdDate = BC000E3_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = BC000E3_A186BR_Encounter_UpdUser[0];
            n186BR_Encounter_UpdUser = BC000E3_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = BC000E3_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = BC000E3_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = BC000E3_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = BC000E3_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = BC000E3_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = BC000E3_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = BC000E3_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = BC000E3_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = BC000E3_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = BC000E3_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = BC000E3_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = BC000E3_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = BC000E3_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = BC000E3_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = BC000E3_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = BC000E3_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = BC000E3_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = BC000E3_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = BC000E3_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = BC000E3_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = BC000E3_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = BC000E3_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = BC000E3_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = BC000E3_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = BC000E3_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = BC000E3_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = BC000E3_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = BC000E3_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = BC000E3_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = BC000E3_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = BC000E3_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = BC000E3_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = BC000E3_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = BC000E3_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = BC000E3_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = BC000E3_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = BC000E3_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = BC000E3_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = BC000E3_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = BC000E3_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = BC000E3_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = BC000E3_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = BC000E3_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = BC000E3_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = BC000E3_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000E3_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC000E3_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC000E3_n360BAS_TenantTenantCode[0];
            Z19BR_EncounterID = A19BR_EncounterID;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0E15( ) ;
            if ( AnyError == 1 )
            {
               RcdFound15 = 0;
               InitializeNonKey0E15( ) ;
            }
            Gx_mode = sMode15;
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0E15( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode15;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0E15( ) ;
         if ( RcdFound15 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_0E0( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0E15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC000E2 */
            pr_default.execute(0, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z35BR_Encounter_EncID != BC000E2_A35BR_Encounter_EncID[0] ) || ( Z172BR_Encounter_Status != BC000E2_A172BR_Encounter_Status[0] ) || ( StringUtil.StrCmp(Z183BR_Encounter_CrtUser, BC000E2_A183BR_Encounter_CrtUser[0]) != 0 ) || ( StringUtil.StrCmp(Z512BR_Encounter_CrtDisplayName, BC000E2_A512BR_Encounter_CrtDisplayName[0]) != 0 ) || ( Z182BR_Encounter_CrtDate != BC000E2_A182BR_Encounter_CrtDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z470BR_Encounter_Department_Code, BC000E2_A470BR_Encounter_Department_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z471BR_Encounter_ENCType_Code, BC000E2_A471BR_Encounter_ENCType_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z472BR_Encounter_AdmitSource_Code, BC000E2_A472BR_Encounter_AdmitSource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z473BR_Encounter_DischargeStatus_Code, BC000E2_A473BR_Encounter_DischargeStatus_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z84BR_Encounter_Department, BC000E2_A84BR_Encounter_Department[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z570BR_Encounter_Departmentadm, BC000E2_A570BR_Encounter_Departmentadm[0]) != 0 ) || ( StringUtil.StrCmp(Z571BR_Encounter_Departmentadm_Code, BC000E2_A571BR_Encounter_Departmentadm_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z572BR_Encounter_Departmentdisch, BC000E2_A572BR_Encounter_Departmentdisch[0]) != 0 ) || ( StringUtil.StrCmp(Z573BR_Encounter_Departmentdisch_Code, BC000E2_A573BR_Encounter_Departmentdisch_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z90BR_Encounter_ENCType, BC000E2_A90BR_Encounter_ENCType[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z91BR_Encounter_AdmitDate != BC000E2_A91BR_Encounter_AdmitDate[0] ) || ( StringUtil.StrCmp(Z92BR_Encounter_AdmitSource, BC000E2_A92BR_Encounter_AdmitSource[0]) != 0 ) || ( Z93BR_Encounter_DischargeDate != BC000E2_A93BR_Encounter_DischargeDate[0] ) || ( StringUtil.StrCmp(Z94BR_Encounter_DischargeStatus, BC000E2_A94BR_Encounter_DischargeStatus[0]) != 0 ) || ( StringUtil.StrCmp(Z574BR_Encounter_Insurance, BC000E2_A574BR_Encounter_Insurance[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z575BR_Encounter_Insurance_Code, BC000E2_A575BR_Encounter_Insurance_Code[0]) != 0 ) || ( Z187BR_Encounter_UpdDate != BC000E2_A187BR_Encounter_UpdDate[0] ) || ( StringUtil.StrCmp(Z186BR_Encounter_UpdUser, BC000E2_A186BR_Encounter_UpdUser[0]) != 0 ) || ( Z333BR_Encounter_IsDLT != BC000E2_A333BR_Encounter_IsDLT[0] ) || ( StringUtil.StrCmp(Z184BR_Encounter_SubmitUser, BC000E2_A184BR_Encounter_SubmitUser[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z335BR_Encounter_Reason, BC000E2_A335BR_Encounter_Reason[0]) != 0 ) || ( Z185BR_Encounter_SubmitDate != BC000E2_A185BR_Encounter_SubmitDate[0] ) || ( StringUtil.StrCmp(Z188BR_Encounter_RecheckUser, BC000E2_A188BR_Encounter_RecheckUser[0]) != 0 ) || ( StringUtil.StrCmp(Z336BR_Encounter_FReason, BC000E2_A336BR_Encounter_FReason[0]) != 0 ) || ( Z189BR_Encounter_RecheckDate != BC000E2_A189BR_Encounter_RecheckDate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z190BR_Encounter_Approver, BC000E2_A190BR_Encounter_Approver[0]) != 0 ) || ( Z191BR_Encounter_ApproveDate != BC000E2_A191BR_Encounter_ApproveDate[0] ) || ( Z192BR_Encounter_IsRandApprove != BC000E2_A192BR_Encounter_IsRandApprove[0] ) || ( StringUtil.StrCmp(Z203BR_Encounter_IsRandApprover, BC000E2_A203BR_Encounter_IsRandApprover[0]) != 0 ) || ( StringUtil.StrCmp(Z204BR_Encounter_IsRandNoApprover, BC000E2_A204BR_Encounter_IsRandNoApprover[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z205BR_Encounter_IsRandApproveDate != BC000E2_A205BR_Encounter_IsRandApproveDate[0] ) || ( Z206BR_Encounter_IsRandNoApproveDate != BC000E2_A206BR_Encounter_IsRandNoApproveDate[0] ) || ( Z193BR_Encounter_IsRandRecheck != BC000E2_A193BR_Encounter_IsRandRecheck[0] ) || ( StringUtil.StrCmp(Z207BR_Encounter_IsRandRecheckr, BC000E2_A207BR_Encounter_IsRandRecheckr[0]) != 0 ) || ( StringUtil.StrCmp(Z208BR_Encounter_IsRandNoRecheckr, BC000E2_A208BR_Encounter_IsRandNoRecheckr[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z209BR_Encounter_IsRandRecheckDate != BC000E2_A209BR_Encounter_IsRandRecheckDate[0] ) || ( Z210BR_Encounter_IsRandNoRecheckDate != BC000E2_A210BR_Encounter_IsRandNoRecheckDate[0] ) || ( Z202BR_Encounter_IsUpdate != BC000E2_A202BR_Encounter_IsUpdate[0] ) || ( Z537BR_Encounter_Datasource != BC000E2_A537BR_Encounter_Datasource[0] ) || ( StringUtil.StrCmp(Z560EncounterIDEncrypt, BC000E2_A560EncounterIDEncrypt[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z85BR_Information_ID != BC000E2_A85BR_Information_ID[0] ) || ( StringUtil.StrCmp(Z360BAS_TenantTenantCode, BC000E2_A360BAS_TenantTenantCode[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Encounter"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0E15( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0E15( 0) ;
            CheckOptimisticConcurrency0E15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0E15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000E9 */
                     pr_default.execute(6, new Object[] {n35BR_Encounter_EncID, A35BR_Encounter_EncID, n172BR_Encounter_Status, A172BR_Encounter_Status, n183BR_Encounter_CrtUser, A183BR_Encounter_CrtUser, n512BR_Encounter_CrtDisplayName, A512BR_Encounter_CrtDisplayName, n182BR_Encounter_CrtDate, A182BR_Encounter_CrtDate, n470BR_Encounter_Department_Code, A470BR_Encounter_Department_Code, n471BR_Encounter_ENCType_Code, A471BR_Encounter_ENCType_Code, n472BR_Encounter_AdmitSource_Code, A472BR_Encounter_AdmitSource_Code, n473BR_Encounter_DischargeStatus_Code, A473BR_Encounter_DischargeStatus_Code, n84BR_Encounter_Department, A84BR_Encounter_Department, n570BR_Encounter_Departmentadm, A570BR_Encounter_Departmentadm, n571BR_Encounter_Departmentadm_Code, A571BR_Encounter_Departmentadm_Code, n572BR_Encounter_Departmentdisch, A572BR_Encounter_Departmentdisch, n573BR_Encounter_Departmentdisch_Code, A573BR_Encounter_Departmentdisch_Code, n90BR_Encounter_ENCType, A90BR_Encounter_ENCType, n91BR_Encounter_AdmitDate, A91BR_Encounter_AdmitDate, n92BR_Encounter_AdmitSource, A92BR_Encounter_AdmitSource, n93BR_Encounter_DischargeDate, A93BR_Encounter_DischargeDate, n94BR_Encounter_DischargeStatus, A94BR_Encounter_DischargeStatus, n574BR_Encounter_Insurance, A574BR_Encounter_Insurance, n575BR_Encounter_Insurance_Code, A575BR_Encounter_Insurance_Code, n187BR_Encounter_UpdDate, A187BR_Encounter_UpdDate, n186BR_Encounter_UpdUser, A186BR_Encounter_UpdUser, n333BR_Encounter_IsDLT, A333BR_Encounter_IsDLT, n184BR_Encounter_SubmitUser, A184BR_Encounter_SubmitUser, n335BR_Encounter_Reason, A335BR_Encounter_Reason, n185BR_Encounter_SubmitDate, A185BR_Encounter_SubmitDate, n188BR_Encounter_RecheckUser, A188BR_Encounter_RecheckUser, n336BR_Encounter_FReason, A336BR_Encounter_FReason, n189BR_Encounter_RecheckDate, A189BR_Encounter_RecheckDate, n190BR_Encounter_Approver, A190BR_Encounter_Approver, n191BR_Encounter_ApproveDate, A191BR_Encounter_ApproveDate, n192BR_Encounter_IsRandApprove, A192BR_Encounter_IsRandApprove, n203BR_Encounter_IsRandApprover, A203BR_Encounter_IsRandApprover, n204BR_Encounter_IsRandNoApprover, A204BR_Encounter_IsRandNoApprover, n205BR_Encounter_IsRandApproveDate, A205BR_Encounter_IsRandApproveDate, n206BR_Encounter_IsRandNoApproveDate, A206BR_Encounter_IsRandNoApproveDate, n193BR_Encounter_IsRandRecheck, A193BR_Encounter_IsRandRecheck, n207BR_Encounter_IsRandRecheckr, A207BR_Encounter_IsRandRecheckr, n208BR_Encounter_IsRandNoRecheckr, A208BR_Encounter_IsRandNoRecheckr, n209BR_Encounter_IsRandRecheckDate, A209BR_Encounter_IsRandRecheckDate, n210BR_Encounter_IsRandNoRecheckDate, A210BR_Encounter_IsRandNoRecheckDate, n202BR_Encounter_IsUpdate, A202BR_Encounter_IsUpdate, n537BR_Encounter_Datasource, A537BR_Encounter_Datasource, n560EncounterIDEncrypt, A560EncounterIDEncrypt, n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode});
                     A19BR_EncounterID = BC000E9_A19BR_EncounterID[0];
                     n19BR_EncounterID = BC000E9_n19BR_EncounterID[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordlog(context ).execute(  StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0),  "就诊信息",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0E15( ) ;
            }
            EndLevel0E15( ) ;
         }
         CloseExtendedTableCursors0E15( ) ;
      }

      protected void Update0E15( )
      {
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E15( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0E15( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0E15( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000E10 */
                     pr_default.execute(7, new Object[] {n35BR_Encounter_EncID, A35BR_Encounter_EncID, n172BR_Encounter_Status, A172BR_Encounter_Status, n183BR_Encounter_CrtUser, A183BR_Encounter_CrtUser, n512BR_Encounter_CrtDisplayName, A512BR_Encounter_CrtDisplayName, n182BR_Encounter_CrtDate, A182BR_Encounter_CrtDate, n470BR_Encounter_Department_Code, A470BR_Encounter_Department_Code, n471BR_Encounter_ENCType_Code, A471BR_Encounter_ENCType_Code, n472BR_Encounter_AdmitSource_Code, A472BR_Encounter_AdmitSource_Code, n473BR_Encounter_DischargeStatus_Code, A473BR_Encounter_DischargeStatus_Code, n84BR_Encounter_Department, A84BR_Encounter_Department, n570BR_Encounter_Departmentadm, A570BR_Encounter_Departmentadm, n571BR_Encounter_Departmentadm_Code, A571BR_Encounter_Departmentadm_Code, n572BR_Encounter_Departmentdisch, A572BR_Encounter_Departmentdisch, n573BR_Encounter_Departmentdisch_Code, A573BR_Encounter_Departmentdisch_Code, n90BR_Encounter_ENCType, A90BR_Encounter_ENCType, n91BR_Encounter_AdmitDate, A91BR_Encounter_AdmitDate, n92BR_Encounter_AdmitSource, A92BR_Encounter_AdmitSource, n93BR_Encounter_DischargeDate, A93BR_Encounter_DischargeDate, n94BR_Encounter_DischargeStatus, A94BR_Encounter_DischargeStatus, n574BR_Encounter_Insurance, A574BR_Encounter_Insurance, n575BR_Encounter_Insurance_Code, A575BR_Encounter_Insurance_Code, n187BR_Encounter_UpdDate, A187BR_Encounter_UpdDate, n186BR_Encounter_UpdUser, A186BR_Encounter_UpdUser, n333BR_Encounter_IsDLT, A333BR_Encounter_IsDLT, n184BR_Encounter_SubmitUser, A184BR_Encounter_SubmitUser, n335BR_Encounter_Reason, A335BR_Encounter_Reason, n185BR_Encounter_SubmitDate, A185BR_Encounter_SubmitDate, n188BR_Encounter_RecheckUser, A188BR_Encounter_RecheckUser, n336BR_Encounter_FReason, A336BR_Encounter_FReason, n189BR_Encounter_RecheckDate, A189BR_Encounter_RecheckDate, n190BR_Encounter_Approver, A190BR_Encounter_Approver, n191BR_Encounter_ApproveDate, A191BR_Encounter_ApproveDate, n192BR_Encounter_IsRandApprove, A192BR_Encounter_IsRandApprove, n203BR_Encounter_IsRandApprover, A203BR_Encounter_IsRandApprover, n204BR_Encounter_IsRandNoApprover, A204BR_Encounter_IsRandNoApprover, n205BR_Encounter_IsRandApproveDate, A205BR_Encounter_IsRandApproveDate, n206BR_Encounter_IsRandNoApproveDate, A206BR_Encounter_IsRandNoApproveDate, n193BR_Encounter_IsRandRecheck, A193BR_Encounter_IsRandRecheck, n207BR_Encounter_IsRandRecheckr, A207BR_Encounter_IsRandRecheckr, n208BR_Encounter_IsRandNoRecheckr, A208BR_Encounter_IsRandNoRecheckr, n209BR_Encounter_IsRandRecheckDate, A209BR_Encounter_IsRandRecheckDate, n210BR_Encounter_IsRandNoRecheckDate, A210BR_Encounter_IsRandNoRecheckDate, n202BR_Encounter_IsUpdate, A202BR_Encounter_IsUpdate, n537BR_Encounter_Datasource, A537BR_Encounter_Datasource, n560EncounterIDEncrypt, A560EncounterIDEncrypt, n85BR_Information_ID, A85BR_Information_ID, n360BAS_TenantTenantCode, A360BAS_TenantTenantCode, n19BR_EncounterID, A19BR_EncounterID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Encounter"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0E15( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0E15( ) ;
         }
         CloseExtendedTableCursors0E15( ) ;
      }

      protected void DeferredUpdate0E15( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0E15( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0E15( ) ;
            AfterConfirm0E15( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0E15( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000E11 */
                  pr_default.execute(8, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Encounter") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0E15( ) ;
         Gx_mode = sMode15;
      }

      protected void OnDeleteControls0E15( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV31Pgmname = "BR_Encounter_BC";
            /* Using cursor BC000E12 */
            pr_default.execute(9, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = BC000E12_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000E12_n36BR_Information_PatientNo[0];
            pr_default.close(9);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000E13 */
            pr_default.execute(10, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(10) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T42"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(10);
            /* Using cursor BC000E14 */
            pr_default.execute(11, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T41"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
            /* Using cursor BC000E15 */
            pr_default.execute(12, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(12) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T39"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(12);
            /* Using cursor BC000E16 */
            pr_default.execute(13, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(13) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T36"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(13);
            /* Using cursor BC000E17 */
            pr_default.execute(14, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(14) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T30"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(14);
            /* Using cursor BC000E18 */
            pr_default.execute(15, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T20"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor BC000E19 */
            pr_default.execute(16, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T19"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor BC000E20 */
            pr_default.execute(17, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T18"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
            /* Using cursor BC000E21 */
            pr_default.execute(18, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(18) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T17"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(18);
            /* Using cursor BC000E22 */
            pr_default.execute(19, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(19) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T13"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(19);
            /* Using cursor BC000E23 */
            pr_default.execute(20, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(20) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T12"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(20);
            /* Using cursor BC000E24 */
            pr_default.execute(21, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(21) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T11"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(21);
            /* Using cursor BC000E25 */
            pr_default.execute(22, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(22) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T10"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(22);
            /* Using cursor BC000E26 */
            pr_default.execute(23, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            if ( (pr_default.getStatus(23) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T9"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(23);
         }
      }

      protected void EndLevel0E15( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0E15( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart0E15( )
      {
         /* Scan By routine */
         /* Using cursor BC000E27 */
         pr_default.execute(24, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         RcdFound15 = 0;
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound15 = 1;
            A19BR_EncounterID = BC000E27_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000E27_n19BR_EncounterID[0];
            A35BR_Encounter_EncID = BC000E27_A35BR_Encounter_EncID[0];
            n35BR_Encounter_EncID = BC000E27_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = BC000E27_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = BC000E27_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = BC000E27_A183BR_Encounter_CrtUser[0];
            n183BR_Encounter_CrtUser = BC000E27_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = BC000E27_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = BC000E27_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = BC000E27_A182BR_Encounter_CrtDate[0];
            n182BR_Encounter_CrtDate = BC000E27_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = BC000E27_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = BC000E27_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = BC000E27_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = BC000E27_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = BC000E27_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = BC000E27_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = BC000E27_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = BC000E27_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = BC000E27_A84BR_Encounter_Department[0];
            n84BR_Encounter_Department = BC000E27_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = BC000E27_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = BC000E27_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = BC000E27_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = BC000E27_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = BC000E27_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = BC000E27_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = BC000E27_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = BC000E27_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = BC000E27_A90BR_Encounter_ENCType[0];
            n90BR_Encounter_ENCType = BC000E27_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = BC000E27_A91BR_Encounter_AdmitDate[0];
            n91BR_Encounter_AdmitDate = BC000E27_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = BC000E27_A92BR_Encounter_AdmitSource[0];
            n92BR_Encounter_AdmitSource = BC000E27_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = BC000E27_A93BR_Encounter_DischargeDate[0];
            n93BR_Encounter_DischargeDate = BC000E27_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = BC000E27_A94BR_Encounter_DischargeStatus[0];
            n94BR_Encounter_DischargeStatus = BC000E27_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = BC000E27_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = BC000E27_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = BC000E27_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = BC000E27_n575BR_Encounter_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000E27_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000E27_n36BR_Information_PatientNo[0];
            A187BR_Encounter_UpdDate = BC000E27_A187BR_Encounter_UpdDate[0];
            n187BR_Encounter_UpdDate = BC000E27_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = BC000E27_A186BR_Encounter_UpdUser[0];
            n186BR_Encounter_UpdUser = BC000E27_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = BC000E27_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = BC000E27_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = BC000E27_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = BC000E27_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = BC000E27_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = BC000E27_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = BC000E27_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = BC000E27_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = BC000E27_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = BC000E27_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = BC000E27_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = BC000E27_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = BC000E27_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = BC000E27_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = BC000E27_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = BC000E27_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = BC000E27_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = BC000E27_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = BC000E27_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = BC000E27_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = BC000E27_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = BC000E27_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = BC000E27_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = BC000E27_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = BC000E27_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = BC000E27_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = BC000E27_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = BC000E27_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = BC000E27_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = BC000E27_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = BC000E27_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = BC000E27_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = BC000E27_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = BC000E27_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = BC000E27_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = BC000E27_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = BC000E27_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = BC000E27_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = BC000E27_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = BC000E27_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = BC000E27_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = BC000E27_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = BC000E27_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = BC000E27_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = BC000E27_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000E27_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC000E27_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC000E27_n360BAS_TenantTenantCode[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0E15( )
      {
         /* Scan next routine */
         pr_default.readNext(24);
         RcdFound15 = 0;
         ScanKeyLoad0E15( ) ;
      }

      protected void ScanKeyLoad0E15( )
      {
         sMode15 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(24) != 101) )
         {
            RcdFound15 = 1;
            A19BR_EncounterID = BC000E27_A19BR_EncounterID[0];
            n19BR_EncounterID = BC000E27_n19BR_EncounterID[0];
            A35BR_Encounter_EncID = BC000E27_A35BR_Encounter_EncID[0];
            n35BR_Encounter_EncID = BC000E27_n35BR_Encounter_EncID[0];
            A172BR_Encounter_Status = BC000E27_A172BR_Encounter_Status[0];
            n172BR_Encounter_Status = BC000E27_n172BR_Encounter_Status[0];
            A183BR_Encounter_CrtUser = BC000E27_A183BR_Encounter_CrtUser[0];
            n183BR_Encounter_CrtUser = BC000E27_n183BR_Encounter_CrtUser[0];
            A512BR_Encounter_CrtDisplayName = BC000E27_A512BR_Encounter_CrtDisplayName[0];
            n512BR_Encounter_CrtDisplayName = BC000E27_n512BR_Encounter_CrtDisplayName[0];
            A182BR_Encounter_CrtDate = BC000E27_A182BR_Encounter_CrtDate[0];
            n182BR_Encounter_CrtDate = BC000E27_n182BR_Encounter_CrtDate[0];
            A470BR_Encounter_Department_Code = BC000E27_A470BR_Encounter_Department_Code[0];
            n470BR_Encounter_Department_Code = BC000E27_n470BR_Encounter_Department_Code[0];
            A471BR_Encounter_ENCType_Code = BC000E27_A471BR_Encounter_ENCType_Code[0];
            n471BR_Encounter_ENCType_Code = BC000E27_n471BR_Encounter_ENCType_Code[0];
            A472BR_Encounter_AdmitSource_Code = BC000E27_A472BR_Encounter_AdmitSource_Code[0];
            n472BR_Encounter_AdmitSource_Code = BC000E27_n472BR_Encounter_AdmitSource_Code[0];
            A473BR_Encounter_DischargeStatus_Code = BC000E27_A473BR_Encounter_DischargeStatus_Code[0];
            n473BR_Encounter_DischargeStatus_Code = BC000E27_n473BR_Encounter_DischargeStatus_Code[0];
            A84BR_Encounter_Department = BC000E27_A84BR_Encounter_Department[0];
            n84BR_Encounter_Department = BC000E27_n84BR_Encounter_Department[0];
            A570BR_Encounter_Departmentadm = BC000E27_A570BR_Encounter_Departmentadm[0];
            n570BR_Encounter_Departmentadm = BC000E27_n570BR_Encounter_Departmentadm[0];
            A571BR_Encounter_Departmentadm_Code = BC000E27_A571BR_Encounter_Departmentadm_Code[0];
            n571BR_Encounter_Departmentadm_Code = BC000E27_n571BR_Encounter_Departmentadm_Code[0];
            A572BR_Encounter_Departmentdisch = BC000E27_A572BR_Encounter_Departmentdisch[0];
            n572BR_Encounter_Departmentdisch = BC000E27_n572BR_Encounter_Departmentdisch[0];
            A573BR_Encounter_Departmentdisch_Code = BC000E27_A573BR_Encounter_Departmentdisch_Code[0];
            n573BR_Encounter_Departmentdisch_Code = BC000E27_n573BR_Encounter_Departmentdisch_Code[0];
            A90BR_Encounter_ENCType = BC000E27_A90BR_Encounter_ENCType[0];
            n90BR_Encounter_ENCType = BC000E27_n90BR_Encounter_ENCType[0];
            A91BR_Encounter_AdmitDate = BC000E27_A91BR_Encounter_AdmitDate[0];
            n91BR_Encounter_AdmitDate = BC000E27_n91BR_Encounter_AdmitDate[0];
            A92BR_Encounter_AdmitSource = BC000E27_A92BR_Encounter_AdmitSource[0];
            n92BR_Encounter_AdmitSource = BC000E27_n92BR_Encounter_AdmitSource[0];
            A93BR_Encounter_DischargeDate = BC000E27_A93BR_Encounter_DischargeDate[0];
            n93BR_Encounter_DischargeDate = BC000E27_n93BR_Encounter_DischargeDate[0];
            A94BR_Encounter_DischargeStatus = BC000E27_A94BR_Encounter_DischargeStatus[0];
            n94BR_Encounter_DischargeStatus = BC000E27_n94BR_Encounter_DischargeStatus[0];
            A574BR_Encounter_Insurance = BC000E27_A574BR_Encounter_Insurance[0];
            n574BR_Encounter_Insurance = BC000E27_n574BR_Encounter_Insurance[0];
            A575BR_Encounter_Insurance_Code = BC000E27_A575BR_Encounter_Insurance_Code[0];
            n575BR_Encounter_Insurance_Code = BC000E27_n575BR_Encounter_Insurance_Code[0];
            A36BR_Information_PatientNo = BC000E27_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = BC000E27_n36BR_Information_PatientNo[0];
            A187BR_Encounter_UpdDate = BC000E27_A187BR_Encounter_UpdDate[0];
            n187BR_Encounter_UpdDate = BC000E27_n187BR_Encounter_UpdDate[0];
            A186BR_Encounter_UpdUser = BC000E27_A186BR_Encounter_UpdUser[0];
            n186BR_Encounter_UpdUser = BC000E27_n186BR_Encounter_UpdUser[0];
            A333BR_Encounter_IsDLT = BC000E27_A333BR_Encounter_IsDLT[0];
            n333BR_Encounter_IsDLT = BC000E27_n333BR_Encounter_IsDLT[0];
            A184BR_Encounter_SubmitUser = BC000E27_A184BR_Encounter_SubmitUser[0];
            n184BR_Encounter_SubmitUser = BC000E27_n184BR_Encounter_SubmitUser[0];
            A335BR_Encounter_Reason = BC000E27_A335BR_Encounter_Reason[0];
            n335BR_Encounter_Reason = BC000E27_n335BR_Encounter_Reason[0];
            A185BR_Encounter_SubmitDate = BC000E27_A185BR_Encounter_SubmitDate[0];
            n185BR_Encounter_SubmitDate = BC000E27_n185BR_Encounter_SubmitDate[0];
            A188BR_Encounter_RecheckUser = BC000E27_A188BR_Encounter_RecheckUser[0];
            n188BR_Encounter_RecheckUser = BC000E27_n188BR_Encounter_RecheckUser[0];
            A336BR_Encounter_FReason = BC000E27_A336BR_Encounter_FReason[0];
            n336BR_Encounter_FReason = BC000E27_n336BR_Encounter_FReason[0];
            A189BR_Encounter_RecheckDate = BC000E27_A189BR_Encounter_RecheckDate[0];
            n189BR_Encounter_RecheckDate = BC000E27_n189BR_Encounter_RecheckDate[0];
            A190BR_Encounter_Approver = BC000E27_A190BR_Encounter_Approver[0];
            n190BR_Encounter_Approver = BC000E27_n190BR_Encounter_Approver[0];
            A191BR_Encounter_ApproveDate = BC000E27_A191BR_Encounter_ApproveDate[0];
            n191BR_Encounter_ApproveDate = BC000E27_n191BR_Encounter_ApproveDate[0];
            A192BR_Encounter_IsRandApprove = BC000E27_A192BR_Encounter_IsRandApprove[0];
            n192BR_Encounter_IsRandApprove = BC000E27_n192BR_Encounter_IsRandApprove[0];
            A203BR_Encounter_IsRandApprover = BC000E27_A203BR_Encounter_IsRandApprover[0];
            n203BR_Encounter_IsRandApprover = BC000E27_n203BR_Encounter_IsRandApprover[0];
            A204BR_Encounter_IsRandNoApprover = BC000E27_A204BR_Encounter_IsRandNoApprover[0];
            n204BR_Encounter_IsRandNoApprover = BC000E27_n204BR_Encounter_IsRandNoApprover[0];
            A205BR_Encounter_IsRandApproveDate = BC000E27_A205BR_Encounter_IsRandApproveDate[0];
            n205BR_Encounter_IsRandApproveDate = BC000E27_n205BR_Encounter_IsRandApproveDate[0];
            A206BR_Encounter_IsRandNoApproveDate = BC000E27_A206BR_Encounter_IsRandNoApproveDate[0];
            n206BR_Encounter_IsRandNoApproveDate = BC000E27_n206BR_Encounter_IsRandNoApproveDate[0];
            A193BR_Encounter_IsRandRecheck = BC000E27_A193BR_Encounter_IsRandRecheck[0];
            n193BR_Encounter_IsRandRecheck = BC000E27_n193BR_Encounter_IsRandRecheck[0];
            A207BR_Encounter_IsRandRecheckr = BC000E27_A207BR_Encounter_IsRandRecheckr[0];
            n207BR_Encounter_IsRandRecheckr = BC000E27_n207BR_Encounter_IsRandRecheckr[0];
            A208BR_Encounter_IsRandNoRecheckr = BC000E27_A208BR_Encounter_IsRandNoRecheckr[0];
            n208BR_Encounter_IsRandNoRecheckr = BC000E27_n208BR_Encounter_IsRandNoRecheckr[0];
            A209BR_Encounter_IsRandRecheckDate = BC000E27_A209BR_Encounter_IsRandRecheckDate[0];
            n209BR_Encounter_IsRandRecheckDate = BC000E27_n209BR_Encounter_IsRandRecheckDate[0];
            A210BR_Encounter_IsRandNoRecheckDate = BC000E27_A210BR_Encounter_IsRandNoRecheckDate[0];
            n210BR_Encounter_IsRandNoRecheckDate = BC000E27_n210BR_Encounter_IsRandNoRecheckDate[0];
            A202BR_Encounter_IsUpdate = BC000E27_A202BR_Encounter_IsUpdate[0];
            n202BR_Encounter_IsUpdate = BC000E27_n202BR_Encounter_IsUpdate[0];
            A537BR_Encounter_Datasource = BC000E27_A537BR_Encounter_Datasource[0];
            n537BR_Encounter_Datasource = BC000E27_n537BR_Encounter_Datasource[0];
            A560EncounterIDEncrypt = BC000E27_A560EncounterIDEncrypt[0];
            n560EncounterIDEncrypt = BC000E27_n560EncounterIDEncrypt[0];
            A85BR_Information_ID = BC000E27_A85BR_Information_ID[0];
            n85BR_Information_ID = BC000E27_n85BR_Information_ID[0];
            A360BAS_TenantTenantCode = BC000E27_A360BAS_TenantTenantCode[0];
            n360BAS_TenantTenantCode = BC000E27_n360BAS_TenantTenantCode[0];
         }
         Gx_mode = sMode15;
      }

      protected void ScanKeyEnd0E15( )
      {
         pr_default.close(24);
      }

      protected void AfterConfirm0E15( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0E15( )
      {
         /* Before Insert Rules */
         A172BR_Encounter_Status = 1;
         n172BR_Encounter_Status = false;
         A182BR_Encounter_CrtDate = DateTimeUtil.ServerNow( context, pr_default);
         n182BR_Encounter_CrtDate = false;
         GXt_char2 = A360BAS_TenantTenantCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char2) ;
         A360BAS_TenantTenantCode = GXt_char2;
         n360BAS_TenantTenantCode = false;
         A183BR_Encounter_CrtUser = StringUtil.Trim( AV14WWPContext.gxTpr_Userguid);
         n183BR_Encounter_CrtUser = false;
         A512BR_Encounter_CrtDisplayName = StringUtil.Trim( AV14WWPContext.gxTpr_Userdisplayname);
         n512BR_Encounter_CrtDisplayName = false;
         GXt_char2 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char2) ;
         A470BR_Encounter_Department_Code = GXt_char2;
         n470BR_Encounter_Department_Code = false;
         GXt_char2 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char2) ;
         A471BR_Encounter_ENCType_Code = GXt_char2;
         n471BR_Encounter_ENCType_Code = false;
         GXt_char2 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char2) ;
         A472BR_Encounter_AdmitSource_Code = GXt_char2;
         n472BR_Encounter_AdmitSource_Code = false;
         GXt_char2 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char2) ;
         A473BR_Encounter_DischargeStatus_Code = GXt_char2;
         n473BR_Encounter_DischargeStatus_Code = false;
         GXt_int3 = A35BR_Encounter_EncID;
         new zutil_findcountbypatientno(context ).execute(  A85BR_Information_ID, out  GXt_int3) ;
         A35BR_Encounter_EncID = GXt_int3;
         n35BR_Encounter_EncID = false;
      }

      protected void BeforeUpdate0E15( )
      {
         /* Before Update Rules */
         GXt_char2 = A470BR_Encounter_Department_Code;
         new zutil_findtargetcode(context ).execute(  3,  A84BR_Encounter_Department, out  GXt_char2) ;
         A470BR_Encounter_Department_Code = GXt_char2;
         n470BR_Encounter_Department_Code = false;
         GXt_char2 = A471BR_Encounter_ENCType_Code;
         new zutil_findtargetcode(context ).execute(  4,  A90BR_Encounter_ENCType, out  GXt_char2) ;
         A471BR_Encounter_ENCType_Code = GXt_char2;
         n471BR_Encounter_ENCType_Code = false;
         GXt_char2 = A472BR_Encounter_AdmitSource_Code;
         new zutil_findtargetcode(context ).execute(  5,  A92BR_Encounter_AdmitSource, out  GXt_char2) ;
         A472BR_Encounter_AdmitSource_Code = GXt_char2;
         n472BR_Encounter_AdmitSource_Code = false;
         GXt_char2 = A473BR_Encounter_DischargeStatus_Code;
         new zutil_findtargetcode(context ).execute(  6,  A94BR_Encounter_DischargeStatus, out  GXt_char2) ;
         A473BR_Encounter_DischargeStatus_Code = GXt_char2;
         n473BR_Encounter_DischargeStatus_Code = false;
      }

      protected void BeforeDelete0E15( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0E15( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0E15( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0E15( )
      {
      }

      protected void send_integrity_lvl_hashes0E15( )
      {
      }

      protected void AddRow0E15( )
      {
         VarsToRow15( bcBR_Encounter) ;
      }

      protected void ReadRow0E15( )
      {
         RowToVars15( bcBR_Encounter, 1) ;
      }

      protected void InitializeNonKey0E15( )
      {
         A35BR_Encounter_EncID = 0;
         n35BR_Encounter_EncID = false;
         A172BR_Encounter_Status = 0;
         n172BR_Encounter_Status = false;
         A183BR_Encounter_CrtUser = "";
         n183BR_Encounter_CrtUser = false;
         A512BR_Encounter_CrtDisplayName = "";
         n512BR_Encounter_CrtDisplayName = false;
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         n182BR_Encounter_CrtDate = false;
         A360BAS_TenantTenantCode = "";
         n360BAS_TenantTenantCode = false;
         A470BR_Encounter_Department_Code = "";
         n470BR_Encounter_Department_Code = false;
         A471BR_Encounter_ENCType_Code = "";
         n471BR_Encounter_ENCType_Code = false;
         A472BR_Encounter_AdmitSource_Code = "";
         n472BR_Encounter_AdmitSource_Code = false;
         A473BR_Encounter_DischargeStatus_Code = "";
         n473BR_Encounter_DischargeStatus_Code = false;
         A84BR_Encounter_Department = "";
         n84BR_Encounter_Department = false;
         A570BR_Encounter_Departmentadm = "";
         n570BR_Encounter_Departmentadm = false;
         A571BR_Encounter_Departmentadm_Code = "";
         n571BR_Encounter_Departmentadm_Code = false;
         A572BR_Encounter_Departmentdisch = "";
         n572BR_Encounter_Departmentdisch = false;
         A573BR_Encounter_Departmentdisch_Code = "";
         n573BR_Encounter_Departmentdisch_Code = false;
         A90BR_Encounter_ENCType = "";
         n90BR_Encounter_ENCType = false;
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         n91BR_Encounter_AdmitDate = false;
         A92BR_Encounter_AdmitSource = "";
         n92BR_Encounter_AdmitSource = false;
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         n93BR_Encounter_DischargeDate = false;
         A94BR_Encounter_DischargeStatus = "";
         n94BR_Encounter_DischargeStatus = false;
         A574BR_Encounter_Insurance = "";
         n574BR_Encounter_Insurance = false;
         A575BR_Encounter_Insurance_Code = "";
         n575BR_Encounter_Insurance_Code = false;
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         n187BR_Encounter_UpdDate = false;
         A186BR_Encounter_UpdUser = "";
         n186BR_Encounter_UpdUser = false;
         A333BR_Encounter_IsDLT = false;
         n333BR_Encounter_IsDLT = false;
         A184BR_Encounter_SubmitUser = "";
         n184BR_Encounter_SubmitUser = false;
         A335BR_Encounter_Reason = "";
         n335BR_Encounter_Reason = false;
         A185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         n185BR_Encounter_SubmitDate = false;
         A188BR_Encounter_RecheckUser = "";
         n188BR_Encounter_RecheckUser = false;
         A336BR_Encounter_FReason = "";
         n336BR_Encounter_FReason = false;
         A189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         n189BR_Encounter_RecheckDate = false;
         A190BR_Encounter_Approver = "";
         n190BR_Encounter_Approver = false;
         A191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         n191BR_Encounter_ApproveDate = false;
         A192BR_Encounter_IsRandApprove = false;
         n192BR_Encounter_IsRandApprove = false;
         A203BR_Encounter_IsRandApprover = "";
         n203BR_Encounter_IsRandApprover = false;
         A204BR_Encounter_IsRandNoApprover = "";
         n204BR_Encounter_IsRandNoApprover = false;
         A205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         n205BR_Encounter_IsRandApproveDate = false;
         A206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         n206BR_Encounter_IsRandNoApproveDate = false;
         A193BR_Encounter_IsRandRecheck = false;
         n193BR_Encounter_IsRandRecheck = false;
         A207BR_Encounter_IsRandRecheckr = "";
         n207BR_Encounter_IsRandRecheckr = false;
         A208BR_Encounter_IsRandNoRecheckr = "";
         n208BR_Encounter_IsRandNoRecheckr = false;
         A209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         n209BR_Encounter_IsRandRecheckDate = false;
         A210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         n210BR_Encounter_IsRandNoRecheckDate = false;
         A202BR_Encounter_IsUpdate = false;
         n202BR_Encounter_IsUpdate = false;
         A537BR_Encounter_Datasource = 0;
         n537BR_Encounter_Datasource = false;
         A560EncounterIDEncrypt = "";
         n560EncounterIDEncrypt = false;
         Z35BR_Encounter_EncID = 0;
         Z172BR_Encounter_Status = 0;
         Z183BR_Encounter_CrtUser = "";
         Z512BR_Encounter_CrtDisplayName = "";
         Z182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         Z470BR_Encounter_Department_Code = "";
         Z471BR_Encounter_ENCType_Code = "";
         Z472BR_Encounter_AdmitSource_Code = "";
         Z473BR_Encounter_DischargeStatus_Code = "";
         Z84BR_Encounter_Department = "";
         Z570BR_Encounter_Departmentadm = "";
         Z571BR_Encounter_Departmentadm_Code = "";
         Z572BR_Encounter_Departmentdisch = "";
         Z573BR_Encounter_Departmentdisch_Code = "";
         Z90BR_Encounter_ENCType = "";
         Z91BR_Encounter_AdmitDate = DateTime.MinValue;
         Z92BR_Encounter_AdmitSource = "";
         Z93BR_Encounter_DischargeDate = DateTime.MinValue;
         Z94BR_Encounter_DischargeStatus = "";
         Z574BR_Encounter_Insurance = "";
         Z575BR_Encounter_Insurance_Code = "";
         Z187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         Z186BR_Encounter_UpdUser = "";
         Z333BR_Encounter_IsDLT = false;
         Z184BR_Encounter_SubmitUser = "";
         Z335BR_Encounter_Reason = "";
         Z185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         Z188BR_Encounter_RecheckUser = "";
         Z336BR_Encounter_FReason = "";
         Z189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         Z190BR_Encounter_Approver = "";
         Z191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         Z192BR_Encounter_IsRandApprove = false;
         Z203BR_Encounter_IsRandApprover = "";
         Z204BR_Encounter_IsRandNoApprover = "";
         Z205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         Z206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z193BR_Encounter_IsRandRecheck = false;
         Z207BR_Encounter_IsRandRecheckr = "";
         Z208BR_Encounter_IsRandNoRecheckr = "";
         Z209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         Z210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         Z202BR_Encounter_IsUpdate = false;
         Z537BR_Encounter_Datasource = 0;
         Z560EncounterIDEncrypt = "";
         Z85BR_Information_ID = 0;
         Z360BAS_TenantTenantCode = "";
      }

      protected void InitAll0E15( )
      {
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         InitializeNonKey0E15( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow15( SdtBR_Encounter obj15 )
      {
         obj15.gxTpr_Mode = Gx_mode;
         obj15.gxTpr_Br_encounter_encid = A35BR_Encounter_EncID;
         obj15.gxTpr_Br_encounter_status = A172BR_Encounter_Status;
         obj15.gxTpr_Br_encounter_crtuser = A183BR_Encounter_CrtUser;
         obj15.gxTpr_Br_encounter_crtdisplayname = A512BR_Encounter_CrtDisplayName;
         obj15.gxTpr_Br_encounter_crtdate = A182BR_Encounter_CrtDate;
         obj15.gxTpr_Bas_tenanttenantcode = A360BAS_TenantTenantCode;
         obj15.gxTpr_Br_encounter_department_code = A470BR_Encounter_Department_Code;
         obj15.gxTpr_Br_encounter_enctype_code = A471BR_Encounter_ENCType_Code;
         obj15.gxTpr_Br_encounter_admitsource_code = A472BR_Encounter_AdmitSource_Code;
         obj15.gxTpr_Br_encounter_dischargestatus_code = A473BR_Encounter_DischargeStatus_Code;
         obj15.gxTpr_Br_encounter_department = A84BR_Encounter_Department;
         obj15.gxTpr_Br_encounter_departmentadm = A570BR_Encounter_Departmentadm;
         obj15.gxTpr_Br_encounter_departmentadm_code = A571BR_Encounter_Departmentadm_Code;
         obj15.gxTpr_Br_encounter_departmentdisch = A572BR_Encounter_Departmentdisch;
         obj15.gxTpr_Br_encounter_departmentdisch_code = A573BR_Encounter_Departmentdisch_Code;
         obj15.gxTpr_Br_encounter_enctype = A90BR_Encounter_ENCType;
         obj15.gxTpr_Br_encounter_admitdate = A91BR_Encounter_AdmitDate;
         obj15.gxTpr_Br_encounter_admitsource = A92BR_Encounter_AdmitSource;
         obj15.gxTpr_Br_encounter_dischargedate = A93BR_Encounter_DischargeDate;
         obj15.gxTpr_Br_encounter_dischargestatus = A94BR_Encounter_DischargeStatus;
         obj15.gxTpr_Br_encounter_insurance = A574BR_Encounter_Insurance;
         obj15.gxTpr_Br_encounter_insurance_code = A575BR_Encounter_Insurance_Code;
         obj15.gxTpr_Br_information_id = A85BR_Information_ID;
         obj15.gxTpr_Br_information_patientno = A36BR_Information_PatientNo;
         obj15.gxTpr_Br_encounter_upddate = A187BR_Encounter_UpdDate;
         obj15.gxTpr_Br_encounter_upduser = A186BR_Encounter_UpdUser;
         obj15.gxTpr_Br_encounter_isdlt = A333BR_Encounter_IsDLT;
         obj15.gxTpr_Br_encounter_submituser = A184BR_Encounter_SubmitUser;
         obj15.gxTpr_Br_encounter_reason = A335BR_Encounter_Reason;
         obj15.gxTpr_Br_encounter_submitdate = A185BR_Encounter_SubmitDate;
         obj15.gxTpr_Br_encounter_recheckuser = A188BR_Encounter_RecheckUser;
         obj15.gxTpr_Br_encounter_freason = A336BR_Encounter_FReason;
         obj15.gxTpr_Br_encounter_recheckdate = A189BR_Encounter_RecheckDate;
         obj15.gxTpr_Br_encounter_approver = A190BR_Encounter_Approver;
         obj15.gxTpr_Br_encounter_approvedate = A191BR_Encounter_ApproveDate;
         obj15.gxTpr_Br_encounter_israndapprove = A192BR_Encounter_IsRandApprove;
         obj15.gxTpr_Br_encounter_israndapprover = A203BR_Encounter_IsRandApprover;
         obj15.gxTpr_Br_encounter_israndnoapprover = A204BR_Encounter_IsRandNoApprover;
         obj15.gxTpr_Br_encounter_israndapprovedate = A205BR_Encounter_IsRandApproveDate;
         obj15.gxTpr_Br_encounter_israndnoapprovedate = A206BR_Encounter_IsRandNoApproveDate;
         obj15.gxTpr_Br_encounter_israndrecheck = A193BR_Encounter_IsRandRecheck;
         obj15.gxTpr_Br_encounter_israndrecheckr = A207BR_Encounter_IsRandRecheckr;
         obj15.gxTpr_Br_encounter_israndnorecheckr = A208BR_Encounter_IsRandNoRecheckr;
         obj15.gxTpr_Br_encounter_israndrecheckdate = A209BR_Encounter_IsRandRecheckDate;
         obj15.gxTpr_Br_encounter_israndnorecheckdate = A210BR_Encounter_IsRandNoRecheckDate;
         obj15.gxTpr_Br_encounter_isupdate = A202BR_Encounter_IsUpdate;
         obj15.gxTpr_Br_encounter_datasource = A537BR_Encounter_Datasource;
         obj15.gxTpr_Encounteridencrypt = A560EncounterIDEncrypt;
         obj15.gxTpr_Br_encounterid = A19BR_EncounterID;
         obj15.gxTpr_Br_encounterid_Z = Z19BR_EncounterID;
         obj15.gxTpr_Br_encounter_encid_Z = Z35BR_Encounter_EncID;
         obj15.gxTpr_Br_encounter_department_Z = Z84BR_Encounter_Department;
         obj15.gxTpr_Br_encounter_department_code_Z = Z470BR_Encounter_Department_Code;
         obj15.gxTpr_Br_encounter_departmentadm_Z = Z570BR_Encounter_Departmentadm;
         obj15.gxTpr_Br_encounter_departmentadm_code_Z = Z571BR_Encounter_Departmentadm_Code;
         obj15.gxTpr_Br_encounter_departmentdisch_Z = Z572BR_Encounter_Departmentdisch;
         obj15.gxTpr_Br_encounter_departmentdisch_code_Z = Z573BR_Encounter_Departmentdisch_Code;
         obj15.gxTpr_Br_encounter_enctype_Z = Z90BR_Encounter_ENCType;
         obj15.gxTpr_Br_encounter_enctype_code_Z = Z471BR_Encounter_ENCType_Code;
         obj15.gxTpr_Br_encounter_admitdate_Z = Z91BR_Encounter_AdmitDate;
         obj15.gxTpr_Br_encounter_admitsource_Z = Z92BR_Encounter_AdmitSource;
         obj15.gxTpr_Br_encounter_admitsource_code_Z = Z472BR_Encounter_AdmitSource_Code;
         obj15.gxTpr_Br_encounter_dischargedate_Z = Z93BR_Encounter_DischargeDate;
         obj15.gxTpr_Br_encounter_dischargestatus_Z = Z94BR_Encounter_DischargeStatus;
         obj15.gxTpr_Br_encounter_dischargestatus_code_Z = Z473BR_Encounter_DischargeStatus_Code;
         obj15.gxTpr_Br_encounter_insurance_Z = Z574BR_Encounter_Insurance;
         obj15.gxTpr_Br_encounter_insurance_code_Z = Z575BR_Encounter_Insurance_Code;
         obj15.gxTpr_Br_encounter_status_Z = Z172BR_Encounter_Status;
         obj15.gxTpr_Br_information_id_Z = Z85BR_Information_ID;
         obj15.gxTpr_Br_information_patientno_Z = Z36BR_Information_PatientNo;
         obj15.gxTpr_Bas_tenanttenantcode_Z = Z360BAS_TenantTenantCode;
         obj15.gxTpr_Br_encounter_crtdate_Z = Z182BR_Encounter_CrtDate;
         obj15.gxTpr_Br_encounter_upddate_Z = Z187BR_Encounter_UpdDate;
         obj15.gxTpr_Br_encounter_crtuser_Z = Z183BR_Encounter_CrtUser;
         obj15.gxTpr_Br_encounter_crtdisplayname_Z = Z512BR_Encounter_CrtDisplayName;
         obj15.gxTpr_Br_encounter_upduser_Z = Z186BR_Encounter_UpdUser;
         obj15.gxTpr_Br_encounter_isdlt_Z = Z333BR_Encounter_IsDLT;
         obj15.gxTpr_Br_encounter_submituser_Z = Z184BR_Encounter_SubmitUser;
         obj15.gxTpr_Br_encounter_reason_Z = Z335BR_Encounter_Reason;
         obj15.gxTpr_Br_encounter_submitdate_Z = Z185BR_Encounter_SubmitDate;
         obj15.gxTpr_Br_encounter_recheckuser_Z = Z188BR_Encounter_RecheckUser;
         obj15.gxTpr_Br_encounter_freason_Z = Z336BR_Encounter_FReason;
         obj15.gxTpr_Br_encounter_recheckdate_Z = Z189BR_Encounter_RecheckDate;
         obj15.gxTpr_Br_encounter_approver_Z = Z190BR_Encounter_Approver;
         obj15.gxTpr_Br_encounter_approvedate_Z = Z191BR_Encounter_ApproveDate;
         obj15.gxTpr_Br_encounter_israndapprove_Z = Z192BR_Encounter_IsRandApprove;
         obj15.gxTpr_Br_encounter_israndapprover_Z = Z203BR_Encounter_IsRandApprover;
         obj15.gxTpr_Br_encounter_israndnoapprover_Z = Z204BR_Encounter_IsRandNoApprover;
         obj15.gxTpr_Br_encounter_israndapprovedate_Z = Z205BR_Encounter_IsRandApproveDate;
         obj15.gxTpr_Br_encounter_israndnoapprovedate_Z = Z206BR_Encounter_IsRandNoApproveDate;
         obj15.gxTpr_Br_encounter_israndrecheck_Z = Z193BR_Encounter_IsRandRecheck;
         obj15.gxTpr_Br_encounter_israndrecheckr_Z = Z207BR_Encounter_IsRandRecheckr;
         obj15.gxTpr_Br_encounter_israndnorecheckr_Z = Z208BR_Encounter_IsRandNoRecheckr;
         obj15.gxTpr_Br_encounter_israndrecheckdate_Z = Z209BR_Encounter_IsRandRecheckDate;
         obj15.gxTpr_Br_encounter_israndnorecheckdate_Z = Z210BR_Encounter_IsRandNoRecheckDate;
         obj15.gxTpr_Br_encounter_isupdate_Z = Z202BR_Encounter_IsUpdate;
         obj15.gxTpr_Br_encounter_datasource_Z = Z537BR_Encounter_Datasource;
         obj15.gxTpr_Encounteridencrypt_Z = Z560EncounterIDEncrypt;
         obj15.gxTpr_Br_encounterid_N = (short)(Convert.ToInt16(n19BR_EncounterID));
         obj15.gxTpr_Br_encounter_encid_N = (short)(Convert.ToInt16(n35BR_Encounter_EncID));
         obj15.gxTpr_Br_encounter_department_N = (short)(Convert.ToInt16(n84BR_Encounter_Department));
         obj15.gxTpr_Br_encounter_department_code_N = (short)(Convert.ToInt16(n470BR_Encounter_Department_Code));
         obj15.gxTpr_Br_encounter_departmentadm_N = (short)(Convert.ToInt16(n570BR_Encounter_Departmentadm));
         obj15.gxTpr_Br_encounter_departmentadm_code_N = (short)(Convert.ToInt16(n571BR_Encounter_Departmentadm_Code));
         obj15.gxTpr_Br_encounter_departmentdisch_N = (short)(Convert.ToInt16(n572BR_Encounter_Departmentdisch));
         obj15.gxTpr_Br_encounter_departmentdisch_code_N = (short)(Convert.ToInt16(n573BR_Encounter_Departmentdisch_Code));
         obj15.gxTpr_Br_encounter_enctype_N = (short)(Convert.ToInt16(n90BR_Encounter_ENCType));
         obj15.gxTpr_Br_encounter_enctype_code_N = (short)(Convert.ToInt16(n471BR_Encounter_ENCType_Code));
         obj15.gxTpr_Br_encounter_admitdate_N = (short)(Convert.ToInt16(n91BR_Encounter_AdmitDate));
         obj15.gxTpr_Br_encounter_admitsource_N = (short)(Convert.ToInt16(n92BR_Encounter_AdmitSource));
         obj15.gxTpr_Br_encounter_admitsource_code_N = (short)(Convert.ToInt16(n472BR_Encounter_AdmitSource_Code));
         obj15.gxTpr_Br_encounter_dischargedate_N = (short)(Convert.ToInt16(n93BR_Encounter_DischargeDate));
         obj15.gxTpr_Br_encounter_dischargestatus_N = (short)(Convert.ToInt16(n94BR_Encounter_DischargeStatus));
         obj15.gxTpr_Br_encounter_dischargestatus_code_N = (short)(Convert.ToInt16(n473BR_Encounter_DischargeStatus_Code));
         obj15.gxTpr_Br_encounter_insurance_N = (short)(Convert.ToInt16(n574BR_Encounter_Insurance));
         obj15.gxTpr_Br_encounter_insurance_code_N = (short)(Convert.ToInt16(n575BR_Encounter_Insurance_Code));
         obj15.gxTpr_Br_encounter_status_N = (short)(Convert.ToInt16(n172BR_Encounter_Status));
         obj15.gxTpr_Br_information_id_N = (short)(Convert.ToInt16(n85BR_Information_ID));
         obj15.gxTpr_Br_information_patientno_N = (short)(Convert.ToInt16(n36BR_Information_PatientNo));
         obj15.gxTpr_Bas_tenanttenantcode_N = (short)(Convert.ToInt16(n360BAS_TenantTenantCode));
         obj15.gxTpr_Br_encounter_crtdate_N = (short)(Convert.ToInt16(n182BR_Encounter_CrtDate));
         obj15.gxTpr_Br_encounter_upddate_N = (short)(Convert.ToInt16(n187BR_Encounter_UpdDate));
         obj15.gxTpr_Br_encounter_crtuser_N = (short)(Convert.ToInt16(n183BR_Encounter_CrtUser));
         obj15.gxTpr_Br_encounter_crtdisplayname_N = (short)(Convert.ToInt16(n512BR_Encounter_CrtDisplayName));
         obj15.gxTpr_Br_encounter_upduser_N = (short)(Convert.ToInt16(n186BR_Encounter_UpdUser));
         obj15.gxTpr_Br_encounter_isdlt_N = (short)(Convert.ToInt16(n333BR_Encounter_IsDLT));
         obj15.gxTpr_Br_encounter_submituser_N = (short)(Convert.ToInt16(n184BR_Encounter_SubmitUser));
         obj15.gxTpr_Br_encounter_reason_N = (short)(Convert.ToInt16(n335BR_Encounter_Reason));
         obj15.gxTpr_Br_encounter_submitdate_N = (short)(Convert.ToInt16(n185BR_Encounter_SubmitDate));
         obj15.gxTpr_Br_encounter_recheckuser_N = (short)(Convert.ToInt16(n188BR_Encounter_RecheckUser));
         obj15.gxTpr_Br_encounter_freason_N = (short)(Convert.ToInt16(n336BR_Encounter_FReason));
         obj15.gxTpr_Br_encounter_recheckdate_N = (short)(Convert.ToInt16(n189BR_Encounter_RecheckDate));
         obj15.gxTpr_Br_encounter_approver_N = (short)(Convert.ToInt16(n190BR_Encounter_Approver));
         obj15.gxTpr_Br_encounter_approvedate_N = (short)(Convert.ToInt16(n191BR_Encounter_ApproveDate));
         obj15.gxTpr_Br_encounter_israndapprove_N = (short)(Convert.ToInt16(n192BR_Encounter_IsRandApprove));
         obj15.gxTpr_Br_encounter_israndapprover_N = (short)(Convert.ToInt16(n203BR_Encounter_IsRandApprover));
         obj15.gxTpr_Br_encounter_israndnoapprover_N = (short)(Convert.ToInt16(n204BR_Encounter_IsRandNoApprover));
         obj15.gxTpr_Br_encounter_israndapprovedate_N = (short)(Convert.ToInt16(n205BR_Encounter_IsRandApproveDate));
         obj15.gxTpr_Br_encounter_israndnoapprovedate_N = (short)(Convert.ToInt16(n206BR_Encounter_IsRandNoApproveDate));
         obj15.gxTpr_Br_encounter_israndrecheck_N = (short)(Convert.ToInt16(n193BR_Encounter_IsRandRecheck));
         obj15.gxTpr_Br_encounter_israndrecheckr_N = (short)(Convert.ToInt16(n207BR_Encounter_IsRandRecheckr));
         obj15.gxTpr_Br_encounter_israndnorecheckr_N = (short)(Convert.ToInt16(n208BR_Encounter_IsRandNoRecheckr));
         obj15.gxTpr_Br_encounter_israndrecheckdate_N = (short)(Convert.ToInt16(n209BR_Encounter_IsRandRecheckDate));
         obj15.gxTpr_Br_encounter_israndnorecheckdate_N = (short)(Convert.ToInt16(n210BR_Encounter_IsRandNoRecheckDate));
         obj15.gxTpr_Br_encounter_isupdate_N = (short)(Convert.ToInt16(n202BR_Encounter_IsUpdate));
         obj15.gxTpr_Br_encounter_datasource_N = (short)(Convert.ToInt16(n537BR_Encounter_Datasource));
         obj15.gxTpr_Encounteridencrypt_N = (short)(Convert.ToInt16(n560EncounterIDEncrypt));
         obj15.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow15( SdtBR_Encounter obj15 )
      {
         obj15.gxTpr_Br_encounterid = A19BR_EncounterID;
         return  ;
      }

      public void RowToVars15( SdtBR_Encounter obj15 ,
                               int forceLoad )
      {
         Gx_mode = obj15.gxTpr_Mode;
         A35BR_Encounter_EncID = obj15.gxTpr_Br_encounter_encid;
         n35BR_Encounter_EncID = false;
         A172BR_Encounter_Status = obj15.gxTpr_Br_encounter_status;
         n172BR_Encounter_Status = false;
         A183BR_Encounter_CrtUser = obj15.gxTpr_Br_encounter_crtuser;
         n183BR_Encounter_CrtUser = false;
         A512BR_Encounter_CrtDisplayName = obj15.gxTpr_Br_encounter_crtdisplayname;
         n512BR_Encounter_CrtDisplayName = false;
         A182BR_Encounter_CrtDate = obj15.gxTpr_Br_encounter_crtdate;
         n182BR_Encounter_CrtDate = false;
         A360BAS_TenantTenantCode = obj15.gxTpr_Bas_tenanttenantcode;
         n360BAS_TenantTenantCode = false;
         A470BR_Encounter_Department_Code = obj15.gxTpr_Br_encounter_department_code;
         n470BR_Encounter_Department_Code = false;
         A471BR_Encounter_ENCType_Code = obj15.gxTpr_Br_encounter_enctype_code;
         n471BR_Encounter_ENCType_Code = false;
         A472BR_Encounter_AdmitSource_Code = obj15.gxTpr_Br_encounter_admitsource_code;
         n472BR_Encounter_AdmitSource_Code = false;
         A473BR_Encounter_DischargeStatus_Code = obj15.gxTpr_Br_encounter_dischargestatus_code;
         n473BR_Encounter_DischargeStatus_Code = false;
         A84BR_Encounter_Department = obj15.gxTpr_Br_encounter_department;
         n84BR_Encounter_Department = false;
         A570BR_Encounter_Departmentadm = obj15.gxTpr_Br_encounter_departmentadm;
         n570BR_Encounter_Departmentadm = false;
         A571BR_Encounter_Departmentadm_Code = obj15.gxTpr_Br_encounter_departmentadm_code;
         n571BR_Encounter_Departmentadm_Code = false;
         A572BR_Encounter_Departmentdisch = obj15.gxTpr_Br_encounter_departmentdisch;
         n572BR_Encounter_Departmentdisch = false;
         A573BR_Encounter_Departmentdisch_Code = obj15.gxTpr_Br_encounter_departmentdisch_code;
         n573BR_Encounter_Departmentdisch_Code = false;
         A90BR_Encounter_ENCType = obj15.gxTpr_Br_encounter_enctype;
         n90BR_Encounter_ENCType = false;
         A91BR_Encounter_AdmitDate = obj15.gxTpr_Br_encounter_admitdate;
         n91BR_Encounter_AdmitDate = false;
         A92BR_Encounter_AdmitSource = obj15.gxTpr_Br_encounter_admitsource;
         n92BR_Encounter_AdmitSource = false;
         A93BR_Encounter_DischargeDate = obj15.gxTpr_Br_encounter_dischargedate;
         n93BR_Encounter_DischargeDate = false;
         A94BR_Encounter_DischargeStatus = obj15.gxTpr_Br_encounter_dischargestatus;
         n94BR_Encounter_DischargeStatus = false;
         A574BR_Encounter_Insurance = obj15.gxTpr_Br_encounter_insurance;
         n574BR_Encounter_Insurance = false;
         A575BR_Encounter_Insurance_Code = obj15.gxTpr_Br_encounter_insurance_code;
         n575BR_Encounter_Insurance_Code = false;
         A85BR_Information_ID = obj15.gxTpr_Br_information_id;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = obj15.gxTpr_Br_information_patientno;
         n36BR_Information_PatientNo = false;
         A187BR_Encounter_UpdDate = obj15.gxTpr_Br_encounter_upddate;
         n187BR_Encounter_UpdDate = false;
         A186BR_Encounter_UpdUser = obj15.gxTpr_Br_encounter_upduser;
         n186BR_Encounter_UpdUser = false;
         A333BR_Encounter_IsDLT = obj15.gxTpr_Br_encounter_isdlt;
         n333BR_Encounter_IsDLT = false;
         A184BR_Encounter_SubmitUser = obj15.gxTpr_Br_encounter_submituser;
         n184BR_Encounter_SubmitUser = false;
         A335BR_Encounter_Reason = obj15.gxTpr_Br_encounter_reason;
         n335BR_Encounter_Reason = false;
         A185BR_Encounter_SubmitDate = obj15.gxTpr_Br_encounter_submitdate;
         n185BR_Encounter_SubmitDate = false;
         A188BR_Encounter_RecheckUser = obj15.gxTpr_Br_encounter_recheckuser;
         n188BR_Encounter_RecheckUser = false;
         A336BR_Encounter_FReason = obj15.gxTpr_Br_encounter_freason;
         n336BR_Encounter_FReason = false;
         A189BR_Encounter_RecheckDate = obj15.gxTpr_Br_encounter_recheckdate;
         n189BR_Encounter_RecheckDate = false;
         A190BR_Encounter_Approver = obj15.gxTpr_Br_encounter_approver;
         n190BR_Encounter_Approver = false;
         A191BR_Encounter_ApproveDate = obj15.gxTpr_Br_encounter_approvedate;
         n191BR_Encounter_ApproveDate = false;
         A192BR_Encounter_IsRandApprove = obj15.gxTpr_Br_encounter_israndapprove;
         n192BR_Encounter_IsRandApprove = false;
         A203BR_Encounter_IsRandApprover = obj15.gxTpr_Br_encounter_israndapprover;
         n203BR_Encounter_IsRandApprover = false;
         A204BR_Encounter_IsRandNoApprover = obj15.gxTpr_Br_encounter_israndnoapprover;
         n204BR_Encounter_IsRandNoApprover = false;
         A205BR_Encounter_IsRandApproveDate = obj15.gxTpr_Br_encounter_israndapprovedate;
         n205BR_Encounter_IsRandApproveDate = false;
         A206BR_Encounter_IsRandNoApproveDate = obj15.gxTpr_Br_encounter_israndnoapprovedate;
         n206BR_Encounter_IsRandNoApproveDate = false;
         A193BR_Encounter_IsRandRecheck = obj15.gxTpr_Br_encounter_israndrecheck;
         n193BR_Encounter_IsRandRecheck = false;
         A207BR_Encounter_IsRandRecheckr = obj15.gxTpr_Br_encounter_israndrecheckr;
         n207BR_Encounter_IsRandRecheckr = false;
         A208BR_Encounter_IsRandNoRecheckr = obj15.gxTpr_Br_encounter_israndnorecheckr;
         n208BR_Encounter_IsRandNoRecheckr = false;
         A209BR_Encounter_IsRandRecheckDate = obj15.gxTpr_Br_encounter_israndrecheckdate;
         n209BR_Encounter_IsRandRecheckDate = false;
         A210BR_Encounter_IsRandNoRecheckDate = obj15.gxTpr_Br_encounter_israndnorecheckdate;
         n210BR_Encounter_IsRandNoRecheckDate = false;
         A202BR_Encounter_IsUpdate = obj15.gxTpr_Br_encounter_isupdate;
         n202BR_Encounter_IsUpdate = false;
         A537BR_Encounter_Datasource = obj15.gxTpr_Br_encounter_datasource;
         n537BR_Encounter_Datasource = false;
         A560EncounterIDEncrypt = obj15.gxTpr_Encounteridencrypt;
         n560EncounterIDEncrypt = false;
         A19BR_EncounterID = obj15.gxTpr_Br_encounterid;
         n19BR_EncounterID = false;
         Z19BR_EncounterID = obj15.gxTpr_Br_encounterid_Z;
         Z35BR_Encounter_EncID = obj15.gxTpr_Br_encounter_encid_Z;
         Z84BR_Encounter_Department = obj15.gxTpr_Br_encounter_department_Z;
         Z470BR_Encounter_Department_Code = obj15.gxTpr_Br_encounter_department_code_Z;
         Z570BR_Encounter_Departmentadm = obj15.gxTpr_Br_encounter_departmentadm_Z;
         Z571BR_Encounter_Departmentadm_Code = obj15.gxTpr_Br_encounter_departmentadm_code_Z;
         Z572BR_Encounter_Departmentdisch = obj15.gxTpr_Br_encounter_departmentdisch_Z;
         Z573BR_Encounter_Departmentdisch_Code = obj15.gxTpr_Br_encounter_departmentdisch_code_Z;
         Z90BR_Encounter_ENCType = obj15.gxTpr_Br_encounter_enctype_Z;
         Z471BR_Encounter_ENCType_Code = obj15.gxTpr_Br_encounter_enctype_code_Z;
         Z91BR_Encounter_AdmitDate = obj15.gxTpr_Br_encounter_admitdate_Z;
         Z92BR_Encounter_AdmitSource = obj15.gxTpr_Br_encounter_admitsource_Z;
         Z472BR_Encounter_AdmitSource_Code = obj15.gxTpr_Br_encounter_admitsource_code_Z;
         Z93BR_Encounter_DischargeDate = obj15.gxTpr_Br_encounter_dischargedate_Z;
         Z94BR_Encounter_DischargeStatus = obj15.gxTpr_Br_encounter_dischargestatus_Z;
         Z473BR_Encounter_DischargeStatus_Code = obj15.gxTpr_Br_encounter_dischargestatus_code_Z;
         Z574BR_Encounter_Insurance = obj15.gxTpr_Br_encounter_insurance_Z;
         Z575BR_Encounter_Insurance_Code = obj15.gxTpr_Br_encounter_insurance_code_Z;
         Z172BR_Encounter_Status = obj15.gxTpr_Br_encounter_status_Z;
         Z85BR_Information_ID = obj15.gxTpr_Br_information_id_Z;
         Z36BR_Information_PatientNo = obj15.gxTpr_Br_information_patientno_Z;
         Z360BAS_TenantTenantCode = obj15.gxTpr_Bas_tenanttenantcode_Z;
         Z182BR_Encounter_CrtDate = obj15.gxTpr_Br_encounter_crtdate_Z;
         Z187BR_Encounter_UpdDate = obj15.gxTpr_Br_encounter_upddate_Z;
         Z183BR_Encounter_CrtUser = obj15.gxTpr_Br_encounter_crtuser_Z;
         Z512BR_Encounter_CrtDisplayName = obj15.gxTpr_Br_encounter_crtdisplayname_Z;
         Z186BR_Encounter_UpdUser = obj15.gxTpr_Br_encounter_upduser_Z;
         Z333BR_Encounter_IsDLT = obj15.gxTpr_Br_encounter_isdlt_Z;
         Z184BR_Encounter_SubmitUser = obj15.gxTpr_Br_encounter_submituser_Z;
         Z335BR_Encounter_Reason = obj15.gxTpr_Br_encounter_reason_Z;
         Z185BR_Encounter_SubmitDate = obj15.gxTpr_Br_encounter_submitdate_Z;
         Z188BR_Encounter_RecheckUser = obj15.gxTpr_Br_encounter_recheckuser_Z;
         Z336BR_Encounter_FReason = obj15.gxTpr_Br_encounter_freason_Z;
         Z189BR_Encounter_RecheckDate = obj15.gxTpr_Br_encounter_recheckdate_Z;
         Z190BR_Encounter_Approver = obj15.gxTpr_Br_encounter_approver_Z;
         Z191BR_Encounter_ApproveDate = obj15.gxTpr_Br_encounter_approvedate_Z;
         Z192BR_Encounter_IsRandApprove = obj15.gxTpr_Br_encounter_israndapprove_Z;
         Z203BR_Encounter_IsRandApprover = obj15.gxTpr_Br_encounter_israndapprover_Z;
         Z204BR_Encounter_IsRandNoApprover = obj15.gxTpr_Br_encounter_israndnoapprover_Z;
         Z205BR_Encounter_IsRandApproveDate = obj15.gxTpr_Br_encounter_israndapprovedate_Z;
         Z206BR_Encounter_IsRandNoApproveDate = obj15.gxTpr_Br_encounter_israndnoapprovedate_Z;
         Z193BR_Encounter_IsRandRecheck = obj15.gxTpr_Br_encounter_israndrecheck_Z;
         Z207BR_Encounter_IsRandRecheckr = obj15.gxTpr_Br_encounter_israndrecheckr_Z;
         Z208BR_Encounter_IsRandNoRecheckr = obj15.gxTpr_Br_encounter_israndnorecheckr_Z;
         Z209BR_Encounter_IsRandRecheckDate = obj15.gxTpr_Br_encounter_israndrecheckdate_Z;
         Z210BR_Encounter_IsRandNoRecheckDate = obj15.gxTpr_Br_encounter_israndnorecheckdate_Z;
         Z202BR_Encounter_IsUpdate = obj15.gxTpr_Br_encounter_isupdate_Z;
         Z537BR_Encounter_Datasource = obj15.gxTpr_Br_encounter_datasource_Z;
         Z560EncounterIDEncrypt = obj15.gxTpr_Encounteridencrypt_Z;
         n19BR_EncounterID = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounterid_N));
         n35BR_Encounter_EncID = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_encid_N));
         n84BR_Encounter_Department = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_department_N));
         n470BR_Encounter_Department_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_department_code_N));
         n570BR_Encounter_Departmentadm = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_departmentadm_N));
         n571BR_Encounter_Departmentadm_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_departmentadm_code_N));
         n572BR_Encounter_Departmentdisch = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_departmentdisch_N));
         n573BR_Encounter_Departmentdisch_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_departmentdisch_code_N));
         n90BR_Encounter_ENCType = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_enctype_N));
         n471BR_Encounter_ENCType_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_enctype_code_N));
         n91BR_Encounter_AdmitDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_admitdate_N));
         n92BR_Encounter_AdmitSource = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_admitsource_N));
         n472BR_Encounter_AdmitSource_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_admitsource_code_N));
         n93BR_Encounter_DischargeDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_dischargedate_N));
         n94BR_Encounter_DischargeStatus = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_dischargestatus_N));
         n473BR_Encounter_DischargeStatus_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_dischargestatus_code_N));
         n574BR_Encounter_Insurance = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_insurance_N));
         n575BR_Encounter_Insurance_Code = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_insurance_code_N));
         n172BR_Encounter_Status = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_status_N));
         n85BR_Information_ID = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_information_id_N));
         n36BR_Information_PatientNo = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_information_patientno_N));
         n360BAS_TenantTenantCode = (bool)(Convert.ToBoolean(obj15.gxTpr_Bas_tenanttenantcode_N));
         n182BR_Encounter_CrtDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_crtdate_N));
         n187BR_Encounter_UpdDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_upddate_N));
         n183BR_Encounter_CrtUser = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_crtuser_N));
         n512BR_Encounter_CrtDisplayName = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_crtdisplayname_N));
         n186BR_Encounter_UpdUser = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_upduser_N));
         n333BR_Encounter_IsDLT = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_isdlt_N));
         n184BR_Encounter_SubmitUser = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_submituser_N));
         n335BR_Encounter_Reason = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_reason_N));
         n185BR_Encounter_SubmitDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_submitdate_N));
         n188BR_Encounter_RecheckUser = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_recheckuser_N));
         n336BR_Encounter_FReason = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_freason_N));
         n189BR_Encounter_RecheckDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_recheckdate_N));
         n190BR_Encounter_Approver = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_approver_N));
         n191BR_Encounter_ApproveDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_approvedate_N));
         n192BR_Encounter_IsRandApprove = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndapprove_N));
         n203BR_Encounter_IsRandApprover = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndapprover_N));
         n204BR_Encounter_IsRandNoApprover = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndnoapprover_N));
         n205BR_Encounter_IsRandApproveDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndapprovedate_N));
         n206BR_Encounter_IsRandNoApproveDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndnoapprovedate_N));
         n193BR_Encounter_IsRandRecheck = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndrecheck_N));
         n207BR_Encounter_IsRandRecheckr = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndrecheckr_N));
         n208BR_Encounter_IsRandNoRecheckr = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndnorecheckr_N));
         n209BR_Encounter_IsRandRecheckDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndrecheckdate_N));
         n210BR_Encounter_IsRandNoRecheckDate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_israndnorecheckdate_N));
         n202BR_Encounter_IsUpdate = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_isupdate_N));
         n537BR_Encounter_Datasource = (bool)(Convert.ToBoolean(obj15.gxTpr_Br_encounter_datasource_N));
         n560EncounterIDEncrypt = (bool)(Convert.ToBoolean(obj15.gxTpr_Encounteridencrypt_N));
         Gx_mode = obj15.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A19BR_EncounterID = (long)getParm(obj,0);
         n19BR_EncounterID = false;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0E15( ) ;
         ScanKeyStart0E15( ) ;
         if ( RcdFound15 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         ZM0E15( -32) ;
         OnLoadActions0E15( ) ;
         AddRow0E15( ) ;
         ScanKeyEnd0E15( ) ;
         if ( RcdFound15 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars15( bcBR_Encounter, 0) ;
         ScanKeyStart0E15( ) ;
         if ( RcdFound15 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z19BR_EncounterID = A19BR_EncounterID;
         }
         ZM0E15( -32) ;
         OnLoadActions0E15( ) ;
         AddRow0E15( ) ;
         ScanKeyEnd0E15( ) ;
         if ( RcdFound15 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0E15( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0E15( ) ;
         }
         else
         {
            if ( RcdFound15 == 1 )
            {
               if ( A19BR_EncounterID != Z19BR_EncounterID )
               {
                  A19BR_EncounterID = Z19BR_EncounterID;
                  n19BR_EncounterID = false;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update0E15( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A19BR_EncounterID != Z19BR_EncounterID )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0E15( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0E15( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars15( bcBR_Encounter, 0) ;
         SaveImpl( ) ;
         VarsToRow15( bcBR_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars15( bcBR_Encounter, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0E15( ) ;
         AfterTrn( ) ;
         VarsToRow15( bcBR_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtBR_Encounter auxBC = new SdtBR_Encounter(context) ;
            auxBC.Load(A19BR_EncounterID);
            auxBC.UpdateDirties(bcBR_Encounter);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars15( bcBR_Encounter, 0) ;
         UpdateImpl( ) ;
         VarsToRow15( bcBR_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars15( bcBR_Encounter, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0E15( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow15( bcBR_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars15( bcBR_Encounter, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0E15( ) ;
         if ( RcdFound15 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A19BR_EncounterID != Z19BR_EncounterID )
            {
               A19BR_EncounterID = Z19BR_EncounterID;
               n19BR_EncounterID = false;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A19BR_EncounterID != Z19BR_EncounterID )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         pr_default.close(9);
         context.RollbackDataStores("br_encounter_bc",pr_default);
         VarsToRow15( bcBR_Encounter) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcBR_Encounter.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcBR_Encounter.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcBR_Encounter )
         {
            bcBR_Encounter = (SdtBR_Encounter)(sdt);
            if ( StringUtil.StrCmp(bcBR_Encounter.gxTpr_Mode, "") == 0 )
            {
               bcBR_Encounter.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow15( bcBR_Encounter) ;
            }
            else
            {
               RowToVars15( bcBR_Encounter, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcBR_Encounter.gxTpr_Mode, "") == 0 )
            {
               bcBR_Encounter.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars15( bcBR_Encounter, 1) ;
         return  ;
      }

      public SdtBR_Encounter BR_Encounter_BC
      {
         get {
            return bcBR_Encounter ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Gx_mode = "";
         AV14WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV31Pgmname = "";
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV13WebSession = context.GetSession();
         AV12TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV29Insert_BAS_TenantTenantCode = "";
         Z183BR_Encounter_CrtUser = "";
         A183BR_Encounter_CrtUser = "";
         Z512BR_Encounter_CrtDisplayName = "";
         A512BR_Encounter_CrtDisplayName = "";
         Z182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         A182BR_Encounter_CrtDate = (DateTime)(DateTime.MinValue);
         Z470BR_Encounter_Department_Code = "";
         A470BR_Encounter_Department_Code = "";
         Z471BR_Encounter_ENCType_Code = "";
         A471BR_Encounter_ENCType_Code = "";
         Z472BR_Encounter_AdmitSource_Code = "";
         A472BR_Encounter_AdmitSource_Code = "";
         Z473BR_Encounter_DischargeStatus_Code = "";
         A473BR_Encounter_DischargeStatus_Code = "";
         Z84BR_Encounter_Department = "";
         A84BR_Encounter_Department = "";
         Z570BR_Encounter_Departmentadm = "";
         A570BR_Encounter_Departmentadm = "";
         Z571BR_Encounter_Departmentadm_Code = "";
         A571BR_Encounter_Departmentadm_Code = "";
         Z572BR_Encounter_Departmentdisch = "";
         A572BR_Encounter_Departmentdisch = "";
         Z573BR_Encounter_Departmentdisch_Code = "";
         A573BR_Encounter_Departmentdisch_Code = "";
         Z90BR_Encounter_ENCType = "";
         A90BR_Encounter_ENCType = "";
         Z91BR_Encounter_AdmitDate = DateTime.MinValue;
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         Z92BR_Encounter_AdmitSource = "";
         A92BR_Encounter_AdmitSource = "";
         Z93BR_Encounter_DischargeDate = DateTime.MinValue;
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         Z94BR_Encounter_DischargeStatus = "";
         A94BR_Encounter_DischargeStatus = "";
         Z574BR_Encounter_Insurance = "";
         A574BR_Encounter_Insurance = "";
         Z575BR_Encounter_Insurance_Code = "";
         A575BR_Encounter_Insurance_Code = "";
         Z187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         A187BR_Encounter_UpdDate = (DateTime)(DateTime.MinValue);
         Z186BR_Encounter_UpdUser = "";
         A186BR_Encounter_UpdUser = "";
         Z184BR_Encounter_SubmitUser = "";
         A184BR_Encounter_SubmitUser = "";
         Z335BR_Encounter_Reason = "";
         A335BR_Encounter_Reason = "";
         Z185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         A185BR_Encounter_SubmitDate = (DateTime)(DateTime.MinValue);
         Z188BR_Encounter_RecheckUser = "";
         A188BR_Encounter_RecheckUser = "";
         Z336BR_Encounter_FReason = "";
         A336BR_Encounter_FReason = "";
         Z189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         A189BR_Encounter_RecheckDate = (DateTime)(DateTime.MinValue);
         Z190BR_Encounter_Approver = "";
         A190BR_Encounter_Approver = "";
         Z191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         A191BR_Encounter_ApproveDate = (DateTime)(DateTime.MinValue);
         Z203BR_Encounter_IsRandApprover = "";
         A203BR_Encounter_IsRandApprover = "";
         Z204BR_Encounter_IsRandNoApprover = "";
         A204BR_Encounter_IsRandNoApprover = "";
         Z205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         A205BR_Encounter_IsRandApproveDate = (DateTime)(DateTime.MinValue);
         Z206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         A206BR_Encounter_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         Z207BR_Encounter_IsRandRecheckr = "";
         A207BR_Encounter_IsRandRecheckr = "";
         Z208BR_Encounter_IsRandNoRecheckr = "";
         A208BR_Encounter_IsRandNoRecheckr = "";
         Z209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         A209BR_Encounter_IsRandRecheckDate = (DateTime)(DateTime.MinValue);
         Z210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         A210BR_Encounter_IsRandNoRecheckDate = (DateTime)(DateTime.MinValue);
         Z560EncounterIDEncrypt = "";
         A560EncounterIDEncrypt = "";
         Z360BAS_TenantTenantCode = "";
         A360BAS_TenantTenantCode = "";
         Z36BR_Information_PatientNo = "";
         A36BR_Information_PatientNo = "";
         BC000E7_A19BR_EncounterID = new long[1] ;
         BC000E7_n19BR_EncounterID = new bool[] {false} ;
         BC000E7_A35BR_Encounter_EncID = new long[1] ;
         BC000E7_n35BR_Encounter_EncID = new bool[] {false} ;
         BC000E7_A172BR_Encounter_Status = new short[1] ;
         BC000E7_n172BR_Encounter_Status = new bool[] {false} ;
         BC000E7_A183BR_Encounter_CrtUser = new String[] {""} ;
         BC000E7_n183BR_Encounter_CrtUser = new bool[] {false} ;
         BC000E7_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         BC000E7_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         BC000E7_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n182BR_Encounter_CrtDate = new bool[] {false} ;
         BC000E7_A470BR_Encounter_Department_Code = new String[] {""} ;
         BC000E7_n470BR_Encounter_Department_Code = new bool[] {false} ;
         BC000E7_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         BC000E7_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         BC000E7_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         BC000E7_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         BC000E7_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         BC000E7_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         BC000E7_A84BR_Encounter_Department = new String[] {""} ;
         BC000E7_n84BR_Encounter_Department = new bool[] {false} ;
         BC000E7_A570BR_Encounter_Departmentadm = new String[] {""} ;
         BC000E7_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         BC000E7_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         BC000E7_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         BC000E7_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         BC000E7_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         BC000E7_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         BC000E7_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         BC000E7_A90BR_Encounter_ENCType = new String[] {""} ;
         BC000E7_n90BR_Encounter_ENCType = new bool[] {false} ;
         BC000E7_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         BC000E7_A92BR_Encounter_AdmitSource = new String[] {""} ;
         BC000E7_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         BC000E7_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         BC000E7_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         BC000E7_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         BC000E7_A574BR_Encounter_Insurance = new String[] {""} ;
         BC000E7_n574BR_Encounter_Insurance = new bool[] {false} ;
         BC000E7_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         BC000E7_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         BC000E7_A36BR_Information_PatientNo = new String[] {""} ;
         BC000E7_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000E7_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n187BR_Encounter_UpdDate = new bool[] {false} ;
         BC000E7_A186BR_Encounter_UpdUser = new String[] {""} ;
         BC000E7_n186BR_Encounter_UpdUser = new bool[] {false} ;
         BC000E7_A333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E7_n333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E7_A184BR_Encounter_SubmitUser = new String[] {""} ;
         BC000E7_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         BC000E7_A335BR_Encounter_Reason = new String[] {""} ;
         BC000E7_n335BR_Encounter_Reason = new bool[] {false} ;
         BC000E7_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         BC000E7_A188BR_Encounter_RecheckUser = new String[] {""} ;
         BC000E7_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         BC000E7_A336BR_Encounter_FReason = new String[] {""} ;
         BC000E7_n336BR_Encounter_FReason = new bool[] {false} ;
         BC000E7_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         BC000E7_A190BR_Encounter_Approver = new String[] {""} ;
         BC000E7_n190BR_Encounter_Approver = new bool[] {false} ;
         BC000E7_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         BC000E7_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E7_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E7_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         BC000E7_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         BC000E7_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         BC000E7_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         BC000E7_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         BC000E7_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         BC000E7_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E7_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E7_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         BC000E7_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         BC000E7_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         BC000E7_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         BC000E7_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         BC000E7_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E7_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         BC000E7_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E7_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E7_A537BR_Encounter_Datasource = new short[1] ;
         BC000E7_n537BR_Encounter_Datasource = new bool[] {false} ;
         BC000E7_A560EncounterIDEncrypt = new String[] {""} ;
         BC000E7_n560EncounterIDEncrypt = new bool[] {false} ;
         BC000E7_A85BR_Information_ID = new long[1] ;
         BC000E7_n85BR_Information_ID = new bool[] {false} ;
         BC000E7_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000E7_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC000E4_A36BR_Information_PatientNo = new String[] {""} ;
         BC000E4_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000E6_A85BR_Information_ID = new long[1] ;
         BC000E6_n85BR_Information_ID = new bool[] {false} ;
         BC000E5_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000E5_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC000E8_A19BR_EncounterID = new long[1] ;
         BC000E8_n19BR_EncounterID = new bool[] {false} ;
         BC000E3_A19BR_EncounterID = new long[1] ;
         BC000E3_n19BR_EncounterID = new bool[] {false} ;
         BC000E3_A35BR_Encounter_EncID = new long[1] ;
         BC000E3_n35BR_Encounter_EncID = new bool[] {false} ;
         BC000E3_A172BR_Encounter_Status = new short[1] ;
         BC000E3_n172BR_Encounter_Status = new bool[] {false} ;
         BC000E3_A183BR_Encounter_CrtUser = new String[] {""} ;
         BC000E3_n183BR_Encounter_CrtUser = new bool[] {false} ;
         BC000E3_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         BC000E3_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         BC000E3_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n182BR_Encounter_CrtDate = new bool[] {false} ;
         BC000E3_A470BR_Encounter_Department_Code = new String[] {""} ;
         BC000E3_n470BR_Encounter_Department_Code = new bool[] {false} ;
         BC000E3_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         BC000E3_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         BC000E3_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         BC000E3_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         BC000E3_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         BC000E3_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         BC000E3_A84BR_Encounter_Department = new String[] {""} ;
         BC000E3_n84BR_Encounter_Department = new bool[] {false} ;
         BC000E3_A570BR_Encounter_Departmentadm = new String[] {""} ;
         BC000E3_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         BC000E3_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         BC000E3_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         BC000E3_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         BC000E3_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         BC000E3_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         BC000E3_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         BC000E3_A90BR_Encounter_ENCType = new String[] {""} ;
         BC000E3_n90BR_Encounter_ENCType = new bool[] {false} ;
         BC000E3_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         BC000E3_A92BR_Encounter_AdmitSource = new String[] {""} ;
         BC000E3_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         BC000E3_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         BC000E3_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         BC000E3_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         BC000E3_A574BR_Encounter_Insurance = new String[] {""} ;
         BC000E3_n574BR_Encounter_Insurance = new bool[] {false} ;
         BC000E3_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         BC000E3_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         BC000E3_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n187BR_Encounter_UpdDate = new bool[] {false} ;
         BC000E3_A186BR_Encounter_UpdUser = new String[] {""} ;
         BC000E3_n186BR_Encounter_UpdUser = new bool[] {false} ;
         BC000E3_A333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E3_n333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E3_A184BR_Encounter_SubmitUser = new String[] {""} ;
         BC000E3_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         BC000E3_A335BR_Encounter_Reason = new String[] {""} ;
         BC000E3_n335BR_Encounter_Reason = new bool[] {false} ;
         BC000E3_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         BC000E3_A188BR_Encounter_RecheckUser = new String[] {""} ;
         BC000E3_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         BC000E3_A336BR_Encounter_FReason = new String[] {""} ;
         BC000E3_n336BR_Encounter_FReason = new bool[] {false} ;
         BC000E3_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         BC000E3_A190BR_Encounter_Approver = new String[] {""} ;
         BC000E3_n190BR_Encounter_Approver = new bool[] {false} ;
         BC000E3_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         BC000E3_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E3_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E3_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         BC000E3_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         BC000E3_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         BC000E3_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         BC000E3_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         BC000E3_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         BC000E3_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E3_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E3_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         BC000E3_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         BC000E3_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         BC000E3_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         BC000E3_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         BC000E3_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E3_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         BC000E3_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E3_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E3_A537BR_Encounter_Datasource = new short[1] ;
         BC000E3_n537BR_Encounter_Datasource = new bool[] {false} ;
         BC000E3_A560EncounterIDEncrypt = new String[] {""} ;
         BC000E3_n560EncounterIDEncrypt = new bool[] {false} ;
         BC000E3_A85BR_Information_ID = new long[1] ;
         BC000E3_n85BR_Information_ID = new bool[] {false} ;
         BC000E3_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000E3_n360BAS_TenantTenantCode = new bool[] {false} ;
         sMode15 = "";
         BC000E2_A19BR_EncounterID = new long[1] ;
         BC000E2_n19BR_EncounterID = new bool[] {false} ;
         BC000E2_A35BR_Encounter_EncID = new long[1] ;
         BC000E2_n35BR_Encounter_EncID = new bool[] {false} ;
         BC000E2_A172BR_Encounter_Status = new short[1] ;
         BC000E2_n172BR_Encounter_Status = new bool[] {false} ;
         BC000E2_A183BR_Encounter_CrtUser = new String[] {""} ;
         BC000E2_n183BR_Encounter_CrtUser = new bool[] {false} ;
         BC000E2_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         BC000E2_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         BC000E2_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n182BR_Encounter_CrtDate = new bool[] {false} ;
         BC000E2_A470BR_Encounter_Department_Code = new String[] {""} ;
         BC000E2_n470BR_Encounter_Department_Code = new bool[] {false} ;
         BC000E2_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         BC000E2_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         BC000E2_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         BC000E2_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         BC000E2_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         BC000E2_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         BC000E2_A84BR_Encounter_Department = new String[] {""} ;
         BC000E2_n84BR_Encounter_Department = new bool[] {false} ;
         BC000E2_A570BR_Encounter_Departmentadm = new String[] {""} ;
         BC000E2_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         BC000E2_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         BC000E2_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         BC000E2_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         BC000E2_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         BC000E2_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         BC000E2_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         BC000E2_A90BR_Encounter_ENCType = new String[] {""} ;
         BC000E2_n90BR_Encounter_ENCType = new bool[] {false} ;
         BC000E2_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         BC000E2_A92BR_Encounter_AdmitSource = new String[] {""} ;
         BC000E2_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         BC000E2_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         BC000E2_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         BC000E2_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         BC000E2_A574BR_Encounter_Insurance = new String[] {""} ;
         BC000E2_n574BR_Encounter_Insurance = new bool[] {false} ;
         BC000E2_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         BC000E2_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         BC000E2_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n187BR_Encounter_UpdDate = new bool[] {false} ;
         BC000E2_A186BR_Encounter_UpdUser = new String[] {""} ;
         BC000E2_n186BR_Encounter_UpdUser = new bool[] {false} ;
         BC000E2_A333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E2_n333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E2_A184BR_Encounter_SubmitUser = new String[] {""} ;
         BC000E2_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         BC000E2_A335BR_Encounter_Reason = new String[] {""} ;
         BC000E2_n335BR_Encounter_Reason = new bool[] {false} ;
         BC000E2_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         BC000E2_A188BR_Encounter_RecheckUser = new String[] {""} ;
         BC000E2_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         BC000E2_A336BR_Encounter_FReason = new String[] {""} ;
         BC000E2_n336BR_Encounter_FReason = new bool[] {false} ;
         BC000E2_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         BC000E2_A190BR_Encounter_Approver = new String[] {""} ;
         BC000E2_n190BR_Encounter_Approver = new bool[] {false} ;
         BC000E2_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         BC000E2_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E2_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E2_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         BC000E2_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         BC000E2_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         BC000E2_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         BC000E2_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         BC000E2_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         BC000E2_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E2_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E2_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         BC000E2_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         BC000E2_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         BC000E2_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         BC000E2_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         BC000E2_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E2_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         BC000E2_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E2_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E2_A537BR_Encounter_Datasource = new short[1] ;
         BC000E2_n537BR_Encounter_Datasource = new bool[] {false} ;
         BC000E2_A560EncounterIDEncrypt = new String[] {""} ;
         BC000E2_n560EncounterIDEncrypt = new bool[] {false} ;
         BC000E2_A85BR_Information_ID = new long[1] ;
         BC000E2_n85BR_Information_ID = new bool[] {false} ;
         BC000E2_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000E2_n360BAS_TenantTenantCode = new bool[] {false} ;
         BC000E9_A19BR_EncounterID = new long[1] ;
         BC000E9_n19BR_EncounterID = new bool[] {false} ;
         BC000E12_A36BR_Information_PatientNo = new String[] {""} ;
         BC000E12_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000E13_A348BR_Encounter_RefuseReasonID = new long[1] ;
         BC000E14_A347BR_Encounter_ID = new long[1] ;
         BC000E15_A327BR_SchemeID = new long[1] ;
         BC000E16_A226BR_PathologyID = new long[1] ;
         BC000E17_A225BR_MedicalImagingID = new long[1] ;
         BC000E18_A150BR_VitalID = new long[1] ;
         BC000E19_A139BR_ProcedureID = new long[1] ;
         BC000E20_A119BR_MedicationID = new long[1] ;
         BC000E21_A101BR_LabID = new long[1] ;
         BC000E22_A64BR_DiagnosisID = new long[1] ;
         BC000E23_A61BR_Demographics_ID = new long[1] ;
         BC000E24_A48BR_DeathID = new long[1] ;
         BC000E25_A37BR_ComorbidityID = new long[1] ;
         BC000E26_A20BR_BehaviorID = new long[1] ;
         BC000E27_A19BR_EncounterID = new long[1] ;
         BC000E27_n19BR_EncounterID = new bool[] {false} ;
         BC000E27_A35BR_Encounter_EncID = new long[1] ;
         BC000E27_n35BR_Encounter_EncID = new bool[] {false} ;
         BC000E27_A172BR_Encounter_Status = new short[1] ;
         BC000E27_n172BR_Encounter_Status = new bool[] {false} ;
         BC000E27_A183BR_Encounter_CrtUser = new String[] {""} ;
         BC000E27_n183BR_Encounter_CrtUser = new bool[] {false} ;
         BC000E27_A512BR_Encounter_CrtDisplayName = new String[] {""} ;
         BC000E27_n512BR_Encounter_CrtDisplayName = new bool[] {false} ;
         BC000E27_A182BR_Encounter_CrtDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n182BR_Encounter_CrtDate = new bool[] {false} ;
         BC000E27_A470BR_Encounter_Department_Code = new String[] {""} ;
         BC000E27_n470BR_Encounter_Department_Code = new bool[] {false} ;
         BC000E27_A471BR_Encounter_ENCType_Code = new String[] {""} ;
         BC000E27_n471BR_Encounter_ENCType_Code = new bool[] {false} ;
         BC000E27_A472BR_Encounter_AdmitSource_Code = new String[] {""} ;
         BC000E27_n472BR_Encounter_AdmitSource_Code = new bool[] {false} ;
         BC000E27_A473BR_Encounter_DischargeStatus_Code = new String[] {""} ;
         BC000E27_n473BR_Encounter_DischargeStatus_Code = new bool[] {false} ;
         BC000E27_A84BR_Encounter_Department = new String[] {""} ;
         BC000E27_n84BR_Encounter_Department = new bool[] {false} ;
         BC000E27_A570BR_Encounter_Departmentadm = new String[] {""} ;
         BC000E27_n570BR_Encounter_Departmentadm = new bool[] {false} ;
         BC000E27_A571BR_Encounter_Departmentadm_Code = new String[] {""} ;
         BC000E27_n571BR_Encounter_Departmentadm_Code = new bool[] {false} ;
         BC000E27_A572BR_Encounter_Departmentdisch = new String[] {""} ;
         BC000E27_n572BR_Encounter_Departmentdisch = new bool[] {false} ;
         BC000E27_A573BR_Encounter_Departmentdisch_Code = new String[] {""} ;
         BC000E27_n573BR_Encounter_Departmentdisch_Code = new bool[] {false} ;
         BC000E27_A90BR_Encounter_ENCType = new String[] {""} ;
         BC000E27_n90BR_Encounter_ENCType = new bool[] {false} ;
         BC000E27_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         BC000E27_A92BR_Encounter_AdmitSource = new String[] {""} ;
         BC000E27_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         BC000E27_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         BC000E27_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         BC000E27_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         BC000E27_A574BR_Encounter_Insurance = new String[] {""} ;
         BC000E27_n574BR_Encounter_Insurance = new bool[] {false} ;
         BC000E27_A575BR_Encounter_Insurance_Code = new String[] {""} ;
         BC000E27_n575BR_Encounter_Insurance_Code = new bool[] {false} ;
         BC000E27_A36BR_Information_PatientNo = new String[] {""} ;
         BC000E27_n36BR_Information_PatientNo = new bool[] {false} ;
         BC000E27_A187BR_Encounter_UpdDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n187BR_Encounter_UpdDate = new bool[] {false} ;
         BC000E27_A186BR_Encounter_UpdUser = new String[] {""} ;
         BC000E27_n186BR_Encounter_UpdUser = new bool[] {false} ;
         BC000E27_A333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E27_n333BR_Encounter_IsDLT = new bool[] {false} ;
         BC000E27_A184BR_Encounter_SubmitUser = new String[] {""} ;
         BC000E27_n184BR_Encounter_SubmitUser = new bool[] {false} ;
         BC000E27_A335BR_Encounter_Reason = new String[] {""} ;
         BC000E27_n335BR_Encounter_Reason = new bool[] {false} ;
         BC000E27_A185BR_Encounter_SubmitDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n185BR_Encounter_SubmitDate = new bool[] {false} ;
         BC000E27_A188BR_Encounter_RecheckUser = new String[] {""} ;
         BC000E27_n188BR_Encounter_RecheckUser = new bool[] {false} ;
         BC000E27_A336BR_Encounter_FReason = new String[] {""} ;
         BC000E27_n336BR_Encounter_FReason = new bool[] {false} ;
         BC000E27_A189BR_Encounter_RecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n189BR_Encounter_RecheckDate = new bool[] {false} ;
         BC000E27_A190BR_Encounter_Approver = new String[] {""} ;
         BC000E27_n190BR_Encounter_Approver = new bool[] {false} ;
         BC000E27_A191BR_Encounter_ApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n191BR_Encounter_ApproveDate = new bool[] {false} ;
         BC000E27_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E27_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         BC000E27_A203BR_Encounter_IsRandApprover = new String[] {""} ;
         BC000E27_n203BR_Encounter_IsRandApprover = new bool[] {false} ;
         BC000E27_A204BR_Encounter_IsRandNoApprover = new String[] {""} ;
         BC000E27_n204BR_Encounter_IsRandNoApprover = new bool[] {false} ;
         BC000E27_A205BR_Encounter_IsRandApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n205BR_Encounter_IsRandApproveDate = new bool[] {false} ;
         BC000E27_A206BR_Encounter_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n206BR_Encounter_IsRandNoApproveDate = new bool[] {false} ;
         BC000E27_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E27_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         BC000E27_A207BR_Encounter_IsRandRecheckr = new String[] {""} ;
         BC000E27_n207BR_Encounter_IsRandRecheckr = new bool[] {false} ;
         BC000E27_A208BR_Encounter_IsRandNoRecheckr = new String[] {""} ;
         BC000E27_n208BR_Encounter_IsRandNoRecheckr = new bool[] {false} ;
         BC000E27_A209BR_Encounter_IsRandRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n209BR_Encounter_IsRandRecheckDate = new bool[] {false} ;
         BC000E27_A210BR_Encounter_IsRandNoRecheckDate = new DateTime[] {DateTime.MinValue} ;
         BC000E27_n210BR_Encounter_IsRandNoRecheckDate = new bool[] {false} ;
         BC000E27_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E27_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         BC000E27_A537BR_Encounter_Datasource = new short[1] ;
         BC000E27_n537BR_Encounter_Datasource = new bool[] {false} ;
         BC000E27_A560EncounterIDEncrypt = new String[] {""} ;
         BC000E27_n560EncounterIDEncrypt = new bool[] {false} ;
         BC000E27_A85BR_Information_ID = new long[1] ;
         BC000E27_n85BR_Information_ID = new bool[] {false} ;
         BC000E27_A360BAS_TenantTenantCode = new String[] {""} ;
         BC000E27_n360BAS_TenantTenantCode = new bool[] {false} ;
         GXt_char2 = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_bc__datastore1(),
            new Object[][] {
                new Object[] {
               BC000E5_A360BAS_TenantTenantCode
               }
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_bc__default(),
            new Object[][] {
                new Object[] {
               BC000E2_A19BR_EncounterID, BC000E2_A35BR_Encounter_EncID, BC000E2_n35BR_Encounter_EncID, BC000E2_A172BR_Encounter_Status, BC000E2_n172BR_Encounter_Status, BC000E2_A183BR_Encounter_CrtUser, BC000E2_n183BR_Encounter_CrtUser, BC000E2_A512BR_Encounter_CrtDisplayName, BC000E2_n512BR_Encounter_CrtDisplayName, BC000E2_A182BR_Encounter_CrtDate,
               BC000E2_n182BR_Encounter_CrtDate, BC000E2_A470BR_Encounter_Department_Code, BC000E2_n470BR_Encounter_Department_Code, BC000E2_A471BR_Encounter_ENCType_Code, BC000E2_n471BR_Encounter_ENCType_Code, BC000E2_A472BR_Encounter_AdmitSource_Code, BC000E2_n472BR_Encounter_AdmitSource_Code, BC000E2_A473BR_Encounter_DischargeStatus_Code, BC000E2_n473BR_Encounter_DischargeStatus_Code, BC000E2_A84BR_Encounter_Department,
               BC000E2_n84BR_Encounter_Department, BC000E2_A570BR_Encounter_Departmentadm, BC000E2_n570BR_Encounter_Departmentadm, BC000E2_A571BR_Encounter_Departmentadm_Code, BC000E2_n571BR_Encounter_Departmentadm_Code, BC000E2_A572BR_Encounter_Departmentdisch, BC000E2_n572BR_Encounter_Departmentdisch, BC000E2_A573BR_Encounter_Departmentdisch_Code, BC000E2_n573BR_Encounter_Departmentdisch_Code, BC000E2_A90BR_Encounter_ENCType,
               BC000E2_n90BR_Encounter_ENCType, BC000E2_A91BR_Encounter_AdmitDate, BC000E2_n91BR_Encounter_AdmitDate, BC000E2_A92BR_Encounter_AdmitSource, BC000E2_n92BR_Encounter_AdmitSource, BC000E2_A93BR_Encounter_DischargeDate, BC000E2_n93BR_Encounter_DischargeDate, BC000E2_A94BR_Encounter_DischargeStatus, BC000E2_n94BR_Encounter_DischargeStatus, BC000E2_A574BR_Encounter_Insurance,
               BC000E2_n574BR_Encounter_Insurance, BC000E2_A575BR_Encounter_Insurance_Code, BC000E2_n575BR_Encounter_Insurance_Code, BC000E2_A187BR_Encounter_UpdDate, BC000E2_n187BR_Encounter_UpdDate, BC000E2_A186BR_Encounter_UpdUser, BC000E2_n186BR_Encounter_UpdUser, BC000E2_A333BR_Encounter_IsDLT, BC000E2_n333BR_Encounter_IsDLT, BC000E2_A184BR_Encounter_SubmitUser,
               BC000E2_n184BR_Encounter_SubmitUser, BC000E2_A335BR_Encounter_Reason, BC000E2_n335BR_Encounter_Reason, BC000E2_A185BR_Encounter_SubmitDate, BC000E2_n185BR_Encounter_SubmitDate, BC000E2_A188BR_Encounter_RecheckUser, BC000E2_n188BR_Encounter_RecheckUser, BC000E2_A336BR_Encounter_FReason, BC000E2_n336BR_Encounter_FReason, BC000E2_A189BR_Encounter_RecheckDate,
               BC000E2_n189BR_Encounter_RecheckDate, BC000E2_A190BR_Encounter_Approver, BC000E2_n190BR_Encounter_Approver, BC000E2_A191BR_Encounter_ApproveDate, BC000E2_n191BR_Encounter_ApproveDate, BC000E2_A192BR_Encounter_IsRandApprove, BC000E2_n192BR_Encounter_IsRandApprove, BC000E2_A203BR_Encounter_IsRandApprover, BC000E2_n203BR_Encounter_IsRandApprover, BC000E2_A204BR_Encounter_IsRandNoApprover,
               BC000E2_n204BR_Encounter_IsRandNoApprover, BC000E2_A205BR_Encounter_IsRandApproveDate, BC000E2_n205BR_Encounter_IsRandApproveDate, BC000E2_A206BR_Encounter_IsRandNoApproveDate, BC000E2_n206BR_Encounter_IsRandNoApproveDate, BC000E2_A193BR_Encounter_IsRandRecheck, BC000E2_n193BR_Encounter_IsRandRecheck, BC000E2_A207BR_Encounter_IsRandRecheckr, BC000E2_n207BR_Encounter_IsRandRecheckr, BC000E2_A208BR_Encounter_IsRandNoRecheckr,
               BC000E2_n208BR_Encounter_IsRandNoRecheckr, BC000E2_A209BR_Encounter_IsRandRecheckDate, BC000E2_n209BR_Encounter_IsRandRecheckDate, BC000E2_A210BR_Encounter_IsRandNoRecheckDate, BC000E2_n210BR_Encounter_IsRandNoRecheckDate, BC000E2_A202BR_Encounter_IsUpdate, BC000E2_n202BR_Encounter_IsUpdate, BC000E2_A537BR_Encounter_Datasource, BC000E2_n537BR_Encounter_Datasource, BC000E2_A560EncounterIDEncrypt,
               BC000E2_n560EncounterIDEncrypt, BC000E2_A85BR_Information_ID, BC000E2_n85BR_Information_ID, BC000E2_A360BAS_TenantTenantCode, BC000E2_n360BAS_TenantTenantCode
               }
               , new Object[] {
               BC000E3_A19BR_EncounterID, BC000E3_A35BR_Encounter_EncID, BC000E3_n35BR_Encounter_EncID, BC000E3_A172BR_Encounter_Status, BC000E3_n172BR_Encounter_Status, BC000E3_A183BR_Encounter_CrtUser, BC000E3_n183BR_Encounter_CrtUser, BC000E3_A512BR_Encounter_CrtDisplayName, BC000E3_n512BR_Encounter_CrtDisplayName, BC000E3_A182BR_Encounter_CrtDate,
               BC000E3_n182BR_Encounter_CrtDate, BC000E3_A470BR_Encounter_Department_Code, BC000E3_n470BR_Encounter_Department_Code, BC000E3_A471BR_Encounter_ENCType_Code, BC000E3_n471BR_Encounter_ENCType_Code, BC000E3_A472BR_Encounter_AdmitSource_Code, BC000E3_n472BR_Encounter_AdmitSource_Code, BC000E3_A473BR_Encounter_DischargeStatus_Code, BC000E3_n473BR_Encounter_DischargeStatus_Code, BC000E3_A84BR_Encounter_Department,
               BC000E3_n84BR_Encounter_Department, BC000E3_A570BR_Encounter_Departmentadm, BC000E3_n570BR_Encounter_Departmentadm, BC000E3_A571BR_Encounter_Departmentadm_Code, BC000E3_n571BR_Encounter_Departmentadm_Code, BC000E3_A572BR_Encounter_Departmentdisch, BC000E3_n572BR_Encounter_Departmentdisch, BC000E3_A573BR_Encounter_Departmentdisch_Code, BC000E3_n573BR_Encounter_Departmentdisch_Code, BC000E3_A90BR_Encounter_ENCType,
               BC000E3_n90BR_Encounter_ENCType, BC000E3_A91BR_Encounter_AdmitDate, BC000E3_n91BR_Encounter_AdmitDate, BC000E3_A92BR_Encounter_AdmitSource, BC000E3_n92BR_Encounter_AdmitSource, BC000E3_A93BR_Encounter_DischargeDate, BC000E3_n93BR_Encounter_DischargeDate, BC000E3_A94BR_Encounter_DischargeStatus, BC000E3_n94BR_Encounter_DischargeStatus, BC000E3_A574BR_Encounter_Insurance,
               BC000E3_n574BR_Encounter_Insurance, BC000E3_A575BR_Encounter_Insurance_Code, BC000E3_n575BR_Encounter_Insurance_Code, BC000E3_A187BR_Encounter_UpdDate, BC000E3_n187BR_Encounter_UpdDate, BC000E3_A186BR_Encounter_UpdUser, BC000E3_n186BR_Encounter_UpdUser, BC000E3_A333BR_Encounter_IsDLT, BC000E3_n333BR_Encounter_IsDLT, BC000E3_A184BR_Encounter_SubmitUser,
               BC000E3_n184BR_Encounter_SubmitUser, BC000E3_A335BR_Encounter_Reason, BC000E3_n335BR_Encounter_Reason, BC000E3_A185BR_Encounter_SubmitDate, BC000E3_n185BR_Encounter_SubmitDate, BC000E3_A188BR_Encounter_RecheckUser, BC000E3_n188BR_Encounter_RecheckUser, BC000E3_A336BR_Encounter_FReason, BC000E3_n336BR_Encounter_FReason, BC000E3_A189BR_Encounter_RecheckDate,
               BC000E3_n189BR_Encounter_RecheckDate, BC000E3_A190BR_Encounter_Approver, BC000E3_n190BR_Encounter_Approver, BC000E3_A191BR_Encounter_ApproveDate, BC000E3_n191BR_Encounter_ApproveDate, BC000E3_A192BR_Encounter_IsRandApprove, BC000E3_n192BR_Encounter_IsRandApprove, BC000E3_A203BR_Encounter_IsRandApprover, BC000E3_n203BR_Encounter_IsRandApprover, BC000E3_A204BR_Encounter_IsRandNoApprover,
               BC000E3_n204BR_Encounter_IsRandNoApprover, BC000E3_A205BR_Encounter_IsRandApproveDate, BC000E3_n205BR_Encounter_IsRandApproveDate, BC000E3_A206BR_Encounter_IsRandNoApproveDate, BC000E3_n206BR_Encounter_IsRandNoApproveDate, BC000E3_A193BR_Encounter_IsRandRecheck, BC000E3_n193BR_Encounter_IsRandRecheck, BC000E3_A207BR_Encounter_IsRandRecheckr, BC000E3_n207BR_Encounter_IsRandRecheckr, BC000E3_A208BR_Encounter_IsRandNoRecheckr,
               BC000E3_n208BR_Encounter_IsRandNoRecheckr, BC000E3_A209BR_Encounter_IsRandRecheckDate, BC000E3_n209BR_Encounter_IsRandRecheckDate, BC000E3_A210BR_Encounter_IsRandNoRecheckDate, BC000E3_n210BR_Encounter_IsRandNoRecheckDate, BC000E3_A202BR_Encounter_IsUpdate, BC000E3_n202BR_Encounter_IsUpdate, BC000E3_A537BR_Encounter_Datasource, BC000E3_n537BR_Encounter_Datasource, BC000E3_A560EncounterIDEncrypt,
               BC000E3_n560EncounterIDEncrypt, BC000E3_A85BR_Information_ID, BC000E3_n85BR_Information_ID, BC000E3_A360BAS_TenantTenantCode, BC000E3_n360BAS_TenantTenantCode
               }
               , new Object[] {
               BC000E4_A36BR_Information_PatientNo, BC000E4_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000E6_A85BR_Information_ID
               }
               , new Object[] {
               BC000E7_A19BR_EncounterID, BC000E7_A35BR_Encounter_EncID, BC000E7_n35BR_Encounter_EncID, BC000E7_A172BR_Encounter_Status, BC000E7_n172BR_Encounter_Status, BC000E7_A183BR_Encounter_CrtUser, BC000E7_n183BR_Encounter_CrtUser, BC000E7_A512BR_Encounter_CrtDisplayName, BC000E7_n512BR_Encounter_CrtDisplayName, BC000E7_A182BR_Encounter_CrtDate,
               BC000E7_n182BR_Encounter_CrtDate, BC000E7_A470BR_Encounter_Department_Code, BC000E7_n470BR_Encounter_Department_Code, BC000E7_A471BR_Encounter_ENCType_Code, BC000E7_n471BR_Encounter_ENCType_Code, BC000E7_A472BR_Encounter_AdmitSource_Code, BC000E7_n472BR_Encounter_AdmitSource_Code, BC000E7_A473BR_Encounter_DischargeStatus_Code, BC000E7_n473BR_Encounter_DischargeStatus_Code, BC000E7_A84BR_Encounter_Department,
               BC000E7_n84BR_Encounter_Department, BC000E7_A570BR_Encounter_Departmentadm, BC000E7_n570BR_Encounter_Departmentadm, BC000E7_A571BR_Encounter_Departmentadm_Code, BC000E7_n571BR_Encounter_Departmentadm_Code, BC000E7_A572BR_Encounter_Departmentdisch, BC000E7_n572BR_Encounter_Departmentdisch, BC000E7_A573BR_Encounter_Departmentdisch_Code, BC000E7_n573BR_Encounter_Departmentdisch_Code, BC000E7_A90BR_Encounter_ENCType,
               BC000E7_n90BR_Encounter_ENCType, BC000E7_A91BR_Encounter_AdmitDate, BC000E7_n91BR_Encounter_AdmitDate, BC000E7_A92BR_Encounter_AdmitSource, BC000E7_n92BR_Encounter_AdmitSource, BC000E7_A93BR_Encounter_DischargeDate, BC000E7_n93BR_Encounter_DischargeDate, BC000E7_A94BR_Encounter_DischargeStatus, BC000E7_n94BR_Encounter_DischargeStatus, BC000E7_A574BR_Encounter_Insurance,
               BC000E7_n574BR_Encounter_Insurance, BC000E7_A575BR_Encounter_Insurance_Code, BC000E7_n575BR_Encounter_Insurance_Code, BC000E7_A36BR_Information_PatientNo, BC000E7_n36BR_Information_PatientNo, BC000E7_A187BR_Encounter_UpdDate, BC000E7_n187BR_Encounter_UpdDate, BC000E7_A186BR_Encounter_UpdUser, BC000E7_n186BR_Encounter_UpdUser, BC000E7_A333BR_Encounter_IsDLT,
               BC000E7_n333BR_Encounter_IsDLT, BC000E7_A184BR_Encounter_SubmitUser, BC000E7_n184BR_Encounter_SubmitUser, BC000E7_A335BR_Encounter_Reason, BC000E7_n335BR_Encounter_Reason, BC000E7_A185BR_Encounter_SubmitDate, BC000E7_n185BR_Encounter_SubmitDate, BC000E7_A188BR_Encounter_RecheckUser, BC000E7_n188BR_Encounter_RecheckUser, BC000E7_A336BR_Encounter_FReason,
               BC000E7_n336BR_Encounter_FReason, BC000E7_A189BR_Encounter_RecheckDate, BC000E7_n189BR_Encounter_RecheckDate, BC000E7_A190BR_Encounter_Approver, BC000E7_n190BR_Encounter_Approver, BC000E7_A191BR_Encounter_ApproveDate, BC000E7_n191BR_Encounter_ApproveDate, BC000E7_A192BR_Encounter_IsRandApprove, BC000E7_n192BR_Encounter_IsRandApprove, BC000E7_A203BR_Encounter_IsRandApprover,
               BC000E7_n203BR_Encounter_IsRandApprover, BC000E7_A204BR_Encounter_IsRandNoApprover, BC000E7_n204BR_Encounter_IsRandNoApprover, BC000E7_A205BR_Encounter_IsRandApproveDate, BC000E7_n205BR_Encounter_IsRandApproveDate, BC000E7_A206BR_Encounter_IsRandNoApproveDate, BC000E7_n206BR_Encounter_IsRandNoApproveDate, BC000E7_A193BR_Encounter_IsRandRecheck, BC000E7_n193BR_Encounter_IsRandRecheck, BC000E7_A207BR_Encounter_IsRandRecheckr,
               BC000E7_n207BR_Encounter_IsRandRecheckr, BC000E7_A208BR_Encounter_IsRandNoRecheckr, BC000E7_n208BR_Encounter_IsRandNoRecheckr, BC000E7_A209BR_Encounter_IsRandRecheckDate, BC000E7_n209BR_Encounter_IsRandRecheckDate, BC000E7_A210BR_Encounter_IsRandNoRecheckDate, BC000E7_n210BR_Encounter_IsRandNoRecheckDate, BC000E7_A202BR_Encounter_IsUpdate, BC000E7_n202BR_Encounter_IsUpdate, BC000E7_A537BR_Encounter_Datasource,
               BC000E7_n537BR_Encounter_Datasource, BC000E7_A560EncounterIDEncrypt, BC000E7_n560EncounterIDEncrypt, BC000E7_A85BR_Information_ID, BC000E7_n85BR_Information_ID, BC000E7_A360BAS_TenantTenantCode, BC000E7_n360BAS_TenantTenantCode
               }
               , new Object[] {
               BC000E8_A19BR_EncounterID
               }
               , new Object[] {
               BC000E9_A19BR_EncounterID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000E12_A36BR_Information_PatientNo, BC000E12_n36BR_Information_PatientNo
               }
               , new Object[] {
               BC000E13_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               BC000E14_A347BR_Encounter_ID
               }
               , new Object[] {
               BC000E15_A327BR_SchemeID
               }
               , new Object[] {
               BC000E16_A226BR_PathologyID
               }
               , new Object[] {
               BC000E17_A225BR_MedicalImagingID
               }
               , new Object[] {
               BC000E18_A150BR_VitalID
               }
               , new Object[] {
               BC000E19_A139BR_ProcedureID
               }
               , new Object[] {
               BC000E20_A119BR_MedicationID
               }
               , new Object[] {
               BC000E21_A101BR_LabID
               }
               , new Object[] {
               BC000E22_A64BR_DiagnosisID
               }
               , new Object[] {
               BC000E23_A61BR_Demographics_ID
               }
               , new Object[] {
               BC000E24_A48BR_DeathID
               }
               , new Object[] {
               BC000E25_A37BR_ComorbidityID
               }
               , new Object[] {
               BC000E26_A20BR_BehaviorID
               }
               , new Object[] {
               BC000E27_A19BR_EncounterID, BC000E27_A35BR_Encounter_EncID, BC000E27_n35BR_Encounter_EncID, BC000E27_A172BR_Encounter_Status, BC000E27_n172BR_Encounter_Status, BC000E27_A183BR_Encounter_CrtUser, BC000E27_n183BR_Encounter_CrtUser, BC000E27_A512BR_Encounter_CrtDisplayName, BC000E27_n512BR_Encounter_CrtDisplayName, BC000E27_A182BR_Encounter_CrtDate,
               BC000E27_n182BR_Encounter_CrtDate, BC000E27_A470BR_Encounter_Department_Code, BC000E27_n470BR_Encounter_Department_Code, BC000E27_A471BR_Encounter_ENCType_Code, BC000E27_n471BR_Encounter_ENCType_Code, BC000E27_A472BR_Encounter_AdmitSource_Code, BC000E27_n472BR_Encounter_AdmitSource_Code, BC000E27_A473BR_Encounter_DischargeStatus_Code, BC000E27_n473BR_Encounter_DischargeStatus_Code, BC000E27_A84BR_Encounter_Department,
               BC000E27_n84BR_Encounter_Department, BC000E27_A570BR_Encounter_Departmentadm, BC000E27_n570BR_Encounter_Departmentadm, BC000E27_A571BR_Encounter_Departmentadm_Code, BC000E27_n571BR_Encounter_Departmentadm_Code, BC000E27_A572BR_Encounter_Departmentdisch, BC000E27_n572BR_Encounter_Departmentdisch, BC000E27_A573BR_Encounter_Departmentdisch_Code, BC000E27_n573BR_Encounter_Departmentdisch_Code, BC000E27_A90BR_Encounter_ENCType,
               BC000E27_n90BR_Encounter_ENCType, BC000E27_A91BR_Encounter_AdmitDate, BC000E27_n91BR_Encounter_AdmitDate, BC000E27_A92BR_Encounter_AdmitSource, BC000E27_n92BR_Encounter_AdmitSource, BC000E27_A93BR_Encounter_DischargeDate, BC000E27_n93BR_Encounter_DischargeDate, BC000E27_A94BR_Encounter_DischargeStatus, BC000E27_n94BR_Encounter_DischargeStatus, BC000E27_A574BR_Encounter_Insurance,
               BC000E27_n574BR_Encounter_Insurance, BC000E27_A575BR_Encounter_Insurance_Code, BC000E27_n575BR_Encounter_Insurance_Code, BC000E27_A36BR_Information_PatientNo, BC000E27_n36BR_Information_PatientNo, BC000E27_A187BR_Encounter_UpdDate, BC000E27_n187BR_Encounter_UpdDate, BC000E27_A186BR_Encounter_UpdUser, BC000E27_n186BR_Encounter_UpdUser, BC000E27_A333BR_Encounter_IsDLT,
               BC000E27_n333BR_Encounter_IsDLT, BC000E27_A184BR_Encounter_SubmitUser, BC000E27_n184BR_Encounter_SubmitUser, BC000E27_A335BR_Encounter_Reason, BC000E27_n335BR_Encounter_Reason, BC000E27_A185BR_Encounter_SubmitDate, BC000E27_n185BR_Encounter_SubmitDate, BC000E27_A188BR_Encounter_RecheckUser, BC000E27_n188BR_Encounter_RecheckUser, BC000E27_A336BR_Encounter_FReason,
               BC000E27_n336BR_Encounter_FReason, BC000E27_A189BR_Encounter_RecheckDate, BC000E27_n189BR_Encounter_RecheckDate, BC000E27_A190BR_Encounter_Approver, BC000E27_n190BR_Encounter_Approver, BC000E27_A191BR_Encounter_ApproveDate, BC000E27_n191BR_Encounter_ApproveDate, BC000E27_A192BR_Encounter_IsRandApprove, BC000E27_n192BR_Encounter_IsRandApprove, BC000E27_A203BR_Encounter_IsRandApprover,
               BC000E27_n203BR_Encounter_IsRandApprover, BC000E27_A204BR_Encounter_IsRandNoApprover, BC000E27_n204BR_Encounter_IsRandNoApprover, BC000E27_A205BR_Encounter_IsRandApproveDate, BC000E27_n205BR_Encounter_IsRandApproveDate, BC000E27_A206BR_Encounter_IsRandNoApproveDate, BC000E27_n206BR_Encounter_IsRandNoApproveDate, BC000E27_A193BR_Encounter_IsRandRecheck, BC000E27_n193BR_Encounter_IsRandRecheck, BC000E27_A207BR_Encounter_IsRandRecheckr,
               BC000E27_n207BR_Encounter_IsRandRecheckr, BC000E27_A208BR_Encounter_IsRandNoRecheckr, BC000E27_n208BR_Encounter_IsRandNoRecheckr, BC000E27_A209BR_Encounter_IsRandRecheckDate, BC000E27_n209BR_Encounter_IsRandRecheckDate, BC000E27_A210BR_Encounter_IsRandNoRecheckDate, BC000E27_n210BR_Encounter_IsRandNoRecheckDate, BC000E27_A202BR_Encounter_IsUpdate, BC000E27_n202BR_Encounter_IsUpdate, BC000E27_A537BR_Encounter_Datasource,
               BC000E27_n537BR_Encounter_Datasource, BC000E27_A560EncounterIDEncrypt, BC000E27_n560EncounterIDEncrypt, BC000E27_A85BR_Information_ID, BC000E27_n85BR_Information_ID, BC000E27_A360BAS_TenantTenantCode, BC000E27_n360BAS_TenantTenantCode
               }
            }
         );
         AV31Pgmname = "BR_Encounter_BC";
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E120E2 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short Z172BR_Encounter_Status ;
      private short A172BR_Encounter_Status ;
      private short Z537BR_Encounter_Datasource ;
      private short A537BR_Encounter_Datasource ;
      private short RcdFound15 ;
      private int trnEnded ;
      private int AV32GXV1 ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long AV8Insert_BR_Information_ID ;
      private long Z35BR_Encounter_EncID ;
      private long A35BR_Encounter_EncID ;
      private long Z85BR_Information_ID ;
      private long A85BR_Information_ID ;
      private long GXt_int3 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String AV31Pgmname ;
      private String sMode15 ;
      private String GXt_char2 ;
      private DateTime Z182BR_Encounter_CrtDate ;
      private DateTime A182BR_Encounter_CrtDate ;
      private DateTime Z187BR_Encounter_UpdDate ;
      private DateTime A187BR_Encounter_UpdDate ;
      private DateTime Z185BR_Encounter_SubmitDate ;
      private DateTime A185BR_Encounter_SubmitDate ;
      private DateTime Z189BR_Encounter_RecheckDate ;
      private DateTime A189BR_Encounter_RecheckDate ;
      private DateTime Z191BR_Encounter_ApproveDate ;
      private DateTime A191BR_Encounter_ApproveDate ;
      private DateTime Z205BR_Encounter_IsRandApproveDate ;
      private DateTime A205BR_Encounter_IsRandApproveDate ;
      private DateTime Z206BR_Encounter_IsRandNoApproveDate ;
      private DateTime A206BR_Encounter_IsRandNoApproveDate ;
      private DateTime Z209BR_Encounter_IsRandRecheckDate ;
      private DateTime A209BR_Encounter_IsRandRecheckDate ;
      private DateTime Z210BR_Encounter_IsRandNoRecheckDate ;
      private DateTime A210BR_Encounter_IsRandNoRecheckDate ;
      private DateTime Z91BR_Encounter_AdmitDate ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime Z93BR_Encounter_DischargeDate ;
      private DateTime A93BR_Encounter_DischargeDate ;
      private bool AV16IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Z333BR_Encounter_IsDLT ;
      private bool A333BR_Encounter_IsDLT ;
      private bool Z192BR_Encounter_IsRandApprove ;
      private bool A192BR_Encounter_IsRandApprove ;
      private bool Z193BR_Encounter_IsRandRecheck ;
      private bool A193BR_Encounter_IsRandRecheck ;
      private bool Z202BR_Encounter_IsUpdate ;
      private bool A202BR_Encounter_IsUpdate ;
      private bool n19BR_EncounterID ;
      private bool n35BR_Encounter_EncID ;
      private bool n172BR_Encounter_Status ;
      private bool n183BR_Encounter_CrtUser ;
      private bool n512BR_Encounter_CrtDisplayName ;
      private bool n182BR_Encounter_CrtDate ;
      private bool n470BR_Encounter_Department_Code ;
      private bool n471BR_Encounter_ENCType_Code ;
      private bool n472BR_Encounter_AdmitSource_Code ;
      private bool n473BR_Encounter_DischargeStatus_Code ;
      private bool n84BR_Encounter_Department ;
      private bool n570BR_Encounter_Departmentadm ;
      private bool n571BR_Encounter_Departmentadm_Code ;
      private bool n572BR_Encounter_Departmentdisch ;
      private bool n573BR_Encounter_Departmentdisch_Code ;
      private bool n90BR_Encounter_ENCType ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n93BR_Encounter_DischargeDate ;
      private bool n94BR_Encounter_DischargeStatus ;
      private bool n574BR_Encounter_Insurance ;
      private bool n575BR_Encounter_Insurance_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool n187BR_Encounter_UpdDate ;
      private bool n186BR_Encounter_UpdUser ;
      private bool n333BR_Encounter_IsDLT ;
      private bool n184BR_Encounter_SubmitUser ;
      private bool n335BR_Encounter_Reason ;
      private bool n185BR_Encounter_SubmitDate ;
      private bool n188BR_Encounter_RecheckUser ;
      private bool n336BR_Encounter_FReason ;
      private bool n189BR_Encounter_RecheckDate ;
      private bool n190BR_Encounter_Approver ;
      private bool n191BR_Encounter_ApproveDate ;
      private bool n192BR_Encounter_IsRandApprove ;
      private bool n203BR_Encounter_IsRandApprover ;
      private bool n204BR_Encounter_IsRandNoApprover ;
      private bool n205BR_Encounter_IsRandApproveDate ;
      private bool n206BR_Encounter_IsRandNoApproveDate ;
      private bool n193BR_Encounter_IsRandRecheck ;
      private bool n207BR_Encounter_IsRandRecheckr ;
      private bool n208BR_Encounter_IsRandNoRecheckr ;
      private bool n209BR_Encounter_IsRandRecheckDate ;
      private bool n210BR_Encounter_IsRandNoRecheckDate ;
      private bool n202BR_Encounter_IsUpdate ;
      private bool n537BR_Encounter_Datasource ;
      private bool n560EncounterIDEncrypt ;
      private bool n85BR_Information_ID ;
      private bool n360BAS_TenantTenantCode ;
      private bool Gx_longc ;
      private String AV29Insert_BAS_TenantTenantCode ;
      private String Z183BR_Encounter_CrtUser ;
      private String A183BR_Encounter_CrtUser ;
      private String Z512BR_Encounter_CrtDisplayName ;
      private String A512BR_Encounter_CrtDisplayName ;
      private String Z470BR_Encounter_Department_Code ;
      private String A470BR_Encounter_Department_Code ;
      private String Z471BR_Encounter_ENCType_Code ;
      private String A471BR_Encounter_ENCType_Code ;
      private String Z472BR_Encounter_AdmitSource_Code ;
      private String A472BR_Encounter_AdmitSource_Code ;
      private String Z473BR_Encounter_DischargeStatus_Code ;
      private String A473BR_Encounter_DischargeStatus_Code ;
      private String Z84BR_Encounter_Department ;
      private String A84BR_Encounter_Department ;
      private String Z570BR_Encounter_Departmentadm ;
      private String A570BR_Encounter_Departmentadm ;
      private String Z571BR_Encounter_Departmentadm_Code ;
      private String A571BR_Encounter_Departmentadm_Code ;
      private String Z572BR_Encounter_Departmentdisch ;
      private String A572BR_Encounter_Departmentdisch ;
      private String Z573BR_Encounter_Departmentdisch_Code ;
      private String A573BR_Encounter_Departmentdisch_Code ;
      private String Z90BR_Encounter_ENCType ;
      private String A90BR_Encounter_ENCType ;
      private String Z92BR_Encounter_AdmitSource ;
      private String A92BR_Encounter_AdmitSource ;
      private String Z94BR_Encounter_DischargeStatus ;
      private String A94BR_Encounter_DischargeStatus ;
      private String Z574BR_Encounter_Insurance ;
      private String A574BR_Encounter_Insurance ;
      private String Z575BR_Encounter_Insurance_Code ;
      private String A575BR_Encounter_Insurance_Code ;
      private String Z186BR_Encounter_UpdUser ;
      private String A186BR_Encounter_UpdUser ;
      private String Z184BR_Encounter_SubmitUser ;
      private String A184BR_Encounter_SubmitUser ;
      private String Z335BR_Encounter_Reason ;
      private String A335BR_Encounter_Reason ;
      private String Z188BR_Encounter_RecheckUser ;
      private String A188BR_Encounter_RecheckUser ;
      private String Z336BR_Encounter_FReason ;
      private String A336BR_Encounter_FReason ;
      private String Z190BR_Encounter_Approver ;
      private String A190BR_Encounter_Approver ;
      private String Z203BR_Encounter_IsRandApprover ;
      private String A203BR_Encounter_IsRandApprover ;
      private String Z204BR_Encounter_IsRandNoApprover ;
      private String A204BR_Encounter_IsRandNoApprover ;
      private String Z207BR_Encounter_IsRandRecheckr ;
      private String A207BR_Encounter_IsRandRecheckr ;
      private String Z208BR_Encounter_IsRandNoRecheckr ;
      private String A208BR_Encounter_IsRandNoRecheckr ;
      private String Z560EncounterIDEncrypt ;
      private String A560EncounterIDEncrypt ;
      private String Z360BAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private String Z36BR_Information_PatientNo ;
      private String A36BR_Information_PatientNo ;
      private IGxSession AV13WebSession ;
      private SdtBR_Encounter bcBR_Encounter ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] BC000E7_A19BR_EncounterID ;
      private bool[] BC000E7_n19BR_EncounterID ;
      private long[] BC000E7_A35BR_Encounter_EncID ;
      private bool[] BC000E7_n35BR_Encounter_EncID ;
      private short[] BC000E7_A172BR_Encounter_Status ;
      private bool[] BC000E7_n172BR_Encounter_Status ;
      private String[] BC000E7_A183BR_Encounter_CrtUser ;
      private bool[] BC000E7_n183BR_Encounter_CrtUser ;
      private String[] BC000E7_A512BR_Encounter_CrtDisplayName ;
      private bool[] BC000E7_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] BC000E7_A182BR_Encounter_CrtDate ;
      private bool[] BC000E7_n182BR_Encounter_CrtDate ;
      private String[] BC000E7_A470BR_Encounter_Department_Code ;
      private bool[] BC000E7_n470BR_Encounter_Department_Code ;
      private String[] BC000E7_A471BR_Encounter_ENCType_Code ;
      private bool[] BC000E7_n471BR_Encounter_ENCType_Code ;
      private String[] BC000E7_A472BR_Encounter_AdmitSource_Code ;
      private bool[] BC000E7_n472BR_Encounter_AdmitSource_Code ;
      private String[] BC000E7_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] BC000E7_n473BR_Encounter_DischargeStatus_Code ;
      private String[] BC000E7_A84BR_Encounter_Department ;
      private bool[] BC000E7_n84BR_Encounter_Department ;
      private String[] BC000E7_A570BR_Encounter_Departmentadm ;
      private bool[] BC000E7_n570BR_Encounter_Departmentadm ;
      private String[] BC000E7_A571BR_Encounter_Departmentadm_Code ;
      private bool[] BC000E7_n571BR_Encounter_Departmentadm_Code ;
      private String[] BC000E7_A572BR_Encounter_Departmentdisch ;
      private bool[] BC000E7_n572BR_Encounter_Departmentdisch ;
      private String[] BC000E7_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] BC000E7_n573BR_Encounter_Departmentdisch_Code ;
      private String[] BC000E7_A90BR_Encounter_ENCType ;
      private bool[] BC000E7_n90BR_Encounter_ENCType ;
      private DateTime[] BC000E7_A91BR_Encounter_AdmitDate ;
      private bool[] BC000E7_n91BR_Encounter_AdmitDate ;
      private String[] BC000E7_A92BR_Encounter_AdmitSource ;
      private bool[] BC000E7_n92BR_Encounter_AdmitSource ;
      private DateTime[] BC000E7_A93BR_Encounter_DischargeDate ;
      private bool[] BC000E7_n93BR_Encounter_DischargeDate ;
      private String[] BC000E7_A94BR_Encounter_DischargeStatus ;
      private bool[] BC000E7_n94BR_Encounter_DischargeStatus ;
      private String[] BC000E7_A574BR_Encounter_Insurance ;
      private bool[] BC000E7_n574BR_Encounter_Insurance ;
      private String[] BC000E7_A575BR_Encounter_Insurance_Code ;
      private bool[] BC000E7_n575BR_Encounter_Insurance_Code ;
      private String[] BC000E7_A36BR_Information_PatientNo ;
      private bool[] BC000E7_n36BR_Information_PatientNo ;
      private DateTime[] BC000E7_A187BR_Encounter_UpdDate ;
      private bool[] BC000E7_n187BR_Encounter_UpdDate ;
      private String[] BC000E7_A186BR_Encounter_UpdUser ;
      private bool[] BC000E7_n186BR_Encounter_UpdUser ;
      private bool[] BC000E7_A333BR_Encounter_IsDLT ;
      private bool[] BC000E7_n333BR_Encounter_IsDLT ;
      private String[] BC000E7_A184BR_Encounter_SubmitUser ;
      private bool[] BC000E7_n184BR_Encounter_SubmitUser ;
      private String[] BC000E7_A335BR_Encounter_Reason ;
      private bool[] BC000E7_n335BR_Encounter_Reason ;
      private DateTime[] BC000E7_A185BR_Encounter_SubmitDate ;
      private bool[] BC000E7_n185BR_Encounter_SubmitDate ;
      private String[] BC000E7_A188BR_Encounter_RecheckUser ;
      private bool[] BC000E7_n188BR_Encounter_RecheckUser ;
      private String[] BC000E7_A336BR_Encounter_FReason ;
      private bool[] BC000E7_n336BR_Encounter_FReason ;
      private DateTime[] BC000E7_A189BR_Encounter_RecheckDate ;
      private bool[] BC000E7_n189BR_Encounter_RecheckDate ;
      private String[] BC000E7_A190BR_Encounter_Approver ;
      private bool[] BC000E7_n190BR_Encounter_Approver ;
      private DateTime[] BC000E7_A191BR_Encounter_ApproveDate ;
      private bool[] BC000E7_n191BR_Encounter_ApproveDate ;
      private bool[] BC000E7_A192BR_Encounter_IsRandApprove ;
      private bool[] BC000E7_n192BR_Encounter_IsRandApprove ;
      private String[] BC000E7_A203BR_Encounter_IsRandApprover ;
      private bool[] BC000E7_n203BR_Encounter_IsRandApprover ;
      private String[] BC000E7_A204BR_Encounter_IsRandNoApprover ;
      private bool[] BC000E7_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] BC000E7_A205BR_Encounter_IsRandApproveDate ;
      private bool[] BC000E7_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] BC000E7_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E7_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E7_A193BR_Encounter_IsRandRecheck ;
      private bool[] BC000E7_n193BR_Encounter_IsRandRecheck ;
      private String[] BC000E7_A207BR_Encounter_IsRandRecheckr ;
      private bool[] BC000E7_n207BR_Encounter_IsRandRecheckr ;
      private String[] BC000E7_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] BC000E7_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] BC000E7_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] BC000E7_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] BC000E7_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E7_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E7_A202BR_Encounter_IsUpdate ;
      private bool[] BC000E7_n202BR_Encounter_IsUpdate ;
      private short[] BC000E7_A537BR_Encounter_Datasource ;
      private bool[] BC000E7_n537BR_Encounter_Datasource ;
      private String[] BC000E7_A560EncounterIDEncrypt ;
      private bool[] BC000E7_n560EncounterIDEncrypt ;
      private long[] BC000E7_A85BR_Information_ID ;
      private bool[] BC000E7_n85BR_Information_ID ;
      private String[] BC000E7_A360BAS_TenantTenantCode ;
      private bool[] BC000E7_n360BAS_TenantTenantCode ;
      private String[] BC000E4_A36BR_Information_PatientNo ;
      private bool[] BC000E4_n36BR_Information_PatientNo ;
      private long[] BC000E6_A85BR_Information_ID ;
      private bool[] BC000E6_n85BR_Information_ID ;
      private IDataStoreProvider pr_datastore1 ;
      private String[] BC000E5_A360BAS_TenantTenantCode ;
      private bool[] BC000E5_n360BAS_TenantTenantCode ;
      private long[] BC000E8_A19BR_EncounterID ;
      private bool[] BC000E8_n19BR_EncounterID ;
      private long[] BC000E3_A19BR_EncounterID ;
      private bool[] BC000E3_n19BR_EncounterID ;
      private long[] BC000E3_A35BR_Encounter_EncID ;
      private bool[] BC000E3_n35BR_Encounter_EncID ;
      private short[] BC000E3_A172BR_Encounter_Status ;
      private bool[] BC000E3_n172BR_Encounter_Status ;
      private String[] BC000E3_A183BR_Encounter_CrtUser ;
      private bool[] BC000E3_n183BR_Encounter_CrtUser ;
      private String[] BC000E3_A512BR_Encounter_CrtDisplayName ;
      private bool[] BC000E3_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] BC000E3_A182BR_Encounter_CrtDate ;
      private bool[] BC000E3_n182BR_Encounter_CrtDate ;
      private String[] BC000E3_A470BR_Encounter_Department_Code ;
      private bool[] BC000E3_n470BR_Encounter_Department_Code ;
      private String[] BC000E3_A471BR_Encounter_ENCType_Code ;
      private bool[] BC000E3_n471BR_Encounter_ENCType_Code ;
      private String[] BC000E3_A472BR_Encounter_AdmitSource_Code ;
      private bool[] BC000E3_n472BR_Encounter_AdmitSource_Code ;
      private String[] BC000E3_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] BC000E3_n473BR_Encounter_DischargeStatus_Code ;
      private String[] BC000E3_A84BR_Encounter_Department ;
      private bool[] BC000E3_n84BR_Encounter_Department ;
      private String[] BC000E3_A570BR_Encounter_Departmentadm ;
      private bool[] BC000E3_n570BR_Encounter_Departmentadm ;
      private String[] BC000E3_A571BR_Encounter_Departmentadm_Code ;
      private bool[] BC000E3_n571BR_Encounter_Departmentadm_Code ;
      private String[] BC000E3_A572BR_Encounter_Departmentdisch ;
      private bool[] BC000E3_n572BR_Encounter_Departmentdisch ;
      private String[] BC000E3_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] BC000E3_n573BR_Encounter_Departmentdisch_Code ;
      private String[] BC000E3_A90BR_Encounter_ENCType ;
      private bool[] BC000E3_n90BR_Encounter_ENCType ;
      private DateTime[] BC000E3_A91BR_Encounter_AdmitDate ;
      private bool[] BC000E3_n91BR_Encounter_AdmitDate ;
      private String[] BC000E3_A92BR_Encounter_AdmitSource ;
      private bool[] BC000E3_n92BR_Encounter_AdmitSource ;
      private DateTime[] BC000E3_A93BR_Encounter_DischargeDate ;
      private bool[] BC000E3_n93BR_Encounter_DischargeDate ;
      private String[] BC000E3_A94BR_Encounter_DischargeStatus ;
      private bool[] BC000E3_n94BR_Encounter_DischargeStatus ;
      private String[] BC000E3_A574BR_Encounter_Insurance ;
      private bool[] BC000E3_n574BR_Encounter_Insurance ;
      private String[] BC000E3_A575BR_Encounter_Insurance_Code ;
      private bool[] BC000E3_n575BR_Encounter_Insurance_Code ;
      private DateTime[] BC000E3_A187BR_Encounter_UpdDate ;
      private bool[] BC000E3_n187BR_Encounter_UpdDate ;
      private String[] BC000E3_A186BR_Encounter_UpdUser ;
      private bool[] BC000E3_n186BR_Encounter_UpdUser ;
      private bool[] BC000E3_A333BR_Encounter_IsDLT ;
      private bool[] BC000E3_n333BR_Encounter_IsDLT ;
      private String[] BC000E3_A184BR_Encounter_SubmitUser ;
      private bool[] BC000E3_n184BR_Encounter_SubmitUser ;
      private String[] BC000E3_A335BR_Encounter_Reason ;
      private bool[] BC000E3_n335BR_Encounter_Reason ;
      private DateTime[] BC000E3_A185BR_Encounter_SubmitDate ;
      private bool[] BC000E3_n185BR_Encounter_SubmitDate ;
      private String[] BC000E3_A188BR_Encounter_RecheckUser ;
      private bool[] BC000E3_n188BR_Encounter_RecheckUser ;
      private String[] BC000E3_A336BR_Encounter_FReason ;
      private bool[] BC000E3_n336BR_Encounter_FReason ;
      private DateTime[] BC000E3_A189BR_Encounter_RecheckDate ;
      private bool[] BC000E3_n189BR_Encounter_RecheckDate ;
      private String[] BC000E3_A190BR_Encounter_Approver ;
      private bool[] BC000E3_n190BR_Encounter_Approver ;
      private DateTime[] BC000E3_A191BR_Encounter_ApproveDate ;
      private bool[] BC000E3_n191BR_Encounter_ApproveDate ;
      private bool[] BC000E3_A192BR_Encounter_IsRandApprove ;
      private bool[] BC000E3_n192BR_Encounter_IsRandApprove ;
      private String[] BC000E3_A203BR_Encounter_IsRandApprover ;
      private bool[] BC000E3_n203BR_Encounter_IsRandApprover ;
      private String[] BC000E3_A204BR_Encounter_IsRandNoApprover ;
      private bool[] BC000E3_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] BC000E3_A205BR_Encounter_IsRandApproveDate ;
      private bool[] BC000E3_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] BC000E3_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E3_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E3_A193BR_Encounter_IsRandRecheck ;
      private bool[] BC000E3_n193BR_Encounter_IsRandRecheck ;
      private String[] BC000E3_A207BR_Encounter_IsRandRecheckr ;
      private bool[] BC000E3_n207BR_Encounter_IsRandRecheckr ;
      private String[] BC000E3_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] BC000E3_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] BC000E3_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] BC000E3_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] BC000E3_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E3_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E3_A202BR_Encounter_IsUpdate ;
      private bool[] BC000E3_n202BR_Encounter_IsUpdate ;
      private short[] BC000E3_A537BR_Encounter_Datasource ;
      private bool[] BC000E3_n537BR_Encounter_Datasource ;
      private String[] BC000E3_A560EncounterIDEncrypt ;
      private bool[] BC000E3_n560EncounterIDEncrypt ;
      private long[] BC000E3_A85BR_Information_ID ;
      private bool[] BC000E3_n85BR_Information_ID ;
      private String[] BC000E3_A360BAS_TenantTenantCode ;
      private bool[] BC000E3_n360BAS_TenantTenantCode ;
      private long[] BC000E2_A19BR_EncounterID ;
      private bool[] BC000E2_n19BR_EncounterID ;
      private long[] BC000E2_A35BR_Encounter_EncID ;
      private bool[] BC000E2_n35BR_Encounter_EncID ;
      private short[] BC000E2_A172BR_Encounter_Status ;
      private bool[] BC000E2_n172BR_Encounter_Status ;
      private String[] BC000E2_A183BR_Encounter_CrtUser ;
      private bool[] BC000E2_n183BR_Encounter_CrtUser ;
      private String[] BC000E2_A512BR_Encounter_CrtDisplayName ;
      private bool[] BC000E2_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] BC000E2_A182BR_Encounter_CrtDate ;
      private bool[] BC000E2_n182BR_Encounter_CrtDate ;
      private String[] BC000E2_A470BR_Encounter_Department_Code ;
      private bool[] BC000E2_n470BR_Encounter_Department_Code ;
      private String[] BC000E2_A471BR_Encounter_ENCType_Code ;
      private bool[] BC000E2_n471BR_Encounter_ENCType_Code ;
      private String[] BC000E2_A472BR_Encounter_AdmitSource_Code ;
      private bool[] BC000E2_n472BR_Encounter_AdmitSource_Code ;
      private String[] BC000E2_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] BC000E2_n473BR_Encounter_DischargeStatus_Code ;
      private String[] BC000E2_A84BR_Encounter_Department ;
      private bool[] BC000E2_n84BR_Encounter_Department ;
      private String[] BC000E2_A570BR_Encounter_Departmentadm ;
      private bool[] BC000E2_n570BR_Encounter_Departmentadm ;
      private String[] BC000E2_A571BR_Encounter_Departmentadm_Code ;
      private bool[] BC000E2_n571BR_Encounter_Departmentadm_Code ;
      private String[] BC000E2_A572BR_Encounter_Departmentdisch ;
      private bool[] BC000E2_n572BR_Encounter_Departmentdisch ;
      private String[] BC000E2_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] BC000E2_n573BR_Encounter_Departmentdisch_Code ;
      private String[] BC000E2_A90BR_Encounter_ENCType ;
      private bool[] BC000E2_n90BR_Encounter_ENCType ;
      private DateTime[] BC000E2_A91BR_Encounter_AdmitDate ;
      private bool[] BC000E2_n91BR_Encounter_AdmitDate ;
      private String[] BC000E2_A92BR_Encounter_AdmitSource ;
      private bool[] BC000E2_n92BR_Encounter_AdmitSource ;
      private DateTime[] BC000E2_A93BR_Encounter_DischargeDate ;
      private bool[] BC000E2_n93BR_Encounter_DischargeDate ;
      private String[] BC000E2_A94BR_Encounter_DischargeStatus ;
      private bool[] BC000E2_n94BR_Encounter_DischargeStatus ;
      private String[] BC000E2_A574BR_Encounter_Insurance ;
      private bool[] BC000E2_n574BR_Encounter_Insurance ;
      private String[] BC000E2_A575BR_Encounter_Insurance_Code ;
      private bool[] BC000E2_n575BR_Encounter_Insurance_Code ;
      private DateTime[] BC000E2_A187BR_Encounter_UpdDate ;
      private bool[] BC000E2_n187BR_Encounter_UpdDate ;
      private String[] BC000E2_A186BR_Encounter_UpdUser ;
      private bool[] BC000E2_n186BR_Encounter_UpdUser ;
      private bool[] BC000E2_A333BR_Encounter_IsDLT ;
      private bool[] BC000E2_n333BR_Encounter_IsDLT ;
      private String[] BC000E2_A184BR_Encounter_SubmitUser ;
      private bool[] BC000E2_n184BR_Encounter_SubmitUser ;
      private String[] BC000E2_A335BR_Encounter_Reason ;
      private bool[] BC000E2_n335BR_Encounter_Reason ;
      private DateTime[] BC000E2_A185BR_Encounter_SubmitDate ;
      private bool[] BC000E2_n185BR_Encounter_SubmitDate ;
      private String[] BC000E2_A188BR_Encounter_RecheckUser ;
      private bool[] BC000E2_n188BR_Encounter_RecheckUser ;
      private String[] BC000E2_A336BR_Encounter_FReason ;
      private bool[] BC000E2_n336BR_Encounter_FReason ;
      private DateTime[] BC000E2_A189BR_Encounter_RecheckDate ;
      private bool[] BC000E2_n189BR_Encounter_RecheckDate ;
      private String[] BC000E2_A190BR_Encounter_Approver ;
      private bool[] BC000E2_n190BR_Encounter_Approver ;
      private DateTime[] BC000E2_A191BR_Encounter_ApproveDate ;
      private bool[] BC000E2_n191BR_Encounter_ApproveDate ;
      private bool[] BC000E2_A192BR_Encounter_IsRandApprove ;
      private bool[] BC000E2_n192BR_Encounter_IsRandApprove ;
      private String[] BC000E2_A203BR_Encounter_IsRandApprover ;
      private bool[] BC000E2_n203BR_Encounter_IsRandApprover ;
      private String[] BC000E2_A204BR_Encounter_IsRandNoApprover ;
      private bool[] BC000E2_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] BC000E2_A205BR_Encounter_IsRandApproveDate ;
      private bool[] BC000E2_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] BC000E2_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E2_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E2_A193BR_Encounter_IsRandRecheck ;
      private bool[] BC000E2_n193BR_Encounter_IsRandRecheck ;
      private String[] BC000E2_A207BR_Encounter_IsRandRecheckr ;
      private bool[] BC000E2_n207BR_Encounter_IsRandRecheckr ;
      private String[] BC000E2_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] BC000E2_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] BC000E2_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] BC000E2_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] BC000E2_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E2_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E2_A202BR_Encounter_IsUpdate ;
      private bool[] BC000E2_n202BR_Encounter_IsUpdate ;
      private short[] BC000E2_A537BR_Encounter_Datasource ;
      private bool[] BC000E2_n537BR_Encounter_Datasource ;
      private String[] BC000E2_A560EncounterIDEncrypt ;
      private bool[] BC000E2_n560EncounterIDEncrypt ;
      private long[] BC000E2_A85BR_Information_ID ;
      private bool[] BC000E2_n85BR_Information_ID ;
      private String[] BC000E2_A360BAS_TenantTenantCode ;
      private bool[] BC000E2_n360BAS_TenantTenantCode ;
      private long[] BC000E9_A19BR_EncounterID ;
      private bool[] BC000E9_n19BR_EncounterID ;
      private String[] BC000E12_A36BR_Information_PatientNo ;
      private bool[] BC000E12_n36BR_Information_PatientNo ;
      private long[] BC000E13_A348BR_Encounter_RefuseReasonID ;
      private long[] BC000E14_A347BR_Encounter_ID ;
      private long[] BC000E15_A327BR_SchemeID ;
      private long[] BC000E16_A226BR_PathologyID ;
      private long[] BC000E17_A225BR_MedicalImagingID ;
      private long[] BC000E18_A150BR_VitalID ;
      private long[] BC000E19_A139BR_ProcedureID ;
      private long[] BC000E20_A119BR_MedicationID ;
      private long[] BC000E21_A101BR_LabID ;
      private long[] BC000E22_A64BR_DiagnosisID ;
      private long[] BC000E23_A61BR_Demographics_ID ;
      private long[] BC000E24_A48BR_DeathID ;
      private long[] BC000E25_A37BR_ComorbidityID ;
      private long[] BC000E26_A20BR_BehaviorID ;
      private long[] BC000E27_A19BR_EncounterID ;
      private bool[] BC000E27_n19BR_EncounterID ;
      private long[] BC000E27_A35BR_Encounter_EncID ;
      private bool[] BC000E27_n35BR_Encounter_EncID ;
      private short[] BC000E27_A172BR_Encounter_Status ;
      private bool[] BC000E27_n172BR_Encounter_Status ;
      private String[] BC000E27_A183BR_Encounter_CrtUser ;
      private bool[] BC000E27_n183BR_Encounter_CrtUser ;
      private String[] BC000E27_A512BR_Encounter_CrtDisplayName ;
      private bool[] BC000E27_n512BR_Encounter_CrtDisplayName ;
      private DateTime[] BC000E27_A182BR_Encounter_CrtDate ;
      private bool[] BC000E27_n182BR_Encounter_CrtDate ;
      private String[] BC000E27_A470BR_Encounter_Department_Code ;
      private bool[] BC000E27_n470BR_Encounter_Department_Code ;
      private String[] BC000E27_A471BR_Encounter_ENCType_Code ;
      private bool[] BC000E27_n471BR_Encounter_ENCType_Code ;
      private String[] BC000E27_A472BR_Encounter_AdmitSource_Code ;
      private bool[] BC000E27_n472BR_Encounter_AdmitSource_Code ;
      private String[] BC000E27_A473BR_Encounter_DischargeStatus_Code ;
      private bool[] BC000E27_n473BR_Encounter_DischargeStatus_Code ;
      private String[] BC000E27_A84BR_Encounter_Department ;
      private bool[] BC000E27_n84BR_Encounter_Department ;
      private String[] BC000E27_A570BR_Encounter_Departmentadm ;
      private bool[] BC000E27_n570BR_Encounter_Departmentadm ;
      private String[] BC000E27_A571BR_Encounter_Departmentadm_Code ;
      private bool[] BC000E27_n571BR_Encounter_Departmentadm_Code ;
      private String[] BC000E27_A572BR_Encounter_Departmentdisch ;
      private bool[] BC000E27_n572BR_Encounter_Departmentdisch ;
      private String[] BC000E27_A573BR_Encounter_Departmentdisch_Code ;
      private bool[] BC000E27_n573BR_Encounter_Departmentdisch_Code ;
      private String[] BC000E27_A90BR_Encounter_ENCType ;
      private bool[] BC000E27_n90BR_Encounter_ENCType ;
      private DateTime[] BC000E27_A91BR_Encounter_AdmitDate ;
      private bool[] BC000E27_n91BR_Encounter_AdmitDate ;
      private String[] BC000E27_A92BR_Encounter_AdmitSource ;
      private bool[] BC000E27_n92BR_Encounter_AdmitSource ;
      private DateTime[] BC000E27_A93BR_Encounter_DischargeDate ;
      private bool[] BC000E27_n93BR_Encounter_DischargeDate ;
      private String[] BC000E27_A94BR_Encounter_DischargeStatus ;
      private bool[] BC000E27_n94BR_Encounter_DischargeStatus ;
      private String[] BC000E27_A574BR_Encounter_Insurance ;
      private bool[] BC000E27_n574BR_Encounter_Insurance ;
      private String[] BC000E27_A575BR_Encounter_Insurance_Code ;
      private bool[] BC000E27_n575BR_Encounter_Insurance_Code ;
      private String[] BC000E27_A36BR_Information_PatientNo ;
      private bool[] BC000E27_n36BR_Information_PatientNo ;
      private DateTime[] BC000E27_A187BR_Encounter_UpdDate ;
      private bool[] BC000E27_n187BR_Encounter_UpdDate ;
      private String[] BC000E27_A186BR_Encounter_UpdUser ;
      private bool[] BC000E27_n186BR_Encounter_UpdUser ;
      private bool[] BC000E27_A333BR_Encounter_IsDLT ;
      private bool[] BC000E27_n333BR_Encounter_IsDLT ;
      private String[] BC000E27_A184BR_Encounter_SubmitUser ;
      private bool[] BC000E27_n184BR_Encounter_SubmitUser ;
      private String[] BC000E27_A335BR_Encounter_Reason ;
      private bool[] BC000E27_n335BR_Encounter_Reason ;
      private DateTime[] BC000E27_A185BR_Encounter_SubmitDate ;
      private bool[] BC000E27_n185BR_Encounter_SubmitDate ;
      private String[] BC000E27_A188BR_Encounter_RecheckUser ;
      private bool[] BC000E27_n188BR_Encounter_RecheckUser ;
      private String[] BC000E27_A336BR_Encounter_FReason ;
      private bool[] BC000E27_n336BR_Encounter_FReason ;
      private DateTime[] BC000E27_A189BR_Encounter_RecheckDate ;
      private bool[] BC000E27_n189BR_Encounter_RecheckDate ;
      private String[] BC000E27_A190BR_Encounter_Approver ;
      private bool[] BC000E27_n190BR_Encounter_Approver ;
      private DateTime[] BC000E27_A191BR_Encounter_ApproveDate ;
      private bool[] BC000E27_n191BR_Encounter_ApproveDate ;
      private bool[] BC000E27_A192BR_Encounter_IsRandApprove ;
      private bool[] BC000E27_n192BR_Encounter_IsRandApprove ;
      private String[] BC000E27_A203BR_Encounter_IsRandApprover ;
      private bool[] BC000E27_n203BR_Encounter_IsRandApprover ;
      private String[] BC000E27_A204BR_Encounter_IsRandNoApprover ;
      private bool[] BC000E27_n204BR_Encounter_IsRandNoApprover ;
      private DateTime[] BC000E27_A205BR_Encounter_IsRandApproveDate ;
      private bool[] BC000E27_n205BR_Encounter_IsRandApproveDate ;
      private DateTime[] BC000E27_A206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E27_n206BR_Encounter_IsRandNoApproveDate ;
      private bool[] BC000E27_A193BR_Encounter_IsRandRecheck ;
      private bool[] BC000E27_n193BR_Encounter_IsRandRecheck ;
      private String[] BC000E27_A207BR_Encounter_IsRandRecheckr ;
      private bool[] BC000E27_n207BR_Encounter_IsRandRecheckr ;
      private String[] BC000E27_A208BR_Encounter_IsRandNoRecheckr ;
      private bool[] BC000E27_n208BR_Encounter_IsRandNoRecheckr ;
      private DateTime[] BC000E27_A209BR_Encounter_IsRandRecheckDate ;
      private bool[] BC000E27_n209BR_Encounter_IsRandRecheckDate ;
      private DateTime[] BC000E27_A210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E27_n210BR_Encounter_IsRandNoRecheckDate ;
      private bool[] BC000E27_A202BR_Encounter_IsUpdate ;
      private bool[] BC000E27_n202BR_Encounter_IsUpdate ;
      private short[] BC000E27_A537BR_Encounter_Datasource ;
      private bool[] BC000E27_n537BR_Encounter_Datasource ;
      private String[] BC000E27_A560EncounterIDEncrypt ;
      private bool[] BC000E27_n560EncounterIDEncrypt ;
      private long[] BC000E27_A85BR_Information_ID ;
      private bool[] BC000E27_n85BR_Information_ID ;
      private String[] BC000E27_A360BAS_TenantTenantCode ;
      private bool[] BC000E27_n360BAS_TenantTenantCode ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV12TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV14WWPContext ;
   }

   public class br_encounter_bc__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC000E5 ;
          prmBC000E5 = new Object[] {
          new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC000E5", "SELECT [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK) WHERE [TenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E5,1,0,true,false )
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
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.NVarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_encounter_bc__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new UpdateCursor(def[7])
       ,new UpdateCursor(def[8])
       ,new ForEachCursor(def[9])
       ,new ForEachCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
       ,new ForEachCursor(def[20])
       ,new ForEachCursor(def[21])
       ,new ForEachCursor(def[22])
       ,new ForEachCursor(def[23])
       ,new ForEachCursor(def[24])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmBC000E7 ;
        prmBC000E7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferBC000E7 ;
        cmdBufferBC000E7=" SELECT TM1.[BR_EncounterID], TM1.[BR_Encounter_EncID], TM1.[BR_Encounter_Status], TM1.[BR_Encounter_CrtUser], TM1.[BR_Encounter_CrtDisplayName], TM1.[BR_Encounter_CrtDate], TM1.[BR_Encounter_Department_Code], TM1.[BR_Encounter_ENCType_Code], TM1.[BR_Encounter_AdmitSource_Code], TM1.[BR_Encounter_DischargeStatus_Code], TM1.[BR_Encounter_Department], TM1.[BR_Encounter_Departmentadm], TM1.[BR_Encounter_Departmentadm_Code], TM1.[BR_Encounter_Departmentdisch], TM1.[BR_Encounter_Departmentdisch_Code], TM1.[BR_Encounter_ENCType], TM1.[BR_Encounter_AdmitDate], TM1.[BR_Encounter_AdmitSource], TM1.[BR_Encounter_DischargeDate], TM1.[BR_Encounter_DischargeStatus], TM1.[BR_Encounter_Insurance], TM1.[BR_Encounter_Insurance_Code], T2.[BR_Information_PatientNo], TM1.[BR_Encounter_UpdDate], TM1.[BR_Encounter_UpdUser], TM1.[BR_Encounter_IsDLT], TM1.[BR_Encounter_SubmitUser], TM1.[BR_Encounter_Reason], TM1.[BR_Encounter_SubmitDate], TM1.[BR_Encounter_RecheckUser], TM1.[BR_Encounter_FReason], TM1.[BR_Encounter_RecheckDate], TM1.[BR_Encounter_Approver], TM1.[BR_Encounter_ApproveDate], TM1.[BR_Encounter_IsRandApprove], TM1.[BR_Encounter_IsRandApprover], TM1.[BR_Encounter_IsRandNoApprover], TM1.[BR_Encounter_IsRandApproveDate], TM1.[BR_Encounter_IsRandNoApproveDate], TM1.[BR_Encounter_IsRandRecheck], TM1.[BR_Encounter_IsRandRecheckr], TM1.[BR_Encounter_IsRandNoRecheckr], TM1.[BR_Encounter_IsRandRecheckDate], TM1.[BR_Encounter_IsRandNoRecheckDate], TM1.[BR_Encounter_IsUpdate], TM1.[BR_Encounter_Datasource], TM1.[EncounterIDEncrypt], TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode] FROM ([BR_Encounter] TM1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = TM1.[BR_Information_ID]) WHERE TM1.[BR_EncounterID] = @BR_EncounterID ORDER BY TM1.[BR_EncounterID]  OPTION "
        + " (FAST 100)" ;
        Object[] prmBC000E4 ;
        prmBC000E4 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E6 ;
        prmBC000E6 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        Object[] prmBC000E8 ;
        prmBC000E8 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E3 ;
        prmBC000E3 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E2 ;
        prmBC000E2 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E9 ;
        prmBC000E9 = new Object[] {
        new Object[] {"@BR_Encounter_EncID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Encounter_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDisplayName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Department_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_AdmitSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Department",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_AdmitSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_DischargeDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_UpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_UpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsDLT",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_SubmitUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_SubmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RecheckUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandRecheck",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsUpdate",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_Datasource",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EncounterIDEncrypt",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0}
        } ;
        String cmdBufferBC000E9 ;
        cmdBufferBC000E9=" INSERT INTO [BR_Encounter]([BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode]) VALUES(@BR_Encounter_EncID, @BR_Encounter_Status, @BR_Encounter_CrtUser, @BR_Encounter_CrtDisplayName, @BR_Encounter_CrtDate, @BR_Encounter_Department_Code, @BR_Encounter_ENCType_Code, @BR_Encounter_AdmitSource_Code, @BR_Encounter_DischargeStatus_Code, @BR_Encounter_Department, @BR_Encounter_Departmentadm, @BR_Encounter_Departmentadm_Code, @BR_Encounter_Departmentdisch, @BR_Encounter_Departmentdisch_Code, @BR_Encounter_ENCType, @BR_Encounter_AdmitDate, "
        + " @BR_Encounter_AdmitSource, @BR_Encounter_DischargeDate, @BR_Encounter_DischargeStatus, @BR_Encounter_Insurance, @BR_Encounter_Insurance_Code, @BR_Encounter_UpdDate, @BR_Encounter_UpdUser, @BR_Encounter_IsDLT, @BR_Encounter_SubmitUser, @BR_Encounter_Reason, @BR_Encounter_SubmitDate, @BR_Encounter_RecheckUser, @BR_Encounter_FReason, @BR_Encounter_RecheckDate, @BR_Encounter_Approver, @BR_Encounter_ApproveDate, @BR_Encounter_IsRandApprove, @BR_Encounter_IsRandApprover, @BR_Encounter_IsRandNoApprover, @BR_Encounter_IsRandApproveDate, @BR_Encounter_IsRandNoApproveDate, @BR_Encounter_IsRandRecheck, @BR_Encounter_IsRandRecheckr, @BR_Encounter_IsRandNoRecheckr, @BR_Encounter_IsRandRecheckDate, @BR_Encounter_IsRandNoRecheckDate, @BR_Encounter_IsUpdate, @BR_Encounter_Datasource, @EncounterIDEncrypt, @BR_Information_ID, @BAS_TenantTenantCode); SELECT SCOPE_IDENTITY()" ;
        Object[] prmBC000E10 ;
        prmBC000E10 = new Object[] {
        new Object[] {"@BR_Encounter_EncID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Encounter_Status",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Encounter_CrtUser",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDisplayName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_CrtDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Department_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_AdmitSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Department",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentadm_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Departmentdisch_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ENCType",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_AdmitDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_AdmitSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_DischargeDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Encounter_DischargeStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Encounter_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_UpdDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_UpdUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsDLT",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_SubmitUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_Reason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_SubmitDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_RecheckUser",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_FReason",SqlDbType.NVarChar,300,0} ,
        new Object[] {"@BR_Encounter_RecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_Approver",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_ApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandApprove",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoApprover",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoApproveDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandRecheck",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckr",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Encounter_IsRandRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsRandNoRecheckDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Encounter_IsUpdate",SqlDbType.Bit,4,0} ,
        new Object[] {"@BR_Encounter_Datasource",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@EncounterIDEncrypt",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferBC000E10 ;
        cmdBufferBC000E10=" UPDATE [BR_Encounter] SET [BR_Encounter_EncID]=@BR_Encounter_EncID, [BR_Encounter_Status]=@BR_Encounter_Status, [BR_Encounter_CrtUser]=@BR_Encounter_CrtUser, [BR_Encounter_CrtDisplayName]=@BR_Encounter_CrtDisplayName, [BR_Encounter_CrtDate]=@BR_Encounter_CrtDate, [BR_Encounter_Department_Code]=@BR_Encounter_Department_Code, [BR_Encounter_ENCType_Code]=@BR_Encounter_ENCType_Code, [BR_Encounter_AdmitSource_Code]=@BR_Encounter_AdmitSource_Code, [BR_Encounter_DischargeStatus_Code]=@BR_Encounter_DischargeStatus_Code, [BR_Encounter_Department]=@BR_Encounter_Department, [BR_Encounter_Departmentadm]=@BR_Encounter_Departmentadm, [BR_Encounter_Departmentadm_Code]=@BR_Encounter_Departmentadm_Code, [BR_Encounter_Departmentdisch]=@BR_Encounter_Departmentdisch, [BR_Encounter_Departmentdisch_Code]=@BR_Encounter_Departmentdisch_Code, [BR_Encounter_ENCType]=@BR_Encounter_ENCType, [BR_Encounter_AdmitDate]=@BR_Encounter_AdmitDate, [BR_Encounter_AdmitSource]=@BR_Encounter_AdmitSource, [BR_Encounter_DischargeDate]=@BR_Encounter_DischargeDate, [BR_Encounter_DischargeStatus]=@BR_Encounter_DischargeStatus, [BR_Encounter_Insurance]=@BR_Encounter_Insurance, [BR_Encounter_Insurance_Code]=@BR_Encounter_Insurance_Code, [BR_Encounter_UpdDate]=@BR_Encounter_UpdDate, [BR_Encounter_UpdUser]=@BR_Encounter_UpdUser, [BR_Encounter_IsDLT]=@BR_Encounter_IsDLT, [BR_Encounter_SubmitUser]=@BR_Encounter_SubmitUser, [BR_Encounter_Reason]=@BR_Encounter_Reason, [BR_Encounter_SubmitDate]=@BR_Encounter_SubmitDate, [BR_Encounter_RecheckUser]=@BR_Encounter_RecheckUser, [BR_Encounter_FReason]=@BR_Encounter_FReason, [BR_Encounter_RecheckDate]=@BR_Encounter_RecheckDate, [BR_Encounter_Approver]=@BR_Encounter_Approver, [BR_Encounter_ApproveDate]=@BR_Encounter_ApproveDate, [BR_Encounter_IsRandApprove]=@BR_Encounter_IsRandApprove, "
        + " [BR_Encounter_IsRandApprover]=@BR_Encounter_IsRandApprover, [BR_Encounter_IsRandNoApprover]=@BR_Encounter_IsRandNoApprover, [BR_Encounter_IsRandApproveDate]=@BR_Encounter_IsRandApproveDate, [BR_Encounter_IsRandNoApproveDate]=@BR_Encounter_IsRandNoApproveDate, [BR_Encounter_IsRandRecheck]=@BR_Encounter_IsRandRecheck, [BR_Encounter_IsRandRecheckr]=@BR_Encounter_IsRandRecheckr, [BR_Encounter_IsRandNoRecheckr]=@BR_Encounter_IsRandNoRecheckr, [BR_Encounter_IsRandRecheckDate]=@BR_Encounter_IsRandRecheckDate, [BR_Encounter_IsRandNoRecheckDate]=@BR_Encounter_IsRandNoRecheckDate, [BR_Encounter_IsUpdate]=@BR_Encounter_IsUpdate, [BR_Encounter_Datasource]=@BR_Encounter_Datasource, [EncounterIDEncrypt]=@EncounterIDEncrypt, [BR_Information_ID]=@BR_Information_ID, [BAS_TenantTenantCode]=@BAS_TenantTenantCode  WHERE [BR_EncounterID] = @BR_EncounterID" ;
        Object[] prmBC000E11 ;
        prmBC000E11 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E12 ;
        prmBC000E12 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E13 ;
        prmBC000E13 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E14 ;
        prmBC000E14 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E15 ;
        prmBC000E15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E16 ;
        prmBC000E16 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E17 ;
        prmBC000E17 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E18 ;
        prmBC000E18 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E19 ;
        prmBC000E19 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E20 ;
        prmBC000E20 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E21 ;
        prmBC000E21 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E22 ;
        prmBC000E22 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E23 ;
        prmBC000E23 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E24 ;
        prmBC000E24 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E25 ;
        prmBC000E25 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E26 ;
        prmBC000E26 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmBC000E27 ;
        prmBC000E27 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        String cmdBufferBC000E27 ;
        cmdBufferBC000E27=" SELECT TM1.[BR_EncounterID], TM1.[BR_Encounter_EncID], TM1.[BR_Encounter_Status], TM1.[BR_Encounter_CrtUser], TM1.[BR_Encounter_CrtDisplayName], TM1.[BR_Encounter_CrtDate], TM1.[BR_Encounter_Department_Code], TM1.[BR_Encounter_ENCType_Code], TM1.[BR_Encounter_AdmitSource_Code], TM1.[BR_Encounter_DischargeStatus_Code], TM1.[BR_Encounter_Department], TM1.[BR_Encounter_Departmentadm], TM1.[BR_Encounter_Departmentadm_Code], TM1.[BR_Encounter_Departmentdisch], TM1.[BR_Encounter_Departmentdisch_Code], TM1.[BR_Encounter_ENCType], TM1.[BR_Encounter_AdmitDate], TM1.[BR_Encounter_AdmitSource], TM1.[BR_Encounter_DischargeDate], TM1.[BR_Encounter_DischargeStatus], TM1.[BR_Encounter_Insurance], TM1.[BR_Encounter_Insurance_Code], T2.[BR_Information_PatientNo], TM1.[BR_Encounter_UpdDate], TM1.[BR_Encounter_UpdUser], TM1.[BR_Encounter_IsDLT], TM1.[BR_Encounter_SubmitUser], TM1.[BR_Encounter_Reason], TM1.[BR_Encounter_SubmitDate], TM1.[BR_Encounter_RecheckUser], TM1.[BR_Encounter_FReason], TM1.[BR_Encounter_RecheckDate], TM1.[BR_Encounter_Approver], TM1.[BR_Encounter_ApproveDate], TM1.[BR_Encounter_IsRandApprove], TM1.[BR_Encounter_IsRandApprover], TM1.[BR_Encounter_IsRandNoApprover], TM1.[BR_Encounter_IsRandApproveDate], TM1.[BR_Encounter_IsRandNoApproveDate], TM1.[BR_Encounter_IsRandRecheck], TM1.[BR_Encounter_IsRandRecheckr], TM1.[BR_Encounter_IsRandNoRecheckr], TM1.[BR_Encounter_IsRandRecheckDate], TM1.[BR_Encounter_IsRandNoRecheckDate], TM1.[BR_Encounter_IsUpdate], TM1.[BR_Encounter_Datasource], TM1.[EncounterIDEncrypt], TM1.[BR_Information_ID], TM1.[BAS_TenantTenantCode] FROM ([BR_Encounter] TM1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = TM1.[BR_Information_ID]) WHERE TM1.[BR_EncounterID] = @BR_EncounterID ORDER BY TM1.[BR_EncounterID]  OPTION "
        + " (FAST 100)" ;
        def= new CursorDef[] {
            new CursorDef("BC000E2", "SELECT [BR_EncounterID], [BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_Encounter] WITH (UPDLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E2,1,0,true,false )
           ,new CursorDef("BC000E3", "SELECT [BR_EncounterID], [BR_Encounter_EncID], [BR_Encounter_Status], [BR_Encounter_CrtUser], [BR_Encounter_CrtDisplayName], [BR_Encounter_CrtDate], [BR_Encounter_Department_Code], [BR_Encounter_ENCType_Code], [BR_Encounter_AdmitSource_Code], [BR_Encounter_DischargeStatus_Code], [BR_Encounter_Department], [BR_Encounter_Departmentadm], [BR_Encounter_Departmentadm_Code], [BR_Encounter_Departmentdisch], [BR_Encounter_Departmentdisch_Code], [BR_Encounter_ENCType], [BR_Encounter_AdmitDate], [BR_Encounter_AdmitSource], [BR_Encounter_DischargeDate], [BR_Encounter_DischargeStatus], [BR_Encounter_Insurance], [BR_Encounter_Insurance_Code], [BR_Encounter_UpdDate], [BR_Encounter_UpdUser], [BR_Encounter_IsDLT], [BR_Encounter_SubmitUser], [BR_Encounter_Reason], [BR_Encounter_SubmitDate], [BR_Encounter_RecheckUser], [BR_Encounter_FReason], [BR_Encounter_RecheckDate], [BR_Encounter_Approver], [BR_Encounter_ApproveDate], [BR_Encounter_IsRandApprove], [BR_Encounter_IsRandApprover], [BR_Encounter_IsRandNoApprover], [BR_Encounter_IsRandApproveDate], [BR_Encounter_IsRandNoApproveDate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandRecheckr], [BR_Encounter_IsRandNoRecheckr], [BR_Encounter_IsRandRecheckDate], [BR_Encounter_IsRandNoRecheckDate], [BR_Encounter_IsUpdate], [BR_Encounter_Datasource], [EncounterIDEncrypt], [BR_Information_ID], [BAS_TenantTenantCode] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E3,1,0,true,false )
           ,new CursorDef("BC000E4", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E4,1,0,true,false )
           ,new CursorDef("BC000E6", "SELECT [BR_Information_ID] FROM [BR_PatientReTenant] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID AND [BAS_TenantTenantCode] = @BAS_TenantTenantCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E6,1,0,true,false )
           ,new CursorDef("BC000E7", cmdBufferBC000E7,true, GxErrorMask.GX_NOMASK, false, this,prmBC000E7,100,0,true,false )
           ,new CursorDef("BC000E8", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E8,1,0,true,false )
           ,new CursorDef("BC000E9", cmdBufferBC000E9, GxErrorMask.GX_NOMASK,prmBC000E9)
           ,new CursorDef("BC000E10", cmdBufferBC000E10, GxErrorMask.GX_NOMASK,prmBC000E10)
           ,new CursorDef("BC000E11", "DELETE FROM [BR_Encounter]  WHERE [BR_EncounterID] = @BR_EncounterID", GxErrorMask.GX_NOMASK,prmBC000E11)
           ,new CursorDef("BC000E12", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E12,1,0,true,false )
           ,new CursorDef("BC000E13", "SELECT TOP 1 [BR_Encounter_RefuseReasonID] FROM [BR_Encounter_RefuseReason] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E13,1,0,true,true )
           ,new CursorDef("BC000E14", "SELECT TOP 1 [BR_Encounter_ID] FROM [BR_EncounterReason] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E14,1,0,true,true )
           ,new CursorDef("BC000E15", "SELECT TOP 1 [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E15,1,0,true,true )
           ,new CursorDef("BC000E16", "SELECT TOP 1 [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E16,1,0,true,true )
           ,new CursorDef("BC000E17", "SELECT TOP 1 [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E17,1,0,true,true )
           ,new CursorDef("BC000E18", "SELECT TOP 1 [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E18,1,0,true,true )
           ,new CursorDef("BC000E19", "SELECT TOP 1 [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E19,1,0,true,true )
           ,new CursorDef("BC000E20", "SELECT TOP 1 [BR_MedicationID] FROM [BR_Medication] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E20,1,0,true,true )
           ,new CursorDef("BC000E21", "SELECT TOP 1 [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E21,1,0,true,true )
           ,new CursorDef("BC000E22", "SELECT TOP 1 [BR_DiagnosisID] FROM [BR_Diagnosis] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E22,1,0,true,true )
           ,new CursorDef("BC000E23", "SELECT TOP 1 [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E23,1,0,true,true )
           ,new CursorDef("BC000E24", "SELECT TOP 1 [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E24,1,0,true,true )
           ,new CursorDef("BC000E25", "SELECT TOP 1 [BR_ComorbidityID] FROM [BR_Comorbidity] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E25,1,0,true,true )
           ,new CursorDef("BC000E26", "SELECT TOP 1 [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000E26,1,0,true,true )
           ,new CursorDef("BC000E27", cmdBufferBC000E27,true, GxErrorMask.GX_NOMASK, false, this,prmBC000E27,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((DateTime[]) buf[43])[0] = rslt.getGXDateTime(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((bool[]) buf[47])[0] = rslt.getBool(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((DateTime[]) buf[53])[0] = rslt.getGXDateTime(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((DateTime[]) buf[59])[0] = rslt.getGXDateTime(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((DateTime[]) buf[63])[0] = rslt.getGXDateTime(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((bool[]) buf[65])[0] = rslt.getBool(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((String[]) buf[67])[0] = rslt.getVarchar(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((DateTime[]) buf[71])[0] = rslt.getGXDateTime(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((bool[]) buf[75])[0] = rslt.getBool(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((String[]) buf[77])[0] = rslt.getVarchar(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((DateTime[]) buf[81])[0] = rslt.getGXDateTime(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((bool[]) buf[85])[0] = rslt.getBool(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((short[]) buf[87])[0] = rslt.getShort(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((String[]) buf[89])[0] = rslt.getVarchar(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((long[]) buf[91])[0] = rslt.getLong(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((String[]) buf[93])[0] = rslt.getVarchar(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((DateTime[]) buf[43])[0] = rslt.getGXDateTime(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((bool[]) buf[47])[0] = rslt.getBool(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((DateTime[]) buf[53])[0] = rslt.getGXDateTime(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((String[]) buf[55])[0] = rslt.getVarchar(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((DateTime[]) buf[59])[0] = rslt.getGXDateTime(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((String[]) buf[61])[0] = rslt.getVarchar(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((DateTime[]) buf[63])[0] = rslt.getGXDateTime(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((bool[]) buf[65])[0] = rslt.getBool(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((String[]) buf[67])[0] = rslt.getVarchar(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((DateTime[]) buf[71])[0] = rslt.getGXDateTime(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((bool[]) buf[75])[0] = rslt.getBool(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((String[]) buf[77])[0] = rslt.getVarchar(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((DateTime[]) buf[81])[0] = rslt.getGXDateTime(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((bool[]) buf[85])[0] = rslt.getBool(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((short[]) buf[87])[0] = rslt.getShort(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((String[]) buf[89])[0] = rslt.getVarchar(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((long[]) buf[91])[0] = rslt.getLong(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((String[]) buf[93])[0] = rslt.getVarchar(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              return;
           case 2 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((DateTime[]) buf[45])[0] = rslt.getGXDateTime(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((bool[]) buf[49])[0] = rslt.getBool(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((DateTime[]) buf[55])[0] = rslt.getGXDateTime(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((DateTime[]) buf[61])[0] = rslt.getGXDateTime(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((String[]) buf[63])[0] = rslt.getVarchar(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((DateTime[]) buf[65])[0] = rslt.getGXDateTime(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((bool[]) buf[67])[0] = rslt.getBool(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((String[]) buf[71])[0] = rslt.getVarchar(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((DateTime[]) buf[75])[0] = rslt.getGXDateTime(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((bool[]) buf[77])[0] = rslt.getBool(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((String[]) buf[81])[0] = rslt.getVarchar(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((DateTime[]) buf[85])[0] = rslt.getGXDateTime(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((bool[]) buf[87])[0] = rslt.getBool(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((short[]) buf[89])[0] = rslt.getShort(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((String[]) buf[91])[0] = rslt.getVarchar(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((long[]) buf[93])[0] = rslt.getLong(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              ((String[]) buf[95])[0] = rslt.getVarchar(49) ;
              ((bool[]) buf[96])[0] = rslt.wasNull(49);
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 14 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 19 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 20 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 21 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 22 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 23 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 24 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDateTime(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((DateTime[]) buf[31])[0] = rslt.getGXDate(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((DateTime[]) buf[45])[0] = rslt.getGXDateTime(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((bool[]) buf[49])[0] = rslt.getBool(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((String[]) buf[51])[0] = rslt.getVarchar(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((String[]) buf[53])[0] = rslt.getVarchar(28) ;
              ((bool[]) buf[54])[0] = rslt.wasNull(28);
              ((DateTime[]) buf[55])[0] = rslt.getGXDateTime(29) ;
              ((bool[]) buf[56])[0] = rslt.wasNull(29);
              ((String[]) buf[57])[0] = rslt.getVarchar(30) ;
              ((bool[]) buf[58])[0] = rslt.wasNull(30);
              ((String[]) buf[59])[0] = rslt.getVarchar(31) ;
              ((bool[]) buf[60])[0] = rslt.wasNull(31);
              ((DateTime[]) buf[61])[0] = rslt.getGXDateTime(32) ;
              ((bool[]) buf[62])[0] = rslt.wasNull(32);
              ((String[]) buf[63])[0] = rslt.getVarchar(33) ;
              ((bool[]) buf[64])[0] = rslt.wasNull(33);
              ((DateTime[]) buf[65])[0] = rslt.getGXDateTime(34) ;
              ((bool[]) buf[66])[0] = rslt.wasNull(34);
              ((bool[]) buf[67])[0] = rslt.getBool(35) ;
              ((bool[]) buf[68])[0] = rslt.wasNull(35);
              ((String[]) buf[69])[0] = rslt.getVarchar(36) ;
              ((bool[]) buf[70])[0] = rslt.wasNull(36);
              ((String[]) buf[71])[0] = rslt.getVarchar(37) ;
              ((bool[]) buf[72])[0] = rslt.wasNull(37);
              ((DateTime[]) buf[73])[0] = rslt.getGXDateTime(38) ;
              ((bool[]) buf[74])[0] = rslt.wasNull(38);
              ((DateTime[]) buf[75])[0] = rslt.getGXDateTime(39) ;
              ((bool[]) buf[76])[0] = rslt.wasNull(39);
              ((bool[]) buf[77])[0] = rslt.getBool(40) ;
              ((bool[]) buf[78])[0] = rslt.wasNull(40);
              ((String[]) buf[79])[0] = rslt.getVarchar(41) ;
              ((bool[]) buf[80])[0] = rslt.wasNull(41);
              ((String[]) buf[81])[0] = rslt.getVarchar(42) ;
              ((bool[]) buf[82])[0] = rslt.wasNull(42);
              ((DateTime[]) buf[83])[0] = rslt.getGXDateTime(43) ;
              ((bool[]) buf[84])[0] = rslt.wasNull(43);
              ((DateTime[]) buf[85])[0] = rslt.getGXDateTime(44) ;
              ((bool[]) buf[86])[0] = rslt.wasNull(44);
              ((bool[]) buf[87])[0] = rslt.getBool(45) ;
              ((bool[]) buf[88])[0] = rslt.wasNull(45);
              ((short[]) buf[89])[0] = rslt.getShort(46) ;
              ((bool[]) buf[90])[0] = rslt.wasNull(46);
              ((String[]) buf[91])[0] = rslt.getVarchar(47) ;
              ((bool[]) buf[92])[0] = rslt.wasNull(47);
              ((long[]) buf[93])[0] = rslt.getLong(48) ;
              ((bool[]) buf[94])[0] = rslt.wasNull(48);
              ((String[]) buf[95])[0] = rslt.getVarchar(49) ;
              ((bool[]) buf[96])[0] = rslt.wasNull(49);
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 1 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 2 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 3 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              return;
           case 4 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 5 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 6 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(5, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(22, (DateTime)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(24, (bool)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(27, (DateTime)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              if ( (bool)parms[58] )
              {
                 stmt.setNull( 30 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(30, (DateTime)parms[59]);
              }
              if ( (bool)parms[60] )
              {
                 stmt.setNull( 31 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(31, (String)parms[61]);
              }
              if ( (bool)parms[62] )
              {
                 stmt.setNull( 32 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(32, (DateTime)parms[63]);
              }
              if ( (bool)parms[64] )
              {
                 stmt.setNull( 33 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(33, (bool)parms[65]);
              }
              if ( (bool)parms[66] )
              {
                 stmt.setNull( 34 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(34, (String)parms[67]);
              }
              if ( (bool)parms[68] )
              {
                 stmt.setNull( 35 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(35, (String)parms[69]);
              }
              if ( (bool)parms[70] )
              {
                 stmt.setNull( 36 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(36, (DateTime)parms[71]);
              }
              if ( (bool)parms[72] )
              {
                 stmt.setNull( 37 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(37, (DateTime)parms[73]);
              }
              if ( (bool)parms[74] )
              {
                 stmt.setNull( 38 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(38, (bool)parms[75]);
              }
              if ( (bool)parms[76] )
              {
                 stmt.setNull( 39 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(39, (String)parms[77]);
              }
              if ( (bool)parms[78] )
              {
                 stmt.setNull( 40 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(40, (String)parms[79]);
              }
              if ( (bool)parms[80] )
              {
                 stmt.setNull( 41 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(41, (DateTime)parms[81]);
              }
              if ( (bool)parms[82] )
              {
                 stmt.setNull( 42 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(42, (DateTime)parms[83]);
              }
              if ( (bool)parms[84] )
              {
                 stmt.setNull( 43 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(43, (bool)parms[85]);
              }
              if ( (bool)parms[86] )
              {
                 stmt.setNull( 44 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(44, (short)parms[87]);
              }
              if ( (bool)parms[88] )
              {
                 stmt.setNull( 45 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(45, (String)parms[89]);
              }
              if ( (bool)parms[90] )
              {
                 stmt.setNull( 46 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(46, (long)parms[91]);
              }
              if ( (bool)parms[92] )
              {
                 stmt.setNull( 47 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(47, (String)parms[93]);
              }
              return;
           case 7 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(3, (String)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(5, (DateTime)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(16, (DateTime)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(22, (DateTime)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(24, (bool)parms[47]);
              }
              if ( (bool)parms[48] )
              {
                 stmt.setNull( 25 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(25, (String)parms[49]);
              }
              if ( (bool)parms[50] )
              {
                 stmt.setNull( 26 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(26, (String)parms[51]);
              }
              if ( (bool)parms[52] )
              {
                 stmt.setNull( 27 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(27, (DateTime)parms[53]);
              }
              if ( (bool)parms[54] )
              {
                 stmt.setNull( 28 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(28, (String)parms[55]);
              }
              if ( (bool)parms[56] )
              {
                 stmt.setNull( 29 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(29, (String)parms[57]);
              }
              if ( (bool)parms[58] )
              {
                 stmt.setNull( 30 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(30, (DateTime)parms[59]);
              }
              if ( (bool)parms[60] )
              {
                 stmt.setNull( 31 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(31, (String)parms[61]);
              }
              if ( (bool)parms[62] )
              {
                 stmt.setNull( 32 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(32, (DateTime)parms[63]);
              }
              if ( (bool)parms[64] )
              {
                 stmt.setNull( 33 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(33, (bool)parms[65]);
              }
              if ( (bool)parms[66] )
              {
                 stmt.setNull( 34 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(34, (String)parms[67]);
              }
              if ( (bool)parms[68] )
              {
                 stmt.setNull( 35 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(35, (String)parms[69]);
              }
              if ( (bool)parms[70] )
              {
                 stmt.setNull( 36 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(36, (DateTime)parms[71]);
              }
              if ( (bool)parms[72] )
              {
                 stmt.setNull( 37 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(37, (DateTime)parms[73]);
              }
              if ( (bool)parms[74] )
              {
                 stmt.setNull( 38 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(38, (bool)parms[75]);
              }
              if ( (bool)parms[76] )
              {
                 stmt.setNull( 39 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(39, (String)parms[77]);
              }
              if ( (bool)parms[78] )
              {
                 stmt.setNull( 40 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(40, (String)parms[79]);
              }
              if ( (bool)parms[80] )
              {
                 stmt.setNull( 41 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(41, (DateTime)parms[81]);
              }
              if ( (bool)parms[82] )
              {
                 stmt.setNull( 42 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(42, (DateTime)parms[83]);
              }
              if ( (bool)parms[84] )
              {
                 stmt.setNull( 43 , SqlDbType.Bit );
              }
              else
              {
                 stmt.SetParameter(43, (bool)parms[85]);
              }
              if ( (bool)parms[86] )
              {
                 stmt.setNull( 44 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(44, (short)parms[87]);
              }
              if ( (bool)parms[88] )
              {
                 stmt.setNull( 45 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(45, (String)parms[89]);
              }
              if ( (bool)parms[90] )
              {
                 stmt.setNull( 46 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(46, (long)parms[91]);
              }
              if ( (bool)parms[92] )
              {
                 stmt.setNull( 47 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(47, (String)parms[93]);
              }
              if ( (bool)parms[94] )
              {
                 stmt.setNull( 48 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(48, (long)parms[95]);
              }
              return;
           case 8 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 10 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 11 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 12 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 13 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 14 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 15 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 16 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 17 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 18 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 19 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 20 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 21 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 22 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 23 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 24 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
     }
  }

}

}
