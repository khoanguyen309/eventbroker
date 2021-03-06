//-------------------------------------------------------------------------------
// <copyright file="IEventTopic.cs" company="Appccelerate">
//   Copyright (c) 2008-2015
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.EventBroker
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Represents a point of communication on a certain topic between the topic publishers and the topic subscribers.
    /// </summary>
    public interface IEventTopic : IDisposable, IEventTopicInfo, IEventTopicExecuter
    {
        void AddPublication(IPublication publication);

        IPublication RemovePublication(object publisher, string eventName);

        void AddSubscription(ISubscription subscription);
        
        void RemoveSubscription(object subscriber, MethodInfo handlerMethod);
    }
}