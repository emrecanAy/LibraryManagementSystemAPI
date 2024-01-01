﻿using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Request.Language;
using Business.Dtos.Response.Language;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class LanguageManager : ILanguageService
    {

        protected readonly ILanguageDal _languageDal;
        protected readonly IMapper _mapper;

        public LanguageManager(ILanguageDal languageDal,IMapper mapper)
        {
            _languageDal = languageDal;
            _mapper = mapper;
        }

        public async Task<CreatedLanguageResponse> Add(CreateLanguageRequest request)
        {
            Language language = _mapper.Map<Language>(request);

            var createdLanguage = await _languageDal.AddAsync(language);

            var createdLanguageResponse = _mapper.Map<CreatedLanguageResponse>(createdLanguage);

            return createdLanguageResponse;
        }

        public async Task<UpdatedLanguageResponse> Update(UpdateLanguageRequest request)
        {
            var languageToUpdate = await _languageDal.GetAsync(l => l.LanguageId == request.LanguageId);

            if (languageToUpdate == null)
            {
                return new UpdatedLanguageResponse() { IsUpdated = false };
            }

            _mapper.Map(request, languageToUpdate);

            await _languageDal.UpdateAsync(languageToUpdate);

            return new UpdatedLanguageResponse();
        }

        public async Task Delete(DeleteLanguageRequest request)
        {
            var languageToDelete = await _languageDal.GetAsync(l => l.LanguageId == request.LanguageId);

            if(languageToDelete is not null)
            {
               await _languageDal.DeleteAsync(languageToDelete);
            }

            throw new Exception("Something went wrong!");
        }

        public async Task<Language> GetAsync(Guid languageId)
        {
            return await _languageDal.GetAsync(l => l.LanguageId == languageId);
        }

        public async Task<IPaginate<GetListLanguageResponse>> GetListAsync(PageRequest pageRequest)
        {

            var data = await _languageDal.GetListAsync(
                null, 
                index : pageRequest.PageIndex,
                size : pageRequest.PageSize);

            var result = _mapper.Map<Paginate<GetListLanguageResponse>>(data);
            return result;
        }
    }
}
