using System;
using System.Collections.Generic;
using System.Linq;
using StackOverflowProjectDomainModels;

namespace StackOverflowProject.Repositories
{
	public interface IQuestionsRepository
	{
		void InsertQuestion(Question q);
		void UpdateQuestionDetails(Question q);
		void UpdateQuestionVotesCount(int qid, int value);
		void UpdateQuestionAnswersCount(int qId, int value);
		void UpdateQuestionViewsCount(int qId, int value);
		void DeleteQuestion(int qId);
		List<Question> GetQuestions();
		List<Question> GetQuestionByQuestionId(int qId);
	}

	public class QuestionsRepository : IQuestionsRepository
	{
		StackOverflowDatabaseDbContext db;

		public QuestionsRepository()
		{
			db = new StackOverflowDatabaseDbContext();
		}

		public void DeleteQuestion(int qId)
		{
			Question q = db.Questions.Where(temp => temp.QuestionID == qId).FirstOrDefault();
			if(q!=null)
			{
				db.Questions.Remove(q);
				db.SaveChanges();
			}
		}

		public List<Question> GetQuestionByQuestionId(int qId)
		{
			List<Question> qs = db.Questions.Where(temp => temp.QuestionID == qId).ToList();
			return qs;
		}

		public List<Question> GetQuestions()
		{
			List<Question> qs = db.Questions.OrderByDescending(temp=>temp.QuestionDateAndTime).ToList();
			return qs;
		}

		public void InsertQuestion(Question q)
		{
			db.Questions.Add(q);
			db.SaveChanges();
		}

		public void UpdateQuestionAnswersCount(int qId, int value)
		{
			Question q = db.Questions.Where(temp => temp.QuestionID == qId).FirstOrDefault();
			if(q!=null)
			{
				q.AnswersCount += value;
				db.SaveChanges();
			}
		}

		public void UpdateQuestionDetails(Question q)
		{
			Question qs = db.Questions.Where(temp => temp.QuestionID == q.QuestionID).FirstOrDefault();
			if(qs!=null)
			{
				qs.QuestionName = q.QuestionName;
				qs.QuestionDateAndTime = q.QuestionDateAndTime;
				qs.CategoryID = q.CategoryID;
				db.SaveChanges();
			}
		}

		public void UpdateQuestionViewsCount(int qId, int value)
		{
			Question q = db.Questions.Where(temp => temp.QuestionID == qId).FirstOrDefault();
			if (q != null)
			{
				q.ViewsCount += value;
				db.SaveChanges();
			}
		}

		public void UpdateQuestionVotesCount(int qid, int value)
		{
			Question q = db.Questions.Where(temp => temp.QuestionID == qid).FirstOrDefault();
			if (q != null)
			{
				q.VotesCount += value;
				db.SaveChanges();
			}
		}
	}
}
