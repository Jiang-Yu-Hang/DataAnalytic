/*
               File: GxFullTextSearchReindexer
        Description: No description for object
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 13:24:4.2
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
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class GxFullTextSearchReindexer
   {
      public static int Reindex( IGxContext context )
      {
         GxSilentTrnSdt obj ;
         IGxSilentTrn trn ;
         bool result ;
         obj = new GeneXus.Programs.wwpbaseobjects.SdtSecFunctionalityRole(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new GeneXus.Programs.wwpbaseobjects.SdtSecUser(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new GeneXus.Programs.wwpbaseobjects.SdtUserCustomizations(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Behavior(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Demographics(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Diagnosis(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Information(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Encounter(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Lab(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtJC_Provider(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Vital(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtXT_DefindcodeType(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtXT_DefineCode(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Medication(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtJC_ProviderSecUser(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtXT_Log(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtJC_Provider_Br_Information(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Procedure(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Comorbidity(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         obj = new SdtBR_Death(context);
         trn = obj.getTransaction();
         result = trn.Reindex();
         return 1 ;
      }

   }

}
