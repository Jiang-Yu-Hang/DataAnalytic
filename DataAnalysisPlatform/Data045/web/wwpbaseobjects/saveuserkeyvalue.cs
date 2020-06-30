/*
               File: WWPBaseObjects.SaveUserKeyValue
        Description: Save User Key Value
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:22.68
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
using System.Runtime.Serialization;
namespace GeneXus.Programs.wwpbaseobjects {
   public class saveuserkeyvalue : GXProcedure
   {
      public saveuserkeyvalue( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public saveuserkeyvalue( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_UserCustomizationsKey ,
                           String aP1_UserCustomizationsValue )
      {
         this.AV11UserCustomizationsKey = aP0_UserCustomizationsKey;
         this.AV12UserCustomizationsValue = aP1_UserCustomizationsValue;
         initialize();
         executePrivate();
      }

      public void executeSubmit( String aP0_UserCustomizationsKey ,
                                 String aP1_UserCustomizationsValue )
      {
         saveuserkeyvalue objsaveuserkeyvalue;
         objsaveuserkeyvalue = new saveuserkeyvalue();
         objsaveuserkeyvalue.AV11UserCustomizationsKey = aP0_UserCustomizationsKey;
         objsaveuserkeyvalue.AV12UserCustomizationsValue = aP1_UserCustomizationsValue;
         objsaveuserkeyvalue.context.SetSubmitInitialConfig(context);
         objsaveuserkeyvalue.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsaveuserkeyvalue);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((saveuserkeyvalue)stateInfo).executePrivate();
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
         AV8Session.Set(AV11UserCustomizationsKey, AV12UserCustomizationsValue);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV14WWPContext) ;
         this.cleanup();
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
         AV8Session = context.GetSession();
         AV14WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV12UserCustomizationsValue ;
      private String AV11UserCustomizationsKey ;
      private IGxSession AV8Session ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV14WWPContext ;
   }

}
