/*
               File: type_SdtBR_PatientReTenant
        Description: 患者租户关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:4.2
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
   [XmlRoot(ElementName = "BR_PatientReTenant" )]
   [XmlType(TypeName =  "BR_PatientReTenant" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_PatientReTenant : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_PatientReTenant( )
      {
      }

      public SdtBR_PatientReTenant( IGxContext context )
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

      public void Load( long AV85BR_Information_ID ,
                        String AV360BAS_TenantTenantCode )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV85BR_Information_ID,(String)AV360BAS_TenantTenantCode});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Information_ID", typeof(long)}, new Object[]{"BAS_TenantTenantCode", typeof(String)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_PatientReTenant");
         metadata.Set("BT", "BR_PatientReTenant");
         metadata.Set("PK", "[ \"BR_Information_ID\",\"BAS_TenantTenantCode\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BAS_TenantTenantCode\" ],\"FKMap\":[  ] },{ \"FK\":[ \"BR_Information_ID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Bas_tenanttenantcode_Z");
         state.Add("gxTpr_Br_information_id_N");
         state.Add("gxTpr_Bas_tenanttenantcode_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_PatientReTenant sdt ;
         sdt = (SdtBR_PatientReTenant)(source);
         gxTv_SdtBR_PatientReTenant_Br_information_id = sdt.gxTv_SdtBR_PatientReTenant_Br_information_id ;
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode = sdt.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode ;
         gxTv_SdtBR_PatientReTenant_Mode = sdt.gxTv_SdtBR_PatientReTenant_Mode ;
         gxTv_SdtBR_PatientReTenant_Initialized = sdt.gxTv_SdtBR_PatientReTenant_Initialized ;
         gxTv_SdtBR_PatientReTenant_Br_information_id_Z = sdt.gxTv_SdtBR_PatientReTenant_Br_information_id_Z ;
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z = sdt.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z ;
         gxTv_SdtBR_PatientReTenant_Br_information_id_N = sdt.gxTv_SdtBR_PatientReTenant_Br_information_id_N ;
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N = sdt.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_PatientReTenant_Br_information_id), 18, 0)), false);
         AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_PatientReTenant_Br_information_id_N, false);
         AddObjectProperty("BAS_TenantTenantCode", gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode, false);
         AddObjectProperty("BAS_TenantTenantCode_N", gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_PatientReTenant_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_PatientReTenant_Initialized, false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_PatientReTenant_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("BAS_TenantTenantCode_Z", gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z, false);
            AddObjectProperty("BR_Information_ID_N", gxTv_SdtBR_PatientReTenant_Br_information_id_N, false);
            AddObjectProperty("BAS_TenantTenantCode_N", gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_PatientReTenant sdt )
      {
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtBR_PatientReTenant_Br_information_id = sdt.gxTv_SdtBR_PatientReTenant_Br_information_id ;
         }
         if ( sdt.IsDirty("BAS_TenantTenantCode") )
         {
            gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode = sdt.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Br_information_id ;
         }

         set {
            if ( gxTv_SdtBR_PatientReTenant_Br_information_id != value )
            {
               gxTv_SdtBR_PatientReTenant_Mode = "INS";
               this.gxTv_SdtBR_PatientReTenant_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z_SetNull( );
            }
            gxTv_SdtBR_PatientReTenant_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode"   )]
      public String gxTpr_Bas_tenanttenantcode
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode ;
         }

         set {
            if ( StringUtil.StrCmp(gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode, value) != 0 )
            {
               gxTv_SdtBR_PatientReTenant_Mode = "INS";
               this.gxTv_SdtBR_PatientReTenant_Br_information_id_Z_SetNull( );
               this.gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z_SetNull( );
            }
            gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode = value;
            SetDirty("Bas_tenanttenantcode");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Mode ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Mode_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Initialized ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Initialized_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Br_information_id_Z ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_Z" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_Z"   )]
      public String gxTpr_Bas_tenanttenantcode_Z
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z = value;
            SetDirty("Bas_tenanttenantcode_Z");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_N" )]
      [  XmlElement( ElementName = "BR_Information_ID_N"   )]
      public short gxTpr_Br_information_id_N
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Br_information_id_N ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Br_information_id_N = value;
            SetDirty("Br_information_id_N");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Br_information_id_N_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Br_information_id_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Br_information_id_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BAS_TenantTenantCode_N" )]
      [  XmlElement( ElementName = "BAS_TenantTenantCode_N"   )]
      public short gxTpr_Bas_tenanttenantcode_N
      {
         get {
            return gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N ;
         }

         set {
            gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N = value;
            SetDirty("Bas_tenanttenantcode_N");
         }

      }

      public void gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N_SetNull( )
      {
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode = "";
         gxTv_SdtBR_PatientReTenant_Mode = "";
         gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_patientretenant", "GeneXus.Programs.br_patientretenant_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_PatientReTenant_Initialized ;
      private short gxTv_SdtBR_PatientReTenant_Br_information_id_N ;
      private short gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_N ;
      private long gxTv_SdtBR_PatientReTenant_Br_information_id ;
      private long gxTv_SdtBR_PatientReTenant_Br_information_id_Z ;
      private String gxTv_SdtBR_PatientReTenant_Mode ;
      private String gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode ;
      private String gxTv_SdtBR_PatientReTenant_Bas_tenanttenantcode_Z ;
   }

   [DataContract(Name = @"BR_PatientReTenant", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_PatientReTenant_RESTInterface : GxGenericCollectionItem<SdtBR_PatientReTenant>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_PatientReTenant_RESTInterface( ) : base()
      {
      }

      public SdtBR_PatientReTenant_RESTInterface( SdtBR_PatientReTenant psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Information_ID" , Order = 0 )]
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

      [DataMember( Name = "BAS_TenantTenantCode" , Order = 1 )]
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

      public SdtBR_PatientReTenant sdt
      {
         get {
            return (SdtBR_PatientReTenant)Sdt ;
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
            sdt = new SdtBR_PatientReTenant() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
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
