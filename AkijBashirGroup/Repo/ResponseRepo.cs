using AkijBashirGroup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AkijBashirGroup.Repo
{
    public class ResponseRepo
    {
       
        public ResultResponse SaveMessage()
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();
                baseResultResponse.msg = "Data Save SuccessFully";
                baseResultResponse.isSuccess = true;
                return baseResultResponse;               

            }
            catch (Exception )
            {

                throw;
            }
        }
        public ResultResponse ExixtsMessage()
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();
               
                baseResultResponse.msg = "Data Allredy Exixts!";
                baseResultResponse.isSuccess = false;

                return baseResultResponse;

            }
            catch (Exception )
            {

                throw;
            }
        }
        public ResultResponse UpdateMessage()
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();

                baseResultResponse.msg = "Data Updated SuccessFully";
                baseResultResponse.isSuccess = true;

                return baseResultResponse;

            }
            catch (Exception )
            {

                throw;
            }
        }
        public ResultResponse DeleteMessage()
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();

                baseResultResponse.msg = "Data Deleted SuccessFully";
                baseResultResponse.isSuccess = true;
                return baseResultResponse;

            }
            catch (Exception )
            {

                throw;
            }
        }




        #region private

        public ResultResponse baseResultResponseMethode(dynamic data)
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();
                if (data.Count > 0)
                {
                    baseResultResponse.data = data;
                    baseResultResponse.msg = "Successful";
                    baseResultResponse.isSuccess = true;
                }
                else
                {
                    baseResultResponse.data = data;
                    baseResultResponse.msg = "No Record Found";
                    baseResultResponse.isSuccess = false;
                }

                return baseResultResponse;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ResultResponse baseResultResponseSingleMethode(dynamic data)
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();
                if (data.Id > 0)
                {
                    baseResultResponse.data = data;
                    baseResultResponse.msg = "Successful";
                    baseResultResponse.isSuccess = true;
                }
                else
                {
                    baseResultResponse.data = data;
                    baseResultResponse.msg = "No Record Found";
                    baseResultResponse.isSuccess = false;
                }

                return baseResultResponse;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ResultResponse NorecordeFound()
        {
            try
            {
				ResultResponse baseResultResponse = new ResultResponse();
                baseResultResponse.data = null;
                baseResultResponse.msg = "No Record Found";
                baseResultResponse.isSuccess = false;
                return baseResultResponse;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion


    }
}
