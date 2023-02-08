using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanner.Common.Model
{
    public enum ActivityType
    {
        [Display(Name = "Server Login")]
        ServerLogin,
        [Display(Name = "Node Login")]
        ClientLogin,
        [Display(Name = "Login fail")]
        LoginFail,
        [Display(Name = "Logout")]
        Logout,
        
        [Display(Name = "Create User")]
        CreateUser,
        [Display(Name = "Delete User")]
        DeleteUser,
        [Display(Name = "Update User")]
        UpdateUser,

        [Display(Name = "Create Prospect Client")]
        CreateProspectClient,
        [Display(Name = "Update Prospect Client")]
        UpdateProspectClient,
        [Display(Name = "Delete Prospect Client")]
        DeleteProspectClient,

        [Display(Name = "Create Prospect Client Conversation")]
        CreateProspectClientConversation,
        [Display(Name = "Update Prospect Client Conversation")]
        UpdateProspectClientConversation,
        [Display(Name = "Delete Prospect Client Conversation")]
        DeleteProspectClientConversation,

        [Display(Name = "Create System setting")]
        CreateSystemSetting,
        [Display(Name = "Update System setting")]
        UpdateSystemSetting,

        [Display(Name ="Create email article")]
        CreateEmailArticle,
        [Display(Name ="Update email article")]
        UpdateEmailArticle,
        [Display(Name="Delete email article")]
        DeleteEmailArticle,

        [Display(Name="Create Client")]
        CreateClient,
        [Display(Name="Update Client")]
        UpdateClient,
        [Display(Name="Delete Client")]
        DeleteClient,
       
        [Display(Name = "Update Client Spouse")]
        UpdateClientSpouse,
        [Display(Name = "Delete Client Spouse")]
        DeleteClientSpouse,

        [Display(Name = "Update Client Contact")]
        UpdateClientContact,
        [Display(Name = "Delete Client Contact")]
        DeleteClientContact,

        [Display(Name = "Update employment detail")]
        UpdateEmployment,
        [Display(Name = "Delete employment detail")]
        DeleteEmployment,

        [Display(Name = "Create family member")]
        CreateFamilyMember,
        [Display(Name = "Update family member")]
        UpdateFamilyMember,
        [Display(Name = "Delete family member")]
        DeleteFamilyMember,

        [Display(Name = "Create Non-Financial Asset")]
        CreateNonFinancialAsset,
        [Display(Name = "Update Non-Financial Asset")]
        UpdateNonFinancialAsset,
        [Display(Name = "Delete Non-Financial Asset")]
        DeleteNonFinancialAsset,

        [Display(Name = "Create Loan")]
        CreateLoan,
        [Display(Name = "Update Loan")]
        UpdateLoan,
        [Display(Name = "Delete Loan")]
        DeleteLoan,

        [Display(Name = "Create Income")]
        CreateIncome,
        [Display(Name = "Update Income")]
        UpdateIncome,
        [Display(Name = "Delete Income")]
        DeleteIncome,

        [Display(Name ="Update Planner Assumption")]
        UpdatePlannerAssumption,

        [Display(Name = "Update Assumption Master")]
        UpdateAssumptionMaster,

        [Display(Name = "Create Expense")]
        CreateExpenses,
        [Display(Name = "Update Expense")]
        UpdateExpenses,
        [Display(Name = "Delete Expense")]
        DeleteExpenses,

        [Display(Name = "Create Life Insurance")]
        CreateLifeInsurance,
        [Display(Name = "Update Life Insurance")]
        UpdateLifeInsurance,
        [Display(Name = "Delete Life Insurance")]
        DeleteLifeInsurance,

        [Display(Name = "Create General Insurance")]
        CreateGeneralInsurance,
        [Display(Name = "Update General Insurance")]
        UpdateGeneralInsurance,
        [Display(Name = "Delete General Insurance")]
        DeleteGeneralInsurance,

        [Display(Name = "Create Goals")]
        CreateGoals,
        [Display(Name = "Update Goals")]
        UpdateGoals,
        [Display(Name = "Delete Goals")]
        DeleteGoals,

        [Display(Name = "Create Risk Profiled")]
        CreateRiskProfiled,
        [Display(Name = "Update Risk Profiled")]
        UpdateRiskProfiled,
        [Display(Name = "Delete Risk Profiled")]
        DeleteRiskProfiled,

        [Display(Name = "Create Email Schedule")]
        CreateEmailSchedule,
        [Display(Name = "Update Email Schedule")]
        UpdateEmailSchedule,
        [Display(Name = "Delete Email Schedule")]
        DeleteEmailSchedule,

        [Display(Name = "Create Plan")]
        CreatePlan,
        [Display(Name = "Update Plan")]
        UpdatePlan,
        [Display(Name = "Delete Plan")]
        DeletePlan,

        [Display(Name = "Create Cash Flow")]
        CreateCashFlow,
        [Display(Name = "Update Cash Flow")]
        UpdateCashFlow,
        [Display(Name = "Delete Cash Flow")]
        DeleteCashFlow,

        [Display(Name = "Create Plan Option")]
        CreatePlannerOption,
        [Display(Name = "Update Plan Option")]
        UpdatePlannerOption,
        [Display(Name = "Delete Plan Option")]
        DeletePlannerOption,

        [Display(Name ="Create Mutual Fund")]
        CreateMutualFund,
        [Display(Name = "Update Mutual Fund")]
        UpdateMutualFund,
        [Display(Name = "Delete Mutual Fund")]
        DeleteMutualFund,

        [Display(Name = "Create NPS")]
        CreateNPS,
        [Display(Name = "Update NPS")]
        UpdateNPS,
        [Display(Name = "Delete NPS")]
        DeleteNPS,

        [Display(Name = "Delete Shares")]
        DeleteShares,
        [Display(Name = "Update Shares")]
        UpdateShares,
        [Display(Name = "Create Shares")]
        CreateShares,

        [Display(Name = "Create Investment Segment")]
        CreateInvestmentSegement,
        [Display(Name = "Update Investment Segment")]
        UpdateInvestmentSegement,
        [Display(Name = "Delete Investment Segment")]
        DeleteInvestmentSegement,


        [Display(Name = "Create Recommended Schemes")]
        CreatedSchemes,
        [Display(Name = "Update Recommended Schemes")]
        UpdateSchemes,
        [Display(Name = "Delete Recommended Schemes")]
        DeleteSchemes,

        [Display(Name = "Create Bonds")]
        CreateBonds,
        [Display(Name = "Update Bonds")]
        UpdateBonds,
        [Display(Name = "Delete Bonds")]
        DeleteBonds,

        [Display(Name = "Create Saving Account")]
        CreateSavingAccount,
        [Display(Name = "Update Saving Account")]
        UpdateSavingAccount,
        [Display(Name = "Delete Saving Account")]
        DeleteSavingAccount,

        [Display(Name ="Create Fixed Deposit")]
        CreateFixedDeposit,
        [Display(Name = "Update Fixed Deposit")]
        UpdateFixedDeposit,
        [Display(Name = "Delete Fixed Deposit")]
        DeleteFixedDeposit,

        [Display(Name ="Create Recurring Deposit")]
        CreateRecurringDeposit,
        [Display(Name = "Update Recurring Deposit")]
        UpdateRecurringDeposit,
        [Display(Name = "Delete Recurring Deposit")]
        DeleteRecurringDeposit,

        [Display(Name = "Create PPF")]
        CreatePPF,
        [Display(Name = "Update PPF")]
        UpdatePPF,
        [Display(Name = "Delete PPF")]
        DeletePPF,
        
        [Display(Name = "Create SCSS")]
        CreateSCSS,
        [Display(Name = "Update SCSS")]
        UpdateSCSS,
        [Display(Name = "Delete SCSS")]
        DeleteSCSS,

        [Display(Name = "Create SukanyaSamrudhi")]
        CreateSukanyaSamrudhi,
        [Display(Name = "Update SukanyaSamrudhi")]
        UpdateSukanyaSamrudhi,
        [Display(Name = "Delete SukanyaSamrudhi")]
        DeleteSukanyaSamrudhi,

        [Display(Name = "Create NSC")]
        CreateNSC,
        [Display(Name = "Update NSC")]
        UpdateNSC,
        [Display(Name = "Delete NSC")]
        DeleteNSC,

        [Display(Name = "Crate ULIP")]
        CreateULIP,
        [Display(Name = "Update ULIP")]
        UpdateULIP,
        [Display (Name = "Delete ULIP")]
        DeleteULIP,

        [Display(Name = "Crate MF Transaction")]
        CreateMFTransactions,
        [Display(Name = "Update MF Transaction")]
        UpdateMFTransactions,
        [Display(Name = "Delete MF Transaction")]
        DeleteMFTransactions,

        [Display(Name = "Crate Current Status To Goal")]
        CreateCurrentStatusToGoal,
        [Display(Name = "Update Current Status To Goal")]
        UpdateCurrentStatusToGoal,
        [Display(Name = "Delete Current Status To Goal")]
        DeleteCurrentStatusToGoal,

        [Display(Name = "Create Bank Details")]
        CreateBankAccount,
        [Display(Name = "Update Bank Details")]
        UpdateBankAccount,
        [Display(Name = "Delete Bank Details")]
        DeleteBankAccount,

        [Display(Name = "Create Document")]
        CreateDocument,
        [Display(Name = "Update Document")]
        UpdateDocument,
        [Display(Name = "Delete Document")]
        DeleteDocument,

        [Display(Name = "Delete Festival")]
        DeleteFestivals,
        [Display(Name = "Create Festival")]
        CreateFestivals,

        [Display(Name = "Create CRM Group")]
        CreateCRMGroup,
        [Display(Name = "Delete CRM Group")]
        DeleteCRMGroup,

        [Display(Name = "Update Company")]
        UpdateCompany,

        [Display(Name = "Delete Area")]
        DeleteArea,
        [Display(Name ="Create Area")]
        CreateArea,

        [Display(Name = "Delete Scheme Category")]
        DeleteSchemeCategory,
        [Display(Name = "Create Scheme Category")]
        CreateSchemeCategory,


        [Display(Name = "Delete Organisation type")]
        DeleteOrganisationType,
        [Display(Name = "Create Organisation type")]
        CreateOrganisationType,
        [Display(Name = "Update Organisation type")]
        UpdateOrganisationType,

        [Display(Name = "Update Process Action")]
        UpdateProcessAction,
        [Display(Name = "Delete Process Action")]
        DeleteProcessAction,
        [Display(Name = "Create Process Action")]
        CreateProcessAction,

        [Display(Name = "Update EPF")]
        UpdateEPF,
        [Display(Name = "Delete EPF")]
        DeleteEPF,
        [Display(Name = "Create EPF")]
        CreateEPF,

        [Display(Name = "Update Others")]
        UpdateOthers,
        [Display(Name = "Delete Others")]
        DeleteOthers,
        [Display(Name = "Create Others")]
        CreateOthers,

        [Display(Name = "Delete Client Rating")]
        DeleteClientRating,
        [Display(Name = "Create Client Rating")]
        CreateClientRating,

        [Display(Name ="Creat Task Project")]
        CreateTaskProject,
        [Display(Name = "Update Task Project")]
        UpdateTaskProject,
        [Display(Name = "Delete Task Project")]
        DeleteTaskProject,

        [Display(Name = "Create ARN")]
        CreateARN,
        [Display(Name = "Update ARN")]
        UpdateARN,
        [Display(Name = "Delete ARN")]
        DeleteARN,

        [Display(Name = "Create Scheme")]
        CreateScheme,
        [Display(Name = "Update Scheme")]
        UpdateScheme,
        [Display(Name = "Delete Scheme")]
        DeleteScheme,

        [Display(Name = "Create Task")]
        CreateTask,
        [Display(Name = "Update Task")]
        UpdateTask,
        [Display(Name = "Delete Task")]
        DeleteTask,
        [Display(Name = "Delete AMC")]
        DeleteAMC,
        [Display(Name = "Create AMC")]
        CreateAMC,
        [Display(Name = "Edit AMC")]
        UpdateAMC,
        [Display(Name ="Investment Recomendation")]
        CreateInvestmentRecommendation,
        [Display(Name = "Update Recomendation")]
        UpdateInvestmentRecommendation,
        [Display(Name = "Delete Recomendation")]
        DeleteInvestmentRecommendation,

        [Display(Name = "Update Quarterly Review Template")]
        UpdateQuarterlyReviewTemplate,
        CreateSessions,
        DeleteSessions,

        [Display(Name = "Create MOM")]
        CreateMOM,
        [Display(Name = "Update MOM")]
        UpdateMOM,
        [Display(Name = "Delete MOM")]
        DeleteMOM,
        [Display(Name = "Delete MOM Point")]
        DeleteMOMPoint,

        [Display(Name = "Add item for approval")]
        AddApproval,
        [Display(Name = "Item get approvaed")]
        ItemApproved,
        [Display(Name = "Item get rejected")]
        ItemRejected,
        [Display(Name = "Item get reassign")]
        ItemReassign,
    }

    public enum Source
    {
        Server,
        Client
    }

    public enum EntryStatus
    {
        Success,
        Fail
    }
}
