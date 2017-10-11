﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code

using System;

using TechTalk.SpecFlow;

#pragma warning disable
namespace PicklesDoc.Pickles.DocumentationBuilders.Json.UnitTests
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Formatting A Feature")]
    public partial class FormattingAFeatureFeature
    {

        private TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "FormattingAFeature.feature"
#line hidden

        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            this.testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Formatting A Feature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            this.testRunner.OnFeatureStart(featureInfo);
        }

        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            this.testRunner.OnFeatureEnd();
            this.testRunner = null;
        }

        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }

        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            this.testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            this.testRunner.OnScenarioStart(scenarioInfo);
        }

        public virtual void ScenarioCleanup()
        {
            this.testRunner.CollectScenarioErrors();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A simple feature")]
        [NUnit.Framework.CategoryAttribute("json")]
        public virtual void ASimpleFeature()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A simple feature", new string[] {
                        "json"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 6
    this.testRunner.Given("I have this feature description", @"Feature: Clearing Screen
    In order to restart a new set of calculations
    As a math idiot
    I want to be able to clear the screen

@workflow @slow
Scenario: Clear the screen
    Given I have entered 50 into the calculator
    And I have entered 70 into the calculator
    When I press C
    Then the screen should be empty", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
    this.testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
    this.testRunner.Then("the JSON file should contain", "{\r\n  \"Features\": [\r\n    {\r\n      \"RelativeFolder\": \"\",\r\n      \"Feature\": {\r\n     " +
                    "   \"Name\": \"Clearing Screen\",\r\n        \"Description\": \"In order to restart a new" +
                    " set of calculations\\r\\nAs a math idiot\\r\\nI want to be able to clear the screen" +
                    "\",\r\n        \"FeatureElements\": [\r\n          {\r\n            \"Name\": \"Clear the sc" +
                    "reen\",\r\n            \"Slug\": \"clear-the-screen\",\r\n            \"Description\": \"\",\r" +
                    "\n            \"Steps\": [\r\n              {\r\n                \"Keyword\": \"Given\",\r\n " +
                    "               \"NativeKeyword\": \"Given \",\r\n                \"Name\": \"I have enter" +
                    "ed 50 into the calculator\",\r\n                \"StepComments\": [],\r\n              " +
                    "  \"AfterLastStepComments\": []\r\n              },\r\n              {\r\n              " +
                    "  \"Keyword\": \"And\",\r\n                \"NativeKeyword\": \"And \",\r\n                \"" +
                    "Name\": \"I have entered 70 into the calculator\",\r\n                \"StepComments\":" +
                    " [],\r\n                \"AfterLastStepComments\": []\r\n              },\r\n           " +
                    "   {\r\n                \"Keyword\": \"When\",\r\n                \"NativeKeyword\": \"When" +
                    " \",\r\n                \"Name\": \"I press C\",\r\n                \"StepComments\": [],\r\n" +
                    "                \"AfterLastStepComments\": []\r\n              },\r\n              {\r\n" +
                    "                \"Keyword\": \"Then\",\r\n                \"NativeKeyword\": \"Then \",\r\n " +
                    "               \"Name\": \"the screen should be empty\",\r\n                \"StepComme" +
                    "nts\": [],\r\n                \"AfterLastStepComments\": []\r\n              }\r\n       " +
                    "     ],\r\n            \"Tags\": [\r\n              \"@workflow\",\r\n              \"@slow" +
                    "\"\r\n            ],\r\n            \"Result\": {\r\n              \"WasExecuted\": false,\r" +
                    "\n              \"WasSuccessful\": false\r\n            }\r\n          }\r\n        ],\r\n " +
                    "       \"Result\": {\r\n          \"WasExecuted\": false,\r\n          \"WasSuccessful\": " +
                    "false\r\n        },\r\n        \"Tags\": []\r\n      },\r\n      \"Result\": {\r\n        \"Was" +
                    "Executed\": false,\r\n        \"WasSuccessful\": false\r\n      }\r\n    }\r\n  ],", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }

        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A feature with a table")]
        [NUnit.Framework.CategoryAttribute("json")]
        public virtual void AFeatureWithATable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A feature with a table", new string[] {
                        "json"});
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 92
    this.testRunner.Given("I have this feature description", @"Feature: Interactive DHTML View
    In order to increase stakeholder engagement with pickled specs
    As a SpecFlow evangelist
    I want to adjust the level of detail in the DHTML view to suit my audience
    So that I do not overwhelm them.

Scenario: Scenario with large data table
    Given a feature with a large table of data:
        | heading    | page # |
        | Chapter 1  | 1      |
        | Chapter 2  | 5      |
        | Chapter 3  | 10     |
        | Chapter 4  | 15     |
        | Chapter 5  | 20     |
        | Chapter 6  | 25     |
        | Chapter 7  | 30     |
        | Chapter 8  | 35     |
        | Chapter 9  | 40     |
        | Chapter 10 | 45     |
        | Chapter 11 | 50     |
        | Chapter 12 | 55     |
        | Chapter 13 | 60     |
        | Chapter 14 | 65     |
        | Chapter 15 | 70     |
        | Chapter 16 | 75     |
        | Chapter 17 | 80     |
        | Chapter 18 | 85     |
        | Chapter 19 | 90     |
        | Chapter 20 | 95     |
        | Chapter 21 | 100    |
        | Chapter 22 | 105    |
    When I click on the table heading
    Then the table body should collapse", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 128
    this.testRunner.When("I generate the documentation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 129
    this.testRunner.Then("the JSON file should contain", "{\r\n  \"Features\": [\r\n    {\r\n      \"RelativeFolder\": \"\",\r\n      \"Feature\": {\r\n     " +
                    "   \"Name\": \"Interactive DHTML View\",\r\n        \"Description\": \"In order to increa" +
                    "se stakeholder engagement with pickled specs\\r\\nAs a SpecFlow evangelist\\r\\nI wa" +
                    "nt to adjust the level of detail in the DHTML view to suit my audience\\r\\nSo tha" +
                    "t I do not overwhelm them.\",\r\n        \"FeatureElements\": [\r\n          {\r\n       " +
                    "     \"Name\": \"Scenario with large data table\",\r\n            \"Slug\": \"scenario-wi" +
                    "th-large-data-table\",\r\n            \"Description\": \"\",\r\n            \"Steps\": [\r\n " +
                    "             {\r\n                \"Keyword\": \"Given\",\r\n                \"NativeKeyw" +
                    "ord\": \"Given \",\r\n                \"Name\": \"a feature with a large table of data:\"" +
                    ",\r\n                \"TableArgument\": {\r\n                  \"HeaderRow\": [\r\n       " +
                    "             \"heading\",\r\n                    \"page #\"\r\n                  ],\r\n   " +
                    "               \"DataRows\": [\r\n                    [\r\n                      \"Chap" +
                    "ter 1\",\r\n                      \"1\"\r\n                    ],\r\n                    " +
                    "[\r\n                      \"Chapter 2\",\r\n                      \"5\"\r\n              " +
                    "      ],\r\n                    [\r\n                      \"Chapter 3\",\r\n           " +
                    "           \"10\"\r\n                    ],\r\n                    [\r\n                " +
                    "      \"Chapter 4\",\r\n                      \"15\"\r\n                    ],\r\n        " +
                    "            [\r\n                      \"Chapter 5\",\r\n                      \"20\"\r\n " +
                    "                   ],\r\n                    [\r\n                      \"Chapter 6\"," +
                    "\r\n                      \"25\"\r\n                    ],\r\n                    [\r\n   " +
                    "                   \"Chapter 7\",\r\n                      \"30\"\r\n                   " +
                    " ],\r\n                    [\r\n                      \"Chapter 8\",\r\n                " +
                    "      \"35\"\r\n                    ],\r\n                    [\r\n                     " +
                    " \"Chapter 9\",\r\n                      \"40\"\r\n                    ],\r\n             " +
                    "       [\r\n                      \"Chapter 10\",\r\n                      \"45\"\r\n     " +
                    "               ],\r\n                    [\r\n                      \"Chapter 11\",\r\n " +
                    "                     \"50\"\r\n                    ],\r\n                    [\r\n      " +
                    "                \"Chapter 12\",\r\n                      \"55\"\r\n                    ]" +
                    ",\r\n                    [\r\n                      \"Chapter 13\",\r\n                 " +
                    "     \"60\"\r\n                    ],\r\n                    [\r\n                      " +
                    "\"Chapter 14\",\r\n                      \"65\"\r\n                    ],\r\n             " +
                    "       [\r\n                      \"Chapter 15\",\r\n                      \"70\"\r\n     " +
                    "               ],\r\n                    [\r\n                      \"Chapter 16\",\r\n " +
                    "                     \"75\"\r\n                    ],\r\n                    [\r\n      " +
                    "                \"Chapter 17\",\r\n                      \"80\"\r\n                    ]" +
                    ",\r\n                    [\r\n                      \"Chapter 18\",\r\n                 " +
                    "     \"85\"\r\n                    ],\r\n                    [\r\n                      " +
                    "\"Chapter 19\",\r\n                      \"90\"\r\n                    ],\r\n             " +
                    "       [\r\n                      \"Chapter 20\",\r\n                      \"95\"\r\n     " +
                    "               ],\r\n                    [\r\n                      \"Chapter 21\",\r\n " +
                    "                     \"100\"\r\n                    ],\r\n                    [\r\n     " +
                    "                 \"Chapter 22\",\r\n                      \"105\"\r\n                   " +
                    " ]\r\n                  ]\r\n                },\r\n                \"StepComments\": []," +
                    "\r\n                \"AfterLastStepComments\": []\r\n              },\r\n              {" +
                    "\r\n                \"Keyword\": \"When\",\r\n                \"NativeKeyword\": \"When \",\r" +
                    "\n                \"Name\": \"I click on the table heading\",\r\n                \"StepC" +
                    "omments\": [],\r\n                \"AfterLastStepComments\": []\r\n              },\r\n  " +
                    "            {\r\n                \"Keyword\": \"Then\",\r\n                \"NativeKeywor" +
                    "d\": \"Then \",\r\n                \"Name\": \"the table body should collapse\",\r\n       " +
                    "         \"StepComments\": [],\r\n                \"AfterLastStepComments\": []\r\n     " +
                    "         }\r\n            ],\r\n            \"Tags\": [],\r\n            \"Result\": {\r\n  " +
                    "            \"WasExecuted\": false,\r\n              \"WasSuccessful\": false\r\n       " +
                    "     }\r\n          }\r\n        ],\r\n        \"Result\": {\r\n          \"WasExecuted\": f" +
                    "alse,\r\n          \"WasSuccessful\": false\r\n        },\r\n        \"Tags\": []\r\n      }" +
                    ",\r\n      \"Result\": {\r\n        \"WasExecuted\": false,\r\n        \"WasSuccessful\": fa" +
                    "lse\r\n      }\r\n    }\r\n  ],", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
