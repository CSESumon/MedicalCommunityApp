﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAL;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.BLL
{
    public class DiseaseManager
    {
        DiseaseDbGateway aDiseaseDbGateway =new DiseaseDbGateway();

        public string SaveDisease(Disease aDisease)
        {
            aDiseaseDbGateway.SaveDisease(aDisease);
            return "Successfully Saved";
        }
    }
}
