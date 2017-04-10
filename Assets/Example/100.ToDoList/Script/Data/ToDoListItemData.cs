﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ToDoList {
	
	public class ToDoListItemData {

		public string Id;

		public string Content;

		bool m_Complete;
		public bool Complete {
			get {
				return m_Complete;
			}
			set {
				m_Complete = value;
			}
		}

		public bool Deleted = false;

		public void Description() {
			Debug.Log (Id + ":" + Complete + ":" + Content + ":" + Deleted);
		}
	}

}