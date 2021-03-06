/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class SearchObjectRequest : RpcAcsRequest<SearchObjectResponse>
    {
        public SearchObjectRequest()
            : base("Vcs", "2020-05-15", "SearchObject", "vcs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private long? startTime;

		private int? pageNumber;

		private string picContent;

		private int? pageSize;

		private string objectType;

		private string algorithmType;

		private long? endTime;

		private List<object> deviceList;

		private string picUrl;

		private string imagePath;

		private string conditions;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public string PicContent
		{
			get
			{
				return picContent;
			}
			set	
			{
				picContent = value;
				DictionaryUtil.Add(BodyParameters, "PicContent", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
				DictionaryUtil.Add(BodyParameters, "ObjectType", value);
			}
		}

		public string AlgorithmType
		{
			get
			{
				return algorithmType;
			}
			set	
			{
				algorithmType = value;
				DictionaryUtil.Add(BodyParameters, "AlgorithmType", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		public List<object> DeviceList
		{
			get
			{
				return deviceList;
			}
			set	
			{
				deviceList = value;
				DictionaryUtil.Add(BodyParameters, "DeviceList", JsonConvert.SerializeObject(value));
			}
		}

		public string PicUrl
		{
			get
			{
				return picUrl;
			}
			set	
			{
				picUrl = value;
				DictionaryUtil.Add(BodyParameters, "PicUrl", value);
			}
		}

		public string ImagePath
		{
			get
			{
				return imagePath;
			}
			set	
			{
				imagePath = value;
				DictionaryUtil.Add(BodyParameters, "ImagePath", value);
			}
		}

		public string Conditions
		{
			get
			{
				return conditions;
			}
			set	
			{
				conditions = value;
				DictionaryUtil.Add(BodyParameters, "Conditions", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchObjectResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchObjectResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
