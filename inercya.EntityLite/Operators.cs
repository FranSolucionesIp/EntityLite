﻿/*
Copyright 2014 i-nercya intelligent software

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inercya.EntityLite
{
    public enum OperatorLite
    {
        None = 0,
        IsNull,
        IsNotNull,
        Equals,
        NotEquals,
        StartsWith,
        NotStartsWith,
        Contains,
        NotContains,
        Less,
        LessOrEquals,
        Greater,
        GreaterOrEquals,
        In,
        NotIn,
        IsDescendantOf,
        IsChildOf,
        IsGrandChildOf,
        HierarchyLevelEquals,
        STEquals,
        STIntersects,
        STDistanceLess,
        STDistanceLessOrEquals
    }

    public enum LogicalOperatorLite
    {
        And,
        Or
    }
}
