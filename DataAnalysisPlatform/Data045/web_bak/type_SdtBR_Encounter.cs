/*
               File: type_SdtBR_Encounter
        Description: 就诊信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:36:59.70
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "BR_Encounter" )]
   [XmlType(TypeName =  "BR_Encounter" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Encounter : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Encounter( )
      {
      }

      public SdtBR_Encounter( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( long AV19BR_EncounterID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV19BR_EncounterID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_EncounterID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Encounter");
         metadata.Set("BT", "BR_Encounter");
         metadata.Set("PK", "[ \"BR_EncounterID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_EncounterID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BAS_TenantTenantCode\" ],\"FKMap\":[  ] },{ \"FK\":[ \"BR_Information_ID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"BR_Information_ID\",\"BAS_TenantTenantCode\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_encounter_encid_Z");
         state.Add("gxTpr_Br_encounter_department_Z");
         state.Add("gxTpr_Br_encounter_department_code_Z");
         state.Add("gxTpr_Br_encounter_departmentadm_Z");
         state.Add("gxTpr_Br_encounter_departmentadm_code_Z");
         state.Add("gxTpr_Br_encounter_departmentdisch_Z");
         state.Add("gxTpr_Br_encounter_departmentdisch_code_Z");
         state.Add("gxTpr_Br_encounter_enctype_Z");
         state.Add("gxTpr_Br_encounter_enctype_code_Z");
         state.Add("gxTpr_Br_encounter_admitdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_admitsource_Z");
         state.Add("gxTpr_Br_encounter_admitsource_code_Z");
         state.Add("gxTpr_Br_encounter_dischargedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_dischargestatus_Z");
         state.Add("gxTpr_Br_encounter_dischargestatus_code_Z");
         state.Add("gxTpr_Br_encounter_insurance_Z");
         state.Add("gxTpr_Br_encounter_insurance_code_Z");
         state.Add("gxTpr_Br_encounter_status_Z");
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Bas_tenanttenantcode_Z");
         state.Add("gxTpr_Br_encounter_crtdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_upddate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_crtuser_Z");
         state.Add("gxTpr_Br_encounter_crtdisplayname_Z");
         state.Add("gxTpr_Br_encounter_upduser_Z");
         state.Add("gxTpr_Br_encounter_isdlt_Z");
         state.Add("gxTpr_Br_encounter_submituser_Z");
         state.Add("gxTpr_Br_encounter_reason_Z");
         state.Add("gxTpr_Br_encounter_submitdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_recheckuser_Z");
         state.Add("gxTpr_Br_encounter_freason_Z");
         state.Add("gxTpr_Br_encounter_recheckdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_approver_Z");
         state.Add("gxTpr_Br_encounter_approvedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_israndapprove_Z");
         state.Add("gxTpr_Br_encounter_israndapprover_Z");
         state.Add("gxTpr_Br_encounter_israndnoapprover_Z");
         state.Add("gxTpr_Br_encounter_israndapprovedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_israndnoapprovedate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_israndrecheck_Z");
         state.Add("gxTpr_Br_encounter_israndrecheckr_Z");
         state.Add("gxTpr_Br_encounter_israndnorecheckr_Z");
         state.Add("gxTpr_Br_encounter_israndrecheckdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_israndnorecheckdate_Z_Nullable");
         state.Add("gxTpr_Br_encounter_isupdate_Z");
         state.Add("gxTpr_Br_encounter_datasource_Z");
         state.Add("gxTpr_Encounteridencrypt_Z");
         state.Add("gxTpr_Br_encounterid_N");
         state.Add("gxTpr_Br_encounter_encid_N");
         state.Add("gxTpr_Br_encounter_department_N");
         state.Add("gxTpr_Br_encounter_department_code_N");
         state.Add("gxTpr_Br_encounter_departmentadm_N");
         state.Add("gxTpr_Br_encounter_departmentadm_code_N");
         state.Add("gxTpr_Br_encounter_departmentdisch_N");
         state.Add("gxTpr_Br_encounter_departmentdisch_code_N");
         state.Add("gxTpr_Br_encounter_enctype_N");
         state.Add("gxTpr_Br_encounter_enctype_code_N");
         state.Add("gxTpr_Br_encounter_admitdate_N");
         state.Add("gxTpr_Br_encounter_admitsource_N");
         state.Add("gxTpr_Br_encounter_admitsource_code_N");
         state.Add("gxTpr_Br_encounter_dischargedate_N");
         state.Add("gxTpr_Br_encounter_dischargestatus_N");
         state.Add("gxTpr_Br_encounter_dischargestatus_code_N");
         state.Add("gxTpr_Br_encounter_insurance_N");
         state.Add("gxTpr_Br_encounter_insurance_code_N");
         state.Add("gxTpr_Br_encounter_status_N");
         state.Add("gxTpr_Br_information_id_N");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Bas_tenanttenantcode_N");
         state.Add("gxTpr_Br_encounter_crtdate_N");
         state.Add("gxTpr_Br_encounter_upddate_N");
         state.Add("gxTpr_Br_encounter_crtuser_N");
         state.Add("gxTpr_Br_encounter_crtdisplayname_N");
         state.Add("gxTpr_Br_encounter_upduser_N");
         state.Add("gxTpr_Br_encounter_isdlt_N");
         state.Add("gxTpr_Br_encounter_submituser_N");
         state.Add("gxTpr_Br_encounter_reason_N");
         state.Add("gxTpr_Br_encounter_submitdate_N");
         state.Add("gxTpr_Br_encounter_recheckuser_N");
         state.Add("gxTpr_Br_encounter_freason_N");
         state.Add("gxTpr_Br_encounter_recheckdate_N");
         state.Add("gxTpr_Br_encounter_approver_N");
         state.Add("gxTpr_Br_encounter_approvedate_N");
         state.Add("gxTpr_Br_encounter_israndapprove_N");
         state.Add("gxTpr_Br_encounter_israndapprover_N");
         state.Add("gxTpr_Br_encounter_israndnoapprover_N");
         state.Add("gxTpr_Br_encounter_israndapprovedate_N");
         state.Add("gxTpr_Br_encounter_israndnoapprovedate_N");
         state.Add("gxTpr_Br_encounter_israndrecheck_N");
         state.Add("gxTpr_Br_encounter_israndrecheckr_N");
         state.Add("gxTpr_Br_encounter_israndnorecheckr_N");
         state.Add("gxTpr_Br_encounter_israndrecheckdate_N");
         state.Add("gxTpr_Br_encounter_israndnorecheckdate_N");
         state.Add("gxTpr_Br_encounter_isupdate_N");
         state.Add("gxTpr_Br_encounter_datasource_N");
         state.Add("gxTpr_Encounteridencrypt_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Encounter sdt ;
         sdt = (SdtBR_Encounter)(source);
         gxTv_SdtBR_Encounter_Br_encounterid = sdt.gxTv_SdtBR_Encounter_Br_encounterid ;
         gxTv_SdtBR_Encounter_Br_encounter_encid = sdt.gxTv_SdtBR_Encounter_Br_encounter_encid ;
         gxTv_SdtBR_Encounter_Br_encounter_department = sdt.gxTv_SdtBR_Encounter_Br_encounter_department ;
         gxTv_SdtBR_Encounter_Br_encounter_department_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_code ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_code ;
         gxTv_SdtBR_Encounter_Br_encounter_admitdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitdate ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_code ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargedate ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_code ;
         gxTv_SdtBR_Encounter_Br_encounter_status = sdt.gxTv_SdtBR_Encounter_Br_encounter_status ;
         gxTv_SdtBR_Encounter_Br_information_id = sdt.gxTv_SdtBR_Encounter_Br_information_id ;
         gxTv_SdtBR_Encounter_Br_information_patientno = sdt.gxTv_SdtBR_Encounter_Br_information_patientno ;
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode = sdt.gxTv_SdtBR_Encounter_Bas_tenanttenantcode ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdate ;
         gxTv_SdtBR_Encounter_Br_encounter_upddate = sdt.gxTv_SdtBR_Encounter_Br_encounter_upddate ;
         gxTv_SdtBR_Encounter_Br_encounter_crtuser = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtuser ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname ;
         gxTv_SdtBR_Encounter_Br_encounter_upduser = sdt.gxTv_SdtBR_Encounter_Br_encounter_upduser ;
         gxTv_SdtBR_Encounter_Br_encounter_isdlt = sdt.gxTv_SdtBR_Encounter_Br_encounter_isdlt ;
         gxTv_SdtBR_Encounter_Br_encounter_submituser = sdt.gxTv_SdtBR_Encounter_Br_encounter_submituser ;
         gxTv_SdtBR_Encounter_Br_encounter_reason = sdt.gxTv_SdtBR_Encounter_Br_encounter_reason ;
         gxTv_SdtBR_Encounter_Br_encounter_submitdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_submitdate ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckuser ;
         gxTv_SdtBR_Encounter_Br_encounter_freason = sdt.gxTv_SdtBR_Encounter_Br_encounter_freason ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckdate ;
         gxTv_SdtBR_Encounter_Br_encounter_approver = sdt.gxTv_SdtBR_Encounter_Br_encounter_approver ;
         gxTv_SdtBR_Encounter_Br_encounter_approvedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_approvedate ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprove ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprover ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheck ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate ;
         gxTv_SdtBR_Encounter_Br_encounter_isupdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_isupdate ;
         gxTv_SdtBR_Encounter_Br_encounter_datasource = sdt.gxTv_SdtBR_Encounter_Br_encounter_datasource ;
         gxTv_SdtBR_Encounter_Encounteridencrypt = sdt.gxTv_SdtBR_Encounter_Encounteridencrypt ;
         gxTv_SdtBR_Encounter_Mode = sdt.gxTv_SdtBR_Encounter_Mode ;
         gxTv_SdtBR_Encounter_Initialized = sdt.gxTv_SdtBR_Encounter_Initialized ;
         gxTv_SdtBR_Encounter_Br_encounterid_Z = sdt.gxTv_SdtBR_Encounter_Br_encounterid_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_encid_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_encid_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_department_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_department_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_status_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_status_Z ;
         gxTv_SdtBR_Encounter_Br_information_id_Z = sdt.gxTv_SdtBR_Encounter_Br_information_id_Z ;
         gxTv_SdtBR_Encounter_Br_information_patientno_Z = sdt.gxTv_SdtBR_Encounter_Br_information_patientno_Z ;
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z = sdt.gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_upddate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_upduser_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_upduser_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_submituser_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_submituser_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_reason_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_reason_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_freason_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_freason_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_approver_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_approver_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z ;
         gxTv_SdtBR_Encounter_Br_encounter_datasource_Z = sdt.gxTv_SdtBR_Encounter_Br_encounter_datasource_Z ;
         gxTv_SdtBR_Encounter_Encounteridencrypt_Z = sdt.gxTv_SdtBR_Encounter_Encounteridencrypt_Z ;
         gxTv_SdtBR_Encounter_Br_encounterid_N = sdt.gxTv_SdtBR_Encounter_Br_encounterid_N ;
         gxTv_SdtBR_Encounter_Br_encounter_encid_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_encid_N ;
         gxTv_SdtBR_Encounter_Br_encounter_department_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_N ;
         gxTv_SdtBR_Encounter_Br_encounter_department_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N ;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_N ;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_N ;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N ;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_N ;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N ;
         gxTv_SdtBR_Encounter_Br_encounter_status_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_status_N ;
         gxTv_SdtBR_Encounter_Br_information_id_N = sdt.gxTv_SdtBR_Encounter_Br_information_id_N ;
         gxTv_SdtBR_Encounter_Br_information_patientno_N = sdt.gxTv_SdtBR_Encounter_Br_information_patientno_N ;
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N = sdt.gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_upddate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_upddate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtuser_N ;
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N ;
         gxTv_SdtBR_Encounter_Br_encounter_upduser_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_upduser_N ;
         gxTv_SdtBR_Encounter_Br_encounter_isdlt_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_isdlt_N ;
         gxTv_SdtBR_Encounter_Br_encounter_submituser_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_submituser_N ;
         gxTv_SdtBR_Encounter_Br_encounter_reason_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_reason_N ;
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_submitdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N ;
         gxTv_SdtBR_Encounter_Br_encounter_freason_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_freason_N ;
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_approver_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_approver_N ;
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_approvedate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_isupdate_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_isupdate_N ;
         gxTv_SdtBR_Encounter_Br_encounter_datasource_N = sdt.gxTv_SdtBR_Encounter_Br_encounter_datasource_N ;
         gxTv_SdtBR_Encounter_Encounteridencrypt_N = sdt.gxTv_SdtBR_Encounter_Encounteridencrypt_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Encounter_Br_encounterid_N, false);
         AddObjectProperty("BR_Encounter_EncID", gxTv_SdtBR_Encounter_Br_encounter_encid, false);
         AddObjectProperty("BR_Encounter_EncID_N", gxTv_SdtBR_Encounter_Br_encounter_encid_N, false);
         AddObjectProperty("BR_Encounter_Department", gxTv_SdtBR_Encounter_Br_encounter_department, false);
         AddObjectProperty("BR_Encounter_Department_N", gxTv_SdtBR_Encounter_Br_encounter_department_N, false);
         AddObjectProperty("BR_Encounter_Department_Code", gxTv_SdtBR_Encounter_Br_encounter_department_code, false);
         AddObjectProperty("BR_Encounter_Department_Code_N", gxTv_SdtBR_Encounter_Br_encounter_department_code_N, false);
         AddObjectProperty("BR_Encounter_Departmentadm", gxTv_SdtBR_Encounter_Br_encounter_departmentadm, false);
         AddObjectProperty("BR_Encounter_Departmentadm_N", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N, false);
         AddObjectProperty("BR_Encounter_Departmentadm_Code", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code, false);
         AddObjectProperty("BR_Encounter_Departmentadm_Code_N", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N, false);
         AddObjectProperty("BR_Encounter_Departmentdisch", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch, false);
         AddObjectProperty("BR_Encounter_Departmentdisch_N", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N, false);
         AddObjectProperty("BR_Encounter_Departmentdisch_Code", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code, false);
         AddObjectProperty("BR_Encounter_Departmentdisch_Code_N", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N, false);
         AddObjectProperty("BR_Encounter_ENCType", gxTv_SdtBR_Encounter_Br_encounter_enctype, false);
         AddObjectProperty("BR_Encounter_ENCType_N", gxTv_SdtBR_Encounter_Br_encounter_enctype_N, false);
         AddObjectProperty("BR_Encounter_ENCType_Code", gxTv_SdtBR_Encounter_Br_encounter_enctype_code, false);
         AddObjectProperty("BR_Encounter_ENCType_Code_N", gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Encounter_Br_encounter_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Encounter_Br_encounter_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Encounter_Br_encounter_admitdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_AdmitDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_AdmitDate_N", gxTv_SdtBR_Encounter_Br_encounter_admitdate_N, false);
         AddObjectProperty("BR_Encounter_AdmitSource", gxTv_SdtBR_Encounter_Br_encounter_admitsource, false);
         AddObjectProperty("BR_Encounter_AdmitSource_N", gxTv_SdtBR_Encounter_Br_encounter_admitsource_N, false);
         AddObjectProperty("BR_Encounter_AdmitSource_Code", gxTv_SdtBR_Encounter_Br_encounter_admitsource_code, false);
         AddObjectProperty("BR_Encounter_AdmitSource_Code_N", gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Encounter_Br_encounter_dischargedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Encounter_Br_encounter_dischargedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Encounter_Br_encounter_dischargedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_DischargeDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_DischargeDate_N", gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N, false);
         AddObjectProperty("BR_Encounter_DischargeStatus", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus, false);
         AddObjectProperty("BR_Encounter_DischargeStatus_N", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N, false);
         AddObjectProperty("BR_Encounter_DischargeStatus_Code", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code, false);
         AddObjectProperty("BR_Encounter_DischargeStatus_Code_N", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N, false);
         AddObjectProperty("BR_Encounter_Insurance", gxTv_SdtBR_Encounter_Br_encounter_insurance, false);
         AddObjectProperty("BR_Encounter_Insurance_N", gxTv_SdtBR_Encounter_Br_encounter_insurance_N, false);
         AddObjectProperty("BR_Encounter_Insurance_Code", gxTv_SdtBR_Encounter_Br_encounter_insurance_code, false);
         AddObjectProperty("BR_Encounter_Insurance_Code_N", gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N, false);
         AddObjectProperty("BR_Encounter_Status", gxTv_SdtBR_Encounter_Br_encounter_status, false);
         AddObjectProperty("BR_Encounter_Status_N", gxTv_SdtBR_Encounter_Br_encounter_status_N, false);
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_Br_information_id), 18, 0)), false);
         AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_Encounter_Br_information_id_N, false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Encounter_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Encounter_Br_information_patientno_N, false);
         AddObjectProperty("BAS_TenantTenantCode", gxTv_SdtBR_Encounter_Bas_tenanttenantcode, false);
         AddObjectProperty("BAS_TenantTenantCode_N", gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_crtdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_CrtDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_CrtDate_N", gxTv_SdtBR_Encounter_Br_encounter_crtdate_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_upddate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_UpdDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_UpdDate_N", gxTv_SdtBR_Encounter_Br_encounter_upddate_N, false);
         AddObjectProperty("BR_Encounter_CrtUser", gxTv_SdtBR_Encounter_Br_encounter_crtuser, false);
         AddObjectProperty("BR_Encounter_CrtUser_N", gxTv_SdtBR_Encounter_Br_encounter_crtuser_N, false);
         AddObjectProperty("BR_Encounter_CrtDisplayName", gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname, false);
         AddObjectProperty("BR_Encounter_CrtDisplayName_N", gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N, false);
         AddObjectProperty("BR_Encounter_UpdUser", gxTv_SdtBR_Encounter_Br_encounter_upduser, false);
         AddObjectProperty("BR_Encounter_UpdUser_N", gxTv_SdtBR_Encounter_Br_encounter_upduser_N, false);
         AddObjectProperty("BR_Encounter_IsDLT", gxTv_SdtBR_Encounter_Br_encounter_isdlt, false);
         AddObjectProperty("BR_Encounter_IsDLT_N", gxTv_SdtBR_Encounter_Br_encounter_isdlt_N, false);
         AddObjectProperty("BR_Encounter_SubmitUser", gxTv_SdtBR_Encounter_Br_encounter_submituser, false);
         AddObjectProperty("BR_Encounter_SubmitUser_N", gxTv_SdtBR_Encounter_Br_encounter_submituser_N, false);
         AddObjectProperty("BR_Encounter_Reason", gxTv_SdtBR_Encounter_Br_encounter_reason, false);
         AddObjectProperty("BR_Encounter_Reason_N", gxTv_SdtBR_Encounter_Br_encounter_reason_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_submitdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_SubmitDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_SubmitDate_N", gxTv_SdtBR_Encounter_Br_encounter_submitdate_N, false);
         AddObjectProperty("BR_Encounter_RecheckUser", gxTv_SdtBR_Encounter_Br_encounter_recheckuser, false);
         AddObjectProperty("BR_Encounter_RecheckUser_N", gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N, false);
         AddObjectProperty("BR_Encounter_FReason", gxTv_SdtBR_Encounter_Br_encounter_freason, false);
         AddObjectProperty("BR_Encounter_FReason_N", gxTv_SdtBR_Encounter_Br_encounter_freason_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_recheckdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_RecheckDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_RecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N, false);
         AddObjectProperty("BR_Encounter_Approver", gxTv_SdtBR_Encounter_Br_encounter_approver, false);
         AddObjectProperty("BR_Encounter_Approver_N", gxTv_SdtBR_Encounter_Br_encounter_approver_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_approvedate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_ApproveDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_ApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_approvedate_N, false);
         AddObjectProperty("BR_Encounter_IsRandApprove", gxTv_SdtBR_Encounter_Br_encounter_israndapprove, false);
         AddObjectProperty("BR_Encounter_IsRandApprove_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N, false);
         AddObjectProperty("BR_Encounter_IsRandApprover", gxTv_SdtBR_Encounter_Br_encounter_israndapprover, false);
         AddObjectProperty("BR_Encounter_IsRandApprover_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N, false);
         AddObjectProperty("BR_Encounter_IsRandNoApprover", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover, false);
         AddObjectProperty("BR_Encounter_IsRandNoApprover_N", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_IsRandApproveDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_IsRandApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_IsRandNoApproveDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_IsRandNoApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N, false);
         AddObjectProperty("BR_Encounter_IsRandRecheck", gxTv_SdtBR_Encounter_Br_encounter_israndrecheck, false);
         AddObjectProperty("BR_Encounter_IsRandRecheck_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N, false);
         AddObjectProperty("BR_Encounter_IsRandRecheckr", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr, false);
         AddObjectProperty("BR_Encounter_IsRandRecheckr_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N, false);
         AddObjectProperty("BR_Encounter_IsRandNoRecheckr", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr, false);
         AddObjectProperty("BR_Encounter_IsRandNoRecheckr_N", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_IsRandRecheckDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_IsRandRecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N, false);
         datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate;
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "T";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + ":";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Encounter_IsRandNoRecheckDate", sDateCnv, false);
         AddObjectProperty("BR_Encounter_IsRandNoRecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N, false);
         AddObjectProperty("BR_Encounter_IsUpdate", gxTv_SdtBR_Encounter_Br_encounter_isupdate, false);
         AddObjectProperty("BR_Encounter_IsUpdate_N", gxTv_SdtBR_Encounter_Br_encounter_isupdate_N, false);
         AddObjectProperty("BR_Encounter_Datasource", gxTv_SdtBR_Encounter_Br_encounter_datasource, false);
         AddObjectProperty("BR_Encounter_Datasource_N", gxTv_SdtBR_Encounter_Br_encounter_datasource_N, false);
         AddObjectProperty("EncounterIDEncrypt", gxTv_SdtBR_Encounter_Encounteridencrypt, false);
         AddObjectProperty("EncounterIDEncrypt_N", gxTv_SdtBR_Encounter_Encounteridencrypt_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Encounter_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Encounter_Initialized, false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Encounter_EncID_Z", gxTv_SdtBR_Encounter_Br_encounter_encid_Z, false);
            AddObjectProperty("BR_Encounter_Department_Z", gxTv_SdtBR_Encounter_Br_encounter_department_Z, false);
            AddObjectProperty("BR_Encounter_Department_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_department_code_Z, false);
            AddObjectProperty("BR_Encounter_Departmentadm_Z", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z, false);
            AddObjectProperty("BR_Encounter_Departmentadm_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z, false);
            AddObjectProperty("BR_Encounter_Departmentdisch_Z", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z, false);
            AddObjectProperty("BR_Encounter_Departmentdisch_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z, false);
            AddObjectProperty("BR_Encounter_ENCType_Z", gxTv_SdtBR_Encounter_Br_encounter_enctype_Z, false);
            AddObjectProperty("BR_Encounter_ENCType_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_AdmitDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_AdmitSource_Z", gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z, false);
            AddObjectProperty("BR_Encounter_AdmitSource_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_DischargeDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_DischargeStatus_Z", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z, false);
            AddObjectProperty("BR_Encounter_DischargeStatus_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z, false);
            AddObjectProperty("BR_Encounter_Insurance_Z", gxTv_SdtBR_Encounter_Br_encounter_insurance_Z, false);
            AddObjectProperty("BR_Encounter_Insurance_Code_Z", gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z, false);
            AddObjectProperty("BR_Encounter_Status_Z", gxTv_SdtBR_Encounter_Br_encounter_status_Z, false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Encounter_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Encounter_Br_information_patientno_Z, false);
            AddObjectProperty("BAS_TenantTenantCode_Z", gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_CrtDate_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_upddate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_UpdDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_CrtUser_Z", gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z, false);
            AddObjectProperty("BR_Encounter_CrtDisplayName_Z", gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z, false);
            AddObjectProperty("BR_Encounter_UpdUser_Z", gxTv_SdtBR_Encounter_Br_encounter_upduser_Z, false);
            AddObjectProperty("BR_Encounter_IsDLT_Z", gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z, false);
            AddObjectProperty("BR_Encounter_SubmitUser_Z", gxTv_SdtBR_Encounter_Br_encounter_submituser_Z, false);
            AddObjectProperty("BR_Encounter_Reason_Z", gxTv_SdtBR_Encounter_Br_encounter_reason_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_SubmitDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_RecheckUser_Z", gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z, false);
            AddObjectProperty("BR_Encounter_FReason_Z", gxTv_SdtBR_Encounter_Br_encounter_freason_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_RecheckDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_Approver_Z", gxTv_SdtBR_Encounter_Br_encounter_approver_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_ApproveDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_IsRandApprove_Z", gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z, false);
            AddObjectProperty("BR_Encounter_IsRandApprover_Z", gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z, false);
            AddObjectProperty("BR_Encounter_IsRandNoApprover_Z", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_IsRandApproveDate_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_IsRandNoApproveDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_IsRandRecheck_Z", gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z, false);
            AddObjectProperty("BR_Encounter_IsRandRecheckr_Z", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z, false);
            AddObjectProperty("BR_Encounter_IsRandNoRecheckr_Z", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_IsRandRecheckDate_Z", sDateCnv, false);
            datetime_STZ = gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z;
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "T";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Hour( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Minute( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + ":";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Second( datetime_STZ)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Encounter_IsRandNoRecheckDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Encounter_IsUpdate_Z", gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z, false);
            AddObjectProperty("BR_Encounter_Datasource_Z", gxTv_SdtBR_Encounter_Br_encounter_datasource_Z, false);
            AddObjectProperty("EncounterIDEncrypt_Z", gxTv_SdtBR_Encounter_Encounteridencrypt_Z, false);
            AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_Encounter_Br_encounterid_N, false);
            AddObjectProperty("BR_Encounter_EncID_N", gxTv_SdtBR_Encounter_Br_encounter_encid_N, false);
            AddObjectProperty("BR_Encounter_Department_N", gxTv_SdtBR_Encounter_Br_encounter_department_N, false);
            AddObjectProperty("BR_Encounter_Department_Code_N", gxTv_SdtBR_Encounter_Br_encounter_department_code_N, false);
            AddObjectProperty("BR_Encounter_Departmentadm_N", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N, false);
            AddObjectProperty("BR_Encounter_Departmentadm_Code_N", gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N, false);
            AddObjectProperty("BR_Encounter_Departmentdisch_N", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N, false);
            AddObjectProperty("BR_Encounter_Departmentdisch_Code_N", gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N, false);
            AddObjectProperty("BR_Encounter_ENCType_N", gxTv_SdtBR_Encounter_Br_encounter_enctype_N, false);
            AddObjectProperty("BR_Encounter_ENCType_Code_N", gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N, false);
            AddObjectProperty("BR_Encounter_AdmitDate_N", gxTv_SdtBR_Encounter_Br_encounter_admitdate_N, false);
            AddObjectProperty("BR_Encounter_AdmitSource_N", gxTv_SdtBR_Encounter_Br_encounter_admitsource_N, false);
            AddObjectProperty("BR_Encounter_AdmitSource_Code_N", gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N, false);
            AddObjectProperty("BR_Encounter_DischargeDate_N", gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N, false);
            AddObjectProperty("BR_Encounter_DischargeStatus_N", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N, false);
            AddObjectProperty("BR_Encounter_DischargeStatus_Code_N", gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N, false);
            AddObjectProperty("BR_Encounter_Insurance_N", gxTv_SdtBR_Encounter_Br_encounter_insurance_N, false);
            AddObjectProperty("BR_Encounter_Insurance_Code_N", gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N, false);
            AddObjectProperty("BR_Encounter_Status_N", gxTv_SdtBR_Encounter_Br_encounter_status_N, false);
            AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_Encounter_Br_information_id_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Encounter_Br_information_patientno_N, false);
            AddObjectProperty("BAS_TenantTenantCode_N", gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N, false);
            AddObjectProperty("BR_Encounter_CrtDate_N", gxTv_SdtBR_Encounter_Br_encounter_crtdate_N, false);
            AddObjectProperty("BR_Encounter_UpdDate_N", gxTv_SdtBR_Encounter_Br_encounter_upddate_N, false);
            AddObjectProperty("BR_Encounter_CrtUser_N", gxTv_SdtBR_Encounter_Br_encounter_crtuser_N, false);
            AddObjectProperty("BR_Encounter_CrtDisplayName_N", gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N, false);
            AddObjectProperty("BR_Encounter_UpdUser_N", gxTv_SdtBR_Encounter_Br_encounter_upduser_N, false);
            AddObjectProperty("BR_Encounter_IsDLT_N", gxTv_SdtBR_Encounter_Br_encounter_isdlt_N, false);
            AddObjectProperty("BR_Encounter_SubmitUser_N", gxTv_SdtBR_Encounter_Br_encounter_submituser_N, false);
            AddObjectProperty("BR_Encounter_Reason_N", gxTv_SdtBR_Encounter_Br_encounter_reason_N, false);
            AddObjectProperty("BR_Encounter_SubmitDate_N", gxTv_SdtBR_Encounter_Br_encounter_submitdate_N, false);
            AddObjectProperty("BR_Encounter_RecheckUser_N", gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N, false);
            AddObjectProperty("BR_Encounter_FReason_N", gxTv_SdtBR_Encounter_Br_encounter_freason_N, false);
            AddObjectProperty("BR_Encounter_RecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N, false);
            AddObjectProperty("BR_Encounter_Approver_N", gxTv_SdtBR_Encounter_Br_encounter_approver_N, false);
            AddObjectProperty("BR_Encounter_ApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_approvedate_N, false);
            AddObjectProperty("BR_Encounter_IsRandApprove_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N, false);
            AddObjectProperty("BR_Encounter_IsRandApprover_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N, false);
            AddObjectProperty("BR_Encounter_IsRandNoApprover_N", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N, false);
            AddObjectProperty("BR_Encounter_IsRandApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N, false);
            AddObjectProperty("BR_Encounter_IsRandNoApproveDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N, false);
            AddObjectProperty("BR_Encounter_IsRandRecheck_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N, false);
            AddObjectProperty("BR_Encounter_IsRandRecheckr_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N, false);
            AddObjectProperty("BR_Encounter_IsRandNoRecheckr_N", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N, false);
            AddObjectProperty("BR_Encounter_IsRandRecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N, false);
            AddObjectProperty("BR_Encounter_IsRandNoRecheckDate_N", gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N, false);
            AddObjectProperty("BR_Encounter_IsUpdate_N", gxTv_SdtBR_Encounter_Br_encounter_isupdate_N, false);
            AddObjectProperty("BR_Encounter_Datasource_N", gxTv_SdtBR_Encounter_Br_encounter_datasource_N, false);
            AddObjectProperty("EncounterIDEncrypt_N", gxTv_SdtBR_Encounter_Encounteridencrypt_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Encounter sdt )
      {
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Encounter_Br_encounterid = sdt.gxTv_SdtBR_Encounter_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Encounter_EncID") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_encid = sdt.gxTv_SdtBR_Encounter_Br_encounter_encid ;
         }
         if ( sdt.IsDirty("BR_Encounter_Department") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_department = sdt.gxTv_SdtBR_Encounter_Br_encounter_department ;
         }
         if ( sdt.IsDirty("BR_Encounter_Department_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_department_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_department_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_Departmentadm") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm ;
         }
         if ( sdt.IsDirty("BR_Encounter_Departmentadm_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_Departmentdisch") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch ;
         }
         if ( sdt.IsDirty("BR_Encounter_Departmentdisch_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_ENCType") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_enctype = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype ;
         }
         if ( sdt.IsDirty("BR_Encounter_ENCType_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_enctype_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_AdmitDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_admitdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_AdmitSource") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource ;
         }
         if ( sdt.IsDirty("BR_Encounter_AdmitSource_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_admitsource_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_DischargeDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargedate ;
         }
         if ( sdt.IsDirty("BR_Encounter_DischargeStatus") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus ;
         }
         if ( sdt.IsDirty("BR_Encounter_DischargeStatus_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_Insurance") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_insurance = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance ;
         }
         if ( sdt.IsDirty("BR_Encounter_Insurance_Code") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_code = sdt.gxTv_SdtBR_Encounter_Br_encounter_insurance_code ;
         }
         if ( sdt.IsDirty("BR_Encounter_Status") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_status = sdt.gxTv_SdtBR_Encounter_Br_encounter_status ;
         }
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtBR_Encounter_Br_information_id = sdt.gxTv_SdtBR_Encounter_Br_information_id ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Encounter_Br_information_patientno = sdt.gxTv_SdtBR_Encounter_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BAS_TenantTenantCode") )
         {
            gxTv_SdtBR_Encounter_Bas_tenanttenantcode = sdt.gxTv_SdtBR_Encounter_Bas_tenanttenantcode ;
         }
         if ( sdt.IsDirty("BR_Encounter_CrtDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_crtdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_UpdDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_upddate = sdt.gxTv_SdtBR_Encounter_Br_encounter_upddate ;
         }
         if ( sdt.IsDirty("BR_Encounter_CrtUser") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_crtuser = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtuser ;
         }
         if ( sdt.IsDirty("BR_Encounter_CrtDisplayName") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname = sdt.gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname ;
         }
         if ( sdt.IsDirty("BR_Encounter_UpdUser") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_upduser = sdt.gxTv_SdtBR_Encounter_Br_encounter_upduser ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsDLT") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_isdlt = sdt.gxTv_SdtBR_Encounter_Br_encounter_isdlt ;
         }
         if ( sdt.IsDirty("BR_Encounter_SubmitUser") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_submituser = sdt.gxTv_SdtBR_Encounter_Br_encounter_submituser ;
         }
         if ( sdt.IsDirty("BR_Encounter_Reason") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_reason = sdt.gxTv_SdtBR_Encounter_Br_encounter_reason ;
         }
         if ( sdt.IsDirty("BR_Encounter_SubmitDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_submitdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_submitdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_RecheckUser") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_recheckuser = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckuser ;
         }
         if ( sdt.IsDirty("BR_Encounter_FReason") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_freason = sdt.gxTv_SdtBR_Encounter_Br_encounter_freason ;
         }
         if ( sdt.IsDirty("BR_Encounter_RecheckDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_recheckdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_Approver") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_approver = sdt.gxTv_SdtBR_Encounter_Br_encounter_approver ;
         }
         if ( sdt.IsDirty("BR_Encounter_ApproveDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_approvedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_approvedate ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandApprove") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprove = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprove ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandApprover") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprover = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprover ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandNoApprover") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandApproveDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandNoApproveDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandRecheck") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheck = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheck ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandRecheckr") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandNoRecheckr") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandRecheckDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsRandNoRecheckDate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_IsUpdate") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_isupdate = sdt.gxTv_SdtBR_Encounter_Br_encounter_isupdate ;
         }
         if ( sdt.IsDirty("BR_Encounter_Datasource") )
         {
            gxTv_SdtBR_Encounter_Br_encounter_datasource = sdt.gxTv_SdtBR_Encounter_Br_encounter_datasource ;
         }
         if ( sdt.IsDirty("EncounterIDEncrypt") )
         {
            gxTv_SdtBR_Encounter_Encounteridencrypt = sdt.gxTv_SdtBR_Encounter_Encounteridencrypt ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounterid ;
         }

         set {
            if ( gxTv_SdtBR_Encounter_Br_encounterid != value )
            {
               gxTv_SdtBR_Encounter_Mode = "INS";
               this.gxTv_SdtBR_Encounter_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_encid_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_department_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_department_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_enctype_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_insurance_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_status_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_upddate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_upduser_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_submituser_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_reason_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_freason_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_approver_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Br_encounter_datasource_Z_SetNull( );
               this.gxTv_SdtBR_Encounter_Encounteridencrypt_Z_SetNull( );
            }
            gxTv_SdtBR_Encounter_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Encounter_EncID" )]
      [  XmlElement( ElementName = "BR_Encounter_EncID"   )]
      public long gxTpr_Br_encounter_encid
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_encid ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_encid_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_encid = value;
            SetDirty("Br_encounter_encid");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_encid_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_encid_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_encid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_encid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department" )]
      [  XmlElement( ElementName = "BR_Encounter_Department"   )]
      public String gxTpr_Br_encounter_department
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_department = value;
            SetDirty("Br_encounter_department");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_department = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_Department_Code"   )]
      public String gxTpr_Br_encounter_department_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_department_code = value;
            SetDirty("Br_encounter_department_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_department_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm"   )]
      public String gxTpr_Br_encounter_departmentadm
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm = value;
            SetDirty("Br_encounter_departmentadm");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm_Code"   )]
      public String gxTpr_Br_encounter_departmentadm_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code = value;
            SetDirty("Br_encounter_departmentadm_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch"   )]
      public String gxTpr_Br_encounter_departmentdisch
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch = value;
            SetDirty("Br_encounter_departmentdisch");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch_Code"   )]
      public String gxTpr_Br_encounter_departmentdisch_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code = value;
            SetDirty("Br_encounter_departmentdisch_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType"   )]
      public String gxTpr_Br_encounter_enctype
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_enctype = value;
            SetDirty("Br_encounter_enctype");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_enctype = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType_Code"   )]
      public String gxTpr_Br_encounter_enctype_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_enctype_code = value;
            SetDirty("Br_encounter_enctype_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitDate" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_admitdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_admitdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Encounter_Br_encounter_admitdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_admitdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_admitdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_admitdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_admitdate = value;
            SetDirty("Br_encounter_admitdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_admitdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource"   )]
      public String gxTpr_Br_encounter_admitsource
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_admitsource = value;
            SetDirty("Br_encounter_admitsource");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource_Code"   )]
      public String gxTpr_Br_encounter_admitsource_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_code = value;
            SetDirty("Br_encounter_admitsource_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeDate" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_dischargedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_dischargedate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Encounter_Br_encounter_dischargedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_dischargedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_dischargedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_dischargedate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargedate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate = value;
            SetDirty("Br_encounter_dischargedate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus"   )]
      public String gxTpr_Br_encounter_dischargestatus
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus = value;
            SetDirty("Br_encounter_dischargestatus");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus_Code"   )]
      public String gxTpr_Br_encounter_dischargestatus_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code = value;
            SetDirty("Br_encounter_dischargestatus_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance"   )]
      public String gxTpr_Br_encounter_insurance
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_insurance = value;
            SetDirty("Br_encounter_insurance");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_insurance = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance_Code" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance_Code"   )]
      public String gxTpr_Br_encounter_insurance_code
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance_code ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_insurance_code = value;
            SetDirty("Br_encounter_insurance_code");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_code_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Status" )]
      [  XmlElement( ElementName = "BR_Encounter_Status"   )]
      public short gxTpr_Br_encounter_status
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_status ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_status_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_status = value;
            SetDirty("Br_encounter_status");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_status_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_status_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_status = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_status_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_id ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_id_N = 0;
            gxTv_SdtBR_Encounter_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_id_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_id_N = 1;
         gxTv_SdtBR_Encounter_Br_information_id = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_id_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_patientno_N = 0;
            gxTv_SdtBR_Encounter_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_patientno_N = 1;
         gxTv_SdtBR_Encounter_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode"   )]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return gxTv_SdtBR_Encounter_Bas_tenanttenantcode ;
         }

         set {
            gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N = 0;
            gxTv_SdtBR_Encounter_Bas_tenanttenantcode = value;
            SetDirty("Bas_tenanttenantcode");
         }

      }

      public void gxTv_SdtBR_Encounter_Bas_tenanttenantcode_SetNull( )
      {
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N = 1;
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Bas_tenanttenantcode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDate" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_crtdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_crtdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_crtdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_crtdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_crtdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_crtdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_crtdate = value;
            SetDirty("Br_encounter_crtdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_crtdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdDate" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_upddate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_upddate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_upddate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upddate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_upddate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_upddate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_upddate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upddate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upddate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_upddate = value;
            SetDirty("Br_encounter_upddate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upddate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upddate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_upddate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upddate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtUser" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtUser"   )]
      public String gxTpr_Br_encounter_crtuser
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtuser ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtuser_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_crtuser = value;
            SetDirty("Br_encounter_crtuser");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtuser_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_crtuser = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtuser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDisplayName" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDisplayName"   )]
      public String gxTpr_Br_encounter_crtdisplayname
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname = value;
            SetDirty("Br_encounter_crtdisplayname");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdUser" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdUser"   )]
      public String gxTpr_Br_encounter_upduser
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upduser ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upduser_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_upduser = value;
            SetDirty("Br_encounter_upduser");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upduser_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upduser_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_upduser = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upduser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsDLT" )]
      [  XmlElement( ElementName = "BR_Encounter_IsDLT"   )]
      public bool gxTpr_Br_encounter_isdlt
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isdlt ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isdlt_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_isdlt = value;
            SetDirty("Br_encounter_isdlt");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isdlt_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isdlt_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_isdlt = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isdlt_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitUser" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitUser"   )]
      public String gxTpr_Br_encounter_submituser
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submituser ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submituser_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_submituser = value;
            SetDirty("Br_encounter_submituser");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submituser_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submituser_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_submituser = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submituser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Reason" )]
      [  XmlElement( ElementName = "BR_Encounter_Reason"   )]
      public String gxTpr_Br_encounter_reason
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_reason ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_reason_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_reason = value;
            SetDirty("Br_encounter_reason");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_reason_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_reason_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_reason = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_reason_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitDate" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_submitdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_submitdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_submitdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_submitdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_submitdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_submitdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submitdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_submitdate = value;
            SetDirty("Br_encounter_submitdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submitdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_submitdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submitdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckUser" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckUser"   )]
      public String gxTpr_Br_encounter_recheckuser
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckuser ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_recheckuser = value;
            SetDirty("Br_encounter_recheckuser");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckuser_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckuser_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_FReason" )]
      [  XmlElement( ElementName = "BR_Encounter_FReason"   )]
      public String gxTpr_Br_encounter_freason
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_freason ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_freason_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_freason = value;
            SetDirty("Br_encounter_freason");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_freason_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_freason_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_freason = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_freason_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckDate" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_recheckdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_recheckdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_recheckdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_recheckdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_recheckdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_recheckdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate = value;
            SetDirty("Br_encounter_recheckdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Approver" )]
      [  XmlElement( ElementName = "BR_Encounter_Approver"   )]
      public String gxTpr_Br_encounter_approver
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approver ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approver_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_approver = value;
            SetDirty("Br_encounter_approver");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approver_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approver_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_approver = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approver_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ApproveDate" )]
      [  XmlElement( ElementName = "BR_Encounter_ApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_approvedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_approvedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_approvedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_approvedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_approvedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_approvedate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approvedate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_approvedate = value;
            SetDirty("Br_encounter_approvedate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approvedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_approvedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approvedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprove" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprove"   )]
      public bool gxTpr_Br_encounter_israndapprove
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprove ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndapprove = value;
            SetDirty("Br_encounter_israndapprove");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprove_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprove_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprover" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprover"   )]
      public String gxTpr_Br_encounter_israndapprover
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprover ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndapprover = value;
            SetDirty("Br_encounter_israndapprover");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprover_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprover_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApprover" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApprover"   )]
      public String gxTpr_Br_encounter_israndnoapprover
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover = value;
            SetDirty("Br_encounter_israndnoapprover");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApproveDate" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndapprovedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndapprovedate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = value;
            SetDirty("Br_encounter_israndapprovedate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApproveDate" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApproveDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndnoapprovedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndnoapprovedate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = value;
            SetDirty("Br_encounter_israndnoapprovedate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheck" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheck"   )]
      public bool gxTpr_Br_encounter_israndrecheck
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheck ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheck = value;
            SetDirty("Br_encounter_israndrecheck");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckr" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckr"   )]
      public String gxTpr_Br_encounter_israndrecheckr
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr = value;
            SetDirty("Br_encounter_israndrecheckr");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckr" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckr"   )]
      public String gxTpr_Br_encounter_israndnorecheckr
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr = value;
            SetDirty("Br_encounter_israndnorecheckr");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckDate" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndrecheckdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndrecheckdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = value;
            SetDirty("Br_encounter_israndrecheckdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckDate" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckDate"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndnorecheckdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate).value ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndnorecheckdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = value;
            SetDirty("Br_encounter_israndnorecheckdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsUpdate" )]
      [  XmlElement( ElementName = "BR_Encounter_IsUpdate"   )]
      public bool gxTpr_Br_encounter_isupdate
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isupdate ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isupdate_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_isupdate = value;
            SetDirty("Br_encounter_isupdate");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isupdate_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isupdate_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_isupdate = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isupdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Datasource" )]
      [  XmlElement( ElementName = "BR_Encounter_Datasource"   )]
      public short gxTpr_Br_encounter_datasource
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_datasource ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_datasource_N = 0;
            gxTv_SdtBR_Encounter_Br_encounter_datasource = value;
            SetDirty("Br_encounter_datasource");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_datasource_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_datasource_N = 1;
         gxTv_SdtBR_Encounter_Br_encounter_datasource = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_datasource_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EncounterIDEncrypt" )]
      [  XmlElement( ElementName = "EncounterIDEncrypt"   )]
      public String gxTpr_Encounteridencrypt
      {
         get {
            return gxTv_SdtBR_Encounter_Encounteridencrypt ;
         }

         set {
            gxTv_SdtBR_Encounter_Encounteridencrypt_N = 0;
            gxTv_SdtBR_Encounter_Encounteridencrypt = value;
            SetDirty("Encounteridencrypt");
         }

      }

      public void gxTv_SdtBR_Encounter_Encounteridencrypt_SetNull( )
      {
         gxTv_SdtBR_Encounter_Encounteridencrypt_N = 1;
         gxTv_SdtBR_Encounter_Encounteridencrypt = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Encounteridencrypt_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Encounter_Mode ;
         }

         set {
            gxTv_SdtBR_Encounter_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Encounter_Mode_SetNull( )
      {
         gxTv_SdtBR_Encounter_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Encounter_Initialized ;
         }

         set {
            gxTv_SdtBR_Encounter_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Encounter_Initialized_SetNull( )
      {
         gxTv_SdtBR_Encounter_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_EncID_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_EncID_Z"   )]
      public long gxTpr_Br_encounter_encid_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_encid_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_encid_Z = value;
            SetDirty("Br_encounter_encid_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_encid_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_encid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_encid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Department_Z"   )]
      public String gxTpr_Br_encounter_department_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_Z = value;
            SetDirty("Br_encounter_department_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Department_Code_Z"   )]
      public String gxTpr_Br_encounter_department_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_code_Z = value;
            SetDirty("Br_encounter_department_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm_Z"   )]
      public String gxTpr_Br_encounter_departmentadm_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z = value;
            SetDirty("Br_encounter_departmentadm_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm_Code_Z"   )]
      public String gxTpr_Br_encounter_departmentadm_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z = value;
            SetDirty("Br_encounter_departmentadm_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch_Z"   )]
      public String gxTpr_Br_encounter_departmentdisch_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z = value;
            SetDirty("Br_encounter_departmentdisch_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch_Code_Z"   )]
      public String gxTpr_Br_encounter_departmentdisch_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z = value;
            SetDirty("Br_encounter_departmentdisch_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType_Z"   )]
      public String gxTpr_Br_encounter_enctype_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_Z = value;
            SetDirty("Br_encounter_enctype_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType_Code_Z"   )]
      public String gxTpr_Br_encounter_enctype_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z = value;
            SetDirty("Br_encounter_enctype_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_admitdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_admitdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = value;
            SetDirty("Br_encounter_admitdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource_Z"   )]
      public String gxTpr_Br_encounter_admitsource_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z = value;
            SetDirty("Br_encounter_admitsource_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource_Code_Z"   )]
      public String gxTpr_Br_encounter_admitsource_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z = value;
            SetDirty("Br_encounter_admitsource_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_dischargedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_dischargedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = value;
            SetDirty("Br_encounter_dischargedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus_Z"   )]
      public String gxTpr_Br_encounter_dischargestatus_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z = value;
            SetDirty("Br_encounter_dischargestatus_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus_Code_Z"   )]
      public String gxTpr_Br_encounter_dischargestatus_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z = value;
            SetDirty("Br_encounter_dischargestatus_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance_Z"   )]
      public String gxTpr_Br_encounter_insurance_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_Z = value;
            SetDirty("Br_encounter_insurance_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance_Code_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance_Code_Z"   )]
      public String gxTpr_Br_encounter_insurance_code_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z = value;
            SetDirty("Br_encounter_insurance_code_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Status_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Status_Z"   )]
      public short gxTpr_Br_encounter_status_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_status_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_status_Z = value;
            SetDirty("Br_encounter_status_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_status_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_status_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_status_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_id_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_Z" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_Z"   )]
      public String gxTpr_Bas_tenanttenantcode_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z = value;
            SetDirty("Bas_tenanttenantcode_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_crtdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_crtdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = value;
            SetDirty("Br_encounter_crtdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_upddate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_upddate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_upddate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_upddate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upddate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = value;
            SetDirty("Br_encounter_upddate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upddate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upddate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtUser_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtUser_Z"   )]
      public String gxTpr_Br_encounter_crtuser_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z = value;
            SetDirty("Br_encounter_crtuser_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDisplayName_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDisplayName_Z"   )]
      public String gxTpr_Br_encounter_crtdisplayname_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z = value;
            SetDirty("Br_encounter_crtdisplayname_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdUser_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdUser_Z"   )]
      public String gxTpr_Br_encounter_upduser_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upduser_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upduser_Z = value;
            SetDirty("Br_encounter_upduser_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upduser_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upduser_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upduser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsDLT_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsDLT_Z"   )]
      public bool gxTpr_Br_encounter_isdlt_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z = value;
            SetDirty("Br_encounter_isdlt_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitUser_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitUser_Z"   )]
      public String gxTpr_Br_encounter_submituser_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submituser_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submituser_Z = value;
            SetDirty("Br_encounter_submituser_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submituser_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submituser_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submituser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Reason_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Reason_Z"   )]
      public String gxTpr_Br_encounter_reason_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_reason_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_reason_Z = value;
            SetDirty("Br_encounter_reason_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_reason_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_reason_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_reason_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_submitdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_submitdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = value;
            SetDirty("Br_encounter_submitdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckUser_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckUser_Z"   )]
      public String gxTpr_Br_encounter_recheckuser_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z = value;
            SetDirty("Br_encounter_recheckuser_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_FReason_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_FReason_Z"   )]
      public String gxTpr_Br_encounter_freason_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_freason_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_freason_Z = value;
            SetDirty("Br_encounter_freason_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_freason_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_freason_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_freason_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_recheckdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_recheckdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = value;
            SetDirty("Br_encounter_recheckdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Approver_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Approver_Z"   )]
      public String gxTpr_Br_encounter_approver_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approver_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approver_Z = value;
            SetDirty("Br_encounter_approver_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approver_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approver_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approver_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_ApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_approvedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_approvedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = value;
            SetDirty("Br_encounter_approvedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprove_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprove_Z"   )]
      public bool gxTpr_Br_encounter_israndapprove_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z = value;
            SetDirty("Br_encounter_israndapprove_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprover_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprover_Z"   )]
      public String gxTpr_Br_encounter_israndapprover_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z = value;
            SetDirty("Br_encounter_israndapprover_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApprover_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApprover_Z"   )]
      public String gxTpr_Br_encounter_israndnoapprover_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z = value;
            SetDirty("Br_encounter_israndnoapprover_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndapprovedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndapprovedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = value;
            SetDirty("Br_encounter_israndapprovedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApproveDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApproveDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndnoapprovedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndnoapprovedate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = value;
            SetDirty("Br_encounter_israndnoapprovedate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheck_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheck_Z"   )]
      public bool gxTpr_Br_encounter_israndrecheck_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z = value;
            SetDirty("Br_encounter_israndrecheck_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckr_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckr_Z"   )]
      public String gxTpr_Br_encounter_israndrecheckr_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z = value;
            SetDirty("Br_encounter_israndrecheckr_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckr_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckr_Z"   )]
      public String gxTpr_Br_encounter_israndnorecheckr_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z = value;
            SetDirty("Br_encounter_israndnorecheckr_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndrecheckdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndrecheckdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = value;
            SetDirty("Br_encounter_israndrecheckdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckDate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_encounter_israndnorecheckdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z == DateTime.MinValue)
               return null;
            return new GxDatetimeString(gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDatetimeString.NullValue )
               gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_encounter_israndnorecheckdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = value;
            SetDirty("Br_encounter_israndnorecheckdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsUpdate_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_IsUpdate_Z"   )]
      public bool gxTpr_Br_encounter_isupdate_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z = value;
            SetDirty("Br_encounter_isupdate_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z = false;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Datasource_Z" )]
      [  XmlElement( ElementName = "BR_Encounter_Datasource_Z"   )]
      public short gxTpr_Br_encounter_datasource_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_datasource_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_datasource_Z = value;
            SetDirty("Br_encounter_datasource_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_datasource_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_datasource_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_datasource_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EncounterIDEncrypt_Z" )]
      [  XmlElement( ElementName = "EncounterIDEncrypt_Z"   )]
      public String gxTpr_Encounteridencrypt_Z
      {
         get {
            return gxTv_SdtBR_Encounter_Encounteridencrypt_Z ;
         }

         set {
            gxTv_SdtBR_Encounter_Encounteridencrypt_Z = value;
            SetDirty("Encounteridencrypt_Z");
         }

      }

      public void gxTv_SdtBR_Encounter_Encounteridencrypt_Z_SetNull( )
      {
         gxTv_SdtBR_Encounter_Encounteridencrypt_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Encounteridencrypt_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_N" )]
      [  XmlElement( ElementName = "BR_EncounterID_N"   )]
      public short gxTpr_Br_encounterid_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounterid_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounterid_N = value;
            SetDirty("Br_encounterid_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounterid_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounterid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounterid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_EncID_N" )]
      [  XmlElement( ElementName = "BR_Encounter_EncID_N"   )]
      public short gxTpr_Br_encounter_encid_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_encid_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_encid_N = value;
            SetDirty("Br_encounter_encid_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_encid_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_encid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_encid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Department_N"   )]
      public short gxTpr_Br_encounter_department_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_N = value;
            SetDirty("Br_encounter_department_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Department_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Department_Code_N"   )]
      public short gxTpr_Br_encounter_department_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_department_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_department_code_N = value;
            SetDirty("Br_encounter_department_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_department_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_department_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm_N"   )]
      public short gxTpr_Br_encounter_departmentadm_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N = value;
            SetDirty("Br_encounter_departmentadm_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentadm_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentadm_Code_N"   )]
      public short gxTpr_Br_encounter_departmentadm_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N = value;
            SetDirty("Br_encounter_departmentadm_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch_N"   )]
      public short gxTpr_Br_encounter_departmentdisch_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N = value;
            SetDirty("Br_encounter_departmentdisch_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Departmentdisch_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Departmentdisch_Code_N"   )]
      public short gxTpr_Br_encounter_departmentdisch_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N = value;
            SetDirty("Br_encounter_departmentdisch_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType_N" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType_N"   )]
      public short gxTpr_Br_encounter_enctype_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_N = value;
            SetDirty("Br_encounter_enctype_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ENCType_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_ENCType_Code_N"   )]
      public short gxTpr_Br_encounter_enctype_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N = value;
            SetDirty("Br_encounter_enctype_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitDate_N"   )]
      public short gxTpr_Br_encounter_admitdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = value;
            SetDirty("Br_encounter_admitdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource_N" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource_N"   )]
      public short gxTpr_Br_encounter_admitsource_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_N = value;
            SetDirty("Br_encounter_admitsource_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_AdmitSource_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_AdmitSource_Code_N"   )]
      public short gxTpr_Br_encounter_admitsource_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N = value;
            SetDirty("Br_encounter_admitsource_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeDate_N"   )]
      public short gxTpr_Br_encounter_dischargedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = value;
            SetDirty("Br_encounter_dischargedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus_N" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus_N"   )]
      public short gxTpr_Br_encounter_dischargestatus_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N = value;
            SetDirty("Br_encounter_dischargestatus_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_DischargeStatus_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_DischargeStatus_Code_N"   )]
      public short gxTpr_Br_encounter_dischargestatus_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N = value;
            SetDirty("Br_encounter_dischargestatus_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance_N"   )]
      public short gxTpr_Br_encounter_insurance_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_N = value;
            SetDirty("Br_encounter_insurance_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Insurance_Code_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Insurance_Code_N"   )]
      public short gxTpr_Br_encounter_insurance_code_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N = value;
            SetDirty("Br_encounter_insurance_code_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Status_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Status_N"   )]
      public short gxTpr_Br_encounter_status_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_status_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_status_N = value;
            SetDirty("Br_encounter_status_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_status_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_status_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_status_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_N" )]
      [  XmlElement( ElementName = "BR_Information_ID_N"   )]
      public short gxTpr_Br_information_id_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_id_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_id_N = value;
            SetDirty("Br_information_id_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_id_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_id_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_id_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_N" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_N"   )]
      public short gxTpr_Bas_tenanttenantcode_N
      {
         get {
            return gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N = value;
            SetDirty("Bas_tenanttenantcode_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDate_N"   )]
      public short gxTpr_Br_encounter_crtdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = value;
            SetDirty("Br_encounter_crtdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdDate_N"   )]
      public short gxTpr_Br_encounter_upddate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upddate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upddate_N = value;
            SetDirty("Br_encounter_upddate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upddate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upddate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upddate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtUser_N" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtUser_N"   )]
      public short gxTpr_Br_encounter_crtuser_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtuser_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtuser_N = value;
            SetDirty("Br_encounter_crtuser_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtuser_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtuser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_CrtDisplayName_N" )]
      [  XmlElement( ElementName = "BR_Encounter_CrtDisplayName_N"   )]
      public short gxTpr_Br_encounter_crtdisplayname_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N = value;
            SetDirty("Br_encounter_crtdisplayname_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_UpdUser_N" )]
      [  XmlElement( ElementName = "BR_Encounter_UpdUser_N"   )]
      public short gxTpr_Br_encounter_upduser_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_upduser_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_upduser_N = value;
            SetDirty("Br_encounter_upduser_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_upduser_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_upduser_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_upduser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsDLT_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsDLT_N"   )]
      public short gxTpr_Br_encounter_isdlt_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isdlt_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isdlt_N = value;
            SetDirty("Br_encounter_isdlt_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isdlt_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isdlt_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isdlt_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitUser_N" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitUser_N"   )]
      public short gxTpr_Br_encounter_submituser_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submituser_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submituser_N = value;
            SetDirty("Br_encounter_submituser_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submituser_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submituser_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submituser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Reason_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Reason_N"   )]
      public short gxTpr_Br_encounter_reason_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_reason_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_reason_N = value;
            SetDirty("Br_encounter_reason_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_reason_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_reason_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_reason_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_SubmitDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_SubmitDate_N"   )]
      public short gxTpr_Br_encounter_submitdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_submitdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = value;
            SetDirty("Br_encounter_submitdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_submitdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_submitdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckUser_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckUser_N"   )]
      public short gxTpr_Br_encounter_recheckuser_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N = value;
            SetDirty("Br_encounter_recheckuser_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_FReason_N" )]
      [  XmlElement( ElementName = "BR_Encounter_FReason_N"   )]
      public short gxTpr_Br_encounter_freason_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_freason_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_freason_N = value;
            SetDirty("Br_encounter_freason_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_freason_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_freason_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_freason_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_RecheckDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_RecheckDate_N"   )]
      public short gxTpr_Br_encounter_recheckdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = value;
            SetDirty("Br_encounter_recheckdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Approver_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Approver_N"   )]
      public short gxTpr_Br_encounter_approver_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approver_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approver_N = value;
            SetDirty("Br_encounter_approver_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approver_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approver_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approver_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_ApproveDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_ApproveDate_N"   )]
      public short gxTpr_Br_encounter_approvedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_approvedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = value;
            SetDirty("Br_encounter_approvedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_approvedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_approvedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprove_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprove_N"   )]
      public short gxTpr_Br_encounter_israndapprove_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N = value;
            SetDirty("Br_encounter_israndapprove_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApprover_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApprover_N"   )]
      public short gxTpr_Br_encounter_israndapprover_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N = value;
            SetDirty("Br_encounter_israndapprover_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApprover_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApprover_N"   )]
      public short gxTpr_Br_encounter_israndnoapprover_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N = value;
            SetDirty("Br_encounter_israndnoapprover_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandApproveDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandApproveDate_N"   )]
      public short gxTpr_Br_encounter_israndapprovedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = value;
            SetDirty("Br_encounter_israndapprovedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoApproveDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoApproveDate_N"   )]
      public short gxTpr_Br_encounter_israndnoapprovedate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = value;
            SetDirty("Br_encounter_israndnoapprovedate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheck_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheck_N"   )]
      public short gxTpr_Br_encounter_israndrecheck_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N = value;
            SetDirty("Br_encounter_israndrecheck_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckr_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckr_N"   )]
      public short gxTpr_Br_encounter_israndrecheckr_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N = value;
            SetDirty("Br_encounter_israndrecheckr_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckr_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckr_N"   )]
      public short gxTpr_Br_encounter_israndnorecheckr_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N = value;
            SetDirty("Br_encounter_israndnorecheckr_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandRecheckDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandRecheckDate_N"   )]
      public short gxTpr_Br_encounter_israndrecheckdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = value;
            SetDirty("Br_encounter_israndrecheckdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsRandNoRecheckDate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsRandNoRecheckDate_N"   )]
      public short gxTpr_Br_encounter_israndnorecheckdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = value;
            SetDirty("Br_encounter_israndnorecheckdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_IsUpdate_N" )]
      [  XmlElement( ElementName = "BR_Encounter_IsUpdate_N"   )]
      public short gxTpr_Br_encounter_isupdate_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_isupdate_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_isupdate_N = value;
            SetDirty("Br_encounter_isupdate_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_isupdate_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_isupdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_isupdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Encounter_Datasource_N" )]
      [  XmlElement( ElementName = "BR_Encounter_Datasource_N"   )]
      public short gxTpr_Br_encounter_datasource_N
      {
         get {
            return gxTv_SdtBR_Encounter_Br_encounter_datasource_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Br_encounter_datasource_N = value;
            SetDirty("Br_encounter_datasource_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Br_encounter_datasource_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_datasource_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Br_encounter_datasource_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "EncounterIDEncrypt_N" )]
      [  XmlElement( ElementName = "EncounterIDEncrypt_N"   )]
      public short gxTpr_Encounteridencrypt_N
      {
         get {
            return gxTv_SdtBR_Encounter_Encounteridencrypt_N ;
         }

         set {
            gxTv_SdtBR_Encounter_Encounteridencrypt_N = value;
            SetDirty("Encounteridencrypt_N");
         }

      }

      public void gxTv_SdtBR_Encounter_Encounteridencrypt_N_SetNull( )
      {
         gxTv_SdtBR_Encounter_Encounteridencrypt_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Encounter_Encounteridencrypt_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Encounter_Br_encounter_department = "";
         gxTv_SdtBR_Encounter_Br_encounter_department_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_enctype = "";
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_admitdate = DateTime.MinValue;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource = "";
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate = DateTime.MinValue;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus = "";
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code = "";
         gxTv_SdtBR_Encounter_Br_encounter_insurance = "";
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code = "";
         gxTv_SdtBR_Encounter_Br_information_patientno = "";
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode = "";
         gxTv_SdtBR_Encounter_Br_encounter_crtdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_upddate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_crtuser = "";
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname = "";
         gxTv_SdtBR_Encounter_Br_encounter_upduser = "";
         gxTv_SdtBR_Encounter_Br_encounter_submituser = "";
         gxTv_SdtBR_Encounter_Br_encounter_reason = "";
         gxTv_SdtBR_Encounter_Br_encounter_submitdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser = "";
         gxTv_SdtBR_Encounter_Br_encounter_freason = "";
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_approver = "";
         gxTv_SdtBR_Encounter_Br_encounter_approvedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Encounteridencrypt = "";
         gxTv_SdtBR_Encounter_Mode = "";
         gxTv_SdtBR_Encounter_Br_encounter_department_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_department_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_enctype_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z = DateTime.MinValue;
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z = DateTime.MinValue;
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_insurance_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z = "";
         gxTv_SdtBR_Encounter_Br_information_patientno_Z = "";
         gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_upddate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_upduser_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_submituser_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_reason_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_freason_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_approver_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z = "";
         gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z = (DateTime)(DateTime.MinValue);
         gxTv_SdtBR_Encounter_Encounteridencrypt_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         datetime_STZ = (DateTime)(DateTime.MinValue);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_encounter", "GeneXus.Programs.br_encounter_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Encounter_Br_encounter_status ;
      private short gxTv_SdtBR_Encounter_Br_encounter_datasource ;
      private short gxTv_SdtBR_Encounter_Initialized ;
      private short gxTv_SdtBR_Encounter_Br_encounter_status_Z ;
      private short gxTv_SdtBR_Encounter_Br_encounter_datasource_Z ;
      private short gxTv_SdtBR_Encounter_Br_encounterid_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_encid_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_department_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_department_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_departmentadm_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_enctype_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_enctype_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_admitdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_admitsource_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_dischargedate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_insurance_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_insurance_code_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_status_N ;
      private short gxTv_SdtBR_Encounter_Br_information_id_N ;
      private short gxTv_SdtBR_Encounter_Br_information_patientno_N ;
      private short gxTv_SdtBR_Encounter_Bas_tenanttenantcode_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_crtdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_upddate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_crtuser_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_upduser_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_isdlt_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_submituser_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_reason_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_submitdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_recheckuser_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_freason_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_recheckdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_approver_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_approvedate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndapprove_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndapprover_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_isupdate_N ;
      private short gxTv_SdtBR_Encounter_Br_encounter_datasource_N ;
      private short gxTv_SdtBR_Encounter_Encounteridencrypt_N ;
      private long gxTv_SdtBR_Encounter_Br_encounterid ;
      private long gxTv_SdtBR_Encounter_Br_encounter_encid ;
      private long gxTv_SdtBR_Encounter_Br_information_id ;
      private long gxTv_SdtBR_Encounter_Br_encounterid_Z ;
      private long gxTv_SdtBR_Encounter_Br_encounter_encid_Z ;
      private long gxTv_SdtBR_Encounter_Br_information_id_Z ;
      private String gxTv_SdtBR_Encounter_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_crtdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_upddate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_submitdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_recheckdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_approvedate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_crtdate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_upddate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_submitdate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_recheckdate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_approvedate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndapprovedate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndnoapprovedate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndrecheckdate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckdate_Z ;
      private DateTime datetime_STZ ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_admitdate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_dischargedate ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_admitdate_Z ;
      private DateTime gxTv_SdtBR_Encounter_Br_encounter_dischargedate_Z ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_isdlt ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_israndapprove ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheck ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_isupdate ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_isdlt_Z ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_israndapprove_Z ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_israndrecheck_Z ;
      private bool gxTv_SdtBR_Encounter_Br_encounter_isupdate_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_department ;
      private String gxTv_SdtBR_Encounter_Br_encounter_department_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentadm ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentdisch ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_enctype ;
      private String gxTv_SdtBR_Encounter_Br_encounter_enctype_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_admitsource ;
      private String gxTv_SdtBR_Encounter_Br_encounter_admitsource_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_dischargestatus ;
      private String gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code ;
      private String gxTv_SdtBR_Encounter_Br_encounter_insurance ;
      private String gxTv_SdtBR_Encounter_Br_encounter_insurance_code ;
      private String gxTv_SdtBR_Encounter_Br_information_patientno ;
      private String gxTv_SdtBR_Encounter_Bas_tenanttenantcode ;
      private String gxTv_SdtBR_Encounter_Br_encounter_crtuser ;
      private String gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname ;
      private String gxTv_SdtBR_Encounter_Br_encounter_upduser ;
      private String gxTv_SdtBR_Encounter_Br_encounter_submituser ;
      private String gxTv_SdtBR_Encounter_Br_encounter_reason ;
      private String gxTv_SdtBR_Encounter_Br_encounter_recheckuser ;
      private String gxTv_SdtBR_Encounter_Br_encounter_freason ;
      private String gxTv_SdtBR_Encounter_Br_encounter_approver ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndapprover ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr ;
      private String gxTv_SdtBR_Encounter_Encounteridencrypt ;
      private String gxTv_SdtBR_Encounter_Br_encounter_department_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_department_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentadm_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentadm_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_departmentdisch_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_enctype_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_enctype_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_admitsource_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_admitsource_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_dischargestatus_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_insurance_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_insurance_code_Z ;
      private String gxTv_SdtBR_Encounter_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Encounter_Bas_tenanttenantcode_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_crtuser_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_crtdisplayname_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_upduser_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_submituser_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_reason_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_recheckuser_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_freason_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_approver_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndapprover_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndnoapprover_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndrecheckr_Z ;
      private String gxTv_SdtBR_Encounter_Br_encounter_israndnorecheckr_Z ;
      private String gxTv_SdtBR_Encounter_Encounteridencrypt_Z ;
   }

   [DataContract(Name = @"BR_Encounter", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Encounter_RESTInterface : GxGenericCollectionItem<SdtBR_Encounter>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Encounter_RESTInterface( ) : base()
      {
      }

      public SdtBR_Encounter_RESTInterface( SdtBR_Encounter psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_EncounterID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Encounter_EncID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_encid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounter_encid), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounter_encid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Encounter_Department" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_department
      {
         get {
            return sdt.gxTpr_Br_encounter_department ;
         }

         set {
            sdt.gxTpr_Br_encounter_department = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Department_Code" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_department_code
      {
         get {
            return sdt.gxTpr_Br_encounter_department_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_department_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Departmentadm" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_departmentadm
      {
         get {
            return sdt.gxTpr_Br_encounter_departmentadm ;
         }

         set {
            sdt.gxTpr_Br_encounter_departmentadm = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Departmentadm_Code" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_departmentadm_code
      {
         get {
            return sdt.gxTpr_Br_encounter_departmentadm_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_departmentadm_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Departmentdisch" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_departmentdisch
      {
         get {
            return sdt.gxTpr_Br_encounter_departmentdisch ;
         }

         set {
            sdt.gxTpr_Br_encounter_departmentdisch = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Departmentdisch_Code" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_departmentdisch_code
      {
         get {
            return sdt.gxTpr_Br_encounter_departmentdisch_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_departmentdisch_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_ENCType" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_enctype
      {
         get {
            return sdt.gxTpr_Br_encounter_enctype ;
         }

         set {
            sdt.gxTpr_Br_encounter_enctype = value;
         }

      }

      [DataMember( Name = "BR_Encounter_ENCType_Code" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_enctype_code
      {
         get {
            return sdt.gxTpr_Br_encounter_enctype_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_enctype_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_AdmitDate" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_admitdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_encounter_admitdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_admitdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_AdmitSource" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_admitsource
      {
         get {
            return sdt.gxTpr_Br_encounter_admitsource ;
         }

         set {
            sdt.gxTpr_Br_encounter_admitsource = value;
         }

      }

      [DataMember( Name = "BR_Encounter_AdmitSource_Code" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_admitsource_code
      {
         get {
            return sdt.gxTpr_Br_encounter_admitsource_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_admitsource_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_DischargeDate" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_dischargedate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_encounter_dischargedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_dischargedate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_DischargeStatus" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_dischargestatus
      {
         get {
            return sdt.gxTpr_Br_encounter_dischargestatus ;
         }

         set {
            sdt.gxTpr_Br_encounter_dischargestatus = value;
         }

      }

      [DataMember( Name = "BR_Encounter_DischargeStatus_Code" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_dischargestatus_code
      {
         get {
            return sdt.gxTpr_Br_encounter_dischargestatus_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_dischargestatus_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Insurance" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_insurance
      {
         get {
            return sdt.gxTpr_Br_encounter_insurance ;
         }

         set {
            sdt.gxTpr_Br_encounter_insurance = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Insurance_Code" , Order = 17 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_insurance_code
      {
         get {
            return sdt.gxTpr_Br_encounter_insurance_code ;
         }

         set {
            sdt.gxTpr_Br_encounter_insurance_code = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Status" , Order = 18 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_encounter_status
      {
         get {
            return sdt.gxTpr_Br_encounter_status ;
         }

         set {
            sdt.gxTpr_Br_encounter_status = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_Information_ID" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_information_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_information_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_information_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 20 )]
      [GxSeudo()]
      public String gxTpr_Br_information_patientno
      {
         get {
            return sdt.gxTpr_Br_information_patientno ;
         }

         set {
            sdt.gxTpr_Br_information_patientno = value;
         }

      }

      [DataMember( Name = "BAS_TenantTenantCode" , Order = 21 )]
      [GxSeudo()]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return sdt.gxTpr_Bas_tenanttenantcode ;
         }

         set {
            sdt.gxTpr_Bas_tenanttenantcode = value;
         }

      }

      [DataMember( Name = "BR_Encounter_CrtDate" , Order = 22 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_crtdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_crtdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_crtdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_UpdDate" , Order = 23 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_upddate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_upddate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_upddate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_CrtUser" , Order = 24 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_crtuser
      {
         get {
            return sdt.gxTpr_Br_encounter_crtuser ;
         }

         set {
            sdt.gxTpr_Br_encounter_crtuser = value;
         }

      }

      [DataMember( Name = "BR_Encounter_CrtDisplayName" , Order = 25 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_crtdisplayname
      {
         get {
            return sdt.gxTpr_Br_encounter_crtdisplayname ;
         }

         set {
            sdt.gxTpr_Br_encounter_crtdisplayname = value;
         }

      }

      [DataMember( Name = "BR_Encounter_UpdUser" , Order = 26 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_upduser
      {
         get {
            return sdt.gxTpr_Br_encounter_upduser ;
         }

         set {
            sdt.gxTpr_Br_encounter_upduser = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsDLT" , Order = 27 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounter_isdlt
      {
         get {
            return sdt.gxTpr_Br_encounter_isdlt ;
         }

         set {
            sdt.gxTpr_Br_encounter_isdlt = value;
         }

      }

      [DataMember( Name = "BR_Encounter_SubmitUser" , Order = 28 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_submituser
      {
         get {
            return sdt.gxTpr_Br_encounter_submituser ;
         }

         set {
            sdt.gxTpr_Br_encounter_submituser = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Reason" , Order = 29 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_reason
      {
         get {
            return sdt.gxTpr_Br_encounter_reason ;
         }

         set {
            sdt.gxTpr_Br_encounter_reason = value;
         }

      }

      [DataMember( Name = "BR_Encounter_SubmitDate" , Order = 30 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_submitdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_submitdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_submitdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_RecheckUser" , Order = 31 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_recheckuser
      {
         get {
            return sdt.gxTpr_Br_encounter_recheckuser ;
         }

         set {
            sdt.gxTpr_Br_encounter_recheckuser = value;
         }

      }

      [DataMember( Name = "BR_Encounter_FReason" , Order = 32 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_freason
      {
         get {
            return sdt.gxTpr_Br_encounter_freason ;
         }

         set {
            sdt.gxTpr_Br_encounter_freason = value;
         }

      }

      [DataMember( Name = "BR_Encounter_RecheckDate" , Order = 33 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_recheckdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_recheckdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_recheckdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_Approver" , Order = 34 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_approver
      {
         get {
            return sdt.gxTpr_Br_encounter_approver ;
         }

         set {
            sdt.gxTpr_Br_encounter_approver = value;
         }

      }

      [DataMember( Name = "BR_Encounter_ApproveDate" , Order = 35 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_approvedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_approvedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_approvedate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandApprove" , Order = 36 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounter_israndapprove
      {
         get {
            return sdt.gxTpr_Br_encounter_israndapprove ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndapprove = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandApprover" , Order = 37 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndapprover
      {
         get {
            return sdt.gxTpr_Br_encounter_israndapprover ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndapprover = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandNoApprover" , Order = 38 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndnoapprover
      {
         get {
            return sdt.gxTpr_Br_encounter_israndnoapprover ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndnoapprover = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandApproveDate" , Order = 39 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndapprovedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_israndapprovedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndapprovedate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandNoApproveDate" , Order = 40 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndnoapprovedate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_israndnoapprovedate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndnoapprovedate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandRecheck" , Order = 41 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounter_israndrecheck
      {
         get {
            return sdt.gxTpr_Br_encounter_israndrecheck ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndrecheck = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandRecheckr" , Order = 42 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndrecheckr
      {
         get {
            return sdt.gxTpr_Br_encounter_israndrecheckr ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndrecheckr = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandNoRecheckr" , Order = 43 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndnorecheckr
      {
         get {
            return sdt.gxTpr_Br_encounter_israndnorecheckr ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndnorecheckr = value;
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandRecheckDate" , Order = 44 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndrecheckdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_israndrecheckdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndrecheckdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_IsRandNoRecheckDate" , Order = 45 )]
      [GxSeudo()]
      public String gxTpr_Br_encounter_israndnorecheckdate
      {
         get {
            return DateTimeUtil.TToC2( sdt.gxTpr_Br_encounter_israndnorecheckdate) ;
         }

         set {
            sdt.gxTpr_Br_encounter_israndnorecheckdate = DateTimeUtil.CToT2( value);
         }

      }

      [DataMember( Name = "BR_Encounter_IsUpdate" , Order = 46 )]
      [GxSeudo()]
      public bool gxTpr_Br_encounter_isupdate
      {
         get {
            return sdt.gxTpr_Br_encounter_isupdate ;
         }

         set {
            sdt.gxTpr_Br_encounter_isupdate = value;
         }

      }

      [DataMember( Name = "BR_Encounter_Datasource" , Order = 47 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_encounter_datasource
      {
         get {
            return sdt.gxTpr_Br_encounter_datasource ;
         }

         set {
            sdt.gxTpr_Br_encounter_datasource = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "EncounterIDEncrypt" , Order = 48 )]
      [GxSeudo()]
      public String gxTpr_Encounteridencrypt
      {
         get {
            return sdt.gxTpr_Encounteridencrypt ;
         }

         set {
            sdt.gxTpr_Encounteridencrypt = value;
         }

      }

      public SdtBR_Encounter sdt
      {
         get {
            return (SdtBR_Encounter)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtBR_Encounter() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 49 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
