namespace SAM.Web.Client.Shared
{
    public class SAMConstants
    {
        public class Queues
        {
            public const string Mailing = "mailing-queue";
        }
        public class Settings
        {
            public const string DateFormat = "dd MMM yyyy";
        }

        public class Users
        {
            public const string UserProfileType = "UserProfile";
            public const string UserDefaultPassword = "DefaultDefault1";

            public class ImageKinds
            {
                public const string ProfileImage = "ProfileImage";
            }
            public class Roles
            {
                public const string GlobalAdmin = "GlobalAdmin";
            }
        }

        public class Support
        {
            public class Dev
            {
                public const string Email = "1048c03a.devrain.com@emea.teams.ms";
            }
            public class TestProd
            {
                public const string Email = "help@sam.coach";
            }
        }
        
        public class Media
        {
            public const string EntityType = "MediaItem";

            public class Type
            {
                public const string Image = "Image";
                public const string Video = "Video";
            }
        }

        public class Meetings
        {
            public class ActionItems
            {
                public class Types
                {
                    public const string ActionItem = nameof(ActionItem);
                    public const string KeyPoint = nameof(KeyPoint);
                    public const string Evidence = nameof(Evidence);
                }
                
                public class Statuses
                {
                    public const string Done = nameof(Done);
                }
                
                public class EvidenceKinds
                {
                    public const string Call = nameof(Call);
                    public const string Email = nameof(Email);
                    public const string Text = nameof(Text);
                    public const string Document = nameof(Document);
                }
            }
            
            public class MeetingNotes
            {
                public const string MeetingNotesType = "MeetingNotes";

                public class Evidences
                {
                    public const string EvidencesType = "Evidences";
                    public class FilesKinds
                    {
                        public const string EvidencesFiles = "EvidencesFiles";
                    }
                }
                public class QuestionAndAnswers
                {
                    public const string QuestionAndAnswersType = "QuestionAndAnswers";
                    public class FilesKinds
                    {
                        public const string QuestionAndAnswersFiles = "QuestionAndAnswersFiles";
                    }
                }
            }

            public class Statuses
            {
                public const string Draft = nameof(Draft);
                public const string Planned = nameof(Planned);
                public const string InProgress = nameof(InProgress);
                public const string Completed = nameof(Completed);
                public const string Cancelled = nameof(Cancelled);
            }

            public class PreparationStatuses
            {
                public const string Step1 = nameof(Step1);
                public const string Step2 = nameof(Step2);
                public const string Step3 = nameof(Step3);
                public enum Steps
                {
                    Step1,
                    Step2,
                    Step3,
                    Step4
                }
            }
            public class SignupSteps
            {
                public const string Step1 = nameof(Step1);
                public const string Step2 = nameof(Step2);
                public const string Step3 = nameof(Step3);
                public enum Steps
                {
                    Step1,
                    Step2,
                    Step3
                }
            }

            public class SignupDescriptionSteps
            {
                public const string Step1 = nameof(Step1);
                public const string Step2 = nameof(Step2);
                public const string Step3 = nameof(Step3);
                public const string Step4 = nameof(Step3);

                public enum Steps
                {
                    Step1,
                    Step2,
                    Step3,
                    Step4
                }
            }

            public class Types
            {
                public const string Meeting = "meeting";
                public const string Call = "call";
            }

            public class Direction
            {
                public const string Inbound = nameof(Inbound);
                public const string Outbound = nameof(Outbound);
            }

            public class Times
            {
                public const string TimeStart = "08:00:00";
                public const string TimeEnd = "08:45:00";
            }
            public class DiffBeetwenStartEnd
            {
                public const int Call = 15;
                public const int Meeting = 45;
            }


            public class ProgressValues
            {
                public const int Step1 = 20;
                public const int Step2 = 40;
                public const int Step3 = 60;
                public const int Step4 = 80;
            }

            public const int PercentCompleteLimit = 80;

        }
        
        public class Api
        {
            public const string SignIn = "api/1.0/user/sign-in";
            public const string RefreshToken = "api/1.0/user/refresh-token";
            public const string GetCurrentUser = "/api/1.0/user/current";
            public const string GetUser = "/api/1.0/user";
            public const string DashboardData = "api/1.0/dashboard";
            public const string GetMeetingsFilters = "api/1.0/meetings/filters";
            public const string Meetings = "api/1.0/meetings";
            public const string MeetingsById = "api/1.0/meetings/id";
            public const string GetMeetingsByDeal = "api/1.0/meetings-by-deal";
            public const string GetPreviousMeetingsWithDiscussionPoints = "api/1.0/prev-meet-w-discussion-points";

            public const string SaveMeetingInfo = "api/1.0/meetings/info";
            public const string SaveMeetingDiscussionPoints = "api/1.0/meetings/discussion-points";
            public const string MeetingSalesQuestion = "api/1.0/meetings/sales-question";
            public const string SaveMeetingSalesQuestions = "api/1.0/meetings/sales-questions";
            // public const string AddMeetingSalesQuestions = "api/1.0/meeting/add-sales-questions";

            public const string DiscardMeetingNotes = "api/1.0/meetings/discard-notes";

            public const string GetKRAs = "api/1.0/kra";    
            public const string GetKPIs = "api/1.0/kpi";
            public const string DiscussionPoints = "api/1.0/discussion-points";
            public const string SalesQuestions= "api/1.0/sales-questions";
            public const string GetQuestionCategories = "api/1.0/sales-questions/categories";

            //Signup
            public const string CreateSignup = "api/1.0/signup";
            public const string VerifyEmail = "api/1.0/verify-email";
            public const string CreateUserAccount = "api/1.0/create-account";

            //Organizations
            public const string Organizations = "api/1.0/organizations";

            //OrganizationPositions
            public const string OrganizationPositions = "api/1.0/organization-positions";

            //OrganizationEmployees
            public const string OrganizationEmployee = "api/1.0/organization-employee";
            public const string OrganizationEmployees = "api/1.0/organization-employees";

            //Deals
            public const string Deals = "api/1.0/deals";

            public const string Feedback = "api/1.0/feedback";

            public const string PresalesRequest = "api/1.0/presales-request";

            //ImportPredefinedData
            public const string ImportPredefinedData = "api/1.0/import-predefined-data";

            public const string AddFile = "api/1.0/file/add";
            public const string CopyFiles = "api/1.0/file/copy";
            public const string RemoveFile = "api/1.0/file/remove";

            public const string CreateOrUpdateAccount = "api/1.0/account/create-update";
            
            public const string Users = "api/1.0/users";
            
            public const string UsersChangePassword = "api/1.0/users/change-password";
            
            public const string MeetingComments = "api/1.0/meetings/comments";
            public const string MeetingKRAs = "api/1.0/meetings/kras";

            public const string MeetingActionItems = "api/1.0/meeting/action-items";
            
            public const string MeetingQuestionsAnswers = "api/1.0/meetings/questions-answers";
            
            public const string ApiKey = "a5cacf75-70bb-42bb-8978-e65981f97ba9";

            public class ErrorCodes
            {
                public const string OK = "";
                public const string Fail = "Fail";
                public const string Unauthorized = "Unauthorized";
                public const string Cancelled = "Cancelled";
                public const string WrongFileFormat = nameof(WrongFileFormat);
                public const string TokenExpired = nameof(TokenExpired);
                public const string InvalidUserCredentials = nameof(InvalidUserCredentials);
                public const string UserNotFound = nameof(UserNotFound);
                public const string UserAlreadyExists= nameof(UserAlreadyExists);
                public const string CustomerAlreadyExists= nameof(CustomerAlreadyExists);
                public const string EntityNotFound = nameof(EntityNotFound);
                public const string InvalidEmailOrPassword = nameof(InvalidEmailOrPassword);
                public const string AccessDenied = nameof(AccessDenied);
            }

            public class ErrorMessages
            {
                public const string DiscardMeetingError = "You can't discard meeting because it was created by another user.";
                public const string NoPermissionError = "You can't change password because you dont have permissions.";
                public static string GetErrorMessageForDelete(string type)
                {
                    return $"You can't delete an {type} because it was created by another user.";
                }

                public static string GetErrorMessageForUpdate(string type)
                {
                    return $"You can't update an {type} because it was created by another user.";
                }
            }
        }

        public class ImportStatus
        {
            public const string Active = "Active";
            public const string Deleted = "Deleted";
        }

        public class ImportYesNo
        {
            public const string Yes = "Yes";
            public const string No = "No";
        }
    }
}