SELECT * FROM Skills
	LEFT JOIN JobSkills ON SKILLS.Id = JobSkills.SkillId
	WHERE JobSkills.JobId IS NOT NULL
	ORDER BY name DESC;