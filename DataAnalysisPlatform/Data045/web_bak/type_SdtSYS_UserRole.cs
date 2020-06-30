/*
               File: type_SdtSYS_UserRole
        Description: SYS_User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:51.61
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
   [XmlRoot(ElementName = "SYS_UserRole" )]
   [XmlType(TypeName =  "SYS_UserRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_UserRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_UserRole( )
      {
      }

      public SdtSYS_UserRole( IGxContext context )
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

      public void Load( Guid AV359UserID ,
                        Guid AV361RoleID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV359UserID,(Guid)AV361RoleID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"UserID", typeof(Guid)}, new Object[]{"RoleID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_UserRole");
         metadata.Set("BT", "SYS_USERROLE");
         metadata.Set("PK", "[ \"UserID\",\"RoleID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"RoleID\" ],\"FKMap\":[  ] },{ \"FK\":[ \"UserID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Userid_Z");
         state.Add("gxTpr_Roleid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_UserRole sdt ;
         sdt = (SdtSYS_UserRole)(source);
         gxTv_SdtSYS_UserRole_Userid = sdt.gxTv_SdtSYS_UserRole_Userid ;
         gxTv_SdtSYS_UserRole_Roleid = sdt.gxTv_SdtSYS_UserRole_Roleid ;
         gxTv_SdtSYS_UserRole_Mode = sdt.gxTv_SdtSYS_UserRole_Mode ;
         gxTv_SdtSYS_UserRole_Initialized = sdt.gxTv_SdtSYS_UserRole_Initialized ;
         gxTv_SdtSYS_UserRole_Userid_Z = sdt.gxTv_SdtSYS_UserRole_Userid_Z ;
         gxTv_SdtSYS_UserRole_Roleid_Z = sdt.gxTv_SdtSYS_UserRole_Roleid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("UserID", gxTv_SdtSYS_UserRole_Userid, false);
         AddObjectProperty("RoleID", gxTv_SdtSYS_UserRole_Roleid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_UserRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_UserRole_Initialized, false);
            AddObjectProperty("UserID_Z", gxTv_SdtSYS_UserRole_Userid_Z, false);
            AddObjectProperty("RoleID_Z", gxTv_SdtSYS_UserRole_Roleid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_UserRole sdt )
      {
         if ( sdt.IsDirty("UserID") )
         {
            gxTv_SdtSYS_UserRole_Userid = sdt.gxTv_SdtSYS_UserRole_Userid ;
         }
         if ( sdt.IsDirty("RoleID") )
         {
            gxTv_SdtSYS_UserRole_Roleid = sdt.gxTv_SdtSYS_UserRole_Roleid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "UserID" )]
      [  XmlElement( ElementName = "UserID"   )]
      public Guid gxTpr_Userid
      {
         get {
            return gxTv_SdtSYS_UserRole_Userid ;
         }

         set {
            if ( gxTv_SdtSYS_UserRole_Userid != value )
            {
               gxTv_SdtSYS_UserRole_Mode = "INS";
               this.gxTv_SdtSYS_UserRole_Userid_Z_SetNull( );
               this.gxTv_SdtSYS_UserRole_Roleid_Z_SetNull( );
            }
            gxTv_SdtSYS_UserRole_Userid = (Guid)(value);
            SetDirty("Userid");
         }

      }

      [  SoapElement( ElementName = "RoleID" )]
      [  XmlElement( ElementName = "RoleID"   )]
      public Guid gxTpr_Roleid
      {
         get {
            return gxTv_SdtSYS_UserRole_Roleid ;
         }

         set {
            if ( gxTv_SdtSYS_UserRole_Roleid != value )
            {
               gxTv_SdtSYS_UserRole_Mode = "INS";
               this.gxTv_SdtSYS_UserRole_Userid_Z_SetNull( );
               this.gxTv_SdtSYS_UserRole_Roleid_Z_SetNull( );
            }
            gxTv_SdtSYS_UserRole_Roleid = (Guid)(value);
            SetDirty("Roleid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_UserRole_Mode ;
         }

         set {
            gxTv_SdtSYS_UserRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_UserRole_Mode_SetNull( )
      {
         gxTv_SdtSYS_UserRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_UserRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_UserRole_Initialized ;
         }

         set {
            gxTv_SdtSYS_UserRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_UserRole_Initialized_SetNull( )
      {
         gxTv_SdtSYS_UserRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_UserRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "UserID_Z" )]
      [  XmlElement( ElementName = "UserID_Z"   )]
      public Guid gxTpr_Userid_Z
      {
         get {
            return gxTv_SdtSYS_UserRole_Userid_Z ;
         }

         set {
            gxTv_SdtSYS_UserRole_Userid_Z = (Guid)(value);
            SetDirty("Userid_Z");
         }

      }

      public void gxTv_SdtSYS_UserRole_Userid_Z_SetNull( )
      {
         gxTv_SdtSYS_UserRole_Userid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_UserRole_Userid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "RoleID_Z" )]
      [  XmlElement( ElementName = "RoleID_Z"   )]
      public Guid gxTpr_Roleid_Z
      {
         get {
            return gxTv_SdtSYS_UserRole_Roleid_Z ;
         }

         set {
            gxTv_SdtSYS_UserRole_Roleid_Z = (Guid)(value);
            SetDirty("Roleid_Z");
         }

      }

      public void gxTv_SdtSYS_UserRole_Roleid_Z_SetNull( )
      {
         gxTv_SdtSYS_UserRole_Roleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_UserRole_Roleid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_UserRole_Userid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_UserRole_Roleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_UserRole_Mode = "";
         gxTv_SdtSYS_UserRole_Userid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_UserRole_Roleid_Z = (Guid)(Guid.Empty);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_userrole", "GeneXus.Programs.sys_userrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_UserRole_Initialized ;
      private String gxTv_SdtSYS_UserRole_Mode ;
      private Guid gxTv_SdtSYS_UserRole_Userid ;
      private Guid gxTv_SdtSYS_UserRole_Roleid ;
      private Guid gxTv_SdtSYS_UserRole_Userid_Z ;
      private Guid gxTv_SdtSYS_UserRole_Roleid_Z ;
   }

   [DataContract(Name = @"SYS_UserRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_UserRole_RESTInterface : GxGenericCollectionItem<SdtSYS_UserRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_UserRole_RESTInterface( ) : base()
      {
      }

      public SdtSYS_UserRole_RESTInterface( SdtSYS_UserRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "UserID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Userid
      {
         get {
            return sdt.gxTpr_Userid ;
         }

         set {
            sdt.gxTpr_Userid = (Guid)(value);
         }

      }

      [DataMember( Name = "RoleID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Roleid
      {
         get {
            return sdt.gxTpr_Roleid ;
         }

         set {
            sdt.gxTpr_Roleid = (Guid)(value);
         }

      }

      public SdtSYS_UserRole sdt
      {
         get {
            return (SdtSYS_UserRole)Sdt ;
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
            sdt = new SdtSYS_UserRole() ;
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
