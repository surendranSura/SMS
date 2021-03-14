export class SmsConstant {

  static readonly bloods = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'A+ ve' },
    { value: "2", viewValue: 'B+ ve' },
    { value: "3", viewValue: 'O+ ve' }
  ];

  static readonly salutations = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'MR' },
    { value: "2", viewValue: 'MISS' },
    { value: "3", viewValue: 'MR' + "'" + 'S' }
  ];
  static readonly maritalStatus = [
    { value: 2, viewValue: 'Unmarried' },
    { value: 1, viewValue: 'Married' },
    { value: 3, viewValue: 'Widow' }
  ];
  static readonly religion = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Hindu' },
    { value: 2, viewValue: 'Muslim' },
    { value: 3, viewValue: 'christian' }
  ];
  static readonly nationality = [
    { value: 0, viewValue: '--select none--' },
    {value: 1, viewValue: 'India'},
    {value: 2, viewValue: 'Algerian'},
    {value: 3, viewValue: 'American'},
    {value: 4, viewValue: 'Andorran'},
    {value: 5, viewValue: 'Angolan'},
    {value: 6, viewValue: 'Antiguans'},
    {value: 7, viewValue: 'Argentinean'},
    {value: 8, viewValue: 'Armenian'},
    {value: 9, viewValue: 'Australian'},
    {value: 10, viewValue: 'Albanian'},
  ];
  static readonly motherTongue = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Tamil' },
    { value: 2, viewValue: 'English' },
    { value: 3, viewValue: 'Telugu' }
  ];
  static readonly languageKnown = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Tamil' },
    { value: 2, viewValue: 'English' },
    { value: 3, viewValue: 'Telugu' }
  ];
  static readonly firstLanguage = [
    { value: "0", viewValue: '--select none--' },
    { value: "1", viewValue: 'Tamil' },
    { value: "2", viewValue: 'English' },
    { value: "3", viewValue: 'Telugu' }
  ];
  static readonly secondLanguage = [
    { value: "0", viewValue: '--select none--' },
    { value: "1", viewValue: 'Tamil' },
    { value: "2", viewValue: 'English' },
    { value: "3", viewValue: 'Telugu' }
  ];
  static readonly city = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Coimbatore' },
    { value: 2, viewValue: 'Pollachi' },
    { value: 3, viewValue: 'OOty' }
  ];
  static readonly state = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Tamil Nadu' },
    { value: 2, viewValue: 'Kerala' },
    { value: 3, viewValue: 'Aandhra' }
  ];
  static readonly country = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'India' }
  ];
  static readonly classes = [
    { value: "0", viewValue: '--select none--' },
    { value: "1", viewValue: '1st' },
    { value: "2", viewValue: '2nd' },
    { value: "3", viewValue: '3rd' }
  ];
  static readonly section = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'A' },
    { value: "2", viewValue: 'B' },
    { value: "3", viewValue: 'C' }
  ];
  static readonly schoolBrand = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'CBSE' },
    { value: 2, viewValue: 'ICSE' },
    { value: 3, viewValue: 'Matric' },
    { value: 4, viewValue: 'State Board' },
    { value: 5, viewValue: 'others' }
  ];
  static readonly passingOutSchool = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: '2020' },
    { value: 2, viewValue: '2019' },
    { value: 3, viewValue: '2018' }
  ];
  static readonly yearOfAttendence = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: '2020' },
    { value: 2, viewValue: '2019' },
    { value: 3, viewValue: '2018' }
  ]
  static readonly staffType = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'School Admin' },
    { value: 2, viewValue: 'Teaching' },
    { value: 3, viewValue: 'Non Teaching' }
  ]
  static readonly designation = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Teacher' },
    { value: 2, viewValue: 'Student' },
    { value: 3, viewValue: 'Non Teaching' },
    { value: 4, viewValue: 'Librarian' },
    { value: 5, viewValue: 'Transport c' },
    { value: 6, viewValue: 'Inventory Coordinator' },
    { value: 7, viewValue: 'Finance Coordinator' }

  ]
  static readonly department = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Finance' },
    { value: 2, viewValue: 'Transport'},
    { value: 3, viewValue: 'Laboratory'},
    { value: 4, viewValue: 'Administration'},
    { value: 5, viewValue: 'Library'},
    { value: 6, viewValue: 'Inventory'},
    { value: 7, viewValue: 'English' },
    { value: 8, viewValue: 'Tamil' },
    { value: 9, viewValue: 'Maths' },
    { value: 10, viewValue: 'Science' },  
    { value: 11, viewValue: 'Social' },
    { value: 12, viewValue: 'Computer Science'},
    { value: 13, viewValue: 'Hindi' },
    { value: 14, viewValue: 'Non Teaching' }
  ]
  static readonly education = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: '10th' },
    { value: 2, viewValue: '12th' },
    { value: 3, viewValue: 'MPhil' }
  ]
  static readonly employmentStatus = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Active' },
    { value: 2, viewValue: 'Inactive'},
    { value: 3, viewValue: 'Maternity Leave' },
    { value: 4, viewValue: 'Paternity Leave' },
    { value: 5, viewValue: 'LOP Leave' }
  ]
  static readonly role = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Finance Admin' },
    { value: 2, viewValue: 'Transport Admin' },
    { value: 4, viewValue: 'Lab Admin'},
    { value: 5, viewValue: 'Principal'},
    { value: 6, viewValue: 'Teacher'},
    { value: 7, viewValue: 'Student'},
    { value: 8, viewValue: 'Parents'},
    { value: 9, viewValue: 'Library Admin'},
    { value: 10, viewValue: 'Inventory Admin'} 
  ]
  static readonly gender = [
    { value: "U", viewValue: '--select none--' },
    { value: "M", viewValue: 'Male' },
    { value: "F", viewValue: 'Female' }
  ]
  static readonly reportingTo = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'Hod' },
    { value: 2, viewValue: 'Principal' }
  ]
  static readonly active = [
    { value: 0, viewValue: '--select none--' },
    { value: 1, viewValue: 'yes' },
    { value: 2, viewValue: 'No' }
    
  ]
  static readonly letterType = [
    { value: "0", viewValue: '--select none--' },
    { value: "1", viewValue: 'Pay-slip' },
    { value: "2", viewValue: 'Incentive' },
    { value: "3", viewValue: 'Promotion' },
    { value: "4", viewValue: 'General' }
  ]
  static readonly feedbackTypes = [
    { value: "0", viewValue: '--select none--' },
    { value: "1", viewValue: 'Achievement' },
    { value: "2", viewValue: 'Ares of Improvement' },
    { value: "3", viewValue: 'Interim Feedback' }
  ]
  // static readonly feedbackTitles = [
  //   { value: 0, viewValue: '--select none--' },
  //   { value: 1, viewValue: 'Ftitle1' },
  //   { value: 2, viewValue: 'Ftitle2' },
  //   { value: 3, viewValue: 'Ftitle3' }
  // ]
  static readonly bank = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'ALLAHABAD BANK ' },
    { value: "2", viewValue: 'ANDHRA BANK' },
    { value: "3", viewValue: 'AXIS BANK' },
    { value: "4", viewValue: 'STATE BANK OF INDIA' },
    { value: "5", viewValue: 'BANK OF BARODA' },
    { value: "6", viewValue: 'UCO BANK' },
    { value: "7", viewValue: 'UNION BANK OF INDIA' },
    { value: "8", viewValue: 'BANK OF INDIA' },
    { value: "9,", viewValue: 'BANDHAN BANK LIMITED' },
    { value: "10", viewValue: 'CANARA BANK' },
    { value: "11", viewValue: 'GRAMIN VIKASH BANK' },
    { value: "12", viewValue: 'CORPORATION BANK' },
    { value: "13", viewValue: 'INDIAN BANK' },
    { value: "14,", viewValue: 'INDIAN OVERSEAS BANK' },
  ]
  static readonly months = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'JAN' },
    { value: "2", viewValue: 'FEB' },
    { value: "3", viewValue: 'MAR' },
    { value: "4", viewValue: 'APR' },
    { value: "5", viewValue: 'MAY' },
    { value: "6", viewValue: 'JUN' },
    { value: "7", viewValue: 'JULY' },
    { value: "8", viewValue: 'AUG' },
    { value: "9,", viewValue: 'SEP' },
    { value: "10", viewValue: 'OCT' },
    { value: "11", viewValue: 'NOV' },
    { value: "12", viewValue: 'DEC' },
  ]
  static readonly year = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: '2021' },
    { value: "2", viewValue: '2020' },
    { value: "3", viewValue: '2019' },
    { value: "4", viewValue: '2018' },
  ]
  static readonly complitionCriteria = [
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'C1' },
    { value: "2", viewValue: 'C2' },
    { value: "3", viewValue: 'C3' },
    { value: "4", viewValue: 'C4' },
  ]
  static readonly contentType=[
    { value: 0, viewValue: '--select none--' },
    { value: "1", viewValue: 'PDF' },
    { value: "2", viewValue: 'DOC' },
    { value: "3", viewValue: 'PPT' },
    { value: "4", viewValue: 'SCORM Package' },
    { value: "5", viewValue: 'Video' },
    { value: "6", viewValue: 'Youtube Link' },
    { value: "7", viewValue: 'Web Link' },

  ]
   subjects = ['Tamil','English','Maths','Science','Social']



}