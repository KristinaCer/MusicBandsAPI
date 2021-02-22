using Microsoft.AspNetCore.Mvc;
using MusicBandsAPI_Project.Dtos;
using MusicBandsAPI_Project.Models;
using MusicBandsAPI_Project.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicBandsAPI_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusiciansController : Controller
    {
        private readonly IMusicianRepository _repository;
        private readonly IBandRepository _bandRepository;

        public MusiciansController(IMusicianRepository repository, IBandRepository bandRepository)
        {
            _repository = repository;
            _bandRepository = bandRepository;
        }

        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MusicianDto>))]
        public IActionResult GetMusicians()
        {
            var musicians = _repository.getAllMusicians();
            var musicianDtos = new List<MusicianDto>(musicians.Count);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            foreach(Musician musician in musicians)
            {
                musicianDtos.Add(new MusicianDto
                {
                    MusicianId = musician.MusicianId,
                    Name = musician.Name,
                    PersonalPage = musician.PersonalPage

                });
            }
            return Ok(musicianDtos);
        }

        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(MusicianDto))]
        [HttpGet("{id}")]
        public IActionResult GetMusician(Guid id)
        {
            if (!_repository.MusicianExists(id))
            {
                return NotFound();
            }
            var musician = _repository.getMusician(id);
            var muscianDto = new MusicianDto
            {
                MusicianId = musician.MusicianId,
                Name = musician.Name,
                PersonalPage = musician.PersonalPage
            };
            return Ok(muscianDto);
        }
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(MusicianDto))]
        [HttpGet("{id}/website")]
        public IActionResult GetMusicianWebsite(Guid id)
        {
            if (!_repository.MusicianExists(id))
            {
                return NotFound();
            }
            var muscianWeb = _repository.getMusicianWebsite(id);
            return Ok(muscianWeb);
        }

        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MusicianDto>))]
        [HttpGet("{bandId}/members")]
        public IActionResult GetBandMembers(Guid bandId)
        {
            if (!_bandRepository.BandExists(bandId))
            {
                return NotFound();
            }
            var bandMembers = _repository.getBandMembers(bandId);
            var bandMemberDtos = new List<MusicianDto>(bandMembers.Count);
            foreach (Musician musician in bandMembers) {
                bandMemberDtos.Add(new MusicianDto
                {
                    MusicianId = musician.MusicianId,
                    Name = musician.Name,
                    PersonalPage = musician.PersonalPage

                });
            }
            return Ok(bandMemberDtos);
        }

        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ReleaseDto>))]
        [HttpGet("{musicianId}/releases")]
        public IActionResult GetAllReleasesOfMusician(Guid musicianId)
        {
            if (!_repository.MusicianExists(musicianId))
            {
                return NotFound();
            }
            var releases = _repository.getAllReleasesOfMusician(musicianId);
            var releasesDtos = new List<ReleaseDto>(releases.Count);
            foreach (Release release in releases)
            {
                releasesDtos.Add(new ReleaseDto
                {
                    ReleaseId = release.ReleaseId,
                    Title = release.Title,
                    Rating = release.Rating,
                    ReleaseYear = release.ReleaseYear

                });
            }
            return Ok(releasesDtos);
        }
    }
}
