﻿using Arcana.Domain.Commons;
using Arcana.Domain.Entities.Students;

namespace Arcana.Domain.Entities.Instructors;

public class InstructorStars : Auditable
{
    public long StudentId { get; set; }
    public long InstructorId { get; set; }
    public byte Stars { get; set; }

    public Student Student { get; set; }
    public Instructor Instructor { get; set; }
}
