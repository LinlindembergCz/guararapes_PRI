import { Injectable , BadRequestException } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { People } from './people.entity';
import { PeopleRepository } from './people.repository';

@Injectable()
export class PeopleService {

  constructor(
    @InjectRepository(PeopleRepository)
    private readonly _entityRepository: PeopleRepository,
    )
    {      
    }

    async ExecRelationCommand(tableName: string , idsRelation: string  )
  {
    //console.log( tableName + "   "+ idsRelation ); 
    await this._entityRepository.
    createQueryBuilder().
    insert().
    into(tableName).
    //values([{filmsId: idMaster , speciesId: idDetail}]).
    values([ JSON.parse( idsRelation ) ]).
    execute();
  }

  async create(entity: People):Promise<People>  {
    const saveEntity = await this._entityRepository.save(entity);
        return saveEntity;
  }

  async findAll() : Promise<People[]> {

   const entities: People[] = await this._entityRepository.find()
        return entities
  }

  async findOne(id: number): Promise<People> {
      if(!id)
      {
          throw new BadRequestException('Id é requerido!');
      }
      const entity: People = await this._entityRepository.
      findOne(id);
      if (!entity)
      {
          throw new BadRequestException('Peple nao existe!');
      }
      return entity;
  }

  async  findOneIdByUrl(_url: string): Promise<bigint>
  {
    if(!_url)
    {
        throw new BadRequestException('url é requerido!');
    }
    const entity: People = await this._entityRepository.findOne({where: {url:_url }});
    if (!entity)
    {
        throw new BadRequestException('Id nao existe!');
    }
    return entity.id;
  }

  async update(id: number, entity: People):Promise<void> {
    await this._entityRepository.update(id, entity);
  }

  async remove(id: number) {
    const Exists = await this._entityRepository.
        findOne(id );

        if(!Exists)
        {
            throw new BadRequestException('People nao existe!');  
        }
        await this._entityRepository.delete(id);
  }
  
  
}
