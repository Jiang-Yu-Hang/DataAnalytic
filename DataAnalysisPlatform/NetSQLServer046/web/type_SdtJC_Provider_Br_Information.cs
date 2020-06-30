/*
               File: type_SdtJC_Provider_Br_Information
        Description: 患者分院表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:13.59
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
   [XmlRoot(ElementName = "JC_Provider_Br_Information" )]
   [XmlType(TypeName =  "JC_Provider_Br_Information" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtJC_Provider_Br_Information : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_Provider_Br_Information( )
      {
      }

      public SdtJC_Provider_Br_Information( IGxContext context )
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

      public void Load( long AV87JC_ProviderID ,
                        long AV85BR_Information_ID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV87JC_ProviderID,(long)AV85BR_Information_ID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"JC_ProviderID", typeof(long)}, new Object[]{"BR_Information_ID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "JC_Provider_Br_Information");
         metadata.Set("BT", "JC_Provider_Br_Information");
         metadata.Set("PK", "[ \"JC_ProviderID\",\"BR_Information_ID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_Information_ID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"JC_ProviderID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Jc_providerid_Z");
         state.Add("gxTpr_Br_information_id_Z");
         state.Add("gxTpr_Jc_providername_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Jc_providername_N");
         state.Add("gxTpr_Br_information_patientno_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtJC_Provider_Br_Information sdt ;
         sdt = (SdtJC_Provider_Br_Information)(source);
         gxTv_SdtJC_Provider_Br_Information_Jc_providerid = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providerid ;
         gxTv_SdtJC_Provider_Br_Information_Br_information_id = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_id ;
         gxTv_SdtJC_Provider_Br_Information_Jc_providername = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providername ;
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno ;
         gxTv_SdtJC_Provider_Br_Information_Mode = sdt.gxTv_SdtJC_Provider_Br_Information_Mode ;
         gxTv_SdtJC_Provider_Br_Information_Initialized = sdt.gxTv_SdtJC_Provider_Br_Information_Initialized ;
         gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z ;
         gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z ;
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z ;
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z ;
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_N = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providername_N ;
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("JC_ProviderID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Br_Information_Jc_providerid), 18, 0)), false);
         AddObjectProperty("BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Br_Information_Br_information_id), 18, 0)), false);
         AddObjectProperty("JC_ProviderName", gxTv_SdtJC_Provider_Br_Information_Jc_providername, false);
         AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_Provider_Br_Information_Jc_providername_N, false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtJC_Provider_Br_Information_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtJC_Provider_Br_Information_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtJC_Provider_Br_Information_Initialized, false);
            AddObjectProperty("JC_ProviderID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z), 18, 0)), false);
            AddObjectProperty("JC_ProviderName_Z", gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z, false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z, false);
            AddObjectProperty("JC_ProviderName_N", gxTv_SdtJC_Provider_Br_Information_Jc_providername_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtJC_Provider_Br_Information sdt )
      {
         if ( sdt.IsDirty("JC_ProviderID") )
         {
            gxTv_SdtJC_Provider_Br_Information_Jc_providerid = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providerid ;
         }
         if ( sdt.IsDirty("BR_Information_ID") )
         {
            gxTv_SdtJC_Provider_Br_Information_Br_information_id = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_id ;
         }
         if ( sdt.IsDirty("JC_ProviderName") )
         {
            gxTv_SdtJC_Provider_Br_Information_Jc_providername = sdt.gxTv_SdtJC_Provider_Br_Information_Jc_providername ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtJC_Provider_Br_Information_Br_information_patientno = sdt.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "JC_ProviderID" )]
      [  XmlElement( ElementName = "JC_ProviderID"   )]
      public long gxTpr_Jc_providerid
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Jc_providerid ;
         }

         set {
            if ( gxTv_SdtJC_Provider_Br_Information_Jc_providerid != value )
            {
               gxTv_SdtJC_Provider_Br_Information_Mode = "INS";
               this.gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z_SetNull( );
            }
            gxTv_SdtJC_Provider_Br_Information_Jc_providerid = value;
            SetDirty("Jc_providerid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_ID" )]
      [  XmlElement( ElementName = "BR_Information_ID"   )]
      public long gxTpr_Br_information_id
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Br_information_id ;
         }

         set {
            if ( gxTv_SdtJC_Provider_Br_Information_Br_information_id != value )
            {
               gxTv_SdtJC_Provider_Br_Information_Mode = "INS";
               this.gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z_SetNull( );
               this.gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z_SetNull( );
            }
            gxTv_SdtJC_Provider_Br_Information_Br_information_id = value;
            SetDirty("Br_information_id");
         }

      }

      [  SoapElement( ElementName = "JC_ProviderName" )]
      [  XmlElement( ElementName = "JC_ProviderName"   )]
      public String gxTpr_Jc_providername
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Jc_providername ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Jc_providername_N = 0;
            gxTv_SdtJC_Provider_Br_Information_Jc_providername = value;
            SetDirty("Jc_providername");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Jc_providername_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_N = 1;
         gxTv_SdtJC_Provider_Br_Information_Jc_providername = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Jc_providername_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Br_information_patientno ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N = 0;
            gxTv_SdtJC_Provider_Br_Information_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N = 1;
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Mode ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Mode_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Mode = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Initialized ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Initialized_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderID_Z" )]
      [  XmlElement( ElementName = "JC_ProviderID_Z"   )]
      public long gxTpr_Jc_providerid_Z
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z = value;
            SetDirty("Jc_providerid_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_ID_Z" )]
      [  XmlElement( ElementName = "BR_Information_ID_Z"   )]
      public long gxTpr_Br_information_id_Z
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z = value;
            SetDirty("Br_information_id_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_Z" )]
      [  XmlElement( ElementName = "JC_ProviderName_Z"   )]
      public String gxTpr_Jc_providername_Z
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z = value;
            SetDirty("Jc_providername_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "JC_ProviderName_N" )]
      [  XmlElement( ElementName = "JC_ProviderName_N"   )]
      public short gxTpr_Jc_providername_N
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Jc_providername_N ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Jc_providername_N = value;
            SetDirty("Jc_providername_N");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Jc_providername_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Jc_providername_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtJC_Provider_Br_Information_Jc_providername = "";
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno = "";
         gxTv_SdtJC_Provider_Br_Information_Mode = "";
         gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z = "";
         gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "jc_provider_br_information", "GeneXus.Programs.jc_provider_br_information_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtJC_Provider_Br_Information_Initialized ;
      private short gxTv_SdtJC_Provider_Br_Information_Jc_providername_N ;
      private short gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_N ;
      private long gxTv_SdtJC_Provider_Br_Information_Jc_providerid ;
      private long gxTv_SdtJC_Provider_Br_Information_Br_information_id ;
      private long gxTv_SdtJC_Provider_Br_Information_Jc_providerid_Z ;
      private long gxTv_SdtJC_Provider_Br_Information_Br_information_id_Z ;
      private String gxTv_SdtJC_Provider_Br_Information_Mode ;
      private String gxTv_SdtJC_Provider_Br_Information_Jc_providername ;
      private String gxTv_SdtJC_Provider_Br_Information_Br_information_patientno ;
      private String gxTv_SdtJC_Provider_Br_Information_Jc_providername_Z ;
      private String gxTv_SdtJC_Provider_Br_Information_Br_information_patientno_Z ;
   }

   [DataContract(Name = @"JC_Provider_Br_Information", Namespace = "DataAnalysisPlatform")]
   public class SdtJC_Provider_Br_Information_RESTInterface : GxGenericCollectionItem<SdtJC_Provider_Br_Information>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtJC_Provider_Br_Information_RESTInterface( ) : base()
      {
      }

      public SdtJC_Provider_Br_Information_RESTInterface( SdtJC_Provider_Br_Information psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "JC_ProviderID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Jc_providerid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Jc_providerid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Jc_providerid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_ID" , Order = 1 )]
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

      [DataMember( Name = "JC_ProviderName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Jc_providername
      {
         get {
            return sdt.gxTpr_Jc_providername ;
         }

         set {
            sdt.gxTpr_Jc_providername = value;
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 3 )]
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

      public SdtJC_Provider_Br_Information sdt
      {
         get {
            return (SdtJC_Provider_Br_Information)Sdt ;
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
            sdt = new SdtJC_Provider_Br_Information() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
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
