using CarnevaleDatabase.Controllers;
using CarnevaleDatabase.Datastore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarnevaleDatabase.Interface
{
    public partial class SpecialRules : Form
    {

        SpecialRulesController specRuleController = new SpecialRulesController();
        List<SpecialRule> specRulesList = new List<SpecialRule>();
        SpecialRule editRule = new SpecialRule();

        public SpecialRules()
        {
            InitializeComponent();
            newRuleLabel.Visible = false;
            ruleText.Visible = false;
            saveNewButton.Visible = false;
            specRuleCombo.Visible = false;
            selectSpecRuleLabel.Visible = false;
            specRuleLabel.Visible = false;
            editSpecRuleText.Visible = false;
            saveEditRule.Visible = false;
            selectRuleButton.Visible = false;
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            newRuleLabel.Visible = true;
            ruleText.Visible = true;
            saveNewButton.Visible = true;
            specRuleCombo.Visible = false;
            selectSpecRuleLabel.Visible = false;
            specRuleLabel.Visible = false;
            editSpecRuleText.Visible = false;
            saveEditRule.Visible = false;
            selectRuleButton.Visible = false;
        }

        private void editSpecRuleButton_Click(object sender, EventArgs e)
        {
            specRuleCombo.Visible = true;
            selectSpecRuleLabel.Visible = true;
            selectRuleButton.Visible = true;
            specRuleLabel.Visible = false;
            editSpecRuleText.Visible = false;
            saveEditRule.Visible = false;
            newRuleLabel.Visible = false;
            ruleText.Visible = false;
            saveNewButton.Visible = false;
            PopulateCombo();
            
        }

        private void PopulateCombo()
        {
            specRulesList.Clear();
            specRulesList = specRuleController.getSpecialRules();
            specRuleCombo.DataSource = specRulesList;
            specRuleCombo.DisplayMember = "Rule";
            
            
        }

        private void saveNewButton_Click(object sender, EventArgs e)
        {
            SpecialRule newSpecRule = new SpecialRule();
            newSpecRule.Rule = ruleText.Text;
            specRuleController.InsertSpecialRule(newSpecRule);
            ruleText.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectRuleButton_Click(object sender, EventArgs e)
        {
            specRuleLabel.Visible = true;
            editSpecRuleText.Visible = true;
            saveEditRule.Visible = true;
            editRule = (SpecialRule)specRuleCombo.SelectedItem;
            editSpecRuleText.Text = editRule.Rule;

        }

        private void saveEditRule_Click(object sender, EventArgs e)
        {
            
            editRule.Rule = editSpecRuleText.Text;
            specRuleController.UpdateSpecialRule(editRule);
            specRuleCombo.Visible = false;
            selectSpecRuleLabel.Visible = false;
            specRuleLabel.Visible = false;
            editSpecRuleText.Visible = false;
            saveEditRule.Visible = false;
            selectRuleButton.Visible = false;
        }
    }
}
