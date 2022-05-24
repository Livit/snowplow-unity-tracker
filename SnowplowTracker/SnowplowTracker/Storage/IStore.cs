﻿/*
 * EventStore.cs
 * SnowplowTracker.Storage
 * 
 * Copyright (c) 2015-2022 Snowplow Analytics Ltd. All rights reserved.
 *
 * This program is licensed to you under the Apache License Version 2.0,
 * and you may not use this file except in compliance with the Apache License Version 2.0.
 * You may obtain a copy of the Apache License Version 2.0 at http://www.apache.org/licenses/LICENSE-2.0.
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the Apache License Version 2.0 is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the Apache License Version 2.0 for the specific language governing permissions and limitations there under.
 */

using System;
using System.Collections.Generic;
using SnowplowTracker.Payloads;

namespace SnowplowTracker.Storage
{
    public interface IStore
    {
        bool AddEvent(TrackerPayload payload);
        bool DeleteEvents(List<Guid> rowIds);
        long GetEventCount();
        List<EventRow> GetEvents(int range);
    }
}
