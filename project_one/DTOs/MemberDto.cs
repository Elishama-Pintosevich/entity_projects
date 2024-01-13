using System;
using entityProject.entities;

namespace entityProject.DTOs
{
	public class MemberDto
	{
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<PhotoDto> Photos { get; set; } = new();
    }
}

