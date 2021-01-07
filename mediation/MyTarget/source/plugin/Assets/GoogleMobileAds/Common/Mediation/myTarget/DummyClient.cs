// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Reflection;

using UnityEngine;

namespace GoogleMobileAds.Common.Mediation.MyTarget
{
    public class DummyClient : IMyTargetClient
    {
        public DummyClient ()
        {
            Debug.Log ("Dummy " + MethodBase.GetCurrentMethod ().Name);
        }

        public void SetUserConsent(bool userConsent)
        {
            Debug.Log ("Dummy " + MethodBase.GetCurrentMethod ().Name);
        }

        public void SetUserAgeRestricted(bool userAgeRestricted)
        {
            Debug.Log ("Dummy " + MethodBase.GetCurrentMethod ().Name);
        }

        public bool IsConsent()
        {
            Debug.Log ("Dummy " + MethodBase.GetCurrentMethod ().Name);
            return false;
        }

        public bool IsUserAgeRestricted()
        {
            Debug.Log ("Dummy " + MethodBase.GetCurrentMethod ().Name);
            return false;
        }
    }
}
