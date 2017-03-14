// Copyright 2016-2017 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using System.Text;


// TODO: Serializer needs to be able to handle nulls and differentiate between null and empty string.

namespace Confluent.Kafka.Serialization
{
    public class StringSerializer : ISerializer<string>
    {
        private Encoding encoding;

        public StringSerializer(Encoding encoding)
        {
            this.encoding = encoding;
        }

        /// <param name="val">
        ///     The string value to serialize.
        /// </param>
        /// <returns>
        ///     <paramref name="val" /> encoded in a byte array.
        /// </returns>
        /// <remarks>
        ///     <paramref name="val" /> cannot be null.
        ///     TODO: well it shouldn't be other there is ambiguity on deserialization. check this.
        /// </remarks>
        public byte[] Serialize(string val)
        {
            return encoding.GetBytes(val);
        }
    }
}
